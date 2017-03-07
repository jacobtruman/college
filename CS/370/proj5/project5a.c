// Jacob Truman
// CS370
// Project 5
//
// "Simulation of Dijkstra's K-State Mutual Exclusion Algorithm"
//***************************************************************

//***********
//	Includes
//***********

#include <sys/types.h>
#include <sys/socket.h>
#include <sys/un.h>
#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <signal.h>

//*********************
// Function Prototypes
//*********************

void genSockName(char* x, int y);
int makeSocket(int x);
void bindNode(char* w, int x, struct sockaddr_un y, int z);
void listNode(char* w, int x);
int acceptNode(char* v, int* w, int x, struct sockaddr_un y, unsigned int z);
void connectNode(char* w, int x, struct sockaddr_un y, int z);
void initData();
void recvNode(int x);
void sigint_handler(int sig);
void sigtstp_handler(int sig);
void printMsg(int x);
void unlinkSockets();

//*********
// Globals
//*********

unsigned int lLen, rLen;			// used for the length of the address
int lsd, rsd, lcsd, rcsd;			// socket descriptors
struct sockaddr_un lAddr, rAddr;	// address of sockets
char lName[12];						// name of left socket
char rName[12];						// name of right socket
int flag = 1;
int numNodes, nodeNum, pNum, lState, sState, iCntr;

//
// main Function
//***************

int main(){
	// capture ctrl+c
	signal(SIGINT, sigint_handler);
	
	// capture ctrl+z
	signal(SIGTSTP, sigtstp_handler);

	srand((unsigned)time(NULL));

	printf("Enter Node Number: ");
	scanf("%i", &nodeNum);
	printf("Enter Number of Nodes: ");
	scanf("%i", &numNodes);

	if(nodeNum == 0){
		genSockName(lName, numNodes - 1);
		genSockName(rName, nodeNum);
	}else if(nodeNum == numNodes - 1){
		genSockName(lName, nodeNum - 1);
		genSockName(rName, nodeNum);
	}else{
		genSockName(lName, nodeNum - 1);
		genSockName(rName, nodeNum);
	}

	lsd = makeSocket(lsd);
	rsd = makeSocket(rsd);

	lAddr.sun_family = AF_UNIX;
	rAddr.sun_family = AF_UNIX;

	strcpy(lAddr.sun_path, lName);
	strcpy(rAddr.sun_path, rName);

	lLen = sizeof(lAddr.sun_family) + strlen(lAddr.sun_path);
	rLen = sizeof(rAddr.sun_family) + strlen(rAddr.sun_path);


	if(nodeNum == 0){
		rcsd = rsd;
		lcsd = lsd;

		bindNode(rName, rsd, rAddr, rLen);
		listNode(rName, rsd);
		acceptNode("right", &rsd, rcsd, rAddr, rLen);

		bindNode(lName, lsd, lAddr, lLen);
		listNode(lName, lsd);
		acceptNode("left", &lsd, lcsd, lAddr, lLen);
	}else if(nodeNum == numNodes - 1){
		connectNode("left", lsd, lAddr, lLen);
		connectNode("right", rsd, rAddr, rLen);
	}else{
		rcsd = rsd;

		connectNode("left", lsd, lAddr, lLen);

		bindNode(rName, rsd, rAddr, rLen);
		listNode(rName, rsd);
		acceptNode("right", &rsd, rcsd, rAddr, rLen);
	}

	void initData();
	printMsg(0);

	while(flag == 1){
		if(nodeNum == 0){
			if(lState == sState){
				sState = (sState + 1) % numNodes;
				printMsg(1);
				sleep(2);
				printMsg(0);
			}
		}else{
			if(lState != sState){
				sState = sState = lState;
				printMsg(1);
				sleep(2);
				printMsg(0);
			}
		}

		send(rsd, &sState, 1, 0);
		
		recv(lsd, &lState, 1, 0);
	}

	unlinkSockets();

	exit(EXIT_SUCCESS);
}

void genSockName(char* x, int y){
	sprintf(x, "%s%i", "mySocket", y);
}

//
// makeSocket Function
//*********************

int makeSocket(int x){
	if ((x = socket(AF_UNIX, SOCK_STREAM, 0)) < 0){
		perror("Error Creating Left Socket");
		exit(1);
	}
	return x;
}

//
// bindNode Function
//*******************

void bindNode(char* w, int x, struct sockaddr_un y, int z){
	unlink(w);
	if (bind(x, (struct sockaddr*)&y, z) < 0){
		printf("%s ", w);
		perror("Error Binding Socket");
		exit(1);
	}
}

//
// listNode Function
//*******************

void listNode(char* w, int x){
	if (listen(x, 1) < 0){
		printf("%s ", w);
		perror("Error Listening");
		exit(1);
	}
	//printf("%s Listening\n", w);
}

//
// acceptNode Function
//*********************

int acceptNode(char* v, int* w, int x, struct sockaddr_un y, unsigned int z){
	if ((*w = accept(x, (struct sockaddr*) &y, &z)) < 0){
		printf("%s ", v);
		perror("Error Accepting");
		exit(1);
	}
//	printf("%s Connection Made Successfully\n", v);
	printf("Connected to %s neighbor\n", v);
	return x;
}

//
// connectNode Function
//**********************

void connectNode(char* w, int x, struct sockaddr_un y, int z){
	if (connect(x, (struct sockaddr*)&y, z) < 0){
		printf("%s ", w);
		perror("Error Connecting");
		exit(1);
	}
	//printf("%s Connected\n", w);
	printf("Connected to %s neighbor\n", w);
}

//
// initData Function
//*******************

void initData(){
	sState = (rand() % numNodes);

	send(rsd, &sState, 1, 0);
	
	recv(lsd, &lState, 1, 0);
}

//
// recvNode Function
//*******************

void recvNode(int x){
	int y;
	recv(x, &y, sizeof(int), 0);
	printf("\n*** Message From Server: %i\n\n", x);
}

//
// sigint_handler Function
//***************************

void sigint_handler(int sig){
	flag = 0;
	printf("Exit\n");
}

//
// unlinkSockets Function
//************************

void unlinkSockets(){
	unlink(lName);
	unlink(rName);
}

//
// sigtstp_handler Function
//**************************

void sigtstp_handler(int sig){
	initData();
	printf("A Fault Has Ocurred\n");
}

//
// sigtstp_handler Function
//**************************

void printMsg(int x){
	if(x == 0){
		for(iCntr = 0; iCntr < 50; iCntr++){
			printf("\n");
		}
	}else{
		for(iCntr = 0; iCntr < 25; iCntr++){
			printf("************************\n");
		}
		printf("In the Critical Section\n");
	}
}
