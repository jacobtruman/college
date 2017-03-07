// Truman, Jacob
// CSC 135 - Lab Assignment 7 - a
// Inputs: 7 user entered digits
// Outputs: The second smallest and second largest numbers enterd

#include <iostream>
using namespace std;

int i, largest, slargest, smallest, ssmallest, num;

int main(){
                                                                                                                                               
cout << "This program will ask you to enter 7 numbers" << endl;
cout << "Please enter a number" << endl;

cin >> largest;
smallest = largest;
ssmallest = 120000;
slargest = -120000;

for (i = 0; i < 6; i++){
	cout << "Please enter another number" << endl;
	cin >> num;
	if (num > largest){
		slargest = largest;
		largest = num;
	}else if (num > slargest){
		slargest = num;
	}
	if (num < smallest){
		ssmallest = smallest;
		smallest = num;
	}else if (num < ssmallest){
		ssmallest = num;
	}
}
cout << "The Second Smallest Number Entered is: " << ssmallest << endl;
cout << "The Second Largest Number Entered is: " << slargest << endl;

return 0;
}
