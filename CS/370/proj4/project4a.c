// Jacob Truman
// CS370
// Project 4
//
// "Simulation of the Peterson Leader-Election Algorithm"
//********************************************************

//*************
// Definitions
//*************

#define NODE_COUNT 200

//***********
//	Includes
//***********

#include <errno.h>
#include <pthread.h>
#include <semaphore.h>
#include <stdlib.h>
#include <stdio.h>

//******************
// Global Variables
//******************

pthread_t Threads[NODE_COUNT];
int numNodes, iCntr, errNum, condCntr = 0, flag = 1, leader;
sem_t curSem[NODE_COUNT];

struct node{
	int phase, UID, tempID, channel[2], head, tail;
	char status;
};
struct node Nodes[NODE_COUNT];

//*********************
// Function Prototypes
//*********************

void getNodes();
void getThread(int x);
void printNode(int x);
void initChannels();
int readChannel(int x);
void writeChannel(int x, int y, int z);
void execNode();
void updateChannels();

//
// main Function
//***************

int main(){

	getNodes();
	initChannels();
	while(flag){
		for(iCntr = 0; iCntr < numNodes; iCntr++){
			if(Nodes[iCntr].status == 'a'){
				printNode(iCntr);
				getThread(iCntr);
			}
		}
		updateChannels();
	}
	printf("\nThe Leader Node: PID %i, Original UID %d, tempID %d\n", leader, Nodes[leader].UID, Nodes[leader].tempID, Nodes[leader].phase);
	exit(EXIT_SUCCESS);
}

//
// getNodes Function
//*******************

void getNodes(){
	int temp;
	char uInput[12];

	fgets(uInput, 12, stdin);
	numNodes = atoi(uInput);
	Nodes[0].phase = 1;
	Nodes[0].UID = atoi(uInput);
	Nodes[0].tempID = atoi(uInput);
	Nodes[0].status = 'a';
	Nodes[0].tail = numNodes - 1;
	Nodes[numNodes - 1].head = 0;
	
	for(iCntr = 1; iCntr < numNodes; iCntr++){
		fgets(uInput, 12, stdin);
		Nodes[iCntr].phase = 1;
		Nodes[iCntr].UID = atoi(uInput);
		Nodes[iCntr].tempID = atoi(uInput);
		Nodes[iCntr].status = 'a';
		Nodes[iCntr].tail = iCntr - 1;
		Nodes[iCntr - 1].head = iCntr;
		
		sem_init(&curSem[iCntr], 0, 0);
	}
}

//
// printNodes Function
//*********************

void printNode(int x){
	printf("PID: %-4i UID: %-4d tempID: %-4d Phase: %-4d\n", x, Nodes[x].UID, Nodes[x].tempID, Nodes[x].phase);
}

//
// getThreads Function
//*********************

void getThread(int x){
	errNum = pthread_create(&Threads[x], NULL, (void*)execNode, (void*)"");

	if(errNum != 0){
		printf("Error: Node thread creation failed.\n");
		exit(0);
	}
}

//
// writeChannel Function
//***********************

void writeChannel(int x, int y, int z){
	Nodes[x].channel[y] = Nodes[z].tempID;
}

//
// execNode Function
//*******************

void execNode(){
	sem_wait(&curSem[iCntr]);

	if((Nodes[iCntr].channel[0] > Nodes[iCntr].channel[1]) && (Nodes[iCntr].channel[0] > Nodes[iCntr].tempID)){
		Nodes[iCntr].tempID = Nodes[iCntr].channel[0];
		Nodes[iCntr].phase++;
	}else{
		Nodes[iCntr].status = 'r';
		Nodes[Nodes[iCntr].head].tail = Nodes[iCntr].tail;
		Nodes[Nodes[iCntr].tail].head = Nodes[iCntr].head;
	}
	
	sem_post(&curSem[iCntr]);
}


//
// initChannels Function
//***********************

void initChannels(){
	for(iCntr = 0; iCntr < numNodes; iCntr++){
		if(iCntr == numNodes - 2){
			writeChannel(numNodes - 1, 0, iCntr);
			writeChannel(0, 1, iCntr);
		}else if(iCntr == numNodes - 1){
			writeChannel(0, 0, iCntr);
			writeChannel(1, 1, iCntr);
		}else{
			writeChannel(iCntr + 1, 0, iCntr);
			writeChannel(iCntr + 2, 1, iCntr);
		}
	}
}

//
// updateChannels Function
//*************************

void updateChannels(){
	for(iCntr = 0; iCntr < numNodes; iCntr++){
		if(Nodes[iCntr].status == 'r'){
			sem_wait(&curSem[iCntr]);
			writeChannel(Nodes[iCntr].head, 1, iCntr);
			writeChannel(Nodes[Nodes[iCntr].head].head, 0, iCntr);
			if(Nodes[iCntr].channel[0] == Nodes[iCntr].tempID){
				flag = 0;
				leader = iCntr;
			}
			sem_post(&curSem[iCntr]);
		}
	}
}
