// Jacob W. Truman
// CS489
//
// Assignment 5
// 
//******************************************

// Includes
//*****************

#include <iostream>
#include <fstream>
#include <string>
#include <sstream>
#include <stdio.h>

// Namespaces
//************

using namespace std;

// Definitions
//*****************

#define MAXREC 20
#define RECDIF 10

// Globals
//*****************

int iCntr, jCntr, rCntr, rMax = 0;
string rec1[MAXREC], rec2[MAXREC], header[MAXREC], pTail[MAXREC];
bool flag = 0, flag2 = 0;
string::size_type loc, loc2, loc3, loc4;
FILE * pFile;

// Function Prototypes
//**********************

void getAll(char* x, string* y, int z);
void checkTail();
void printHeader(int x);
void printTail(int x);
void printRecs();
void procHeader(int x, int y);

// Main Function
//***************

int main(int argc, char **argv){

	getAll(argv[1], rec1, 0);
	getAll(argv[2], rec2, 1);

	checkTail();

	pFile = fopen ("searchString.dat","w");
		printRecs();
	fclose (pFile);

	return 0;
}

// getAll Function
//
//
//***************************************************

void getAll(char* x, string* y, int z){
	iCntr = 0;
	rCntr = -1;
	string line;
	ifstream myfile (x);
	if(myfile.is_open()){
		while(!myfile.eof()){
			iCntr++;
			getline (myfile,line);

			if(line[0] == '>'){
				rCntr++;
				if(z){
					loc = line.find("UpstreamSeq", 0);
					if(loc != string::npos){
						line.replace(loc, 11, "PromoterTail");
					}
					header[rCntr] = line;
				}
			}else{
				for (int i = 0; i < line.length(); i++){
					line[i] = toupper(line[i]);
				}
				y[rCntr].insert(y[rCntr].length(), line);
			}
		}
		myfile.close();
		if(rMax < rCntr){
			rMax = rCntr;
		}
	}else{
		cout << "Unable to open file";
	}
	
}

// checkTail Function
//
//
//***********************************************

void checkTail(){
	int recStart;
	for(iCntr = 0; iCntr < rMax; iCntr++){
		loc = rec1[iCntr].find(rec2[iCntr].substr(rec2[iCntr].length() - RECDIF, rec2[iCntr].length()), 0);
		if(loc != string::npos){
			recStart = rec2[iCntr].length() - (loc + RECDIF + 35);
		}else{
			recStart = rec2[iCntr].length() - 38;
		}
		if(recStart > 0){
			pTail[iCntr] = rec2[iCntr].substr(recStart, 35);
		}else{
			for(jCntr = 0; jCntr < (recStart * -1); jCntr++){
				pTail[iCntr].insert(0, "N");
			}
			pTail[iCntr].insert(pTail[iCntr].length(), rec2[iCntr].substr(0, 35 + recStart));
		}
		procHeader(iCntr, recStart);
	}
}

// printTail Function
//
//
//***********************************************

void printTail(int x){
	cout << pTail[iCntr] << endl;
	fprintf (pFile, "%s\n", pTail[iCntr].c_str());
}

// printHeader Function
//
//
//***********************************************

void printHeader(int x){
	cout << header[iCntr] << endl;
	fprintf (pFile, "%s\n", header[iCntr].c_str());
}

// printRecs Function
//
//
//***********************************************

void printRecs(){
	for(iCntr = 0; iCntr < rMax; iCntr++){
		printHeader(iCntr);
		printTail(iCntr);
	}
}


// procHeader Function
//
//
//***********************************************

void procHeader(int x, int y){
	string buff;
	int num1, num2;
	loc = header[x].find("PromoterTail", 0);
	if(loc != string::npos){
		loc2 = header[x].find("|", loc);
		loc3 = header[x].find("..", loc2);
		loc4 = header[x].find(" ", loc3);
		buff = header[x].substr(loc2 + 1, loc3 - loc2 - 1);
		num1 = atoi(buff.c_str()) + y;
		num2 = num1 + 35;
		stringstream ss;
		ss << num1;
		ss >> buff;
		header[x].replace(loc2 + 1, loc3 - loc2 - 1, buff);
		stringstream ss1;
		ss1 << num2;
		ss1 >> buff;
		header[x].replace(loc3 + 1, loc4 - loc3 - 1, buff);
	}
}

