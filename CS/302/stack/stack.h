/*
This file provides a parametrized Linked List
class that will store any data type you like,
provided that it has:

0) a default constructor
1) copy constructor
2) = assignment
3) == (equality test)
4) << (put to fstream)

The list keeps real copies (not references) to
the things it stores.


The LList changes its size to contain data it is given.
You can interact with things stored via the [] operator.
Search(value) will return an index to access the place the value is stored.

With minor name changes, this is essentially an implementation of the
SmallList type used in some other library routines by means of
a linked list instead of an array. This makes removal of elements
and adding elements more efficient.

*/

#ifndef LINKEDLIST
#define LINKEDLIST
#include <fstream.h>
#include <assert.h>

template <class T>
class LList
{
protected:
	struct Node
	{
		T Data;
		Node * Next;
		Node()
		{
			Next=0;
		}
		Node(T element, Node *ptr=0)
		{
			Data = element;
			Next=ptr;
		}
		//friend ostream& operator<<(ostream&s,Node n){ s<< n.Data; return s;}
	}  *First,*Last;

	int NumberNodes;
public:
	LList(){ First=0; Last=0; NumberNodes=0;}
	~LList();
	//copy operation
	LList(const LList& L);
	int Length();
	//subscripting
	T& operator[](int i);
	void Print();
	const T& operator[](int i) const;
	//T& operator[](int i) ;
	//Insertion
	void Insert(const T& el);
	//Append
	void Append(const LList<T>& L);
	//Removal
	void Remove(int location);
	//Search
	int Search(const T& value)const;
	//output
	friend ostream& operator<<(s,const LList<T>& L) ;
};

template <class T>
LList<T>::~LList()
{
	Node * p=First;
	while( p !=0)
	{
		First=p->Next;
		delete p;
		p=First;
	}
	NumberNodes=0;
	Last=0;
}
template <class T>
int LList<T>::Length() { return  NumberNodes;}

template <class T>
LList<T>::LList(const LList& L)
{
	Node *Old=L.First, *New=0;
	NumberNodes=L.NumberNodes;
	if(NumberNodes==0) First=0;
	else
	{
		New= new Node(Old->Data);
		assert(New !=0);
		Old=Old->Next;
		First=New;
	}
	while(Old !=0)
	{
		New->Next= new Node(Old->Data);
		assert(New->Next !=0);
		New= New->Next;
		Old= Old->Next;
	}
	Last=New;
}


template <class  T>
ostream& operator<<(ostream & s,const LList<T>& L)
{
	int i,M=L.Length();
	for(i=0;i<M-1;i++)
	{
		s << L[i] << ",";
	}
   s << L[M-1] ;
	return s;
}

template <class T>
void LList<T>::Print()
{
	 Node *p=First;
	 while (p!=Last)
	 {
		cout << p->Data <<",";
		p=p->Next;
	 }
	 cout << p->Data << endl;
}
template <class T>
T& LList<T>::operator[](int i)
{
	assert(i >=0);
	assert(i <NumberNodes);
	Node *p=First;
	for(int k=0;k<i;k++)
	{
		p = p->Next;
	}
	return p->Data;
}
template <class T>
const T& LList<T>::operator[](int i) const
{
	assert(i >=0);
	assert(i <NumberNodes);
	Node *p=First;
	for(int k=0;k<i;k++)
	{
		p = p->Next;
	}
	return p->Data;
}

template <class T>
void LList<T>::Insert(const T& el)
{
	Node *newnode= new Node(el);
	assert(newnode  !=0);
	newnode->Next=First;
	First=newnode;
	if(NumberNodes==0) Last=newnode;
	NumberNodes++;
}
template <class T>
void LList<T>::Remove(int location)
{
	assert(location >=0);
	assert(location < NumberNodes);
	Node * p;
	if(location==0)
	{
		p=First;
		First=p->Next;
		p->Next=0;
	}
	else
	{
		Node *pp=First;
		for(int i=0;i<location-1;i++) pp=pp->Next;
		p=pp->Next;
		pp->Next=p->Next;
		p->Next=0;
		if(location==NumberNodes-1) Last=pp;
	}
	delete p;
	NumberNodes--;

}
template<class T>
int LList<T>::Search(const T& value)const
{
	Node *p=First;
	for(int i=0;i<NumberNodes;i++)
	{
		if(p->Data==value) return i;
		else p=p->Next;
	}
	return -1;
}
template <class T>
void LList<T>::Append(const LList<T>& L)
{
	Node *p=L.First;
	while(p !=0)
	{
		Insert(p->Data);
		p=p->Next;
	}
}
#endif

/*
This stack is implemented on top of LList above.
*/
#ifndef STACK
#define STACK
template <class T>
class Stack: private LList<T>
{
	public:
	Stack():LList<T>(){}
	Stack(const Stack<T>& S): LList<T>(S){}
	int Empty() const{ return (Length()==0) ;}
	void Push(T& el){ Insert(el);}
	T Pop()
	{
		assert(Length()>0);
		T el = First->Data;
		Remove(0);
		return el;
	}
	Print(){ LList<T>::Print();}
};
#endif

main()
{
	LList<int> L,M;
	L.Insert(2);
	L.Insert(3);
	for(int i=0;i<10;i++) L.Insert(i);
	L.Print();
	cout << endl;
	L.Remove(0);
	L.Print();
	cout << endl;
	L.Remove(1);
	L.Print();
}

