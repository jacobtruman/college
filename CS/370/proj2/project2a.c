// Jacob W. Truman
// CS 370 Section 2
// Project 2 - "Arithmetic Shell and Additional Environment Commands"
//********************************************************************

// Includes
//*****************

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>
#include <sys/wait.h>
#include <unistd.h>
#include <signal.h>
#include <fcntl.h>

// Definitions
//**************

#define BUFFERMAX 1024

// Constants
//*****************

const int MAX_BG = 3;
const int MAX_ARGS = 32;
const int MAX_STR = 1024;

// Globals
//*****************

int numArgs;
char* uArgs[32];
char* inBuff;
char Prompt[1024];
int qflag = 0;
int argCnt;
int iCntr;
int pPid;

// Function Prototypes
//**********************

void startShell();
void showPrompt();
int parse_uInput(char[]);
void runCmd();

int readFile(char *fRp, char *oFile);
int readCarFile(char *iFile);
void writeCarFile(char *fWp, int fSize, int pSize);
void writeFile(char *fWp, int fSize);
void car();
void uncar();
int myAdder();
// *** signal functions ***
void sigint_handler(int sig);
void sigtstp_handler(int sig);

// main Function
//*****************

int main(){

// Welcome message
printf("********************************\n");
printf("**    Welcome to my Shell     **\n");
printf("** ? will display a help menu **\n");
printf("********************************\n");

startShell();

}

// startShell Function
//
// start/re-start shell
//**********************

void startShell(){

// Get path to start
getcwd(Prompt, MAX_STR);

	// capture ctrl+c for child process termination
	if (signal(SIGINT, sigint_handler) == SIG_ERR){
		perror("signal");
		exit(1);
	}

	// capture ctrl+z
	if (signal(SIGTSTP, sigtstp_handler) == SIG_ERR){
		perror("signal");
		exit(1);
	}

	char uInput[MAX_STR];

	while (qflag == 0){

		// display prompt
		showPrompt();
		
		fgets(uInput, MAX_STR, stdin);

		numArgs = parse_uInput(uInput);

		if (numArgs > 0){
			runCmd();
		}
	}

	// exit shell
	exit(EXIT_SUCCESS);
}

// showPrompt Function
//
// Display prompt with path of current directory
//***********************************************

void showPrompt(){

// user input var

write(0, Prompt, (strlen(Prompt) + 1));
write(0, "/% ", 3);

}

// parse_uInput Function
//
// Parses user input, separates arguements and commands
//******************************************************

int parse_uInput(char uInput[]){

	int uiLen;
	argCnt = 0;

	if(strcmp(uInput, "\n\0") != 0){

		// parse string
		uArgs[argCnt++] = strtok(uInput, " \t\n");

		// set command to lowercase
		for(iCntr = 0; iCntr < strlen(uArgs[0]); iCntr++){
			uArgs[0][iCntr] = tolower(uArgs[0][iCntr]);
		}

		// get args after cmd
		while((uArgs[argCnt++] = strtok(NULL, " \t\n")) && argCnt < MAX_ARGS);
	}
	return argCnt;
}

// runCmd Function
//
// Runs the command from user input
//**********************************

