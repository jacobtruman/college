// Truman, Jacob
// CSC 135 - Exercise 2
// Inputs: 3 numbers input by the user. 
// Outputs: The x value(s) for the quadratic equation.

#include <iostream>
#include <iomanip>
using namespace std;

int main(){
	float a, b, c, d, x1, x2;
	cout << "Enter 3 numbers (a, b, c)" << endl;
	cout << "a=";
	cin >> a;
	cout << "b=";
	cin >> b;
	cout << "c=";
	cin >> c;
	if (a == 0){
		cout << "Error: coefficient 'a' must be nonzero" << endl;
		return 0;
	}
	cout << "Coefficients entered: a=" << a << " b=" << b << " c=" << c << endl;
	d = pow(b, 2) - 4 * a * c;
	if (d == 0){
		x1 = (-b) / 2 * a;
		cout << "One real solution: x1 = " << x1 << endl;
	}else if (d < 0){
		cout << "No real Solutions." << endl;
	}else if (d > 0){
		x1 = ((-b) + sqrt(d)) / (2 * a);
		x2 = ((-b) - sqrt(d)) / (2 * a);
		cout << "Two real Solutions: x1 = " << x1 << " x2 = " << x2 << endl;
	}
	return 0;
}

