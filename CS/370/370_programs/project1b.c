//-----------------------------------------------------------
//	Robert F. Ludwick
//	CS 370 Section 1
//	Project 1a
//
//	Purpose: To provide a DOS shell overtop of Linux
//-----------------------------------------------------------

//-----------------------------------------------------------
//	Definitions
//-----------------------------------------------------------

#define timer 15

//-----------------------------------------------------------
//	Includes
//-----------------------------------------------------------

#include <ctype.h>
#include <errno.h>
#include <signal.h>
#include <stdlib.h>
#include <stdio.h>
#include <string.h>
#include <unistd.h>
#include <sys/wait.h>

//-----------------------------------------------------------
//	Constants
//-----------------------------------------------------------

const int MAX_CHAR = 1024;
const int MAX_ARGUMENTS = 32;
const int MAX_BACKGROUND = 3;

//-----------------------------------------------------------
//	Global Variables
//-----------------------------------------------------------

char* Arguments[32];
char Path[1024];
int Num_Arguments;
int Is_Background;
int Num_Background = 0;
int Background_Process_IDs[3];
int Sentinel = 0;
int Counter;

//-----------------------------------------------------------
//	External Variables
//-----------------------------------------------------------

extern int errno;

//-----------------------------------------------------------
//	Function Prototypes
//-----------------------------------------------------------

int parse_input(char[]);
int check_linux();
void execute_input();
void background_add(int);
void display_help();
void sigalrm_handler(int);
void sigchld_handler(int);
void sigint_handler(int);
void translate_command(int);
void display_shell_status();
void background_remove(int);
void kill_all_children();

char* strrev(char*);
char* itoa(int, char*, int);

//-----------------------------------------------------------
//	Function:	main
//
//	Output:		The usage of the shell will be output.
//
//	Purpose:		To provide the main shell loop
//-----------------------------------------------------------

int main()
{
	// Signal handling
	signal(SIGALRM, sigalrm_handler);
	signal(SIGCHLD, sigchld_handler);
	signal(SIGINT, sigint_handler);

	// Variables
	char Input[MAX_CHAR];

	// Get path to start
	getcwd(Path, MAX_CHAR);

	// Run shell loop
	while(Sentinel == 0)
	{
		// Begin alarm detection
		alarm(timer);

		// Display path prompt
		printf("%s/%% ", Path);

		// Retrieve input from user
		fgets(Input, MAX_CHAR, stdin);

		// Parse input
		Num_Arguments = parse_input(Input);

		// Check for empty input or a blocked Linux command
		if((Num_Arguments > 0) && (check_linux() != -1))
		{
			// Execute input
			execute_input();
		}
	}

	// Kill all children
	kill_all_children();

	// Exit shell
	exit(EXIT_SUCCESS);
}

//-----------------------------------------------------------
//	Function:	parse_input
//
//	Input:		Character array representing user input.
//	Output:		Arguments array updated with inputted
//					arguments. Integer returned representing
//					the number of arguments entered.
//
//	Purpose:		To take the string input from the user and
//					parse it into arguments. Makes a specific
//					exception for chdir.
//-----------------------------------------------------------

int parse_input(char Input[])
{
	// Variables
	int Argument_Counter = 0, Command_Length;
	char Separators[] = " \t\n";

	// Check for blank input
	if(strcmp(Input, "\n\0") != 0)
	{
		// Parse command
		Arguments[Argument_Counter] = strtok(Input, Separators);

		// Check for background process
		Command_Length = strlen(Arguments[0]);

		Is_Background = 0;
		if(Arguments[0][Command_Length - 1] == '&')
		{
			Arguments[0][Command_Length - 1] = '\0';

			Is_Background = 1;
		}

		// Check for chdir command
		if(strcmp(Arguments[0], "chdir\0") == 0)
		{
			Argument_Counter++;

			Arguments[Argument_Counter] = strtok(NULL, "\n");
		}
		else // Otherwise, make argument array
		{
			while((Arguments[Argument_Counter] != NULL) && (Argument_Counter < MAX_ARGUMENTS))
			{
				Argument_Counter++;

				Arguments[Argument_Counter] = strtok(NULL, Separators);
			}
		}

		// Make command lowercase
		for(Counter = 0; Counter < strlen(Arguments[0]); Counter++)
		{
			Arguments[0][Counter] = tolower(Arguments[0][Counter]);
		}
	}

	// Return
	return(Argument_Counter);
}

