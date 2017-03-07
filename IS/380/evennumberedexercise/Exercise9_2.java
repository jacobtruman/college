// Exercise9_2.java: Create a CompareRectangle class
public class Exercise9_2 {
  // Main method
  public static void main(String[] args) {
    // Create two comarable rects
    ComparableCylinder cylinder1 = new ComparableCylinder(2, 5);
    ComparableCylinder cylinder2 = new ComparableCylinder(3, 4);

    // Display the max rect
    ComparableCylinder rect = (ComparableCylinder)Max.max(cylinder1, cylinder2);
    System.out.println("The max rect's width and height are " +
      rect.getWidth() + " and " + rect.getHeight());
    System.out.println(rect);
  }
}

// Rectangle1.java: The Rectangle1 class that extends GeometricObject
class Rectangle1 extends GeometricObject1 {
  protected double width;
  protected double height;

  // Default constructor
  public Rectangle1() {
    this(1.0, 1.0, "white", 1.0);
  }

  // Construct a rectangle with specified width and height
  public Rectangle1(double width, double height) {
    this.width = width;
    this.height = height;
  }

  // Construct a rectangle with specified width, height, weight, and color
  public Rectangle1(double width, double height,
    String color, double weight) {
    super(color, weight);
    this.width = width;
    this.height = height;
  }

  // Getter method for width
  public double getWidth() {
    return width;
  }

  // Setter method for width
  public void setWidth(double width) {
    this.width = width;
  }

  // Getter method for height
  public double getHeight() {
    return height;
  }

  // Setter method for height
  public void getHeight(double height) {
    this.height = height;
  }

  // Implement the findArea method in GeometricObject
  public double findArea() {
    return width*height;
  }

  // Implement the findPerimeter method in GeometricObject
  public double findPerimeter() {
    return 2*(width + height);
  }

  public int compareTo(Object object) {
    if (this.findArea() > ((Rectangle)object).findArea())
      return 1;
    else if (this.findArea() == ((Rectangle)object).findArea())
      return 0;
    else
      return -1;
  }

  /**Override the equals() method defined in the Object class*/
  public boolean equals(Rectangle1 rectangle) {
    return (width == rectangle.getWidth()) &&
      (height ==  rectangle.getHeight());
  }

  // Override the toString() method defined in the Object class
  public String toString() {
    return "[Rectangle1] width = " + width + " and height = " + height;
  }
}

class ComparableCylinder extends Rectangle1 implements Comparable {
  // Construct a CompareCircle with specified radius
  public ComparableCylinder(double w, double h) {
    super(w, h);
  }

  // Implement the compareTo method defined in Comparable
  public int compareTo(Object o) {
    if (findArea() > ((Rectangle1)o).findArea())
      return 1;
    else if (findArea() < ((Rectangle1)o).findArea())
      return -1;
    else
      return 0;
  }
}
