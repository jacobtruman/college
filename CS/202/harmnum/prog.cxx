// Truman, Jacob
// 9-8-2004
// CS 202 Sec 1 - Programming Assignment 1
// Inputs: Number of returned Harmonic Numbers
// Outputs: Harmonic Numbers

#include <iostream>
#include <iomanip>
using namespace std;

void gcd( long, long);
long en, dn, g;

main(){
// Enter the mumber of harmonic numbers you want returned
	long i, n;
	cout << "Enter a number" << endl;
	cin >> n;
 	if ((n > 19) || (n < 1)){
	  	cout << "Try again" << endl;
		return main();
	}
	cout << endl;

	for (i = 1; i <= n; i++){
 		if (i == 1){
			en = 1;
 			dn  = i;
		}else{
 			en = (en * i) + dn;
 			dn = dn * i;
		}
		gcd(en, dn);
		en = en / g;
		dn = dn / g;
		cout << en << "/" << dn << endl;
	// outputs the harmonic numbers in reduced form.
	}
}

// gets the numerator and denominator of each fraction
void gcd(long a, long b){
	long tmp;
	long rem = b % a;
	if ( rem != 0 )
		return gcd(rem,a);
	g = a;
// leaves the numerator and denominator unchanged and sets the GCD to the variable "g"
}