//-----------------------------------------------------------
//	Function:	check_linux
//
//	Output:		Integer returned representing an error or
//					success - Success: 0; Error: -1.
//
//	Purpose:		Checks the command entered by the user against
//					the list of Linux commands we're translating
//					for.
//-----------------------------------------------------------

int check_linux()
{
	// Check for blocked Linux commands
	if(strcmp(Arguments[0], "ls\0") == 0)
	{
		printf("ERROR: Invalid command\n");

		return(-1);
	}
	else if(strcmp(Arguments[0], "date\0") == 0)
	{
		printf("ERROR: Invalid command\n");

		return(-1);
	}
	else if(strcmp(Arguments[0], "cd\0") == 0)
	{
		printf("ERROR: Invalid command\n");

		return(-1);
	}
	else if(strcmp(Arguments[0], "man\0") == 0)
	{
		printf("ERROR: Invalid command\n");

		return(-1);
	}
	else if(strcmp(Arguments[0], "cat\0") == 0)
	{
		printf("ERROR: Invalid command\n");

		return(-1);
	}

	// Return
	return(0);
}


//-----------------------------------------------------------
//	Function:	translate_command
//
//	Input:		Integer representing index in arguments
//					array.
//	Output:		Arguments array of index specified updated
//					to Linux command.
//
//	Purpose:		To translate the given argument from DOS to
//					Linux.
//-----------------------------------------------------------

void translate_command(int Argument_Index)
{
	// Replace command if need be
	if(strcmp(Arguments[Argument_Index], "dir\0") == 0)
	{
		Arguments[Argument_Index] = "ls\0";
	}
	else if(strcmp(Arguments[Argument_Index], "time\0") == 0)
	{
		Arguments[Argument_Index] = "date\0";
	}
	else if(strcmp(Arguments[Argument_Index], "chdir\0") == 0)
	{
		Arguments[Argument_Index] = "cd\0";
	}
	else if(strcmp(Arguments[Argument_Index], "help\0") == 0)
	{
		Arguments[Argument_Index] = "man\0";
	}
	else if(strcmp(Arguments[Argument_Index], "type\0") == 0)
	{
		Arguments[Argument_Index] = "cat\0";
	}

	// Return
	return;
}

//-----------------------------------------------------------
//	Function:	execute_input
//
//	Output:		Any error messages and called programs will
//					be output to the screen. Background process
//					ID array will be updated as neccessary.
//
//	Purpose:		To execute the input given by the user. Will
//					allow for background execution using &. Forks
//					the child process out and handles errors.
//					Accounts for shellstatus, ?, chdir and exit
//					separately.
//-----------------------------------------------------------

