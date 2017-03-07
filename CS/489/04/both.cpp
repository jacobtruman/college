// Jacob W. Truman
// CS489
//
// Assignment 4 Part 1
// Get Intron-Exon / Exon-Intron Boundaries
//******************************************

// Includes
//*****************

#include <iostream>
#include <fstream>
#include <string>
#include <sstream>

// Namespaces
//************

using namespace std;

// Definitions
//*****************

#define maxBound 15

// Globals
//*****************

int iCntr, jCntr, hCntr, hLen[10], fhLen[10], fhLen2[10];;
string newLine, prevline, prevline2, rec1, rec2, rec3, rec4, header1, header2;
bool flag = 0, flag2 = 0;

// Function Prototypes
//**********************

void getIntrons(char* x, string y);
void getExons(char* x, string y);
void getPrev(string x, string y, string& rec);
void findBorder(string x, string y, string z, int& Cntr);
void getHeader(string x, string& y);
void procHeader(string& x, string& y);
void printRecord(const char* v, string w, string x, string y, int* z);

// Main Function
//***************

int main(int argc, char **argv){
	string chrom = argv[3], ofName;
	chrom.erase (0,3);
	chrom.insert (0,"Os");

	getIntrons(argv[2], chrom);
	getExons(argv[1], chrom);

	// Intron Beginnings: rec1
	// Intron Endings: rec2
	// Exon Endings: rec3
	// Exon Beginnings: rec4

	procHeader(header1, header2);

	ofName = ".intron-exon";
	ofName.insert(0, argv[3]);
	printRecord(ofName.c_str(), rec2, rec4, header2, fhLen);

	ofName = ".exon-intron";
	ofName.insert(0, argv[3]);
	printRecord(ofName.c_str(), rec3, rec1, header1, fhLen2);

	return 0;
}

// getPrev Function
//
// Gets the two lines previous to gene header to
//  handle the case where the last line of the
//  intron record is less than 15 chars long, and
//  inserts the last 15 chars to the specified
//  variable
//
//*************************************************

void getPrev(string x, string y, string& rec){
	string temp;
	x.insert(0, y);
	temp = x.substr(x.length() - maxBound, maxBound);
	rec.insert(rec.length(), temp);
}

// getIntrons Function
//
// Gets 15 chars at the beginning and end of
//  each of the introns of the specified chromosome.
//
//***************************************************

void getIntrons(char* x, string chrom){
	iCntr = 0;
	string line;
	ifstream myfile (x);
	if(myfile.is_open()){
		while(!myfile.eof()){
			iCntr++;
			getline (myfile,line);

			if(flag == 1){
				rec1.insert(rec1.length(), line.substr(0, maxBound));
				flag = 0;
			}

			if(line[0] == '>'){
				string::size_type loc = line.find(chrom, 0);
				if(loc != string::npos){
					getHeader(line, header1);
					flag = 1;
					flag2 = 1;
				}else{
					flag2 = 0;
				}
			}
			
			if((flag2 == 1) && (flag != 1)){
				prevline2 = prevline;
				prevline = line;
			}
			
			if((flag == 1) && (prevline.length() > 0)){
				getPrev(prevline, prevline2, rec2);
			}
		}
		myfile.close();
		getPrev(prevline, prevline2, rec2);
	}else{
		cout << "Unable to open file";
	}
}

// getExons Function
//
// Gets 15 chars at the beginning and end of
//  each of the Exons of the specified chromosome.
//
//***************************************************

void getExons(char* x, string chrom){
	int recCnt = rec1.length() / maxBound, bCntr = 0, eCntr = 0;
	iCntr = 0;
	flag = 0;
	string line, fbInt, feInt;;
	ifstream myfile (x);
	if(myfile.is_open()){
		while(!myfile.eof()){
			iCntr++;
			getline (myfile,line);

			if((flag == 1) && (line[0] != '>')){
				fbInt = rec1.substr(bCntr * maxBound, maxBound);
				feInt = rec2.substr(eCntr * maxBound, maxBound);
				prevline2 = prevline;
				prevline = line;
				newLine = prevline;
				newLine.insert(0, prevline2);

				if(bCntr != recCnt){
					findBorder(newLine, fbInt, "beginning", bCntr);
				}
				if(eCntr != recCnt){
					findBorder(newLine, feInt, "ending", eCntr);
				}
			}

			if(line[0] == '>'){
				string::size_type loc = line.find(chrom, 0);
				if(loc != string::npos){
					getHeader(line, header2);
					flag = 1;
				}else{
					flag = 0;
				}
			}
		}
		myfile.close();
	}else{
		cout << "Unable to open file";
	}
}

