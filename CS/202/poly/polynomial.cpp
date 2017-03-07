#include <iostream>
#include <algorithm>
#include <cassert>
#include "polynomial.h"
using namespace std;

namespace main_skitch_4
{
    const polynomial::size_type polynomial::DEFAULT_DEGREE;

    polynomial::polynomial(size_type initial_degree)
    {
        data = new value_type[initial_degree];
        degree = initial_degree;
        used = 0;
    }

    polynomial::polynomial(const polynomial& source)
    {
        data = new value_type[source.degree];
        degree = source.degree;
        used = source.used;
        copy(source.data, source.data + used, data);
    }

    polynomial::~polynomial( )
    {
	delete [ ] data;
    }

    void polynomial::reserve(size_type new_degree)
    {
        value_type *larger_array;

        if (new_degree == degree)
            return;

        if (new_degree < used)
            new_degree = used;

        larger_array = new value_type[new_degree];
        copy(data, data + used, larger_array);
        delete [ ] data;
        data = larger_array;
        degree = new_degree;
    }
    
	void polynomial::insert(size_type degree)
    {   
		reserve(degree + 1);
		value_type entry;
        for (size_type i = 0; i <= degree; i ++){
			cout << "Enter a coefficent" << endl;
			cin >> entry;
	        data[i] = entry;
		}
    }
	
	void polynomial::print( )
    {   
        for (size_type i = 0; i < degree; i ++){
			if ((i == 0) || (data[i] < 0)){
				cout << " " << data[i] << " **x" << i;
			}else{
				cout << " +" << data[i] << " **x" << i;
			}
		}
		cout << endl;
    }
	
	polynomial operator +(const polynomial& b1, const polynomial& b2)
    {
		polynomial b3;
		if (b1.degree < b2.degree){
			b3.reserve(b2.degree);
		}else{
			b3.reserve(b1.degree);			
		}
		for (int i = 0; i <= b3.degree; i++){
			b3.data[i] = 0;
		}
		for (int i = 0; i < b3.degree; i++){
			if (i >= b1.degree){
				b3.data[i] = b2.data[i];
			}else if (i >= b2.degree){
				b3.data[i] = b1.data[i];
			}else{
				b3.data[i] = b1.data[i] + b2.data[i];
			}
		}
	return b3;
    }
	
	polynomial operator -(const polynomial& b1, const polynomial& b2)
    {
                polynomial b4;
                if (b1.degree < b2.degree){
                        b4.reserve(b2.degree);
                }else{
                        b4.reserve(b1.degree);
                }
                for (int i = 0; i <= b4.degree; i++){
                        b4.data[i] = 0;
                }
                for (int i = 0; i < b4.degree; i++){
                        if (i >= b1.degree){
                                b4.data[i] = b2.data[i];
                        }else if (i >= b2.degree){
                                b4.data[i] = b1.data[i];
                        }else{
                                b4.data[i] = b1.data[i] - b2.data[i];
                        }
                }
        return b4;
    }
	
	polynomial operator *(const polynomial& b1, const polynomial& b2)
    {
                polynomial b5;
                b5.reserve((b1.degree + b2.degree) - 1);
                for (int i = 0; i <= b5.degree; i++){
                        b5.data[i] = 0;
                }
		for (int i = 0; i < b5.degree; i++){
	                for (int l = 0; l <= i; l++){
        	                if (l >= b1.degree){
                	                b5.data[i] += 0;
                        	}else if (l >= b2.degree){
                                	b5.data[i] += 0;
                        	}else{
                                	b5.data[i] += b1.data[l] * b2.data[i-l];
                        	}
			}
                }
        return b5;
    }
}