void execute_input()
{
	// Variables
	int Error, Process_ID, Status;

	// Check for background process maximum
	if((Num_Background == MAX_BACKGROUND) && (Is_Background == 1))
	{
		printf("ERROR: Maximum background processes exceeded\n");
	}
	else
	{
		if(strcmp(Arguments[0], "shellstatus\0") == 0) // Display shell status
		{
			display_shell_status();
		}
		else if(strcmp(Arguments[0], "?\0") == 0) // Display help
		{
			display_help();
		}
		else if(strcmp(Arguments[0], "chdir\0") == 0) // Run chdir directly
		{
			Error = chdir(Arguments[1]);

			// Display error if need be, or get path again
			if(Error == -1)
			{
				perror("ERROR");
			}
			else
			{
				getcwd(Path, MAX_CHAR);
			}
		}
		else if(strcmp(Arguments[0], "exit\0") == 0) // Allow for quitting of shell
		{
			Sentinel = 1;
		}
		else // Execute command
		{
			 // Check for replacement of help argument
			if((strcmp(Arguments[0], "help\0") == 0) && (Num_Arguments > 1))
			{
				translate_command(1);
			}

			// Fork the processes
			Process_ID = fork();

			// Check for error
			if(Process_ID == -1)
			{
				perror("ERROR");

				// Kill all children
				kill_all_children();

				// Force exit of shell
				exit(EXIT_FAILURE);
			}
			else if(Process_ID == 0) // Execute child forking
			{
				translate_command(0);

				Error = execvp(*Arguments, Arguments);

				// Check for error
				if(Error == -1)
				{
					perror("ERROR");

					// Exit
					exit(EXIT_FAILURE);
				}

				exit(EXIT_SUCCESS);
			}
			else // Perform parent actions
			{
				// Reset status
				Status = 0;

				// Perform wait for child if not background
				if(Is_Background == 0)
				{
					// Reset alarm to allow child unrestricted time
					alarm(0);

					// Execute child
					waitpid(Process_ID, &Status, WUNTRACED);
				}
				else // Allow child to execute in background
				{
					Num_Background++;

					// Display background child status
					printf("[%d] %d\n", Num_Background, Process_ID);

					// Add to background processes
					background_add(Process_ID);
				}
			}
		}
	}

	// Return
	return;
}

//-----------------------------------------------------------
//	Function:	background_add
//
//	Input:		Integer representing process ID.
//	Output:		Background process ID array will be updated.
//
//	Purpose:		Adds a process ID to the list of backgrounds.
//-----------------------------------------------------------

void background_add(int Process_ID)
{
	// Move previous children back
	for(Counter = (MAX_BACKGROUND - 1); Counter > 0; Counter--)
	{
		Background_Process_IDs[Counter] = Background_Process_IDs[Counter - 1];
	}

	// Add new child in
	Background_Process_IDs[0] = Process_ID;

	// Return
	return;
}

//-----------------------------------------------------------
//	Function:	background_remove
//
//	Input:		Integer index of process.
//	Output:		Background process ID array will be updated.
//
//	Purpose:		Removes an index from the background
//					processes.
//-----------------------------------------------------------

void background_remove(int Starting_Index)
{
	// Loop children forward
	for(Counter = Starting_Index; Counter < (MAX_BACKGROUND - 1); Counter++)
	{
		Background_Process_IDs[Counter] = Background_Process_IDs[Counter + 1];
	}

	// Reset last position to 0
	Background_Process_IDs[MAX_BACKGROUND - 1] = 0;

	// Return
	return;
}

//-----------------------------------------------------------
//	Function:	display_help
//
//	Output:		A listing of DOS commands that will be
//					translated to Linux.
//
//	Purpose:		Display the DOS to linux translations allowed.
//-----------------------------------------------------------

void display_help()
{
	// Display help list
	printf("Type 'exit' to quit the shell\n");
	printf("CUSTOM  ->  LINUX\n");
	printf("dir     ->     ls\n");
	printf("time    ->   date\n");
	printf("chdir   ->     cd\n");
	printf("help    ->    man\n");
	printf("type    ->    cat\n");

	// Return
	return;
}

//-----------------------------------------------------------
//	Function:	display_shell_status
//
//	Output:		The number of background processes currently
//					running and a list of the process IDs.
//
//	Purpose:		To display the status of the background
//					processes of the shell. For debugging.
//-----------------------------------------------------------

void display_shell_status()
{
	// Display number of background processes
	printf("Number of Background Processes: %d\n", Num_Background);

	// Display background process ids
	for(Counter = 0; Counter < MAX_BACKGROUND; Counter++)
	{
		printf("Background Process #%d: %d\n", (Counter + 1), Background_Process_IDs[Counter]);
	}

	// Return
	return;
}

