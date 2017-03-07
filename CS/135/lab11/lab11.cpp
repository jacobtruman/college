// Truman, Jacob
// CSC 135 - Lab Assignment 11
// Inputs: The number of integers to enter, then that number of integers
// Outputs: The frequency of each integer entered

#include <iostream>
#include <iomanip>
using namespace std;
void freq(int a[], int n);
int amt;

int main(){
	cout << "The amount of numbers you want to enter" << endl;
	cin >> amt;
	int a[100];
	cout << "Enter the first number" << endl;
	cin >> a[0];
	for (int i = 1; i < amt; i++){
		cout << "Enter the next number" << endl;
		cin >> a[i];
	}
	freq(a, amt);
}

void freq(int a[], int n){
	int num[1000] = {0};
	cout << "Integer     Frequency" << endl;
	
	for (int i = 0; i < n; i++){
		num[a[i]]++;
	}
	for (int i = 0; i < 1000; i++){
		if (num[i] != 0)
			cout << i << setw(12) << num[i] << endl;
	}
}
