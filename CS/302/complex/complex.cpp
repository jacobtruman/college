// Program Written By:  Jacob Truman
// CS 302 Section 002

#include <iostream>
#include <fstream>
#include "complex.h"
using namespace std;
complex cpow(float, complex&);
ofstream outfile;

int main(){
	complex x(3, 2);
	complex ans;

	outfile.open("complex.txt");
	ans = (cpow(4, x) + (7 * cpow(3, x)) - (4 * cpow(2, x)) - (9 * x) - 1);
	outfile << ans;
	outfile.close();
	return EXIT_SUCCESS;
}

complex cpow(float num, complex& compx){
	if (num > 1){
		complex ctmp = compx;
		for (int p = 1; p < num; p++){
			ctmp = ctmp * compx;
		}
		return ctmp;
	}
}

complex::complex(float real, float imag){
rpart = real;
ipart = imag;
}

complex::complex(){
rpart = 0.0;
ipart = 0.0;
}

ostream& operator<<(ostream& outfile, const complex& other){

	outfile << other.rpart;
	outfile << " + ";
	outfile << other.ipart;
	outfile << "i";
	
	return outfile;
}

const complex& complex::operator=(const complex& other){
	rpart = other.rpart;
	ipart = other.ipart;
}

const complex& complex::operator=(float other){
	rpart = other;
}

bool complex::operator==(const complex& other) const{
	return(rpart == other.rpart && ipart == other.ipart);
}

complex operator +(float real, const complex &i){

}

complex complex::operator +(const complex &other) const{
	return complex(rpart + other.rpart, ipart + other.ipart);
}

complex complex::operator +(float other) const{
	return complex(rpart + other, ipart);
}

complex operator -(float real, const complex &i){

}

complex complex::operator -(const complex &other) const{
	return complex(rpart - other.rpart, ipart - other.ipart);
}

complex complex::operator -(float other) const{
	return complex(rpart - other, ipart);
}

complex complex::operator -() const{

}

complex operator *(float real, const complex &other){
	complex temp;
	temp.rpart = (real * other.rpart);
	temp.ipart = (real * other.ipart);
	return temp;
}

complex complex::operator *(const complex &other) const{
	complex temp;
	temp.rpart = (rpart * other.rpart) - (ipart * other.ipart);
	temp.ipart = (rpart * other.ipart) + (ipart * other.rpart);
	return temp;
}

complex complex::operator *(float other) const{
	return complex(other * rpart, other * ipart);
}

complex operator /(float real, const complex &i){

}

complex complex::operator /(const complex &other) const{
	complex temp;
	temp.rpart = (rpart / other.rpart) - (ipart / other.ipart);
	temp.ipart = (rpart / other.ipart) + (ipart / other.rpart);
	return temp;
}

complex complex::operator /(float other) const{

}
