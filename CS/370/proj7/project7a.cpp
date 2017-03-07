// Jacob W. Truman
// CS 370 Section 2
//
// Project 7
// "Linux Scheduler & Memory Management"
//***************************************

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
#include <math.h>
#include <stdlib.h>

//
// Definitions
//*************

#define LINESIZE 50
#define NUMQS 14
#define QLEN 256
#define MAXBURSTS 1024

//
// Structs
//*********

struct pageNode{
	int pageNum, nodeNum;
	pageNode *nextPage, *prevPage;
};

struct proc{
	char pType;
	int pid, size, startAddress, endAddress, faults, calls;
	int priNiceVal, aTime, CPUBursts[MAXBURSTS], IOBursts[MAXBURSTS];
	long burstTotal, prevBurstTotal;
};

struct qProc{
	proc iniProc;
	bool curBurst;
	int qPri, burstLeft, CPUUsed, IOUsed, timeSlice, prevTimeSlice, procNum, CPUIndex, IOIndex;
	long termTime;
};

//
// Global Variables
//******************

pageNode *headNode = NULL;
pageNode *tempNode;
int memSize, pfSize, numProcs, iCntr, jCntr, numFrames, numNodes, numPages;
int *procSize;

bool BMP1[NUMQS], BMP2[NUMQS];
bool* activeBMP;
bool* expBMP;

int activeQ, activeProcs = 0, q1End[NUMQS], q2End[NUMQS], IOQEnd, termQEnd, termProcs = 0, rType;
int* activeQEnd;
int* expQEnd;

long theClock = 0;

proc procList[QLEN];

qProc* activeQs;
qProc* expQs;
qProc activeProc, termQ[QLEN], procQ1[NUMQS * QLEN], procQ2[NUMQS * QLEN], IOQ[QLEN];

//
// Function Prototypes
//*********************

void getIniNums();
void getProcSizes(proc **x);
void initMem();
void linSched(int x);
void memMan();
void getTheRest(proc **x);
void checkMem(int x, int y, proc **z);
void moveNodeToFront();
void addNodeToFront();
void printMem();
void printStats(proc **x);
void procPreemp();
void add2Q(int, int, qProc);
void printSchedStats(int procs);

int getStart();
int getPageNum(proc *x, int y);
int getInFile();
int getTimeSlice(int);
int getQNum(int);
int getPriority(qProc);
int getQIndex(int, int);

bool getNewProc(long, int);
bool updateIOproc();
bool hasActive();
bool hasExp();

//
// main Function
//*****************

int main(){
	rType = getStart();
	linSched(rType);
	exit(EXIT_SUCCESS);
}

//
// getStart Function
//*******************

