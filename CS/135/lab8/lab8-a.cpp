// Truman, Jacob
// CSC 135 - Lab Assignment 8 - a
// Outputs: Prints out a checkerboard with one while loop.

#include <iostream>
using namespace std;

int i = 0;

int main(){

while(i < 8){
	if (i % 2 == 0){
		cout << "* * * * * * * * " << endl;
	}else{
		cout << " * * * * * * * *" << endl;
	}
i++;
}

return 0;
}
