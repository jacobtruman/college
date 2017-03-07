#include <iostream>
#include <cstdlib>
#include "polynomial.h"
using namespace std;
using namespace main_skitch_4;

int main( )
{
    polynomial p, q, r, s, t;
	int n;
	
	cout << "Enter degree of first polynomial p >" << endl;
	cin >> n;
	p.insert(n);
	p.print();
	
	cout << "Enter degree of second polynomial q >" << endl;
	cin >> n;
	q.insert(n);
	q.print();
	
	cout << endl;
	r = p + q;
	cout << " + ";
	r.print();
	cout << endl;
	s = p - q;
	cout << " - ";
	s.print();
	cout << endl;
	t = p * q;
	cout << " * ";
	t.print();
	
    cout << "Each day is better than the next." << endl;
return EXIT_SUCCESS;
}