int getStart(){
	char line[LINESIZE];
	fgets(line, LINESIZE, stdin);
	return atoi(line);
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

//
// getInFile Function
//********************

int getInFile(){
	int i, j, procs = 0, inBurst, CPUBursts, IOBursts;
	string inFilePath, inLine, myStr;
	bool isIO;
	char line[LINESIZE], *temp;

	while (fgets(line, LINESIZE, stdin) != NULL){
		procList[procs].burstTotal = 0;
		CPUBursts = 0;
		IOBursts = 0;
		iCntr = 0;
		isIO = false;
		tempNode = new pageNode;
		j = 0;

		myStr = line;

		i = myStr.find(" ",0);
		temp = new char[i];
		for(iCntr = 0; iCntr < i; iCntr++){
			temp[iCntr] = myStr[iCntr];
		}
		procList[procs].priNiceVal = atoi(temp);
		j = iCntr + 1;

		i = myStr.find(" ",j);
		for(iCntr = 0; iCntr < i; iCntr++){
			procList[procs].pType = myStr[iCntr];
		}
		j = iCntr + 1;

		i = myStr.find(" ",j);
		temp = new char[i - iCntr];
		for(iCntr = 0; iCntr < i; iCntr++){
			temp[iCntr] = myStr[iCntr + j];
		}
		procList[procs].aTime = atoi(temp);
		j = iCntr + 1;

		while((i = myStr.find(" ",j)) > 0){
			temp = new char[i - j];
			for(iCntr = 0; iCntr < i; iCntr++){
				temp[iCntr] = myStr[iCntr + j];
			}
			j = iCntr + 1;
			inBurst = atoi(temp);
		
			procList[procs].burstTotal += inBurst;

			if(isIO == false){
				procList[procs].CPUBursts[CPUBursts] = inBurst;
				CPUBursts++;
				isIO = true;
			}else{
				procList[procs].IOBursts[IOBursts] = inBurst;
				IOBursts++;
				isIO = false;
			}
		}
		
		i = myStr.length();
		temp = new char[i - iCntr];
		for(iCntr = 0; iCntr < i; iCntr++){
			temp[iCntr] = myStr[iCntr + j];
		}
		inBurst = atoi(temp);
		procList[procs].burstTotal += inBurst;
		if(isIO == false){
			procList[procs].CPUBursts[CPUBursts] = inBurst;
			CPUBursts++;
			isIO = true;
		}else{
			procList[procs].IOBursts[IOBursts] = inBurst;
			IOBursts++;
			isIO = false;
		}
		
		procList[procs].prevBurstTotal = procList[procs].burstTotal;
		procs++;
	}
	return(procs);
}

//
// getNewProc Function
//*********************

bool getNewProc(long theClock, int numProcs){
	int iniPriority, QNum;
	qProc newProc;
	bool isNew = false;

	for(int Cntr = 0; Cntr < numProcs; Cntr++){
		if(procList[Cntr].aTime == theClock){
			int iniPriority = 120;

			if(procList[Cntr].pType != 'n'){
				iniPriority = procList[Cntr].priNiceVal;
			}else{
				iniPriority = (120 + procList[Cntr].priNiceVal);
			}

			QNum = getQNum(iniPriority);
			newProc.iniProc = procList[Cntr];
			newProc.qPri = iniPriority;

			if(newProc.iniProc.pType == 'n'){
				newProc.timeSlice = getTimeSlice(iniPriority);
				newProc.prevTimeSlice = newProc.timeSlice;
			}

			newProc.procNum = activeProcs;
			newProc.curBurst = false;
			newProc.burstLeft = newProc.iniProc.CPUBursts[0];
			cout << "T[" << theClock << "] - Process [" << newProc.procNum << "] arrived queue [" << QNum << "]: ";

			if(newProc.iniProc.pType == 'n'){
				cout << " T-" << newProc.timeSlice << ", ";
			}
			cout << "P-" << iniPriority << "\n";

			activeProcs++;
			add2Q(1, QNum, newProc);
			isNew = true;
		}
	}
	return(isNew);
}

//
// getQIndex Function
//********************

int getQIndex(int QNum, int theIndex){
	int QI = (QNum * QLEN) + theIndex;
	return QI;
}

//
// getQNum Function
//******************

int getQNum(int pri){
	int QNum = (pri / 10);

	if(QNum == NUMQS){
		QNum = (NUMQS - 1);
	}
	return(QNum);
}

//
// getPriority Function
//**********************

int getPriority(qProc expProc){
	int bonus, penalty, newPriority;
	
	bonus = (int) floor (min(expProc.CPUUsed / 500.0, 1.0) * 5.0);
	penalty = (int) floor (min(expProc.CPUUsed / 500.0, 1.0) * 5.0);

	newPriority = (expProc.qPri - (bonus - penalty));
	if(newPriority > 140){
		newPriority = 140;
	}else if((expProc.iniProc.pType == 'n') && (newPriority < 100)){
		newPriority = 100;
	}

	expProc.CPUUsed = 0;
	expProc.IOUsed = 0;

	return newPriority;
}

//
// getTimeSlice Function
//***********************

int getTimeSlice(int pri){
	int ts;
	ts = max (100 * (140 - pri) / 20, 5);
	return(ts);
}

//
// add2Q Function
//****************

void add2Q(int qType, int QNum, qProc addProc){
	int QIndex;

	if(qType == 1){
		activeQs[getQIndex(QNum, activeQEnd[QNum])] = addProc;
		activeBMP[QNum] = true;
		activeQEnd[QNum]++;
	}else if(qType == 2){
		expQs[getQIndex(QNum, expQEnd[QNum])] = addProc;
		expBMP[QNum] = true;
		expQEnd[QNum]++;
	}else if(qType == 3){
		termQ[termQEnd] = addProc;
		termQEnd++;
	}else{
		IOQ[IOQEnd] = addProc;
		IOQEnd++;
	}
}

//
// procPreemp Function
//*********************

void procPreemp(){
	qProc curProc = activeProc, nullQProc;
	int QNum, iCntr, theIndex;
	bool switched = false, incActive = false;

	if((curProc.iniProc.pType == 'n') || (curProc.iniProc.pType == 'r')){
		if(((curProc.timeSlice > 0) || (curProc.iniProc.pType == 'r')) && (curProc.iniProc.burstTotal > 0) && (curProc.curBurst == false)){
			incActive = true;
		}else if(((curProc.timeSlice > 0) || (curProc.iniProc.pType == 'r')) && (curProc.iniProc.burstTotal > 0) && (curProc.curBurst == true)){
			curProc.CPUUsed = 0;
			cout << "T[" << theClock << "] - Process [" << curProc.procNum << "] finish CPU burst and moves to Wait queue\n";
			add2Q(0, 0, curProc);

		}else if(curProc.iniProc.burstTotal == 0){
			cout << "T[" << theClock << "] - Process [" << curProc.procNum << "] terminates\n";
			curProc.termTime = theClock;
			add2Q(3, 0, curProc);
			termProcs++;
		}else{
			curProc.qPri = getPriority(curProc);
			QNum = getQNum(curProc.qPri);

			if(curProc.iniProc.pType == 'n'){
				curProc.timeSlice = getTimeSlice(curProc.qPri);
				curProc.prevTimeSlice = curProc.timeSlice;
			}

			cout << "T[" << theClock << "] - Process [" << curProc.procNum << "]'s timeslice is out and moves to Expired queue [" << QNum << "]: T-" << curProc.timeSlice << ", P-" << curProc.qPri << "\n";
			add2Q(2, QNum, curProc);
		}
	}

	if((hasActive() == false) && (hasExp() == true)){
			qProc* tempQ;
			bool* tempBMP;
			int* tempEnd;

			tempQ = activeQs;
			tempBMP = activeBMP;
			tempEnd = activeQEnd;
	
			activeQs = expQs;
			activeBMP = expBMP;
			activeQEnd = expQEnd;
	
			expQs = tempQ;
			expBMP = tempBMP;
			expQEnd = tempEnd;

			cout << "T[" << theClock << "] - switched queues\n New active queue's bitmap:";

			for(int Counter = 0; Counter < NUMQS; Counter++){
				if(activeBMP[Counter] == true){
					cout << " 1";
				}else{
					cout << " 0";
				}
			}
			cout << "\n";
		}

	for(int Cntr = 0; Cntr < NUMQS; Cntr++){
		if(activeBMP[Cntr] == true){
			activeProc = activeQs[getQIndex(Cntr, (activeQEnd[Cntr] - 1))];
			theIndex = getQIndex(Cntr, (activeQEnd[Cntr] - 1));

			for(iCntr = 0; iCntr < (activeQEnd[Cntr] - 1); iCntr++){
				activeQs[iCntr + theIndex] = activeQs[iCntr + theIndex + 1];
			}

			activeQs[iCntr + theIndex] = nullQProc;
			activeQEnd[Cntr]--;

			if(activeQEnd[Cntr] == 0){
				activeBMP[Cntr] = false;
			}

			switched = true;
			activeQ = Cntr;
			break;
		}
	}

	if(switched == false){
		activeProc = nullQProc;
		activeQ = NUMQS;
	}

	if((curProc.iniProc.pType == 'n') || (curProc.iniProc.pType == 'r')){
		if(incActive == true){
			QNum = getQNum(curProc.qPri);

			cout << "T[" << theClock << "] - Process [" << curProc.procNum << "] got preempted and moves to Active queue  [" << QNum << "]: ";
			if(curProc.iniProc.pType == 'n'){
				cout << " T-" << curProc.timeSlice << ", ";
			}
			cout << "P-" << curProc.qPri << "\n";
			add2Q(1, QNum, curProc);

		}
	}
}

//
// updateIOproc Function
//***********************

bool updateIOproc(){
	qProc procDone, nullQProc;
	int QNum, iCntr, t;
	bool newIO = false;
	
	for(int Cntr = 0; Cntr < IOQEnd; Cntr++){
		IOQ[Cntr].burstLeft--;
		IOQ[Cntr].iniProc.burstTotal--;
		IOQ[Cntr].IOUsed++;

		if(IOQ[Cntr].burstLeft == 0){
			procDone = IOQ[Cntr];
			procDone.curBurst = false;
			procDone.burstLeft = procDone.iniProc.CPUBursts[procDone.CPUIndex];
			procDone.IOIndex++;

			for(iCntr = Cntr; iCntr < IOQEnd; iCntr++){
				IOQ[iCntr] = IOQ[iCntr + 1];
			}

			IOQ[iCntr + 1] = nullQProc;
			newIO = true;

			if((procDone.timeSlice > 0) || (procDone.iniProc.pType == 'r')){
				QNum = getQNum(procDone.qPri);
				cout << "T[" << theClock << "] - Process [" << procDone.procNum << "] finishs IO and moves to Active queue [" << QNum << "]: ";
				if(procDone.iniProc.pType == 'n'){
					cout << " T-" << procDone.timeSlice << ", ";
				}
				cout << "P-" << procDone.qPri << "\n";
				add2Q(1, QNum, procDone);
			}else{
				procDone.qPri = getPriority(procDone);
				QNum = getQNum(procDone.qPri);

				if(procDone.iniProc.pType == 'n'){
					procDone.timeSlice = getTimeSlice(procDone.qPri);
					procDone.prevTimeSlice = procDone.timeSlice;
				}
				cout << "T[" << theClock << "] - Process [" << procDone.procNum << "] compeleted its IO; moved to expired queue [" << QNum << "]: P-" << procDone.qPri;
				if(procDone.iniProc.pType == 'n'){
					cout << ", T-" << procDone.timeSlice;
				}
				cout << "\n";
				add2Q(2, QNum, procDone);
			}
		}
	}
	return(newIO);
}

//
// hasActive Function
//********************

bool hasActive(){
	bool flag = false;

	for(int Cntr = 0; Cntr < NUMQS; Cntr++){
		if(activeBMP[Cntr] == true){
			flag = true;
		}
	}
	return(flag);
}

//
// hasExp Function
//*****************

bool hasExp(){
	bool flag = false;

	for(int Cntr = 0; Cntr < NUMQS; Cntr++){
		if(expBMP[Cntr] == true){
			flag = true;
		}
	}
	return(flag);
}

//
// linSched Function
//*******************

void linSched(int x){
	if(x == 2){
		memMan();
	}else{
		int procs;
	 	bool isNewProc, switched, termFlag = false, newIO;

		activeBMP = &BMP1[0];
		expBMP = &BMP2[0];
		activeQEnd = &q1End[0];
		expQEnd = &q2End[0];
		activeQs = &procQ1[0];
		expQs = &procQ2[0];

		for(int Cntr = 0; Cntr < NUMQS; Cntr++){
			activeQEnd[Cntr] = 0;
			expQEnd[Cntr] = 0;
		}

		activeQ = NUMQS;
		procs = getInFile();

		if(procs > -1){
			while(termFlag == false){
				switched = false;
				isNewProc = getNewProc(theClock, procs);
				newIO = updateIOproc();

				if((isNewProc == true) || (newIO == true)){
					for(int Cntr = 0; Cntr < NUMQS; Cntr++){
						if((activeBMP[Cntr] == true) && (Cntr < activeQ)){
							procPreemp();
							switched = true;
						}
					}		
				}else{
					if((activeProc.timeSlice == 0) && (activeProc.iniProc.pType == 'n')){
						if((hasActive() == true) || (hasExp() == true)){
							procPreemp();
							if(x == 3){
								cout << "T[" << theClock << "] - Process [" << activeProc.procNum << "] Finishes PageFault queue and moves to Active queue [12]: T-" << activeProc.timeSlice << "P-" << activeProc.qPri << "\n";
							}
							switched = true;
						}else{
							activeProc.qPri = getPriority(activeProc);
							activeProc.timeSlice = getTimeSlice(activeProc.qPri);
							activeProc.prevTimeSlice = activeProc.timeSlice;
						}
					}else if(activeProc.curBurst == true){
						procPreemp();
						switched = true;
					}else if(activeProc.iniProc.burstTotal == 0){
						procPreemp();
						switched = true;
					}
				}

				if((activeProc.iniProc.pType == 'r') || (activeProc.iniProc.pType == 'n')){
					if(switched == true){
						cout << "T[" << theClock << "] - Process [" << activeProc.procNum << "] begins execution\n";
					}

					activeProc.burstLeft--;
					activeProc.iniProc.burstTotal--;
					activeProc.CPUUsed++;

					if(activeProc.iniProc.pType == 'n'){
						activeProc.timeSlice--;
					}

					if(activeProc.burstLeft == 0){
						activeProc.curBurst = true;
						activeProc.burstLeft = activeProc.iniProc.IOBursts[activeProc.IOIndex];
						activeProc.CPUIndex++;
					}
				}

				if(termProcs == procs){
					cout << "T[" << theClock << "] - All processes terminate\n\n";
					termFlag = true;
				}
				theClock++;
				
				if(switched && x == 3){
					cout << "T[" << theClock << "] - Process [" << activeProc.procNum << "] Non Swap Page Fault, moves to page fault queue, Page 0 moved to memory\n";
				}
			}
		}
		printSchedStats(procs);
	}
}

//
// memMan Function
//*****************

void memMan(){
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
// printSchedStats Function
//**************************

void printSchedStats(int procs){
	int CPUTime1, CPUTime2, CPUCntr, IOCntr, IOTime2, IOTime1, turnaroundTime, waitTime;
	int CPUTimeTotal = 0, waitTimeTotal = 0, turnaroundTimeTotal = 0;
	double CPUUtil, CPUUtilTotal, avgWaitTime, avgTurnaroundTime, avgCPUUtil; 

	cout << setiosflags(ios_base::fixed) << "***** Individual Statistics *****\n\n";

	for(int Counter = 0; Counter < procs; Counter++){
		CPUTime1 = 0;
		CPUCntr = 0;
		IOTime1 = 0;
		IOCntr = 0;
		turnaroundTime = 0;
		waitTime = 0;

		turnaroundTime = (termQ[Counter].termTime - termQ[Counter].iniProc.aTime);
		CPUTime2 = termQ[Counter].iniProc.CPUBursts[CPUCntr];

		while(CPUTime2 > 0){
			CPUTime1 += CPUTime2;
			CPUCntr++;
			CPUTime2 = termQ[Counter].iniProc.CPUBursts[CPUCntr];
		}

		IOTime2 = termQ[Counter].iniProc.IOBursts[IOCntr];

		while(IOTime2 > 0){
			IOTime1 += IOTime2;
			IOCntr++;
			IOTime2 = termQ[Counter].iniProc.IOBursts[IOCntr];
		}

		waitTime = (turnaroundTime - CPUTime1 - IOTime1);
		CPUUtil = (((double)CPUTime1 / turnaroundTime) * 100);

		cout << "Process[" << setprecision(0) << termQ[Counter].procNum << "]\n";
		cout << "  Turn Around Time: " << turnaroundTime << "\n";
		cout << "  Total CPU Time: " << CPUTime1 << "\n";
		cout << "  Waiting Time: " << waitTime << "\n";
		cout << "  CPU utilization %: " << setprecision(1) << CPUUtil << "%\n\n";

		CPUTimeTotal += CPUTime1;
		waitTimeTotal += waitTime;
		turnaroundTimeTotal += turnaroundTime;
		CPUUtilTotal += CPUUtil;
	}
	avgWaitTime = ((double)waitTimeTotal / procs);
	avgTurnaroundTime = ((double)turnaroundTimeTotal / procs);
	avgCPUUtil = (CPUUtilTotal / procs);

	cout << setprecision(3) << "***** Overall Statistics *****\n\n";
	cout << "Average Waiting Time: " << avgWaitTime << "\n";
	cout << "Average Turnaround Time: " << avgTurnaroundTime << "\n";
	cout << "Average CPU Utilization: " << avgCPUUtil << "\n";
}
