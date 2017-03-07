// Truman, Jacob
// CSC 135 - Lab Assignment 8 - b
// Outputs: Prints out a checkerboard with nested while loops.

#include <iostream>
using namespace std;

int i = 0, j = 0;

int main(){

while(i < 8){
	if (i % 2 == 0){
	}else{
	cout << " ";
	}
	while(j < 8){
		cout << "* ";
	j++;
	}
	cout << endl;
j = 0;
i++;
}

return 0;
}