void runCmd(){
	int cPid, errCode, Status, rFile, oFile, rfDup, ofDup, rfClose, ofClose, runFlag = 1;
	if(strcmp(uArgs[0], "exit\0") == 0){
		qflag = 1;
	}else if(strcmp(uArgs[0], "?\0") == 0){
		// Display help menu
		printf("Type 'exit' to quit the shell\n");
		printf("COMMAND        ->  DESCRIPTION\n");
		printf("------------------------------\n");
		printf("ls             ->  Displays list of files in current directory\n");
		printf("pwd            ->  Display current directory\n");
		printf("cd <dirname>   ->  Change directory\n");
		printf("man <command>  ->  Help for specified command\n");
		printf("date           ->  Displays current date and time\n");
		// check for 'cd', convert to chdir
	}else if(strcmp(uArgs[0], "cd\0") == 0){
		errCode = chdir(uArgs[1]);
			if(errCode == -1){
			perror("Error");
		}else{
			getcwd(Prompt, MAX_STR);
		}
	}else{
		cPid = fork();
		
			// check if child process
		if (cPid == 0){
			if(strcmp(uArgs[0], "car\0") == 0){
				car();
				exit(EXIT_SUCCESS);
			}else if(strcmp(uArgs[0], "uncar\0") == 0){
				uncar();
				exit(EXIT_SUCCESS);
			}else if(strcmp(uArgs[0], "=\0") == 0){
				printf("%i\n", myAdder());
				exit(EXIT_SUCCESS);
			}else{
				if(argCnt == 3){
					// run regular command
				}else if(argCnt == 4){
					if(strcmp(uArgs[1], "<\0") == 0){
						rFile = open(uArgs[2], O_RDONLY);
					
						// Check for error
						if(rFile == -1){
							perror("Error");
								// Exit
							exit(EXIT_FAILURE);
						}else{
							// Copy file descriptor
							rfDup = dup2(rFile, 0);
								// Check for duplication error
							if(rfDup == -1){
								perror("Error");
									// Exit
							exit(EXIT_FAILURE);
							}
						}
						uArgs[1] = NULL;
					}else if(strcmp(uArgs[1], ">\0") == 0){
						oFile = open(uArgs[2], O_WRONLY | O_CREAT | O_TRUNC, 0777);
					
						// Check for error
						if(oFile == -1){
							perror("Error");
								// Exit
							exit(EXIT_FAILURE);
						}else{
							// Copy file descriptor
							ofDup = dup2(oFile, 0);
								// Check for duplication error
							if(ofDup == -1){
								perror("Error");
									// Exit
							exit(EXIT_FAILURE);
							}
						}
						uArgs[1] = NULL;
					}else{
						printf("improper command\n");
					}
				}else if(argCnt == 6){
					if((strcmp(uArgs[1], "<\0") == 0) && ((strcmp(uArgs[3], ">\0") == 0) || (strcmp(uArgs[3], ">>\0") == 0))){
						if(strcmp(uArgs[3], ">>\0") == 0){
							oFile = open(uArgs[4], O_WRONLY | O_CREAT | O_APPEND, 0777);
						}else{
							oFile = open(uArgs[4], O_WRONLY | O_CREAT | O_TRUNC, 0777);
						}
						rFile = open(uArgs[2], O_RDONLY);
							// Check for error
						if((oFile == -1) || (rFile == -1)){
							perror("Error");
								// Exit
							exit(EXIT_FAILURE);
						}else{
							// dup2 files
							rfDup = dup2(rFile, 1);
							ofDup = dup2(oFile, 1);
								// Check for duplication error
							if((rfDup == -1) || (ofDup == -1)){
								perror("Error");
									// Exit
								exit(EXIT_FAILURE);
							}
							
							ofClose = close(oFile);
							rfClose = close(rFile);
							// Check for closing error
							if((ofClose == -1) || (rfClose == -1)){
								perror("Error");
							}
						}
						uArgs[1] = NULL;
						uArgs[3] = NULL;
					}else if(((strcmp(uArgs[1], ">\0") == 0) || (strcmp(uArgs[1], ">>\0") == 0)) && (strcmp(uArgs[3], "<\0") == 0)){
						if(strcmp(uArgs[1], ">>\0") == 0){
							oFile = open(uArgs[2], O_WRONLY | O_CREAT | O_APPEND, 0777);
						}else{
							oFile = open(uArgs[2], O_WRONLY | O_CREAT | O_TRUNC, 0777);
						}
						rFile = open(uArgs[4], O_RDONLY);
							// Check for error
						if((oFile == -1) || (rFile == -1)){
							perror("Error");
								// Exit
							exit(EXIT_FAILURE);
						}else{
							// dup2 files
							rfDup = dup2(rFile, 1);
							ofDup = dup2(oFile, 1);
								// Check for duplication error
							if((rfDup == -1) || (ofDup == -1)){
								perror("Error");
									// Exit
								exit(EXIT_FAILURE);
							}
							
							ofClose = close(oFile);
							rfClose = close(rFile);
							// Check for closing error
							if((ofClose == -1) || (rfClose == -1)){
								perror("Error");
							}
						}
						uArgs[1] = NULL;
						uArgs[3] = NULL;
					}else{
						runFlag = 0;
						printf("improper command\n");
					}
				}else{
//					printf("not enough arguments\n");
				}
			
				if (runFlag == 1){
					errCode = execvp(*uArgs, uArgs);
					// Check for error
					if(errCode == -1){
						perror("Error");
						// force exit
						exit(EXIT_FAILURE);
					}
				}
				exit(EXIT_SUCCESS);
			}
			// check for error
		}else if(cPid == -1){
			perror("Error");
				// force shell to exit
			exit(EXIT_FAILURE);
			// run parent processes
		}else{
			//Status = 0;
			pPid = getpid();
				// run child process
			waitpid(cPid, &Status, WUNTRACED);
		}
	}
}

// sigint_handler Function
//
// Handles the ctrl+c signal
//***************************

void sigint_handler(int sig){

	// if no background processes, display error
	printf("\nTo exit, type 'exit'\n");

	// display prompt
	showPrompt();
}

// sigtstp_handler Function
//
// Handles the ctrl+z signal
//***************************

