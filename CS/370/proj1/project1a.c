// Jacob W. Truman
// CS 370 Section 1
// Project 1 - "A Simple UNIX Minishell"
//**************************************

// Includes
//*****************

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>
#include <sys/wait.h>
#include <unistd.h>
#include <signal.h>

// Definitions
//*****************

#define aTimer 15

// Constants
//*****************

const int MAX_BG = 3;
const int MAX_ARGS = 32;
const int MAX_STR = 1024;

// Globals
//*****************

int numArgs;
char* uArgs[32];
int isBG;
int bgNum = 0;
int bgPIDs[3];
char Prompt[1024];
int qflag = 0;
int alarmFlag = 0;
int iCntr;
int pPid;

// Function Prototypes
//**********************

void startShell();
void showPrompt();
int parse_uInput(char[]);
void runCmd();
void killKids();
void addBG(int cPid);
void remBG(int cPid);
// *** signal functions ***
void sigint_handler(int sig);
void sigtstp_handler(int sig);
void sigchld_handler(int sig);
void sigalrm_handler(int sig);

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

	// handle child processes
	if (signal(SIGCHLD, sigchld_handler) == SIG_ERR){
		perror("signal");
		exit(1);
	}
	
	// handle alarms
	if (signal(SIGALRM, sigalrm_handler) == SIG_ERR){
		perror("signal");
		exit(1);
	}

	char uInput[MAX_STR];

	while (qflag == 0){

		// start alarm timer
		alarm(aTimer);

		// display prompt
		showPrompt();
		
		fgets(uInput, MAX_STR, stdin);

		numArgs = parse_uInput(uInput);

		if (numArgs > 0){
			runCmd();
		}
	}

	// kill all child processes
	killKids();

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

	int argCnt = 0, uiLen;

	if(strcmp(uInput, "\n\0") != 0){

		// parse string
		uArgs[argCnt++] = strtok(uInput, " \t\n");

		// set command to lowercase
		for(iCntr = 0; iCntr < strlen(uArgs[0]); iCntr++){
			uArgs[0][iCntr] = tolower(uArgs[0][iCntr]);
		}

		// reset isBG flag
		isBG = 0;

		// if command ends in "&" set background process flag
		if (uArgs[0][iCntr - 1] == '&'){
			isBG = 1;
			uArgs[0][iCntr - 1] = '\0';
		}

		// get args after cmd
		while((uArgs[argCnt++] = strtok(NULL, " \t\n")) && argCnt < MAX_ARGS);
	}
	return(argCnt);
}

// runCmd Function
//
// Runs the command from user input
//**********************************

void runCmd(){
	int cPid, errCode, Status;
	if((bgNum == MAX_BG) && (isBG == 1)){
		printf("Error: Maximum background processes exceeded\n");
	}else{
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
				errCode = execvp(*uArgs, uArgs);

				// Check for error
				if(errCode == -1){
					perror("Error");

					// force exit
					exit(EXIT_FAILURE);
				}
				exit(EXIT_SUCCESS);

			// check for error
			}else if(cPid == -1){
				perror("Error");

				// kill all child processes
				killKids();

				// force shell to exit
				exit(EXIT_FAILURE);

			// run parent processes
			}else{
				//Status = 0;
			pPid = getpid();
				if (isBG == 1){
					bgNum++;

					// add to background processes
					addBG(cPid);
					sleep(1);
				}else{

					// run child process
					waitpid(cPid, &Status, WUNTRACED);
				}
			}
		}
	}
}

// killKids Function
//
// Kills all child processes
//***************************

void killKids(){

	// loop to kill all child processes
	for(iCntr = 0; iCntr < bgNum; iCntr++){

		// kill process
		kill(bgPIDs[iCntr], SIGINT);

		// remove from background list
		remBG(bgPIDs[iCntr]);
	}
}

// sigint_handler Function
//
// Handles the ctrl+c signal
//***************************

void sigint_handler(int sig){

	int kPid;

	if (alarmFlag == 0){
		if(bgNum == 0){
			// if no background processes, display error
			printf("\nError: No background processes\n");
		}else{

			// get the oldest background pid
			kPid = bgPIDs[bgNum - 1];

			// kill the oldest background process
			remBG(bgNum - 1);
			kill(kPid, SIGINT);

			// display results
			printf("\nProcess %i was terminated\n", kPid);

			bgNum--;
		}

		// display prompt
		showPrompt();
	}
}

// sigtstp_handler Function
//
// Handles the ctrl+z signal
//***************************

void sigtstp_handler(int sig){
	// do nothing
}

// sigchld_handler Function
//
// Handles child processes
//**************************

void sigchld_handler(int sig){

	int Status, pIndex = -1, flag = 1;

	// check for child
	if(bgNum > 0){

		// loop to find what has stopped
		for(iCntr = 0; (iCntr < bgNum) && (flag == 1); iCntr++){

			// get status w/o stopping parent or child
			waitpid(bgPIDs[iCntr], &Status, WNOHANG);

			// check to see if background process stopped
			if(WIFEXITED(Status)){

				// get the index and end loop
				bgNum--;

				pIndex = iCntr;
				flag = 0;
			}
		}

		// check if process died
		if(pIndex > -1){

			// display results
			printf("\nProcess %i successfully terminated\n", bgPIDs[pIndex]);

			// remove from background process list
			remBG(pIndex);
		}
	}
}

// sigalrm_handler Function
//
// Handles alarms
//**************************

void sigalrm_handler(int sig){

alarmFlag = 1;

char uInput[MAX_STR];
int lgnFlag = 0;

	while(lgnFlag == 0){
	
		uArgs[0] = "clear\0";
		runCmd();
		
		printf("Please Login\n\n");

		// display login prompt
		printf("Login: ");

		fgets(uInput, MAX_STR, stdin);

		if(strcmp(uInput, "abc\n") == 0){

			// display password prompt
			printf("Password: ");
		
			fgets(uInput, MAX_STR, stdin);

			if(strcmp(uInput, "123\n") == 0){
				lgnFlag = 1;
			}else{
				printf("Invalid Password\n");
				sleep(2);
			}
		}else{
			printf("Invalid Login\n");
			sleep(2);
		}
	}
	alarmFlag = 0;
	
	// return to main
	startShell();
}

// addBG Function
//
// Add a backgroud Process
//*************************

void addBG(int cPid){
	// shift older child processes back
	for(iCntr = (MAX_BG - 1); iCntr > 0; iCntr--){
		bgPIDs[iCntr] = bgPIDs[iCntr - 1];
	}

	// Add new child in
	bgPIDs[0] = cPid;
	printf("Process %i added to background", cPid);
}

// remBG Function
//
// Kill a background process
//***************************

void remBG(int Starting_Index){
	// Loop children forward
	for(iCntr = Starting_Index; iCntr < (MAX_BG - 1); iCntr++){
		bgPIDs[iCntr] = bgPIDs[iCntr + 1];
	}

	// Reset last position to 0
	bgPIDs[MAX_BG - 1] = 0;
}

