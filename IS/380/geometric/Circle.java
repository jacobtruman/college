// Circle.java: The circle class that extends GeometricObject
public class Circle extends GeometricObject implements Colorable {
  private double radius;

  /**Default constructor*/
  public Circle() {
    this(1.0);
  }

  /**Construct circle with a specified radius*/
  public Circle(double radius) {
    this(radius, "white", false);
  }

  /**Construct a circle with specified radius, filled, and color*/
  public Circle(double radius, String color, boolean filled) {
    super(color, filled);
    this.radius = radius;
  }
  
	public String howToColor(){
		return "Start in the top of the circle and, moving from top to bottoms and left to right, fill in each pixel. Continue til circle is filled.";
	}

  /**Return radius*/
  public double getRadius() {
    return radius;
  }

  /**Set a new radius*/
  public void setRadius(double radius) {
    this.radius = radius;
  }

  /**Implement the findArea method defined in GeometricObject*/
  public double findArea() {
    return radius*radius*Math.PI;
  }

  /**Implement the findPerimeter method defined in GeometricObject*/
  public double findPerimeter() {
    return 2*radius*Math.PI;
  }

  /**Override the equals() method defined in the Object class*/
  public boolean equals(Circle circle) {
    return this.radius == circle.getRadius();
  }

  /**Override the toString() method defined in the Object class*/
  public String toString() {
    return "[Circle] radius = " + radius;
  }
}