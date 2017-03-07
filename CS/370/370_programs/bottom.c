//-----------------------------------------------------------
//	Robert F. Ludwick
//	CS 370 Section 1
//	Project 6a
// "Bottom" program
//
//	Purpose: To implement sockets and self-stabilizing mutual
//				exclusion.
//-----------------------------------------------------------

//-----------------------------------------------------------
//	Definitions
//-----------------------------------------------------------

//-----------------------------------------------------------
//	Struct:	
//
//	Purpose:	
//-----------------------------------------------------------

//-----------------------------------------------------------
//	Includes
//-----------------------------------------------------------

#include <errno.h>
#include <signal.h>
#include <stdlib.h>
#include <stdio.h>
#include <time.h>
#include <unistd.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <sys/un.h>

//-----------------------------------------------------------
//	Global Variables
//-----------------------------------------------------------

int Top_Socket_FD_Connection,
	Other_Socket_FD_Connection,
	Top_Socket_FD,
	Other_Socket_FD,
	Error,
	Sentinel = 0,
	Self_State,
	Other_State;
struct sockaddr_un Top_Socket_Address,
	Other_Socket_Address;
size_t Top_Socket_Address_Length,
	Other_Socket_Address_Length;
char State_Buffer;

//-----------------------------------------------------------
//	External Variables
//-----------------------------------------------------------

extern int errno;

//-----------------------------------------------------------
//	Function Prototypes
//-----------------------------------------------------------

void create_sockets();
void accept_socket_connections();
void startup_data();
void send_data(char);
void receive_data();
void close_sockets();
void sig_ctlc_handler(int);
void sig_ctlz_handler(int);

char* strrev(char*);
char* itoa(int, char*, int);

//-----------------------------------------------------------
//	Function:	main
//-----------------------------------------------------------

int main()
{
	// Signal handling
	signal(SIGINT, sig_ctlc_handler);
	signal(SIGTSTP, sig_ctlz_handler);

	// Seed random numbers
	srand((unsigned)time(NULL));

	// Create sockets
	create_sockets();

	// Accept socket connections
	accept_socket_connections();

	// Startup data
	startup_data();

	// Empty loop
	while(Sentinel == 0)
	{
		// Check for critical section usage
		if(((Self_State + 1) % 3) == Other_State)
		{
			// Recalculate state
			Self_State = ((Self_State + 2) % 3);

			// Output privelege
			printf("I have privilege, S = [%d]\n", Self_State);

			// Sleep
			sleep(2);
		}

		// Send data
		send_data('o');
		send_data('t');

		// Receive data
		receive_data('o');
	}

	// Close sockets
	close_sockets();

	// Exit
	exit(EXIT_SUCCESS);
}

//-----------------------------------------------------------
//	Function:	create_sockets
//-----------------------------------------------------------

void create_sockets()
{
	// Set top socket information
	Top_Socket_Address.sun_family = AF_UNIX;
	strcpy(Top_Socket_Address.sun_path, "0_t.sock");

	// Set other socket information
	Other_Socket_Address.sun_family = AF_UNIX;
	strcpy(Other_Socket_Address.sun_path, "0_1.sock");

	// Unlink the names
	unlink(Top_Socket_Address.sun_path);
	unlink(Other_Socket_Address.sun_path);

	// Create top socket
	Top_Socket_FD_Connection = socket(AF_UNIX, SOCK_STREAM, 0);

	// Check for creation error
	if(Top_Socket_FD_Connection < 0)
	{
		// Display error message
		perror("ERROR");

		// Exit
		exit(EXIT_FAILURE);
	}

	// Bind socket
	Error = bind(Top_Socket_FD_Connection, (struct sockaddr *)&Top_Socket_Address, sizeof(Top_Socket_Address));

	// Check for bind error
	if(Error < 0)
	{
		// Display error message
		perror("ERROR");

		// Exit
		exit(EXIT_FAILURE);
	}

	// Create other socket
	Other_Socket_FD_Connection = socket(AF_UNIX, SOCK_STREAM, 0);

	// Check for creation error
	if(Other_Socket_FD_Connection < 0)
	{
		// Display error message
		perror("ERROR");

		// Exit
		exit(EXIT_FAILURE);
	}

	// Bind socket
	Error = bind(Other_Socket_FD_Connection, (struct sockaddr *)&Other_Socket_Address, sizeof(Other_Socket_Address));

	// Check for bind error
	if(Error < 0)
	{
		// Display error message
		perror("ERROR");

		// Exit
		exit(EXIT_FAILURE);
	}

	// Return
	return;
}

