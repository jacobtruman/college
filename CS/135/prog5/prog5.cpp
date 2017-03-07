// Truman, Jacob
// CSC 135 - Programming Assignment 5
// Inputs: Year and day of week for Jan 1st
// Outputs: Calendar for that year.

#include <iostream>
#include <iomanip>
using namespace std;

bool leapyear(int);
int lastDay(int, int);
void pweek();
void pyear(int, int);
int year, day;

int main(){
	cout << "Enter the year you would like the calendar for" << endl;
	cin >> year;
	cout << "Enter the day of the week that Jan 1st falls on" << endl;
	cin >> day;
	pyear(day, year);
	cout << endl;
}

void pyear(int d,int y){
	int lday, bday = d;
	for (int i = 0; i <= 11; i++){
		cout << endl;
		switch(i){
			case 0: cout << "       January" << endl; break;
			case 1: cout << "      February" << endl; break;
			case 2: cout << "        March" << endl; break;
			case 3: cout << "        April" << endl; break;
			case 4: cout << "         May" << endl; break;
			case 5: cout << "         June" << endl; break;
			case 6: cout << "         July" << endl; break;
			case 7: cout << "        August" << endl; break;
			case 8: cout << "       September" << endl; break;
			case 9: cout << "        October" << endl; break;
			case 10: cout << "       November" << endl; break;
			case 11: cout << "       December" << endl; break;
		}
		pweek();
		lday = lastDay(i, y);
		int l = 1, m = 0;
		while (l <= lday){
			for (int k = 0; k < bday; k++){
				cout << "   ";
			}
			for (int m = bday; m < 7; m++){
				if (l <= 9){
					cout << " " << l++ << " ";
				}else if ((l > 9) && (l <= lday)){
					cout << l++ << " ";
				}else{
					bday = m;
					break;
				}	
			}
			if (l > lday){
			}else{
				bday = 0;
			}
			cout << endl;
		}
	}
}

void pweek(){
	cout << " S  M  T  W  T  F  S" << endl;
}

bool leapyear(int y){
	if ((((y % 4) == 0) && ((y % 100) != 0)) || ((y % 400) == 0))
		return true;
	else
		return false;
}

int lastDay(int m, int y){
	switch(m){
		case 1: if (leapyear(y))
					return 29;
				else
					return 28;
		case 3: return 30;
		case 5: return 30;
		case 8: return 30;
		case 10: return 30;
		default: return 31;
	}
}
