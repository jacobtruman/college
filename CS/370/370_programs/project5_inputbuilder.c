/**************************************
Program to generate the input file with 50 nodes
***************************************/
#include <stdio.h>
#include <stdlib.h>
#include <time.h>

#define n 50       // number of node

int list[n];

int isUsed(int temp, int i)
{
  int j;
  for(j=0; j<i; j++)
    {
      if(list[j] == temp)
        return 1;
    }
  return 0;
}

int main()
{
  int i;
  int temp;

  printf("%i\n", n);

  srand((unsigned)time(NULL));

  for (i=0; i<n; i++)
    {
      temp =  rand()%500;
      while(isUsed(temp, i))
        {
          temp = rand()%500;
        }
      list[i] = temp;
      printf("%i\n", list[i]);
    }
  return 0;
}

