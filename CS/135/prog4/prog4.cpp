// Truman, Jacob
// CSC 135 - Program Assignment 4
// Inputs: Reads times from file.
// Outputs: Either adds of subtracts the numbers read in outputs the results.

#include <iostream>
#include <fstream>
using namespace std;

long rtime(ifstream&);
void wtime(long);

int main(){
	cout << endl;
	char op, coln, ch;
	long time1, time2, res;
	int i = 0, num;
	ifstream timeFile;
	timeFile.open("times.txt");
	timeFile >> num;
	while (i < num){
		time1 = rtime (timeFile);
		timeFile >> op;
		cout << " " << op << " ";
		time2 = rtime (timeFile);
		if (op == '+')
			res = time1 + time2;
		else if (op == '-')
			res = time1 - time2;
		cout << " = ";
		wtime(res);
	cout << endl;
	i++;
	}
	cout << endl;
return 0;
}

long rtime(ifstream& files){
	int d, h, m, s;
	long thrs, tmin, tsec;
	char ch;
	files >> d >> ch >> h >> ch >> m >> ch >> s;

	thrs = d * 24 + h;
	tmin = thrs * 60 + m;
	tsec = tmin * 60 + s;
	wtime(tsec);
	return tsec;
}

void wtime(long tsec){
	int days, hrs, mins, secs;
	days = tsec / (24 * 60 * 60);
	tsec = tsec % (24 * 60 * 60);
	hrs = tsec / (60 * 60);
	tsec = tsec % (60 * 60);
	mins = tsec / 60;
	secs = tsec % 60;

	if (days < 10)
		cout << "0" << days << ":";
	else 
		cout << days << ":";
	if (hrs < 10)
		cout << "0" << hrs << ":";
	else
		cout << hrs << ":";
	if (mins < 10)
		cout << "0" << mins << ":";
	else
		cout << mins << ":";
	if (secs < 10)
		cout << "0" << secs;
	else
		cout << secs;
}
