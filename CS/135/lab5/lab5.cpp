// Truman, Jacob
// CSC 135 - Lab 5
// Inputs: 
// Outputs: 

#include <iostream>
#include <iomanip>
using namespace std;

int main(){
	int num1, num2, num3, num4, smallest, thrdsmallest, fail1, fail2, fail3, pass;
	cout << "Enter 4 numbers" << endl;
	cin >> num1;
	cin >> num2;
	cin >> num3;
	cin >> num4;
	if (num1 > num2){
		fail1 = num2;
		pass = num1;
	}else{
		fail1 = num1;
		pass = num2;
	}
	if (pass > num3){
		fail2 = num3;
	}else{
		fail2 = pass;
		pass = num3;
	}
	if (pass > num4){
		smallest = num4;
	}else{
		fail3 = pass;
		smallest = pass;
	}
	if (fail1 > fail2){
		fail1 = fail2;
		pass = fail1;
	}else{
		pass = fail2;
	}
	if (pass > fail3){
		thrdsmallest = fail3;
	}else{
		thrdsmallest = pass;
	}
	cout << "The 3rd smallest of your four numbers is: "<< thrdsmallest << endl;
	return 0;
}
