//-----------------------------------------------------------
//	Robert F. Ludwick
//	CS 370 Section 1
//	Project 2a
//
//	Purpose: To provide a DOS shell overtop of Linux, allow
//				file redirection and encryption.
//-----------------------------------------------------------

//-----------------------------------------------------------
//	Definitions
//-----------------------------------------------------------

#define timer 15
#define MAX_CHAR 1024
#define MAX_ARGUMENTS 32
#define MAX_BACKGROUND 3

//-----------------------------------------------------------
//	Includes
//-----------------------------------------------------------

#include <errno.h>
#include <fcntl.h>
#include <signal.h>
#include <stdlib.h>
#include <stdio.h>
#include <string.h>
#include <unistd.h>
#include <sys/wait.h>

//-----------------------------------------------------------
//	Global Variables
//-----------------------------------------------------------

char* Arguments[MAX_ARGUMENTS];
char Path[MAX_CHAR];
int Num_Arguments;
int Is_Background;
int Num_Background = 0;
int Background_Process_IDs[MAX_BACKGROUND];
int Sentinel = 0;
int Counter;
int Redirect_Output_Index, Redirect_Append_Index, Redirect_Input_Index;

//-----------------------------------------------------------
//	External Variables
//-----------------------------------------------------------

extern int errno;

//-----------------------------------------------------------
//	Function Prototypes
//-----------------------------------------------------------

int parse_input(char[]);
int check_redirection();
int check_enc();
int check_rep();
void execute_input();
void background_add(int);
void display_help();
void display_shell_status();
void background_remove(int);
void kill_all_children();
void rep();
void enc_child(int[]);
void enc_parent(int[]);
void sigalrm_handler(int);
void sigchld_handler(int);
void sigint_handler(int);

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
		//alarm(timer);

		// Display path prompt
		printf("%s/%% ", Path);

		// Retrieve input from user
		fgets(Input, MAX_CHAR, stdin);

		// Parse input
		Num_Arguments = parse_input(Input);

		// Check for empty input
		if(Num_Arguments > 0)
		{
			// Perform redirection and enc checks
			if(check_redirection() != -1)
			{
				if((check_enc() != -1) && (check_rep() != -1))
				{
					// Execute input
					execute_input();
				}
			}
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

		// Otherwise, make argument array
		while((Arguments[Argument_Counter] != NULL) && (Argument_Counter < MAX_ARGUMENTS))
		{
			Argument_Counter++;

			Arguments[Argument_Counter] = strtok(NULL, Separators);
		}
	}

	// Return
	return(Argument_Counter);
}

//-----------------------------------------------------------
//	Function:	check_redirection
//
//	Output:		Integer returned representing an error or
//					success - Success: 0; Error: -1.
//
//	Purpose:		Checks the command entered by the user for
//					redirection and validates correct usage.
//-----------------------------------------------------------

int check_redirection()
{
	// Variables
	int Num_Output = 0, Num_Append = 0, Num_Input = 0, Num_Redirect_Arguments, In_Redirection = 0;

	// Reset indices
	Redirect_Output_Index = -1;
	Redirect_Append_Index = -1;
	Redirect_Input_Index = -1;

	// Loop to find and record instances; Verify arguments
	for(Counter = 0; Counter < Num_Arguments; Counter++)
	{
		// Check for any of the redirections
		if((strcmp(Arguments[Counter], ">\0") == 0) || (strcmp(Arguments[Counter], ">>\0") == 0) || (strcmp(Arguments[Counter], "<\0") == 0))
		{
			 // Check for no argument on prior redirection
			if((In_Redirection == 1) && (Num_Redirect_Arguments == 0))
			{
				printf("ERROR: Invalid use of redirection (Missing argument)\n");

				return(-1);
			}
			else
			{
				// Set trackers for next loop
				In_Redirection = 1;
				Num_Redirect_Arguments = 0;

				if(strcmp(Arguments[Counter], ">\0") == 0) // Output redirection
				{
					// Check for multiple output definitions
					if(Num_Output == 1)
					{
						printf("ERROR: Invalid use of redirection (Multiple output definitions)\n");

						return(-1);
					}
					else // Record the redirection
					{
						Num_Output++;

						Redirect_Output_Index = (Counter + 1);
					}
				}
				else if(strcmp(Arguments[Counter], ">>\0") == 0) // Output append redirection
				{
					// Check for multiple output append definitions
					if(Num_Append == 1)
					{
						printf("ERROR: Invalid use of redirection (Multiple append definitions)\n");

						return(-1);
					}
					else // Record the redirection
					{
						Num_Append++;

						Redirect_Append_Index = (Counter + 1);
					}
				}
				else // Input redirection
				{
					// Check for multiple input definitions
					if(Num_Input == 1)
					{
						printf("ERROR: Invalid use of redirection (Multiple input definitions)\n");

						return(-1);
					}
					else // Record the redirection
					{
						Num_Input++;

						Redirect_Input_Index = (Counter + 1);
					}
				}
			}
		}
		else
		{
			Num_Redirect_Arguments++;
		}

		// Check for too many arguments
		if(Num_Redirect_Arguments == 2)
		{
			printf("ERROR: Invalid use of redirection (Multiple arguments)\n");

			return(-1);
		}
	}

	// Verify that a command was given before redirection
	if((Redirect_Output_Index == 1) || (Redirect_Append_Index == 1) || (Redirect_Input_Index == 1))
	{
		printf("ERROR: Invalid use of redirection (No command given)\n");

		return(-1);
	}

	// Return
	return(0);
}

