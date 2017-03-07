// Truman, Jacob
// CSC 135 - Lab Assignment 6
// Inputs: Number to specify amount of numbers entered, nunbers.
// Outputs: The sum and average of the numbers entered.

#include <iostream>
#include <iomanip>
using namespace std;

int main(){
	int num, amt, sum = 0, i = 1, avg;
	cout << "Enter the amount of numbers you would like to enter" << endl;
	cin >> amt;
	while (i <= amt){
		cout << "Enter your number " << i << endl;
		cin >> num;
		sum = num + sum;
		i++;
	}
	avg = sum / amt;
	cout << "The sum of these " << amt << " numbers is " << sum << endl;
	cout << "The average of these " << amt << " numbers is " << avg << endl;
	return 0;
}
