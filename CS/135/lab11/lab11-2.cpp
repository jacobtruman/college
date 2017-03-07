// Truman, Jacob
// CSC 135 - Lab Assignment 11-2
// Inputs: None
// Outputs: The first 4 Perfect integers

#include <iostream>
#include <iomanip>
using namespace std;
int num, i, sum = 0, num2 = 0;

int main(){
	cout << endl;
	for (num = 1; num2 < 4; num++){
		for (i = 1; i < num; i++){
			if ((num % i) == 0){
				sum = sum + i;
			}
		}
		if (sum == num){
			cout << sum << " is a perfect integer" <<  endl;
			num2++;
		}
	sum = 0;
	}
	cout << endl;
}