//-----------------------------------------------------------
//	Function:	check_enc
//
//	Output:		Integer returned representing an error or
//					success - Success: 0; Error: -1.
//
//	Purpose:		Checks the command entered by the user for
//					encryption and validates correct usage.
//-----------------------------------------------------------

int check_enc()
{
	// Check if we need to perform checks
	if(strcmp(Arguments[0], "enc\0") == 0)
	{
		// Check for number of arguments
		if(Num_Arguments == 1)
		{
			printf("ERROR: enc expects a filename given as argument\n");

			return(-1);
		}
		else
		{
			// Check if no input defined
			if(((strcmp(Arguments[1], ">\0") == 0) || (strcmp(Arguments[1], ">>\0") == 0) || (strcmp(Arguments[1], "<\0") == 0)) && (Redirect_Input_Index == -1))
			{
				printf("ERROR: enc expects a filename given as argument\n");

				return(-1);
			}
		}
	}

	// Return
	return(0);
}

//-----------------------------------------------------------
//	Function:	check_rep
//
//	Output:		Integer returned representing an error or
//					success - Success: 0; Error: -1.
//
//	Purpose:		Checks the command entered by the user for
//					replacement and validates correct usage.
//-----------------------------------------------------------

int check_rep()
{
	// Check if we need to perform checks
	if(strcmp(Arguments[0], "rep\0") == 0)
	{
		// Check for number of arguments
		if(Num_Arguments < 4)
		{
			printf("ERROR: rep expects a filename given as argument\n");

			return(-1);
		}
		else
		{
			// Check if no input defined
			if(((strcmp(Arguments[3], ">\0") == 0) || (strcmp(Arguments[3], ">>\0") == 0) || (strcmp(Arguments[3], "<\0") == 0)) && (Redirect_Input_Index == -1))
			{
				printf("ERROR: rep expects a filename given as argument\n");

				return(-1);
			}
		}
	}

	// Return
	return(0);
}

//-----------------------------------------------------------
//	Function:	execute_input
//
//	Output:		Any error messages and called programs will
//					be output to the screen if there is no
//					redirection. Background process ID array will
//					be updated as neccessary.
//
//	Purpose:		To execute the input given by the user. Will
//					allow for background execution using &. Forks
//					the child process out and handles errors.
//					Accounts for shellstatus, ?, cd and exit
//					separately. Handles I/O redirection.
//-----------------------------------------------------------

