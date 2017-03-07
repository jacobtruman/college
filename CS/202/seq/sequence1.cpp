// FILE: sequence1.cpp
// CLASS IMPLEMENTED: sequence (see sequence1.h for documentation)

#include <algorithm> // Provides copy function
#include <cassert>   // Provides assert function
#include "sequence1.h"
using namespace std;

namespace main_skitch_5
{
	const sequence::size_type sequence::CAPACITY;

	void sequence::start()
	{
		current_index = 0;
	}
	void sequence::advance()
	{
		if (is_item())
			current_index++;
	}
	void sequence::insert(const value_type& entry)
	{
		if (used == 0){
			start();
		}
		int i = 1, n;
		n = used;
		while (n > current_index){
			data[n] = data[--n];
			i++;
		}
		data[current_index] = entry;
		++used;
	}
	void sequence::attach(const value_type& entry)
	{
		if (used == 0){
			start();
		}
		int i = 1, n;
		n = used;
		while (n > current_index){
			data[n] = data[--n];
			i++;
		}
		advance();
		data[current_index] = entry;
		++used;
	}
	void sequence::remove_current()
	{
		if (is_item()){
			int i = 1, n;
			n = current_index;
			while (n < used){
				data[n] = data[++n];
				i++;
			}
			--used;
		}
	}
	bool sequence::is_item() const
	{
		if (current_index >= used){
			return false;
		}else{
			return true;
		}
	}
	sequence::size_type sequence::size( ) const
	{
		return used;
	}
	sequence::value_type sequence::current( ) const 
	{
		if (current_index <= used)
			return data[current_index];
	}
}

