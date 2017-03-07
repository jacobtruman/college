// FILE: bagsort.cpp
#include <iostream>    // Provides cout and cin
#include <cstdlib>     // Provides EXIT_SUCCESS
#include "bag.h"      // With value_type defined as an int
using namespace std;
using namespace main_skitch_3;

void get_nums(bag& the_bag);
// Postcondition: The user has been prompted to type in the amount of 
// numbers to be generated. These numbers have been read and placed in
// the the_bag.

void sort_nums(bag& the_bag);
// Postcondition: The numbers generated are printed on the screen in
// numerical order and removed from the bag.


int main( )
{
    bag the_bag;
    get_nums(the_bag);
    if (the_bag.size() > 0)
    sort_nums(the_bag);
    return EXIT_SUCCESS;  
}


void get_nums(bag& the_bag)
{
    int n; 

    cout << "Please enter a number between 0 and 30, enter * to quit"  << endl;
    cin >> n;
	while ((n > the_bag.CAPACITY) || (n < 0)){
		cout << "Invalid entry. Please enter a number between 0 and 30, enter * to quit" << endl;
		cin >> n;
	}
	if (n != '*'){
		for (int i = 1; i <= n; i++)
		the_bag.insert((int) floor(1000 * (sin (1.2 * i) * sin (1.2 * i))));
	}
}

void sort_nums(bag& the_bag)
{
	cout << endl;
	cout << "Here are your sorted numbers" << endl;
	while (the_bag.size() > 0){
		cout << the_bag.minimum() << endl;
		the_bag.erase_one(the_bag.minimum());
	}
}
