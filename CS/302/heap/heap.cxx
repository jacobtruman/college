#include <iostream>
#include <fstream>
using namespace std;

typedef int TYPE;
void buildHeap( TYPE*, int)
void heapSort( TYPE*, int);
void insert_special( TYPE, TYPE*, int, int);


int main(){
{
	ifstream in("dataHeap.txt");
	if (!in) {
		return EXIT_FAILURE;
	}
	in >> num;
    int num;
	TYPE a[num];
	
	for (i = 0; i <= num - 1; i++){
		in >> a[i] ;
	}
	
	builHeap(a, num);
}

void heapSort( TYPE* a, int size )
// sort an array of the given size
{
   int i;
   TYPE temp;
   buildHeap( a, size );
   for (i = size-1; i >=1; i--) {
      temp = a[i];    // extract the last element from the array
      a[i] = a[0];    // move top of heap to the end of the array
      insert_special( temp, a, 0, i-1 );      // restore heap properties
   }
}


void buildHeap( TYPE* a, int size )
// Build a heap from an array of items
// Binary tree with one node satisfies heap properties
// Therefore ignore leaves and start from the parent
// of the last item
{
   int i;
   for (i = (size - 2)/2; i >= 0; i--)     // start from parent of last item
      insert_special( a[i], a, i, size-1);
}


void insert_special( TYPE x, TYPE* heap, int start, int end )
// insert x into the sub-heap from start to end
// location start is empty

{
   int child = 2*start + 1;        // left child of start
        
   while (child <= end) {
      if (child < end && heap[child] < heap[child + 1])
         child++;         // child is the larger child of start
      if (x > heap[child])
         break;           // x stays in start
      else {
         heap[start] = heap[child];
         start = child;
         child = 2*start + 1;
      }
   }       
   heap[start] = x;
}
