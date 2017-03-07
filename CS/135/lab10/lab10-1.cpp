// Truman, Jacob
// CSC 135 - Lab Assignment 10-1
// Inputs: 3 integers
// Outputs: Triangle Shape

#include <iostream>
using namespace std;

enum triangleType{scalene, isoceles, equalateral, notriangle};
triangleType triangleShape(int, int, int);
void printShape();
triangleType tshape;

int main(){

	int a, b, c;
	cout << "Enter three integers  " << endl;
	cin >> a >> b >> c;
	cout << "Triangle Shape: ";
	triangleShape(a, b, c);
	printShape();
	cout << endl;
}

triangleType triangleShape(int x, int y, int z){
	if (((x + y) < z) || ((x + z) < y) || ((y + z) < x)){
                tshape = notriangle;	
	}else if ((x == y) && (x == z)){
		tshape = equalateral;
	}else if ((x == y) || (x == z) || (y == z)){
		tshape = isoceles;
	}else{
		tshape = scalene;
	}
}

void printShape(){
	switch(tshape){
		case scalene: cout << "Scalene"; break;
		case isoceles: cout << "Isoceles"; break;
		case equalateral: cout << "Equalateral"; break;
		case notriangle: cout << "No Triangle"; break;
	}
}