//-----------------------------------------------------------
//	Function:	kill_all_children
//
//	Output:		The background processes will all be killed.
//
//	Purpose:		To kill all children background processes.
//					Used in exiting.
//-----------------------------------------------------------

void kill_all_children()
{
	// Loop to kill them all
	for(Counter = 0; Counter < Num_Background; Counter++)
	{
		kill(Background_Process_IDs[Counter], SIGINT);
	}

	// Return
	return;
}

//-----------------------------------------------------------
//	Function:	sigalrm_handler
//
//	Input:		Integer representing signal.
//	Output:		Error of timeout.
//
//	Purpose:		To handle the SIGALRM, which means the user
//					waited too long to enter a command. Exits.
//-----------------------------------------------------------

void sigalrm_handler(int Signal)
{
	// Display error
	write(0, "\nERROR: Maximum inactive time suceeded\n", 39);

	// Kill all children
	kill_all_children();

	// Exit
	exit(EXIT_FAILURE);
}

//-----------------------------------------------------------
//	Function:	sigchld_handler
//
//	Input:		Integer representing signal.
//	Output:		Will update background process ID array as
//					neccessary.
//
//	Purpose:		To handle SIGCHLD, which means a background
//					process exited. Will account only for those
//					that exited normally, as another signal
//					handler deals with those which are force-
//					quit.
//-----------------------------------------------------------

void sigchld_handler(int Signal)
{
	// Variables
	int Status, Process_Index = -1, Continue_Loop = 1;

	// Check to see if there was a real child
	if(Num_Background > 0)
	{
		// Loop to find the one that's stopped
		for(Counter = 0; (Counter < Num_Background) && (Continue_Loop == 1); Counter++)
		{
			// Get status without halting parent or child
			waitpid(Background_Process_IDs[Counter], &Status, WNOHANG);

			// Check to see if its the background process that stopped
			if(WIFEXITED(Status))
			{
				// It stopped, so record the index and break the loop
				Num_Background--;

				Process_Index = Counter;

				Continue_Loop = 0;
			}
		}

		// Check if a child was actually killed
		if(Process_Index > -1)
		{
			// Remove from background process list
			background_remove(Process_Index);
		}
	}

	// Return
	return;
}

//-----------------------------------------------------------
//	Function:	sigint_handler
//
//	Input:		Integer representing signal.
//	Output:		All errors and cancelled processes will be
//					displayed. Background process ID array will
//					be updated as neccessary.
//
//	Purpose:		To handle SIGINT, which means the user pressed
//					CTRL-C to cancel the oldest backrgound
//					process still running.
//-----------------------------------------------------------

void sigint_handler(int Signal)
{
	//Variables
	int Process_ID;
	char Process_ID_String[MAX_CHAR];
	char* Process_ID_String_Ptr;

	// Check if there is indeed a background process
	if(Num_Background == 0)
	{
		// Display error
		write(0, "\nERROR: No background processes\n", 32);
	}
	else
	{
		// Record process id for output
		Process_ID = Background_Process_IDs[Num_Background - 1];

		// Remove from backgrounds
		background_remove(Num_Background - 1);

		// Kill oldest child
		kill(Process_ID, SIGINT);

		// Convert Process ID to string
		Process_ID_String_Ptr = itoa(Process_ID, Process_ID_String, 10);

		// Display kill
		write(0, "\nprocess ", 9);
		write(0, Process_ID_String, (strlen(Process_ID_String) + 1));
		write(0, " was terminated\n", 16);

		Num_Background--;
	}

	// Display path prompt
	write(0, Path, (strlen(Path) + 1));
	write(0, "/% ", 3);

	// Return
	return;
}

//-----------------------------------------------------------
//	Functions:	strrev and itoa
//
//	From:			http://www.daniweb.com/techtalkforums/thread11049.html
//
//	Purpose:		For converting process ID integers into char
//					arrays for printing in signal handlers.
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