// findBorder Function
//
// Finds the intron-exon/exon-intron border
//  and assigns the 15 chars of the exon to
//  specified variable
//******************************************

void findBorder(string x, string y, string z, int& Cntr){
	string::size_type intLoc = x.find(y, 0);
	if(intLoc != string::npos){
		if(z == "beginning"){
			if(intLoc >= 30){
				rec3.insert(Cntr * 15, x.substr(intLoc - maxBound, maxBound));
				Cntr++;
			}
		}else if(z == "ending"){
			if(intLoc < newLine.length() - 15){
				rec4.insert(Cntr * 15, x.substr(intLoc + 15, maxBound));
				Cntr++;
			}
		}
	}
}

// getHeader Function
//
// Gets the header
//
//*************************

void getHeader(string x, string& y){
	hLen[hCntr++] = x.length();
	y.insert(y.length(), x);
}

// procHeader Function
//
// Generate new header based on headers
//  from the 2 files used
//
//**************************************

void procHeader(string& x, string& y){
	string temp, hTemp, hTemp2, tuNum;
	int gNum;
	string::size_type loc;
	
	loc = y.find(".t", 0);
	if(loc != string::npos){
		y.erase(0, loc);
	}
	loc = y.find("|", 0);
	if(loc != string::npos){
		tuNum = y.substr(0, loc);
	}
	y.erase (0, y.length());

	for(iCntr = 0; iCntr < hCntr - 1; iCntr++){
		temp = x.substr(0, hLen[iCntr]);
		loc = temp.find(".", 0);
		if(loc != string::npos){
			hTemp.insert(hTemp.length(), temp.substr(0, loc));
			hTemp2.insert(hTemp2.length(), temp.substr(0, loc));
			temp.erase(0, loc);
		}

		loc = temp.find("|", 0);
		if(loc != string::npos){
			temp.erase(0, loc - 1);
		}

		loc = temp.find(".", 0);
		if(loc != string::npos){
			hTemp.insert(hTemp.length(), temp.substr(0, loc));
			hTemp2.insert(hTemp2.length(), temp.substr(0, loc));
			temp.erase(0, loc);
		}

		hTemp.insert(hTemp.length(), tuNum);
		hTemp2.insert(hTemp2.length(), tuNum);

		loc = temp.find("|", 0);
		if(loc != string::npos){
			hTemp.insert(hTemp.length(), temp.substr(0, loc + 1));
			hTemp2.insert(hTemp2.length(), temp.substr(0, loc + 1));
			temp.erase(0, loc + 1);
		}

		loc = temp.find("_", 0);
		if(loc != string::npos){
			temp.erase(0, loc + 1);
		}

		hTemp.insert(hTemp.length(), "exon_");
		hTemp.insert(hTemp.length(), temp);
		hTemp.insert(hTemp.length(), "-intron_");
		hTemp.insert(hTemp.length(), temp);
		hTemp.insert(hTemp.length(), " unspliced-genomic hypothetical protein");

		hTemp2.insert(hTemp2.length(), "intron_");
		hTemp2.insert(hTemp2.length(), temp);
		hTemp2.insert(hTemp2.length(), "-exon_");
			gNum = atoi(temp.c_str());
			gNum++;
			stringstream ss;
			ss << gNum;
			ss >> temp;
		hTemp2.insert(hTemp2.length(), temp);
		hTemp2.insert(hTemp2.length(), " unspliced-genomic hypothetical protein");
		x.erase (0, hLen[iCntr]);
		fhLen[iCntr] = hTemp.length();
		fhLen2[iCntr] = hTemp2.length();
	}
	x = hTemp;
	y = hTemp2;
}

// printRecord Function
//
// Prints a record with header to specified file
//
//***********************************************

void printRecord(const char* v, string w, string x, string y, int* z){
	string buffer;
	for(iCntr = 0; iCntr < w.length() / maxBound; iCntr++){
		buffer.insert(buffer.length(), y.substr(z[iCntr - 1], z[iCntr] - z[iCntr - 1]));
		buffer.insert(buffer.length(), "\n");
		buffer.insert(buffer.length(), w.substr(iCntr * maxBound, maxBound));
		buffer.insert(buffer.length(), x.substr(iCntr * maxBound, maxBound));
		buffer.insert(buffer.length(), "\n");
	}
	ofstream myFile (v);
	myFile.write(buffer.c_str(), buffer.size());
	myFile.close();
}
