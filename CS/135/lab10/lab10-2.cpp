// Truman, Jacob
// CSC 135 - Lab Assignment 10-2
// Inputs: A date
// Outputs: The days number

#include <iostream>
using namespace std;

int days, month, year;
char ch;
void ddays(int, int, int);

int main(){

cout << "Enter a date (m-d-yy)" << endl;
cin >> month >> ch >> days >> ch >> year;
ddays(month, days, year);

}

void ddays(int m, int d, int y){
int mdays = 0, tdays = 0, ldays;

	if ((y % 4 == 0) && (y % 100 != 0)){
                ldays = 29;
	}else{
        	ldays = 28;
	}

	if (m == 2)
		mdays = 31;
	if (m == 3)
                mdays = 31 + ldays;
	if (m == 4)
                mdays = 62 + ldays;
	if (m == 5)
                mdays = 92 + ldays;
	if (m == 6)
                mdays = 123 + ldays;
	if (m == 7)
                mdays = 153 + ldays;
	if (m == 8)
                mdays = 184 + ldays;
	if (m == 9)
                mdays = 215 + ldays;
	if (m == 10)
                mdays = 245 + ldays;
	if (m == 11)
                mdays = 276 + ldays;
	if (m == 12)
                mdays = 306 + ldays;
tdays = d + mdays;
cout << "The day number is: " << tdays << endl;
}
