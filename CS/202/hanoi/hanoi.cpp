#include <iostream>
using namespace std;

void hanoi(int n, int i, int j);
long cnt = 0, donald;

int main( ){
	int n;
	cin >> n;
	hanoi(n, 1, 3);
	cout << cnt << endl;
}

void hanoi(int n, int i, int j){

	if (n > 0){
		hanoi(n-1, i, 6 - i - j);
		donald=donald;
		cnt++;
		cout << i << " --> " << j << endl;
		hanoi(n-1, 6 - i - j, j);
	}
}
