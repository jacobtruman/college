// Jacob W. Truman
// CS 489
// 
// Count all base types and dimers
//*********************************

// Includes
//*****************

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

// Globals
//*****************

char* uArgs[32];
char* inBuff;
int argCnt;
int iCntr;
double total;
double dtotal;
char gLetter[] = {'-', 'A', 'C', 'G', 'T', 'K', 'M', 'R', 'Y', 'S', 'W', 'B', 'D', 'H', 'V', 'N'};
int gCode[16][16];

// Function Prototypes
//**********************

void readFile(char *fName);
void writeFile(char *fName);
void getDimer(char gc, char cc, int ci, char pch);

// main Function
//*****************

int main(int argsc, char *argv[], char *envp[]){

	readFile(argv[1]);
	writeFile(argv[2]);

}

// readFile Function
//
// Read single file's contents
//*****************************

void readFile(char *fName){

	FILE *fRp;
	fRp = fopen(fName, "r");
	int i, j;
	char ch[200];
	char pch;
	
	while(fgets(ch, 200, fRp) != NULL){
		if (ch[0] != '>'){
			for(i = 0; i < strlen(ch); i++){
				total++;
				switch(toupper(ch[i])){
					case 'A': gCode[0][1]++;
					break;
					case 'C': gCode[0][2]++;
					break;
					case 'G': gCode[0][3]++;
					break;
					case 'T': gCode[0][4]++;
					break;
					case 'K': gCode[0][5]++;
					break;
					case 'M': gCode[0][6]++;
					break;
					case 'R': gCode[0][7]++;
					break;
					case 'Y': gCode[0][8]++;
					break;
					case 'S': gCode[0][9]++;
					break;
					case 'W': gCode[0][10]++;
					break;
					case 'B': gCode[0][11]++;
					break;
					case 'D': gCode[0][12]++;
					break;
					case 'H': gCode[0][13]++;
					break;
					case 'V': gCode[0][14]++;
					break;
					case 'N': gCode[0][15]++;
					break;
					case '\n': break;
					default: //gCode[0][0]++;
					break;
				}
				
				for(j = 0; j <= 15; j++){
					getDimer(gLetter[j], ch[i], j, pch);
				}
				
				if(ch[i] != '\n'){
					pch = ch[i];
				}
			}
		}
	}

	fclose(fRp);

}

// writeFile Function
//
// Write buffer contents to file
//*******************************

void writeFile(char *fName){

	FILE *fWp;
	fWp = fopen(fName, "w");
	int i, j, k;
	float x = 1;
	char perc = '%';
	float avg;

	for(i = 0; i <= 15; i++){
		avg = gCode[0][i] / total;
		fprintf(fWp, "%c's: %9.0f  %0.7f\n", gLetter[i], gCode[0][i] * x, avg);
	}
	
	fprintf(fWp, "Total: %9.0f\nAverage should be: 0.2500000", total);
	
	fprintf(fWp, "\n");
	k = 0;
	
	while(k < 16){
		fprintf(fWp, "\n1/2         ");
		for(i = 0; i < 4; i++){
			fprintf(fWp, "%c  %c              ", gLetter[i + k], perc);
		}
		fprintf(fWp, "\n");
		for(i = 0; i < 75; i++){
			fprintf(fWp, "-");
		}
		fprintf(fWp, "\n");

		for(i = 0; i <= 15; i++){
			fprintf(fWp, "%c:   ", gLetter[i]);
			for(j = 0; j < 4; j++){
				avg = gCode[j + k][i] / dtotal;
				fprintf(fWp, "%9.0f %1.4f  ", gCode[j + k][i] * x, avg);
			}
			fprintf(fWp, "\n");
		}
		k += 4;
	}
	fprintf(fWp, "Total: %9.0f\nAverage should be: 0.0625000", dtotal);
	fclose(fWp);
}

void getDimer(char gc, char cc, int ci, char pch){
	if(toupper(cc) == gc){
		dtotal++;
		switch(toupper(pch)){
			case 'A': gCode[ci][1]++;
			break;
			case 'C': gCode[ci][2]++;
			break;
			case 'G': gCode[ci][3]++;
			break;
			case 'T': gCode[ci][4]++;
			break;
			case 'K': gCode[ci][5]++;
			break;
			case 'M': gCode[ci][6]++;
			break;
			case 'R': gCode[ci][7]++;
			break;
			case 'Y': gCode[ci][8]++;
			break;
			case 'S': gCode[ci][9]++;
			break;
			case 'W': gCode[ci][10]++;
			break;
			case 'B': gCode[ci][11]++;
			break;
			case 'D': gCode[ci][12]++;
			break;
			case 'H': gCode[ci][13]++;
			break;
			case 'V': gCode[ci][14]++;
			break;
			case 'N': gCode[ci][15]++;
			break;
			case '\n': break;
			default: //gCode[ci][0]++;
			break;
		}
	}
}