//-----------------------------------------------------------
//	Function:	accept_socket_connections
//-----------------------------------------------------------

void accept_socket_connections()
{
	// Listen for connections on other socket
	listen(Other_Socket_FD_Connection, 1);

	// Accept connection on other socket
	Other_Socket_FD = accept(Other_Socket_FD_Connection, (struct sockaddr *)&Other_Socket_Address, &Other_Socket_Address_Length);

	// Check for accept error
	if(Other_Socket_FD < 0)
	{
		// Display error message
		perror("ERROR");

		// Exit
		exit(EXIT_FAILURE);
	}

	// Output connection
	printf("Connected with right neighbor\n");

	// Listen for connections on top socket
	listen(Top_Socket_FD_Connection, 1);

	// Accept connection on top socket
	Top_Socket_FD = accept(Top_Socket_FD_Connection, (struct sockaddr *)&Top_Socket_Address, &Top_Socket_Address_Length);

	// Check for accept error
	if(Top_Socket_FD < 0)
	{
		// Display error message
		perror("ERROR");

		// Exit
		exit(EXIT_FAILURE);
	}

	// Output connection
	printf("Connected with left neighbor\n");

	// Return
	return;
}

//-----------------------------------------------------------
//	Function:	startup_data
//-----------------------------------------------------------

void startup_data()
{
	// Generate random numbers
	Self_State = (rand() % 3);
	Other_State = (rand() % 3);

	// Send data
	send_data('t');
	send_data('o');

	// Receive data
	receive_data();

	// Returns
	return;
}

//-----------------------------------------------------------
//	Function:	receive_data
//-----------------------------------------------------------

void receive_data()
{
	// Receive the data from bottom
	recv(Other_Socket_FD, &State_Buffer, 1, 0);

	// Convert the state into a char
	Other_State = atoi(&State_Buffer);

	// Return
	return;
}

//-----------------------------------------------------------
//	Function:	send_data
//-----------------------------------------------------------

void send_data(char Direction)
{
	// Convert the state into a char
	itoa(Self_State, &State_Buffer, 10);

	// Check for which direction
	if(Direction == 't')
	{
		// Send the data
		send(Top_Socket_FD, &State_Buffer, 1, 0);
	}
	else
	{
		// Send the data
		send(Other_Socket_FD, &State_Buffer, 1, 0);
	}

	// Return
	return;
}

//-----------------------------------------------------------
//	Function:	close_sockets
//-----------------------------------------------------------

void close_sockets()
{
	// Close the sockets
	close(Top_Socket_FD);
	close(Other_Socket_FD);

	// Return
	return;
}

//-----------------------------------------------------------
//	Function:	sig_ctlc_handler
//-----------------------------------------------------------

void sig_ctlc_handler(int Signal)
{
	// Set sentinel
	Sentinel = 1;

	// Return
	return;
}

//-----------------------------------------------------------
//	Function:	sig_ctlz_handler
//-----------------------------------------------------------

void sig_ctlz_handler(int Signal)
{
	// Generate random numbers
	Self_State = (rand() % 3);
	Other_State = (rand() % 3);

	// Output fault
	printf("Fault changed my values to S = [%d], R = [%d]\n", Self_State, Other_State);

	// Send numbers to top and other
	send_data('t');
	send_data('o');

	// Return
	return;
}

//-----------------------------------------------------------
//	Functions:	strrev and itoa
//
//	From:			http://www.daniweb.com/techtalkforums/thread11049.html
//-----------------------------------------------------------

char *strrev(char *str) {
	char *p1, *p2;

	if (!str || !*str)
		return str;

	for (p1 = str, p2 = str + strlen(str) - 1; p2 > p1; ++p1, --p2) {
		*p1 ^= *p2;
		*p2 ^= *p1;
		*p1 ^= *p2;
	}

	return str;
}

char *itoa(int n, char *s, int b) {
	static char digits[] = "0123456789abcdefghijklmnopqrstuvwxyz";
	int i=0, sign;
    
	if ((sign = n) < 0)
		n = -n;

	do {
		s[i++] = digits[n % b];
	} while ((n /= b) > 0);

	if (sign < 0)
		s[i++] = '-';
	s[i] = '\0';

	return strrev(s);
}

