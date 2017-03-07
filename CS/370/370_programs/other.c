//-----------------------------------------------------------
//	Robert F. Ludwick
//	CS 370 Section 1
//	Project 6a
// "Other" program
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

int Left_Socket_FD,
	Right_Socket_FD_Connection,
	Right_Socket_FD,
	Error,
	Sentinel = 0,
	Left_State,
	Self_State,
	Right_State,
	PID_Int;
struct sockaddr_un Left_Socket_Address,
	Right_Socket_Address;
size_t Right_Socket_Address_Length;
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
void connect_to_server();
void accept_socket_connection();
void startup_data();
void receive_data(char);
void send_data(char);
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
	connect_to_server();

	// Accept socket connection
	accept_socket_connection();

	// Startup data
	startup_data();

	// Empty loop
	while(Sentinel == 0)
	{
		// Check for critical section usage
		if((Left_State == ((Self_State + 1) % 3)) || (Right_State == ((Self_State + 1) % 3)))
		{
			// Recalculate state
			Self_State = ((Self_State + 1) % 3);

			// Output privelege
			printf("I have privilege, S = [%d]\n", Self_State);

			// Sleep
			sleep(2);
		}

		// Send data
		send_data('l');
		send_data('r');

		// Receive data
		receive_data('l');
		receive_data('r');
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
	char Socket_1[16],
		Socket_2[16],
		Temp[5];
	int Lower_PID = (PID_Int - 1),
		Upper_PID = (PID_Int + 1);

	// Setup left socket name
	itoa(Lower_PID, Socket_1, 10);
	strcat(Socket_1, "_");
	strcat(Socket_1, PID_Char);
	strcat(Socket_1, ".sock");

	// Setup right socket name
	strcpy(Socket_2, PID_Char);
	strcat(Socket_2, "_");
	itoa(Upper_PID, Temp, 10);
	strcat(Socket_2, Temp);
	strcat(Socket_2, ".sock");

	// Set left socket information
	Left_Socket_Address.sun_family = AF_UNIX;
	strcpy(Left_Socket_Address.sun_path, Socket_1);

	// Set other socket information
	Right_Socket_Address.sun_family = AF_UNIX;
	strcpy(Right_Socket_Address.sun_path, Socket_2);

	// Create left socket
	Left_Socket_FD = socket(AF_UNIX, SOCK_STREAM, 0);

	// Check for creation error
	if(Left_Socket_FD < 0)
	{
		// Display error message
		perror("ERROR");

		// Exit
		exit(EXIT_FAILURE);
	}

	// Create other socket
	Right_Socket_FD_Connection = socket(AF_UNIX, SOCK_STREAM, 0);

	// Check for creation error
	if(Right_Socket_FD_Connection < 0)
	{
		// Display error message
		perror("ERROR");

		// Exit
		exit(EXIT_FAILURE);
	}

	// Unlink socket name & bind
	unlink(Right_Socket_Address.sun_path);
	Error = bind(Right_Socket_FD_Connection, (struct sockaddr *)&Right_Socket_Address, sizeof(Right_Socket_Address));

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
//	Function:	connect_to_server
//-----------------------------------------------------------

void connect_to_server()
{
	// Connect to left socket
	Error = connect(Left_Socket_FD, (struct sockaddr *)&Left_Socket_Address, sizeof(Left_Socket_Address));

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

	// Return
	return;
}

//-----------------------------------------------------------
//	Function:	accept_socket_connection
//-----------------------------------------------------------

void accept_socket_connection()
{
	// Listen for connections on right socket
	listen(Right_Socket_FD_Connection, 1);

	// Accept connection on right socket
	Right_Socket_FD = accept(Right_Socket_FD_Connection, (struct sockaddr *)&Right_Socket_Address, &Right_Socket_Address_Length);

	// Check for accept error
	if(Right_Socket_FD < 0)
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
	Left_State = (rand() % 3);
	Self_State = (rand() % 3);
	Right_State = (rand() % 3);

	// Receive data from left
	receive_data('l');

	// Send data
	send_data('l');
	send_data('r');

	// Receive data from right
	receive_data('r');

	// Returns
	return;
}

//-----------------------------------------------------------
//	Function:	receive_data
//-----------------------------------------------------------

void receive_data(char Direction)
{
	// Check for which direction
	if(Direction == 'l')
	{
		// Receive the data from other
		recv(Left_Socket_FD, &State_Buffer, 1, 0);

		// Convert the state into a char
		Left_State = atoi(&State_Buffer);
	}
	else
	{
		// Receive the data from bottom
		recv(Right_Socket_FD, &State_Buffer, 1, 0);

		// Convert the state into a char
		Right_State = atoi(&State_Buffer);
	}

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
	if(Direction == 'l')
	{
		// Send the data
		send(Left_Socket_FD, &State_Buffer, 1, 0);
	}
	else
	{
		// Send the data
		send(Right_Socket_FD, &State_Buffer, 1, 0);
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
	close(Left_Socket_FD);
	close(Right_Socket_FD);

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
	Left_State = (rand() % 3);
	Self_State = (rand() % 3);
	Right_State = (rand() % 3);

	// Output fault
	printf("Fault changed my values to S = [%d], R = [%d], L = [%d]\n", Self_State, Right_State, Left_State);

	// Send numbers to left and right
	send_data('l');
	send_data('r');

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

