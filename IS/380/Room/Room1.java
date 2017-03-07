public class Room1 {
    double length, width;

    //constructor with parameters
    Room1(double l, double w) {
	length = l;
	width = w;
    }
    
    public double computeArea() {
        double area;

	area = length * width;

	return area;
    }
}