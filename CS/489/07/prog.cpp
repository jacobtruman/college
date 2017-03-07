// Jacob W. Truman
// CS489
//
// Assignment 7
//**************

//
// Includes
//**********

#include <iostream>
#include <fstream>
#include <string>
#include <sstream>
#include <stdio.h>

//
// Namespaces
//************

using namespace std;

//
// Definitions
//*************

#define MAXREC 30

//
// Globals
//*********

int iCntr, jCntr, rCntr, tCntr;
string rec1[MAXREC], rec2[MAXREC], header[MAXREC];
int* recScores;
string::size_type loc;
FILE * pFile;

//
// Function Prototypes
//*********************

void getAll(char* x, string* y);
void getAminoAcids(string* x, string* y);
void getScore(string* x);
void getAlign(string* x);
void printHeader(int x);
void printRecs();

//
// Main Function
//***************

int main(int argc, char **argv){
	getAll(argv[1], rec1);
	getAminoAcids(rec1, rec2);

	pFile = fopen (argv[2],"w");
		printRecs();
	fclose (pFile);

	return 0;
}

//
// getAll Function
//*****************

void getAll(char* x, string* y){
	iCntr = 0;
	rCntr = -1;
	string line;
	ifstream myfile (x);
	if(myfile.is_open()){
		while(!myfile.eof()){
			iCntr++;
			getline (myfile,line);

			if(line[0] != '>'){
				for (int i = 0; i < line.length(); i++){
					line[i] = toupper(line[i]);
				}
				y[rCntr].insert(y[rCntr].length(), line);
			}

			if(line[0] == '>'){
				rCntr++;
				header[rCntr] = line;
			}
		}

		myfile.close();
	}else{
		cout << "Unable to open file" << endl;
	}
	
}

//
// getAminoAcids Function
//************************