void execute_input()
{
	// Variables
	int Error, Process_ID, Status, Output_FD, Input_FD, FD_Close_Result, FD_Dup_Result, Pipe[2];

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
		else if(strcmp(Arguments[0], "cd\0") == 0) // Run chdir directly
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
			// Create pipe if enc
			if(strcmp(Arguments[0], "enc\0") == 0)
			{
				Error = pipe(Pipe);
			}

			if(Error == -1)
			{
				perror("ERROR");
			}
			else
			{
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
					// Check for output redirection
					if(Redirect_Output_Index != -1)
					{
						Output_FD = open(Arguments[Redirect_Output_Index], O_WRONLY | O_CREAT | O_TRUNC);

						// Check for error
						if(Output_FD == -1)
						{
							perror("ERROR");

							// Exit
							exit(EXIT_FAILURE);
						}
						else
						{
							// Copy file descriptor
							FD_Dup_Result = dup2(Output_FD, 1);

							// Check for duplication error
							if(FD_Dup_Result == -1)
							{
								perror("ERROR");

								// Exit
								exit(EXIT_FAILURE);
							}
						}
					}
					else if(Redirect_Append_Index != -1)
					{
						Output_FD = open(Arguments[Redirect_Append_Index], O_WRONLY | O_CREAT | O_APPEND);

						// Check for error
						if(Output_FD == -1)
						{
							perror("ERROR");

							// Exit
							exit(EXIT_FAILURE);
						}
						else
						{
							// Copy file descriptor
							FD_Dup_Result = dup2(Output_FD, 1);

							// Check for duplication error
							if(FD_Dup_Result == -1)
							{
								perror("ERROR");

								// Exit
								exit(EXIT_FAILURE);
							}
						}
					}

					// Check for input redirection
					if(Redirect_Input_Index != -1)
					{
						Input_FD = open(Arguments[Redirect_Input_Index], O_RDONLY);

						// Check for error
						if(Input_FD == -1)
						{
							perror("ERROR");

							// Exit
							exit(EXIT_FAILURE);
						}
						else
						{
							// Copy file descriptor
							FD_Dup_Result = dup2(Input_FD, 0);

							// Check for duplication error
							if(FD_Dup_Result == -1)
							{
								perror("ERROR");

								// Exit
								exit(EXIT_FAILURE);
							}
						}
					}

					// Remove redirection from arguments array for correct system execution
					if(Redirect_Output_Index != -1)
					{
						Arguments[Redirect_Output_Index - 1] = NULL;
						Arguments[Redirect_Output_Index] = NULL;
					}
					if(Redirect_Append_Index != -1)
					{
						Arguments[Redirect_Append_Index - 1] = NULL;
						Arguments[Redirect_Append_Index] = NULL;
					}
					if(Redirect_Input_Index != -1)
					{
						Arguments[Redirect_Input_Index - 1] = NULL;
						Arguments[Redirect_Input_Index] = NULL;
					}

					// Execute appropriate input
					if(strcmp(Arguments[0], "enc\0") == 0)
					{
						// Execute child enc
						enc_child(Pipe);
					}
					else if(strcmp(Arguments[0], "rep\0") == 0)
					{
						// Execute rep
						rep();
					}
					else
					{
						// Execute other command
						Error = execvp(*Arguments, Arguments);
					}

					// Check for error
					if(Error == -1)
					{
						perror("ERROR");

						// Exit
						exit(EXIT_FAILURE);
					}
					else
					{
						// Close open file descriptors
						if((Redirect_Output_Index != -1) || (Redirect_Append_Index != -1))
						{
							FD_Close_Result = close(Output_FD);

							// Check for closing error
							if(FD_Close_Result == -1)
							{
								perror("ERROR");
							}
						}
						if(Redirect_Input_Index != -1)
						{
							FD_Close_Result = close(Input_FD);

							// Check for closing error
							if(FD_Close_Result == -1)
							{
								perror("ERROR");
							}
						}
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

						// Check for enc_parent usage
						if(strcmp(Arguments[0], "enc\0") == 0)
						{
							enc_parent(Pipe);
						}
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
	printf("To exit, type 'exit'\n");
	printf("enc <filename> --> to encrypt <filename>\n");
   printf("rep arg1 arg2 <filename> --> to replace every instance of arg1 with arg2 in <filename>\n");

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
//	Function:	rep
//
//	Input:		Will open a file for input replacement.
//	Output:		The inputted file with arg1 replaced wit
//					arg2.
//
//	Purpose:		To replace all instances of arg1 with arg2 in
//					a file.
//-----------------------------------------------------------

void rep()
{
	// Variables
	int Input_FD, Needle_Length = strlen(Arguments[1]), Needle_Counter = 0, Storage_Counter, FD_Close_Result, FD_Dup_Result;
	char Input, Storage[MAX_CHAR] = "\0";

	// Check for input as argument
	if(Redirect_Input_Index == -1)
	{
		Input_FD = open(Arguments[3], O_RDONLY);

		FD_Dup_Result = dup2(Input_FD, 0);

		// Check for duplication error
		if(FD_Dup_Result == -1)
		{
			perror("ERROR");
			return;
		}
	}

	// Perform reading loop
	while(Input = getchar())
	{
		// Check loop break
		if(Input == -1)
		{
			break;
		}

		// Check character against needle
		if(Input == Arguments[1][Needle_Counter])
		{
			Needle_Counter++;

			// Check if entire needle found
			if(Needle_Counter == Needle_Length)
			{
				printf("%s", Arguments[2]);

				Needle_Counter = 0;
				Storage_Counter = 0;
			}
			else // Just part of the needle so far
			{
				Storage[Storage_Counter] = Input;
				Storage[Storage_Counter + 1] = '\0';

				Storage_Counter++;
			}
		}
		else
		{
			// Need to output storage if part, but not all, of the needle was previously found
			if(Storage_Counter > 0)
			{
				printf("%s", Storage);

				Storage_Counter = 0;
			}

			// Reset needle and output character from input
			Needle_Counter = 0;

			printf("%c", Input);
		}
	}

	// Close input file if neccessary
	if(Redirect_Input_Index == -1)
	{
		// Close file
		FD_Close_Result = close(Input_FD);

		// Check for closing error
		if(FD_Close_Result == -1)
		{
			perror("ERROR");
		}
	}

	// Return
	return;
}

//-----------------------------------------------------------
//	Function:	enc_child
//
//	Input:		Integer array representing a pipe. Will open
//					a file for input for encryption.
//	Output:		Outputs to the pipe or specified output
//					redirection the results of encrypting the
//					input specified.
//
//	Purpose:		To encrypt a file specified.
//-----------------------------------------------------------

void enc_child(int Pipe[])
{
	// Variables
	int Input_FD, FD_Close_Result, FD_Dup_Result;
	char Input;

	// Close pipe's output
	FD_Close_Result = close(Pipe[0]);

	// Check for closing error
	if(FD_Close_Result == -1)
	{
		perror("ERROR");
		return;
	}

	// Check for input as argument
	if(Redirect_Input_Index == -1)
	{
		Input_FD = open(Arguments[1], O_RDONLY);

		FD_Dup_Result = dup2(Input_FD, 0);

		// Check for duplication error
		if(FD_Dup_Result == -1)
		{
			perror("ERROR");
			return;
		}
	}

	// Perform encryption loop
	while(Input = getchar())
	{
		// Check loop break
		if(Input == -1)
		{
			break;
		}

		if((Input >= 33) && (Input <= 126))
		{
			Input = (((Input * 2) % 94) + 33);
		}

		printf("%c", Input);
	}

	// Close pipe
	FD_Close_Result = close(Pipe[1]);

	// Check for closing error
	if(FD_Close_Result == -1)
	{
		perror("ERROR");
	}

	// Close input file if neccessary
	if(Redirect_Input_Index == -1)
	{
		FD_Close_Result = close(Input_FD);

		// Check for closing error
		if(FD_Close_Result == -1)
		{
			perror("ERROR");
		}
	}

	// Return
	return;
}

//-----------------------------------------------------------
//	Function:	enc_parent
//
//	Input:		Integer array representing a pipe.
//	Output:		Outputs the results of encrypting the input
//					to its child process.
//
//	Purpose:		To present encryption for a file specified.	
//-----------------------------------------------------------

void enc_parent(int Pipe[])
{
	// Variables
	int Input_FD, FD_Close_Result, FD_Dup_Result;
	char Input;

	// Close pipe's input
	FD_Close_Result = close(Pipe[1]);

	// Check for closing error
	if(FD_Close_Result == -1)
	{
		perror("ERROR");
		return;
	}

	// Copy stdin to temporary file descriptor
	Input_FD = dup(0);

	// Check for duplication error
	if(Input_FD == -1)
	{
		perror("ERROR");
		return;
	}

	// Replace stdin with the pipe
	FD_Dup_Result = dup2(Pipe[0], 0);

	// Check for duplication error
	if(FD_Dup_Result == -1)
	{
		perror("ERROR");
		return;
	}

	// Perform encryption loop
	while(Input = getchar())
	{
		// Check loop break
		if(Input == -1)
		{
			break;
		}

		printf("%c", Input);
	}

	// Make input stdin again
	FD_Dup_Result = dup2(Input_FD, 0);
	
	// Check for duplication error
	if(FD_Dup_Result == -1)
	{
		perror("ERROR");
		return;
	}

	// Close pipe
	FD_Close_Result = close(Pipe[0]);

	// Check for closing error
	if(FD_Close_Result == -1)
	{
		perror("ERROR");
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
//	Output:		A message stating CTRL-C will not exit and to
//					use the exit command.
//
//	Purpose:		To inform the user the proper method of
//					exiting.
//-----------------------------------------------------------

void sigint_handler(int Signal)
{
	// Display Message
	write(0, "\nTo exit, type 'exit'\n", 22);

	// Display path prompt
	write(0, Path, (strlen(Path) + 1));
	write(0, "/% ", 3);

	// Return
	return;
}

