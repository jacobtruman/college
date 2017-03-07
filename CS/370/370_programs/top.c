//-----------------------------------------------------------
//	Robert F. Ludwick
//	CS 370 Section 1
//	Project 6a
// "Top" program
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
#include <sys/types.h>
#include <sys/socket.h>
#include <sys/un.h>

//-----------------------------------------------------------
//	Global Variables
//-----------------------------------------------------------

int Other_Socket_FD,
	Bottom_Socket_FD,
	Error,
	Sentinel = 0,
	Other_State,
	Self_State,
	Bottom_State,
	PID_Int;
struct sockaddr_un Other_Socket_Address,
	Bottom_Socket_Address;
char State_Buffer,
	PID_Char[5];

//-----------------------------------------------------------
//	External Variables
//-----------------------------------------------------------

extern int errno;

//-----------------------------------------------------------
//	Function Prototypes
//-----------------------------------------------------------

void get_pid();
void create_sockets();
void connect_to_servers();
void startup_data();
void receive_data(char);
void send_data();
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

	// Get PID
	get_pid();

	// Create sockets
	create_sockets();

	// Connect to servers
	connect_to_servers();

	// Startup initial data
	startup_data();

	// Empty loop
	while(Sentinel == 0)
	{
		// Check for critical section usage
		if((Other_State == Bottom_State) && (Self_State != ((Other_State + 1) % 3)))
		{
			// Recalculate state
			Self_State = ((Other_State + 1) % 3);

			// Output privelege
			printf("I have privilege, S = [%d]\n", Self_State);

			// Sleep
			sleep(2);
		}

		// Send data
		send_data();

		// Receive data
		receive_data('o');
		receive_data('b');
	}

	// Close sockets
	close_sockets();

	// Exit
	exit(EXIT_SUCCESS);
}

//-----------------------------------------------------------
//	Function:	get_pid
//-----------------------------------------------------------

void get_pid()
{
	// Variables
	int Length;

	// Retrieve input from user
	fgets(PID_Char, 5, stdin);

	// Remove trailing newline
	Length = strlen(PID_Char);
	PID_Char[Length - 1] = '\0';

	// Convert input
	PID_Int = atoi(PID_Char);

	// Return
	return;
}

//-----------------------------------------------------------
//	Function:	create_sockets
//-----------------------------------------------------------

void create_sockets()
{
	// Variables
	char Socket_1[16];
	int Lower_PID = (PID_Int - 1);

	// Setup other socket name
	itoa(Lower_PID, Socket_1, 10);
	strcat(Socket_1, "_");
	strcat(Socket_1, PID_Char);
	strcat(Socket_1, ".sock");

	// Set other socket information
	Other_Socket_Address.sun_family = AF_UNIX;
	strcpy(Other_Socket_Address.sun_path, Socket_1);

	// Set bottom socket information
	Bottom_Socket_Address.sun_family = AF_UNIX;
	strcpy(Bottom_Socket_Address.sun_path, "0_t.sock");

	// Create other socket
	Other_Socket_FD = socket(AF_UNIX, SOCK_STREAM, 0);

	// Check for creation error
	if(Other_Socket_FD < 0)
	{
		// Display error message
		perror("ERROR");

		// Exit
		exit(EXIT_FAILURE);
	}

	// Create bottom socket
	Bottom_Socket_FD = socket(AF_UNIX, SOCK_STREAM, 0);

	// Check for creation error
	if(Bottom_Socket_FD < 0)
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
//	Function:	connect_to_servers
//-----------------------------------------------------------

void connect_to_servers()
{
	// Connect to other socket
	Error = connect(Other_Socket_FD, (struct sockaddr *)&Other_Socket_Address, sizeof(Other_Socket_Address));

	// Check for connection error
	if(Error < 0)
	{
		// Display error message
		perror("ERROR");

		// Exit
		exit(EXIT_FAILURE);
	}

	// Output connection
	printf("Connected with left neighbor\n");

	// Connect to bottom socket
	Error = connect(Bottom_Socket_FD, (struct sockaddr *)&Bottom_Socket_Address, sizeof(Bottom_Socket_Address));

	// Check for connection error
	if(Error < 0)
	{
		// Display error message
		perror("ERROR");

		// Exit
		exit(EXIT_FAILURE);
	}

	// Output connection
	printf("Connected with right neighbor\n");

	// Return
	return;
}

//-----------------------------------------------------------
//	Function:	startup_data
//-----------------------------------------------------------

void startup_data()
{
	// Generate random number
	Other_State = (rand() % 3);
	Self_State = (rand() % 3);
	Bottom_State = (rand() % 3);

	// Receive data
	receive_data('o');
	receive_data('b');

	// Send data
	send_data();

	// Returns
	return;
}

//-----------------------------------------------------------
//	Function:	receive_data
//-----------------------------------------------------------

void receive_data(char Direction)
{
	// Check for which direction
	if(Direction == 'b')
	{
		// Receive the data from other
		recv(Bottom_Socket_FD, &State_Buffer, 1, 0);

		// Convert the state into a char
		Bottom_State = atoi(&State_Buffer);
	}
	else
	{
		// Receive the data from bottom
		recv(Other_Socket_FD, &State_Buffer, 1, 0);

		// Convert the state into a char
		Other_State = atoi(&State_Buffer);
	}

	// Return
	return;
}

//-----------------------------------------------------------
//	Function:	send_data
//-----------------------------------------------------------

void send_data()
{
	// Convert the state into a char
	itoa(Self_State, &State_Buffer, 10);

	// Send the data
	send(Other_Socket_FD, &State_Buffer, 1, 0);

	// Return
	return;
}

//-----------------------------------------------------------
//	Function:	close_sockets
//-----------------------------------------------------------

void close_sockets()
{
	// Close the sockets
	close(Other_Socket_FD);
	close(Bottom_Socket_FD);

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
	Other_State = (rand() % 3);
	Self_State = (rand() % 3);
	Bottom_State = (rand() % 3);

	// Output fault
	printf("Fault changed my values to S = [%d], R = [%d], L = [%d]\n", Self_State, Bottom_State, Other_State);

	// Send number
	send_data();

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

