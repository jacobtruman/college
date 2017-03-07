// Truman, Jacob
// CSC 135 - Lab Assignment 9
// Inputs: 3 integers
// Outputs: Min, Max, Average, if all are even, if it could be a traingle

#include <iostream>
using namespace std;

int max(int, int, int);
int min(int, int, int);
int allEven(int, int, int);
int triangleInequality(int, int, int);
float average(int, int, int);

int main(){

	int a, b, c;
	cout << "Enter three integers  " << endl;
	cin >> a >> b >> c;
	cout << "The three numbers are: " << a << " " << b << " " << c << endl;
	cout << "Minimum: " << min(a, b, c) << endl;
	cout << "Maximum: " << max(a, b, c) << endl;
	cout << "All even: ";
	if (allEven(a, b, c) == 0)
	cout << "NO";
	else
	cout << "YES";
	cout << endl;
	cout << "Average: " << average(a, b, c) << endl;
	cout << "Triangle Inequality: ";
	if (triangleInequality(a, b, c) == 0)
	cout << "NO";
	else
	cout << "YES";
	cout << endl;
}

int max(int x, int y, int z){
	int max = x;
	if (max < y) max = y;
	if (max < z) max = z;
	return max;
}

float average(int x, int y, int z){
	float av = (x + y + z) / 3.0;
	return av;
}

int min(int x, int y, int z){
	int min = x;
	if (min > y) min = y;
	if (min > z) min = z;
	return min;
}

int allEven(int x, int y, int z){
	int num = 1;
	if (x % 2 != 0){
		num = 0;
	}
	if (y % 2 != 0){
		num = 0;
	}
	if (z % 2 != 0){
		num = 0;
	}
	return num;
}

int triangleInequality(int x, int y, int z){
	int num = 0;
	if (((x + y) >= z) && ((x + z) >= y) && ((y + z) >= x)){
		num = 1;
	}
	return num;
}
