// FILE: sequence_list.cpp
// CLASS IMPLEMENTED: sequence (see sequence_list.h for documentation)

#include <iostream>     // Provides cout and cin
#include <algorithm> // Provides copy function
#include <cassert>   // Provides assert function
#include "sequence_list.h"
#include "node.h"
using namespace std;

namespace main_skitch_5
{
	sequence::sequence( )
	{
		head_ptr = NULL;
		tail_ptr = NULL;
		cursor = NULL;
		precursor = NULL;
		many_nodes = 0;
	}

	sequence::sequence(const sequence& source)
	{
		list_copy(source.head_ptr, head_ptr, tail_ptr);
		many_nodes = source.many_nodes;
	}
	
	sequence::~sequence( )
	{
        list_clear(head_ptr);
        many_nodes = 0;
	}
	
	void sequence::remove_current( )
	{
		if (is_item()){
			if (precursor != NULL){
				list_remove(precursor);
				if (precursor->link() != NULL){
					cursor = precursor->link();
				}else{
					cursor = NULL;
					precursor = NULL;
				}
			}else{
				list_head_remove(head_ptr);
					cursor = NULL;
			}
		--many_nodes;
		}
	}
	
	void sequence::start()
	{
		cursor = head_ptr;
		precursor = NULL;
	}

	void sequence::advance()
	{
		if (cursor == NULL){
			cursor = head_ptr;
		}else{
			if (cursor->link() != NULL){
				precursor = cursor;
				cursor = cursor->link();
			}else{
				precursor = NULL;
				cursor = cursor->link();
			}
		}
	}
	
	void sequence::insert(const value_type& entry)
	{
		if ((cursor == NULL) || (precursor == NULL)){
			list_head_insert(head_ptr, entry);
			cursor = head_ptr;
		}else{
			list_insert(precursor, entry);
			cursor = precursor->link();
		}
		++many_nodes;
	}
	
	void sequence::attach(const value_type& entry)
	{
		if (cursor == NULL){
			list_head_insert(head_ptr, entry);
			cursor = head_ptr;
		}else{
			list_insert(cursor, entry);
			precursor = cursor;
			cursor = cursor->link();
		}
		++many_nodes;
	}

	sequence::value_type sequence::current( ) const
	{
		return cursor->data();
	}

	sequence::value_type sequence::previous( ) const
	{
		return precursor->data();
	}

	void sequence::operator =(const sequence& source)
	{

	}
}