void sigtstp_handler(int sig){
	// do nothing
}

// readFile Function
//
// Read single file's contents
//*****************************

int readFile(char* fName, char* oFile){

  FILE *fp;
  int sLen = 0;
  char line[130];			/* line of data from unix command*/
  char command[80] = "cat ";
  strcat(command, fName);
   
  fp = popen(command, "r");		/* Issue the command.		*/

					/* Read a line			*/
	while ( fgets( line, sizeof line, fp)){
		sLen += strlen(line);
		inBuff = line;
		writeCarFile(oFile, strlen(inBuff), 1);
	}
	pclose(fp);
return sLen;
}

// readCarFile Function
//
// Read single file's contents
//*****************************

int readCarFile(char* iFile){

	FILE *fp;
	int i = 0, sLen = 0;
	char line[130];
	char line2[130];
	char line3[130];
	char command[80] = "cat ";
	char* oFile;
	strcat(command, iFile);

	fp = popen(command, "r");

	while ( fgets( line, sizeof line, fp)){
		oFile = strtok(line, " \t\n\r");
//		oFile = line;
		fgets( line2, sizeof line2, fp);
		sLen = atoi(line2);
		fgets( line3, sizeof line3, fp);
		inBuff = line3;
		writeFile(oFile, sLen);
	}
	pclose(fp);
return sLen;
}

// writeCarFile Function
//
// Write buffer contents to file
//*******************************

void writeCarFile(char* fName, int fSize, int pSize){
	int newLine;
	FILE *fWp;
	fWp = fopen(fName, "a");

	if(pSize == 1){
		fprintf(fWp, "%i\n", fSize);
	}
	fwrite (inBuff , 1 , fSize, fWp);
	newLine = strcspn(inBuff, "\n");
	if (newLine == fSize){
		fprintf(fWp, "\n");
	}

	fclose(fWp);
}

// writeFile Function
//
// Write buffer contents to file
//*******************************

void writeFile(char* fName, int fSize){

	int oFile, fDup, writ;

	oFile = open(fName, O_WRONLY | O_CREAT | O_APPEND, 0777);
	// Check for error
	if(oFile == -1){
		perror("Error");
		// Exit
		exit(EXIT_FAILURE);
	}else{
		// Copy file descriptor
		fDup = dup2(oFile, 0);
		// Check for duplication error
		if(fDup == -1){
			perror("Error");
			// Exit
			exit(EXIT_FAILURE);
		}
	}
	writ = write(oFile, inBuff, fSize);
	if(writ == -1){
		perror("Error");
		// Exit
		exit(EXIT_FAILURE);
	}
	
	close(oFile);
}

// car Function
//
// Creates a file by combining files
//***********************************

void car(){
	char* oFile = uArgs[1];


	for(iCntr = 2; iCntr < numArgs - 1; iCntr++){
		inBuff = uArgs[iCntr];
		writeCarFile(oFile, strlen(uArgs[iCntr]), 0);
		int fSize = readFile(uArgs[iCntr], oFile);
	}
}

void uncar(){
	char* iFile = uArgs[1];
	if(numArgs == 3){
		int fSize = readCarFile(iFile);
	}else if(numArgs < 3){
		printf("Please specify file name\n");
	}else if(numArgs > 3){
		printf("Improper File Name\n");
	}
}

int myAdder(){
int i;

	int Ans = 0;
	if (strcmp(uArgs[2], "+\0") == 0){
		Ans = atoi(uArgs[1]) + atoi(uArgs[3]);
	}else if (strcmp(uArgs[2], "-\0") == 0){
		Ans = atoi(uArgs[1]) - atoi(uArgs[3]);
	}else if (strcmp(uArgs[2], "*\0") == 0){
		Ans = atoi(uArgs[1]) * atoi(uArgs[3]);
	}else if (strcmp(uArgs[2], "/\0") == 0){
		Ans = atoi(uArgs[1]) / atoi(uArgs[3]);
	}else if (strcmp(uArgs[2], "^\0") == 0){
		int num1 = atoi(uArgs[1]), num2 = atoi(uArgs[3]);
		Ans = num1;
		for(i = 1; i < num2; i++){
			Ans = Ans * num1;
		}
	}else if (strcmp(uArgs[1], "fib\0") == 0){
		int theNum = atoi(uArgs[2]);
		int* fib;
		fib = (int*) malloc (theNum);

		fib[0] = 0;
		fib[1] = 1;

		for(i = 2; i <= theNum; i++){
			fib[i] = fib[i-1] + fib[i-2];
		}
		Ans = fib[theNum];
	}else{
		printf("improper operator\n");
	}
	return Ans;
}
