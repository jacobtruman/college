public class Room2 {
    private double length, width;

    //constructor with parameters
    Room2(double l, double w) {
		length = l;
		width = w;
    }

    //data interface methods
    public double getLength() {
		return length;
    }
    public double getWidth() {
		return width;
    }
    public void setLength(double l) {
		length = l;
    }
    public void setWidth(double w) {
		idth = w;
    }

    //object (public) behavior methods
    public double computeArea() {
    	double area;
		displayMsg();
		area = length * width;
		return area;
    }

    //supporting methods, if any, - private methods
    private void displayMsg() {
		System.out.println("this is just a demo");
    }
}