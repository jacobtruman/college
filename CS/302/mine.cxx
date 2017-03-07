#include <iostream>
#include <fstream>
#include <cstdlib>
#include <string>
using namespace std;

int main() {

	ifstream in("in.txt");
	if (!in) {
		return EXIT_FAILURE;
	}
	
	int cnt = 15, i = 0;
	string tmp, temp;
	string list[3][cnt];	
	
	while(!in.eof()){
		in >> temp;
		list[0][i] = temp.substr(0, temp.find(",",0));
		list[1][i] = temp.substr(temp.find(",",0) + 1, 100);
		in >> list[2][i];
		cout << list[0][i] << " " << list[1][i] << " " << list[2][i] << endl;
		i++;
	}
	in.close();
	return 0;
}
