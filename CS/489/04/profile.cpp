// Jacob W. Truman
// CS489
//
// Assignment 4 Part 2
// Get Profile Matrix and Consensus Sequence
//*******************************************

// Includes
//*****************

#include <iostream>
#include <fstream>
#include <iomanip>
#include <string>
#include <sstream>

// Namespaces
//************

using namespace std;

// Definitions
//*****************

#define maxCol 15

// Globals
//*****************

int iCntr, jCntr, bCntr;
int bMatrix[4][30];
int bMax[30], bTot;
string cSeq;
char gLetters[] = {'A', 'C', 'G', 'T'};

// Function Prototypes
//**********************

void getBounds(const char* x);
void getSeq();
void printRecord(const char* x, const char* y);

// Main Function
//***************

int main(int argc, char **argv){
	string ofName;
	
	getBounds(argv[1]);
	getSeq();
	printRecord(argv[1], argv[2]);

	return 0;
}

// getBounds Function
//
// Gets intron-exon/intron-exon boundaries and put them
//  in a matrix
//
//******************************************************

void getBounds(const char* x){
	iCntr = 0;
	string line;
	ifstream myFile (x);
	if(myFile.is_open()){
		while(!myFile.eof()){
			iCntr++;
			getline (myFile,line);
			bCntr = 0;
			
			if(line[0] != '>'){
				for(jCntr = 0; jCntr < line.length(); jCntr++){
					switch(line[jCntr]){
						case 'A' : bMatrix[0][bCntr]++;
							break;
						case 'C' : bMatrix[1][bCntr]++;
							break;
						case 'G' : bMatrix[2][bCntr]++;
							break;
						case 'T' : bMatrix[3][bCntr]++;
							break;
						default : break;
					}
					bCntr++;
				}
				bTot++;
			}
		}
		myFile.close();
	}else{
		cout << "Unable to open file";
	}
}

// printRecord Function
//
// Prints a record with header to specified file
//
//***********************************************

void printRecord(const char* x, const char* y){
	FILE *fName;
	fName = fopen(y, "w");

	fprintf(fName, "File: %s\nProfile Matrix:\n ", x);
	for(iCntr = 0; iCntr < cSeq.length() / 2; iCntr++){
		fprintf(fName, "    %c", cSeq[iCntr]);
	}
	fprintf(fName, "\n");
	for(iCntr = 0; iCntr < 4; iCntr++){
		fprintf(fName, "%c:", gLetters[iCntr]);
		for(jCntr = 0; jCntr < cSeq.length() / 2; jCntr++){
			if(bMatrix[iCntr][jCntr] != 0){
				fprintf(fName, " .%i", bMatrix[iCntr][jCntr]);
			}else{
				fprintf(fName, " .000");
			}
		}
		fprintf(fName, "\n");
	}
	fprintf(fName, "\n ");
	for(iCntr = 15; iCntr < cSeq.length(); iCntr++){
		fprintf(fName, "    %c", cSeq[iCntr]);
	}
	fprintf(fName, "\n");
	for(iCntr = 0; iCntr < 4; iCntr++){
		fprintf(fName, "%c:", gLetters[iCntr]);
		for(jCntr = 15; jCntr < cSeq.length(); jCntr++){
			if(bMatrix[iCntr][jCntr] != 0){
				fprintf(fName, " .%i", bMatrix[iCntr][jCntr]);
			}else{
				fprintf(fName, " .000");
			}
		}
		fprintf(fName, "\n");
	}
	fprintf(fName, "\nConsensus Sequence: %s \n", cSeq.c_str());
	fclose(fName);
}


void getSeq(){
	double temp, tMax;
		
	for(iCntr = 0; iCntr < 30; iCntr++){
		temp = bMatrix[0][iCntr];
		tMax = int ((temp / bTot) * 1000);
		for(jCntr = 0; jCntr < 4; jCntr++){
			temp = bMatrix[jCntr][iCntr];
			bMatrix[jCntr][iCntr] = int ((temp / bTot) * 1000);
			if(bMatrix[jCntr][iCntr] > tMax){
				bMax[iCntr] = jCntr;
				tMax = bMatrix[jCntr][iCntr];
			}
		}
		switch(bMax[iCntr]){
			case 0 : cSeq.insert(cSeq.length(), "A");
				break;
			case 1 : cSeq.insert(cSeq.length(), "C");
				break;
			case 2 : cSeq.insert(cSeq.length(), "G");
				break;
			case 3 : cSeq.insert(cSeq.length(), "T");
				break;
			default : break;
		}
	}
}