void getAminoAcids(string* x, string* y){
	int rLen;
	char temp[3];
	
	for(iCntr = 0; iCntr < rCntr; iCntr++){
		rLen = x[iCntr].length();
		jCntr = 0;
		for(jCntr = 0; jCntr < rLen; jCntr += 3){
			temp[0] = x[iCntr][jCntr];
			temp[1] = x[iCntr][jCntr + 1];
			temp[2] = x[iCntr][jCntr + 2];
			if((temp[0] == 'A') && (temp[1] == 'T') && (temp[2] == 'G')){
				y[iCntr].insert(y[iCntr].length(), "M");
			}else if((temp[0] == 'T') && (temp[1] == 'T') && (temp[2] == 'G')){
				y[iCntr].insert(y[iCntr].length(), "W");
			}else if((temp[0] == 'C') && (temp[1] == 'A') && ((temp[2] == 'T') || (temp[2] == 'C'))){
				y[iCntr].insert(y[iCntr].length(), "H");
			}else if((temp[0] == 'T') && (temp[1] == 'A') && ((temp[2] == 'T') || (temp[2] == 'C'))){
				y[iCntr].insert(y[iCntr].length(), "Y");
			}else if((temp[0] == 'A') && (temp[1] == 'A') && ((temp[2] == 'T') || (temp[2] == 'C'))){
				y[iCntr].insert(y[iCntr].length(), "N");
			}else if((temp[0] == 'A') && (temp[1] == 'A') && ((temp[2] == 'A') || (temp[2] == 'G'))){
				y[iCntr].insert(y[iCntr].length(), "K");
			}else if((temp[0] == 'G') && (temp[1] == 'A') && ((temp[2] == 'T') || (temp[2] == 'C'))){
				y[iCntr].insert(y[iCntr].length(), "D");
			}else if((temp[0] == 'T') && (temp[1] == 'T') && ((temp[2] == 'T') || (temp[2] == 'C'))){
				y[iCntr].insert(y[iCntr].length(), "F");
			}else if((temp[0] == 'T') && (temp[1] == 'G') && ((temp[2] == 'T') || (temp[2] == 'C'))){
				y[iCntr].insert(y[iCntr].length(), "C");
			}else if((temp[0] == 'C') && (temp[1] == 'A') && ((temp[2] == 'C') || (temp[2] == 'G'))){
				y[iCntr].insert(y[iCntr].length(), "Q");
			}else if((temp[0] == 'G') && (temp[1] == 'A') && ((temp[2] == 'A') || (temp[2] == 'G'))){
				y[iCntr].insert(y[iCntr].length(), "E");
			}else if((temp[0] == 'A') && (temp[1] == 'T') && ((temp[2] == 'T') || (temp[2] == 'C') || (temp[2] == 'A'))){
				y[iCntr].insert(y[iCntr].length(), "I");
			}else if((temp[0] == 'T') && ((temp[1] == 'A') && (temp[2] == 'G')) || ((temp[1] == 'A') || (temp[2] == 'A')) || ((temp[1] == 'G') || (temp[2] == 'A'))){
				y[iCntr].insert(y[iCntr].length(), "Z");
			}else if((temp[0] == 'C') && (temp[1] == 'C') && ((temp[2] == 'T') || (temp[2] == 'C') || (temp[2] == 'A') || (temp[2] == 'G'))){
				y[iCntr].insert(y[iCntr].length(), "P");
			}else if((temp[0] == 'A') && (temp[1] == 'C') && ((temp[2] == 'T') || (temp[2] == 'C') || (temp[2] == 'A') || (temp[2] == 'G'))){
				y[iCntr].insert(y[iCntr].length(), "T");
			}else if((temp[0] == 'G') && (temp[1] == 'G') && ((temp[2] == 'T') || (temp[2] == 'C') || (temp[2] == 'A') || (temp[2] == 'G'))){
				y[iCntr].insert(y[iCntr].length(), "G");
			}else if((temp[0] == 'G') && (temp[1] == 'T') && ((temp[2] == 'T') || (temp[2] == 'C') || (temp[2] == 'A') || (temp[2] == 'G'))){
				y[iCntr].insert(y[iCntr].length(), "V");
			}else if((temp[1] == 'T') && (((temp[0] == 'T') && ((temp[2] == 'A') || (temp[2] == 'G'))) || ((temp[0] == 'C') && ((temp[2] == 'T') || (temp[2] == 'C') || (temp[2] == 'A') || (temp[2] == 'G'))))){
				y[iCntr].insert(y[iCntr].length(), "L");
			}else if(((temp[0] == 'T') && (temp[1] == 'C') && ((temp[2] == 'T') || (temp[2] == 'C') || (temp[2] == 'A') || (temp[2] == 'G'))) || ((temp[0] == 'A') && (temp[1] == 'G') && ((temp[2] == 'T') || (temp[2] == 'C')))){
				y[iCntr].insert(y[iCntr].length(), "S");
			}else if(((temp[0] == 'G') && (temp[1] == 'C') && ((temp[2] == 'T') || (temp[2] == 'C') || (temp[2] == 'A') || (temp[2] == 'G')))){
				y[iCntr].insert(y[iCntr].length(), "A");
			}else if((temp[1] == 'G') && ((temp[0] == 'C') && ((temp[2] == 'T') || (temp[2] == 'C') || (temp[2] == 'A') || (temp[2] == 'G')) || ((temp[0] == 'A') && ((temp[2] == 'A') || (temp[2] == 'G'))))){
				y[iCntr].insert(y[iCntr].length(), "R");
			}
		}
	}

}

//
// getScore Function
//*******************

void getScore(string* x){

}

//
// getAlign Function
//*******************

void getAlign(string* x){
	string aTemp;
	tCntr = 0;
	iCntr = 0;
	jCntr = 0;
	while(iCntr < x[0].length()){
		while(jCntr < x[1].length()){
			if(x[0][iCntr] == x[1][jCntr]){
				aTemp[tCntr] = x[0][iCntr];
				iCntr++;
				jCntr++;
				tCntr++;
			}else if(iCntr > jCntr){
				aTemp[tCntr] = x[1][jCntr];
				jCntr++;
				tCntr++;
			}else{
				aTemp[tCntr] = x[0][iCntr];
				iCntr++;
				tCntr++;
			}
		}
		cout << tCntr << endl;
	}
	cout << aTemp << endl;
}

// printRecs Function
//
//
//***********************************************

void printRecs(){
	for(iCntr = 0; iCntr < rCntr; iCntr++){
		fprintf (pFile, "%s\n%s\n", header[iCntr].c_str(), rec2[iCntr].c_str());
	}
}

