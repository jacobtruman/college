// Truman, Jacob
// CSC 135 - Lab Assignment 8
// Inputs: 7 user entered digits
// Outputs: The second smallest and second largest numbers enterd

#include <iostream>
#include <fstream>
using namespace std;

void numCheck(int);
int i = 0, largest, slargest, smallest, ssmallest, num, num1, num2, num3, num4, num5, num6, num7;

int main(){
                                                                                                                                               
cout << "This program will ask you to enter 7 numbers" << endl;
cout << "Please enter a number" << endl;

cin >> num1;
largest = num1;
smallest = num1;

	while (i < 6){
		cout << "Please enter another number" << endl;
		cin >> num2;
		numCheck(num2);
		i++;
		cin >> num3;
		numCheck(num3);
		i++;
		cin >> num4;
		numCheck(num4);
		i++;
		cin >> num5;
		numCheck(num5);
		i++;
		cin >> num6;
		numCheck(num6);
		i++;
		cin >> num7;
		numCheck(num7);
		i++;
	}
cout << endl;
cout << "The Numbers Entered Are: " << num1 << ", " << num2 << ", " << num3 << ", " << num4 << ", " << num5 << ", " << num6 << ", " << num7 << endl;
cout << endl;
cout << "The Second Smallest Number Entered is: " << ssmallest << endl;
cout << endl;
cout << "The Second Largest Number Entered is: " << slargest << endl;

return 0;
}

void numCheck(int num){
	if (num > largest){
		slargest = largest;
		largest = num;
	}
	if (num < largest && num > slargest){
		slargest = num;
	}
	if (num < smallest){
		ssmallest = smallest;
		smallest = num;
	}
	if (num > smallest && num < ssmallest){
		ssmallest = num;
	}
cout << "Please enter another number" << endl;
}
