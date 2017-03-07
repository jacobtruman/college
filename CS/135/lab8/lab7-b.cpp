// Truman, Jacob
// CSC 135 - Lab Assignment 7 - b
// Inputs: 1 number entered
// Outputs: Determines if number is prime or not

#include <iostream>
using namespace std;

int i, num, nump = 1;

int main(){
                                                                                                                                               
cout << "Please enter a number" << endl;

cin >> num;

for (i = 2; i < num; i++)
  {
	if (num % i == 0){
		nump = 0;
	}
}
if (nump == 0){
	cout << "The number " << num << " is not prime" << endl;
}else{
	cout << "The number " << num << " is prime" << endl;
}

return 0;
}
