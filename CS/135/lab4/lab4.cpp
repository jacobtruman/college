// Truman, Jacob
// CSC 135 - Lab 4
// Inputs: 
// Outputs: 

#include <iostream>
#include <iomanip>
using namespace std;

int main(){
	string name, name1, name2, name3;
	int age, age1, age2, age3, avage, i = 0, tota = 0;
	double sal, sal1, sal2, sal3, avsal, tots = 0;

	while (i < 3){
		cout << "Enter your first name" << endl;
		cin >> name;
		cout << "Enter your age" << endl;
		cin >> age;
		cout << "Enter your salary" << endl;
		cin >> sal;
		if (i == 0){
			name1 = name;
			age1 = age;
			sal1 = sal;
		}else if (i == 1){
			name2 = name;
			age2 = age;
			sal2 = sal;
		}else if (i == 2){
			name3 = name;
			age3 = age;
			sal3 = sal;
		}
		tota = tota + age;
		tots = tots + sal;
		i++;
	}
	avage = tota / 3;
	avsal = tots / 3.0;
	cout << fixed << showpoint;
	cout << "Record Number 1 is: Name: " << setw(10) << name1 << ", Age: " << setw(3) << age1 << ", Salary: " << setw(9) << setprecision(2) << sal1 << endl;
	cout << "Record Number 2 is: Name: " << setw(10) << name2 << ", Age: " << setw(3) << age2 << ", Salary: " << setw(9)
<< setprecision(2) << sal2 << endl;
	cout << "Record Number 3 is: Name: " << setw(10) << name3 << ", Age: " << setw(3) << age3 << ", Salary: " << setw(9)
<< setprecision(2) << sal3 << endl;
	cout << "" << endl;
	cout << "Average Salary is: " << setw(7) << setprecision(2) << avsal << endl;
	cout << "Average Age is: " << avage << endl;
	return 0;
}
