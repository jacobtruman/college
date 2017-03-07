// Truman, Jacob
// CSC 135 - Exercise 1
// Inputs: 
// Outputs: 

#include <iostream>
#include <iomanip>

using namespace std;


int main(){
  double x1, x2, y1, y2, Mx, My, CArea, CVol, r, d;
  double pi = 3.1428;

  cout << "Enter the first Coordinate (x1,y1)" << endl;
  cin >> x1 >> y1;
  cout << "Enter the second Coordinate (x2,y2)" << endl;
  cin >> x2 >> y2;
  
  d = sqrt(pow((x2-x1),2) + pow((y2-y1),2));
  r = d/2;

  Mx = ( x1 + x2 ) / 2;
  My = ( y1 + y2 ) / 2;
  CArea = pi * pow(r,2);
  CVol = (4.0/3.0) * pi * pow(d,3);

  cout << "The Coordinates of the Midpoint are: (" << Mx << "," << My << ")" << endl;
  cout << "The Area of the Circle is: " << CArea << endl;
  cout << "The Volume of the Circle is: " << CVol << endl;
 return 0;
}
