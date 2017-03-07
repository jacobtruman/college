// Jacob W. Truman
// CS 370 Section 2
//
// Project 6
// "Memory Management"
//*********************

//
// Namespaces
//************

using namespace std;

//
// Includes
//**********

#include <iomanip>
#include <iostream>
#include <string>
#include <stdio.h>

//
// Definitions
//**************

#define LINESIZE 20

//
// Structs
//*********

struct pageNode{
	int pageNum, nodeNum;
	pageNode *nextPage, *prevPage;
};

struct proc{
	int pid, size, startAddress, endAddress, faults, calls;
};

//
// Global Variables
//******************

pageNode *headNode = NULL, *tempNode;
int memSize, pfSize, numProcs, iCntr, jCntr, *procSize, numFrames, numNodes, numPages;

//
// Function Prototypes
//*********************

void getIniNums();
void getProcSizes(proc **x);
void initMem();
void getTheRest(proc **x);
int getPageNum(proc *x, int y);
void checkMem(int x, int y, proc **z);
void moveNodeToFront();
void addNodeToFront();
void printMem();
void printStats(proc **x);

//
// main Function
//*****************

int main(){
	getIniNums();
	proc *procList[numProcs];
	numFrames = memSize / pfSize;
	getProcSizes(procList);
	initMem();
	getTheRest(procList);
	
	printMem();
	printStats(procList);

}

//
// getIniNums Function
//*********************

void getIniNums(){
	int iniNums[3];
	char line[LINESIZE];
	for(iCntr = 0; iCntr < 3; iCntr++){
		fgets(line, LINESIZE, stdin);
		iniNums[iCntr] = atoi(line);
	}
	memSize = iniNums[0];
	pfSize = iniNums[1];
	numProcs = iniNums[2];
}

//
// getProcSizes Function
//***********************

void getProcSizes(proc **x){
	proc *tempProc;
	numPages = 0;
	char line[LINESIZE];
	for(iCntr = 0; iCntr < numProcs; iCntr++){
		tempProc = new proc;
		fgets(line, LINESIZE, stdin);
		tempProc->size = atoi(line);
		tempProc->pid = iCntr;
		tempProc->startAddress = (numPages * pfSize);
		tempProc->endAddress = tempProc->startAddress + tempProc->size;
		if(tempProc->size % pfSize == 0){
			numPages += (tempProc->size / pfSize);
		}else{
			numPages += ((tempProc->size / pfSize) + 1);
		}
		x[iCntr] = tempProc;
	}
}

//
// initMem Function
//******************

void initMem(){
	for(iCntr = 0; iCntr < numFrames; iCntr++){
		tempNode = new pageNode;
		tempNode->pageNum = -1;
		tempNode->nodeNum = (numFrames - iCntr) - 1;
		tempNode->nextPage = NULL;
		tempNode->prevPage = NULL;
		if(headNode == NULL){
			headNode = tempNode;
			numNodes++;
		}else if(numNodes < numFrames){
			tempNode->nextPage = headNode;
			headNode->prevPage = tempNode;
			headNode = tempNode;
			numNodes++;
			while(tempNode->nextPage != NULL){
				tempNode = tempNode->nextPage;
			}
		}
	}
}

//
// getTheRest Function
//*********************

void getTheRest(proc **x){
	char line[LINESIZE];
	char *temp;
	int i = -1, lineNum = 3 + numProcs, pid, offset;

	while (fgets(line, LINESIZE, stdin) != NULL){
		tempNode = new pageNode;
		lineNum++;
		i = -1;
		i = strcspn (line, " ");
		if(i > -1){
			temp = new char[i];
			for(iCntr = 0; iCntr < i; iCntr++){
				temp[iCntr] = line[iCntr];
			}
			pid = atoi(temp);

			temp = new char[strlen(line) - i];
			for(iCntr = 0; iCntr < strlen(line); iCntr++){
				temp[iCntr] = line[iCntr + i];
			}
			offset = atoi(temp);
			
			checkMem(pid, offset, x);
		}
	}
}

//
// checkMem Function
//*******************

void checkMem(int x, int y, proc **z){
	tempNode = headNode;
	int flag = 0;
	z[x]->calls++;
	if(y > z[x]->size){
		cout << "[" << x << "](" << z[x]->startAddress + y << ") Invalid Address Reference" << endl;
	}else{
		for(iCntr = 0; iCntr < numFrames; iCntr++){
			if(tempNode->pageNum < 0){
				z[x]->faults++;
				tempNode->pageNum = getPageNum(z[x], y);
				cout << "[" << x << "](" << z[x]->startAddress + y << ") Page Fault, page " << getPageNum(z[x], y) << " moved to memory location " << iCntr << endl;
				moveNodeToFront();
				flag++;
				break;
			}else if(tempNode->pageNum == getPageNum(z[x], y)){
				cout << "[" << x << "](" << z[x]->startAddress + y << ") Page Hit, page " << getPageNum(z[x], y) << " Already In Memory" << endl;
				moveNodeToFront();
				flag++;
				break;
			}
			tempNode = tempNode->nextPage;
		}
		if(flag == 0){
			z[x]->faults++;
			tempNode = new pageNode;
			tempNode->pageNum = getPageNum(z[x], y);
			tempNode->nodeNum = headNode->nextPage->nextPage->nextPage->nodeNum;
			cout << "[" << x << "](" << z[x]->startAddress + y << ") Page Fault, page " << tempNode->pageNum << " moved to memory location " << tempNode->nodeNum << " Swapped with page " << headNode->nextPage->nextPage->nextPage->pageNum << endl;
			addNodeToFront();
		}
	}
}

//
// getPageNum Function
//*********************

int getPageNum(proc *x, int y){
	return ((y + x->startAddress) / pfSize);
}

//
// moveNodeToFront Function
//**************************

void moveNodeToFront(){
	if(tempNode != headNode){
		if(tempNode->prevPage != NULL){
			tempNode->prevPage->nextPage = tempNode->nextPage;
		}
		if(tempNode->nextPage != NULL){
			tempNode->nextPage->prevPage = tempNode->prevPage;
		}
		addNodeToFront();
	}

}

//
// addNodeToFront Function
//*************************

void addNodeToFront(){
	headNode->prevPage = tempNode;
	tempNode->nextPage = headNode;
	tempNode->prevPage = NULL;
	headNode = tempNode;
}

//
// printMem Function
//*******************

void printMem(){
	cout << endl << endl;
	cout << "Memory:" << endl;
	cout << "----------" << endl;
	for(iCntr = 0; iCntr < numFrames; iCntr++){
		tempNode = headNode;
		while(iCntr != tempNode->nodeNum){
			tempNode = tempNode->nextPage;
		}
		cout << "| Page " << tempNode->pageNum << " |" << endl;
		cout << "----------" << endl;
	}
	cout << endl;
}

//
// printStats Function
//*********************

void printStats(proc **x){
	cout << endl << "Processes:" << endl;
	for(iCntr = 0; iCntr < numProcs; iCntr++){
		cout << "Process : " << iCntr << endl;
		cout << "Total Page Faults: " << x[iCntr]->faults << endl;
		cout << (x[iCntr]->faults * 100) / x[iCntr]->calls << "% page faults per access" << endl << endl;
	}
}
