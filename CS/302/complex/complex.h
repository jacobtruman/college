// Program Written By:  Jacob Truman
// CS 302 Section 002

#ifndef MAIN_SKITCH_COMPLEX_H
#define MAIN_SKITCH_COMPLEX_H
using namespace std;

class complex{
	friend complex operator+(float,const complex&);
	friend complex operator-(float,const complex&);
	friend complex operator*(float,const complex&);
	friend complex operator/(float,const complex&);
	friend ostream& operator<<(ostream& outfile, const complex&);
	public:
		static const complex i;
		complex();
		complex(float, float);
		const complex& operator=(const complex&);
		const complex& operator=(float);
		bool operator==(const complex&) const;
		complex operator+(const complex&) const;
		complex operator+(float) const;
		complex operator-(const complex&) const;
		complex operator-(float) const;
		complex operator-() const;
		complex operator*(const complex&) const;
		complex operator*(float) const;
		complex operator/(const complex&) const;
		complex operator/(float) const;
	private:
		float ipart;
		float rpart;
};
#endif
