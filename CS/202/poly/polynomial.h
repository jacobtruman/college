#ifndef MAIN_SKITCH_POLYNOMIAL_H
#define MAIN_SKITCH_POLYNOMIAL_H
#include <cstdlib>

namespace main_skitch_4
{
    class polynomial
    {
    public:
        // TYPEDEFS and MEMBER CONSTANTS
        typedef double value_type;
        typedef std::size_t size_type;
        static const size_type DEFAULT_DEGREE = 1;        
        // CONSTRUCTORS and DESTRUCTOR
        polynomial(size_type initial_degree = DEFAULT_DEGREE);
        polynomial(const polynomial& source);
        ~polynomial( );
        // MODIFICATION MEMBER FUNCTIONS
        void reserve(size_type new_degree);
        void insert(size_type degree);
		void print( );
        // CONSTANT MEMBER FUNCTIONS
        size_type size( ) const { return used; }
		size_type capac( ) const { return degree; }
		// FRIEND FUNCTIONS
		friend polynomial operator +(const polynomial& b1, const polynomial& b2);
		friend polynomial operator -(const polynomial& b1, const polynomial& b2);
		friend polynomial operator *(const polynomial& b1, const polynomial& b2);
    private:
        value_type *data;
        size_type used;
        size_type degree;
    };

	// NONMEMBER FUNCTIONS for the polynomial class 
}

#endif
