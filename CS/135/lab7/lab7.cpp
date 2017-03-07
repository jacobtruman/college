// Truman, Jacob
// CSC 135 - Lab Assignment 7
// Inputs:
// Outputs: 

#include <iostream>
#include <fstream>
using namespace std;

int main(){
	int score, count = 0, valid, sum = 0, i = 0, acnt = 0, bcnt = 0, ccnt = 0, dcnt = 0, fcnt = 0, ecnt = 0, asum = 0, bsum = 0, csum = 0, dsum = 0, fsum = 0;
	char ch;
	ifstream gradeFile;
	gradeFile.open("grades.txt");
	gradeFile >> ch >> score;

	while (count < 100){
		valid = 0;
		if ((ch == 'A') && (score >= 90)){ valid = 1; acnt++; asum = asum + score;}
		else if ((ch == 'B') && (score < 90) && (score >= 80)){ valid = 1; bcnt++; bsum = bsum + score;}
		else if ((ch == 'C') && (score < 80) && (score >= 70)){ valid = 1; ccnt++; csum = csum + score;}
		else if ((ch == 'D') && (score < 70) && (score >= 60)){ valid = 1; dcnt++; dsum = dsum + score;}
		else if ((ch == 'F') && (score < 60)){ valid = 1; fcnt++; fsum = fsum + score;}
		if ((score < 0) || (score > 100)) valid = 0; 
	
	if (valid){
		cout << score << " " << ch << endl;
		count++;
	}else{
	cout << "Error in Grade!" << endl;
	count++;
	ecnt++;
	}
	gradeFile >> ch >> score;
	if (ch == '*')
		break;
	}
	if (acnt != 0){
		cout << "There are " << acnt << " A's with an average score of " << (asum / acnt) << endl;
	}else{
		cout << "There are " << acnt << " A's" << endl;
	}
	if (bcnt != 0){
		cout << "There are " << bcnt << " B's with an average score of " << (bsum / bcnt) << endl;
	}else{
        	cout << "There are " << bcnt << " B's" << endl;
        }
	if (ccnt != 0){
		cout << "There are " << ccnt << " C's with an average score of " << (csum / ccnt) << endl;
	}else{
        	cout << "There are " << ccnt << " C's" << endl;
        }
	if (dcnt != 0){
		cout << "There are " << dcnt << " D's with an average score of " << (dsum / dcnt) << endl;
	}else{
        	cout << "There are " << ccnt << " C's" << endl;
        }
	if (fcnt != 0){
		cout << "There are " << fcnt << " F's with an average score of " << (fsum / fcnt) << endl;
	}else{
        	cout << "There are " << fcnt << " F's" << endl;
        }
	cout << "There are " << ecnt << " Errors" << endl;
}
