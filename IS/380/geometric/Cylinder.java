// Cylinder.java: The new cylinder class that extends the circle
// class
public class Cylinder extends Circle implements Colorable {
  private double length;

  /**Default constructor*/
  public Cylinder() {
    this(1.0, 1.0);
  }

  /**Construct a cylinder with specified radius, and length*/
  public Cylinder(double radius, double length) {
    this(radius, "white", false, length);
  }

  /**Construct a cylinder with specified radius, filled, color, and
     length
   */
  public Cylinder(double radius,
    String color, boolean filled, double length) {
    super(radius, color, filled);
    this.length = length;
  }

	public String howToColor(){
		return "Start in the top of the cylinder and, moving from top to bottoms and left to right, fill in each pixel. Continue til cylinder is filled.";
	}

  /**Return length*/
  public double getLength() {
    return length;
  }

  /**Set a new length*/
  public void setLength(double length) {
    this.length = length;
  }

  /**Return the surface area of this cylinder*/
  public double findArea() {
    return 2*super.findArea()+(2*getRadius()*Math.PI)*length;
  }

  /**Return the volume of this cylinder*/
  public double findVolume() {
    return super.findArea()*length;
  }

  /**Override the equals method defined in the Object class*/
  public boolean equals(Cylinder cylinder) {
    return (this.getRadius() == cylinder.getRadius()) &&
      (this.length == cylinder.getLength());
  }

  /**Override the toString method defined in the Object class*/
  public String toString() {
    return "[Cylinder] radius = " + getRadius() + " and length "
      + length;
  }
}