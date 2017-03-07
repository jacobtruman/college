// Truman, Jacob
// CSC 135 - Programming Assignment 3
// Inputs: Initials and test scores from file hw3.dat
// Outputs: Average scores for each student, number of students, number of error lines.

#include <iostream>
#include <iomanip>
#include <cctype>
#include <fstream>
using namespace std;

int main(){
	cout << "STUDENT  AVERAGE  GRADE" << endl;

	float score1, score2, score3, avg, highs = 0;
	char grd, finit, sinit, hfinit, hsinit;
	int nstud = 0, invd = -1;

	ifstream infile;
	infile.open ("data.dat");
	while (finit != '*'){
		infile >> finit;
		if (!isalpha(finit)){
			infile.ignore(15, '\n');
			invd++;
		}else{
			infile >> sinit >> score1 >> score2 >> score3;
			avg = (score1 + score2 + score3) / 3.0;
			if (avg > highs){
				highs = avg;
				hfinit = finit;
				hsinit = sinit;
			}
			if (avg >= 90){
				grd = 'A';
			}else if (avg >= 80){
				grd = 'B';
			}else if (avg >= 70){
				grd = 'C';
			}else if (avg >= 60){
				grd = 'D';
			}else{
				grd = 'F';
			}
			cout << fixed;
			cout << finit << sinit << setw(13) << setprecision(1) << avg << setw(6) << grd << endl;
			nstud++;
		}
	}
	cout << endl;
	cout << hfinit << hsinit << " had the highest average " << highs << endl;
	cout << "There are " << nstud << " students in the class." << endl;
	cout << invd << " invalid data lines were found." << endl;
	return 0;
}
