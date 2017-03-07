// Truman, Jacob
// CSC 135 - Programming Assignment 5
// Inputs: Year and day of week for Jan 1st
// Outputs: Calendar for that year.

#include <iostream>
#include <iomanip>
using namespace std;

bool leapyear(int); // Function to determine leap year.
int lastDay(int, int); // Function to determine last day of month.
void pweek(); // Function to print the days of the week header.
void pyear(int, int); // Function to print the months of the year
int year, day; // day and year variables.

int main(){
	cout << "Enter the year you would like the calendar for" << endl; // Prompt for the year.
	cin >> year; // Input the year.
	cout << "Enter the day of the week that Jan 1st falls on" << endl; // Prompt for the day
	cin >> day; // Input the day of week that Jan 1st falls on.
	pyear(day, year); // Call the pyear function.
	cout << endl; // New line.
}

void pyear(int d,int y){
	int lday, bday = d; // Variable for the last day of the month.
	for (int i = 0; i <= 11; i++){ // The loop for the months of the year.
		cout << endl; // New line.
		switch(i){ // Switch statment to print the month name header.
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
		} // End switch statement.
		pweek(); // Call pweek function to print days of week header.
		lday = lastDay(i, y); // Determine and set the last day of the month.
		int l = 1, m = 0; // Declare and initialize the l, m and bday variables.
		while (l <= lday){ // The loop for days within the month.
			for (int k = 0; k < bday; k++){ // Loop to place the first day of the month on the correct day of week.
				cout << "   ";
			}
			for (int m = bday; m < 7; m++){ // Loop to place each day of the week in the correct postion under the header.
				if (l <= 9){ // Determine if the current day of the week in the loop is single digit.
					cout << " " << l++ << " "; // Print the single digit days of the week.
				}else if ((l > 9) && (l <= lday)){ // Determine if the current day in the loop is double digit.
					cout << l++ << " "; // Print the double digit days of the week.
				}else{
					bday = m; // Set the beginning day of the first week of the next month in the loop.
					break;
				}
			}
			if (l > lday){ // Determine if the current day in the loop is within the month.
			}else{
				bday = 0; // Reset the beginning day of week while in the loop.
			}
			cout << endl;
		}
	}
}

void pweek(){
	cout << " S  M  T  W  T  F  S" << endl; // Print the days of the week header.
}

bool leapyear(int y){
	if ((((y % 4) == 0) && ((y % 100) != 0)) || ((y % 400) == 0)) // determines if the year is a leap year.
		return true;
	else
		return false;
}

int lastDay(int m, int y){
	switch(m){ // Switch statement to set the last day of the current month in the loop.
		case 1: if (leapyear(y))
					return 29;
				else
					return 28;
		case 3: return 30;
		case 5: return 30;
		case 8: return 30;
		case 10: return 30;
		default: return 31; // The default value.
	}
}
