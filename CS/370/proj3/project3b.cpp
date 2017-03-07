// Jacob W. Truman
// CS 370 Section 2
// Project 3 - "Linux Scheduler"
//*******************************

// Namespaces
//************

using namespace std;

// Includes
//**********

#include <fstream>
#include <iostream>
#include <iomanip>
#include <math.h>
#include <stdlib.h>
#include <sstream>
#include <string>

// Definitions
//**************

#define NUMQS 14
#define QLEN 256
#define MAXBURSTS 1024

// Struct: proc
//**************

struct proc{
	char pType;

	int priNiceVal;
	int aTime;
	int CPUBursts[MAXBURSTS];
	int IOBursts[MAXBURSTS];

	long burstTotal;
	long prevBurstTotal;
};

// Struct: qProc
//***************

struct qProc{
	proc iniProc;

	bool curBurst;

	int qPri;
	int burstLeft;
	int CPUUsed;
	int IOUsed;
	int timeSlice;
	int prevTimeSlice;
	int procNum;
	int CPUIndex;
	int IOIndex;

	long termTime;
};

// Global Variables
//******************

bool BMP1[NUMQS];
bool BMP2[NUMQS];
bool* activeBMP;
bool* expBMP;

int activeQ;
int* activeQEnd;
int activeProcs = 0;
int* expQEnd;
int q1End[NUMQS];
int q2End[NUMQS];
int IOQEnd;
int termQEnd;
int termProcs = 0;

long theClock = 0;

proc procList[QLEN];

qProc* activeQs;
qProc activeProc;
qProc* expQs;
qProc termQ[QLEN];
qProc procQ1[NUMQS * QLEN];
qProc procQ2[NUMQS * QLEN];
qProc IOQ[QLEN];

// Function Prototypes
//*********************

bool getNewProc(long, int);
bool updateIOproc();
bool hasActive();
bool hasExp();

int getInFile();
int getTimeSlice(int);
int getQNum(int);
int getPriority(qProc);
int getQIndex(int, int);

void procPreemp();
void add2Q(int, int, qProc);

// main Function
//*****************

int main(){
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
		}
	}

//****************
//
// Display totals
//
//****************
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

	exit(EXIT_SUCCESS);
}

// getInFile Function
//
// Get input from file specified by user
//***************************************

int getInFile(){
	int procs = 0, inBurst, CPUBursts, IOBursts;
	string inFilePath, inLine;
	istringstream inLineStream;
	ifstream inFile;
	bool isIO;

	cout << "> Enter input filename: ";
	cin >> inFilePath;
	inFile.open(inFilePath.c_str());

	if(!inFile.is_open()){
		cout << "* Error: File not found.\n";
		return(-1);
	}else{
		while(!inFile.eof()){
			CPUBursts = 0;
			IOBursts = 0;
			inLineStream.clear();
			isIO = false;
			getline(inFile, inLine);

			if(inLine.length() > 0){
				inLineStream.str(inLine);
				procList[procs].burstTotal = 0;
				inLineStream >> procList[procs].priNiceVal;
				inLineStream >> procList[procs].pType;
				inLineStream >> procList[procs].aTime;

				while(inLineStream >> inBurst){
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

				procList[procs].prevBurstTotal = procList[procs].burstTotal;
				procs++;
			}
		}
	}
	return(procs);
}

// getNewProc Function
//
// Place new processes into queues
//*********************************

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

// getQIndex Function
//
// Get index in queue
//********************

int getQIndex(int QNum, int theIndex){
	int QI = (QNum * QLEN) + theIndex;
	return QI;
}

// getQNum Function
//
// Get queue number
//******************

int getQNum(int pri){
	int QNum = (pri / 10);

	if(QNum == NUMQS){
		QNum = (NUMQS - 1);
	}
	return(QNum);
}

// getPriority Function
//
// Get the priority for a process
//********************************

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

// getTimeSlice Function
//
// Get time slice
//***********************

int getTimeSlice(int pri){
	int ts;
	ts = max (100 * (140 - pri) / 20, 5);
	return(ts);
}

// add2Q Function
//
// Add process to queue
//**********************

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

// procPreemp Function
//
// Preempts running process
//**************************

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

// updateIOproc Function
//
// Update info on IO process
//***************************

bool updateIOproc(){
	qProc procDone, nullQProc;
	int QNum, iCntr;
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

// hasActive Function
//
// Checks if process is active
//*****************************

bool hasActive(){
	bool flag = false;

	for(int Cntr = 0; Cntr < NUMQS; Cntr++){
		if(activeBMP[Cntr] == true){
			flag = true;
		}
	}
	return(flag);
}

// hasExp Function
//
// Checks if there is an expired process
//***************************************

bool hasExp(){
	bool flag = false;

	for(int Cntr = 0; Cntr < NUMQS; Cntr++){
		if(expBMP[Cntr] == true){
			flag = true;
		}
	}
	return(flag);
}

