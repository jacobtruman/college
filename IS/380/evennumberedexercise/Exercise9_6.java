/*
 * Exercise9_6.java
 *
 * Created on September 17, 2002, 2:45 PM
 */

/**
 *
 * @author  administrator
 */
public class Exercise9_6 {
  public static void main(String[] args) {
    Rectangle9_6 obj1 = new Rectangle9_6();
    Rectangle9_6 obj2 = new Rectangle9_6();
    
    System.out.println(obj1);  
    System.out.println(obj2);  
    System.out.println(obj1.equals(obj2));  
    System.out.println(obj1.compareTo(obj2));  
  }
}

// Rectangle.java: The Rectangle class that extends GeometricObject
class Rectangle9_6 extends GeometricObject implements Comparable {
  private double width;
  private double height;

  /** Default constructor */
  public Rectangle9_6() {
    this(1.0, 1.0);
  }

  /** Construct a rectangle with width and height */
  public Rectangle9_6(double width, double height) {
    this(width, height, "white", false);
  }

  /** Construct a rectangle with specified width, height, 
     filled, and color */
  public Rectangle9_6(double width, double height,
    String color, boolean filled) {
    super(color, filled);
    this.width = width;
    this.height = height;
  }

  /** Return width */
  public double getWidth() {
    return width;
  }

  /** Set a new width */
  public void setWidth(double width) {
    this.width = width;
  }

  /** Return height */
  public double getHeight() {
    return height;
  }

  /** Set a new height */
  public void setHeight(double height) {
    this.height = height;
  }

  /** Implement the findArea method in GeometricObject */
  public double findArea() {
    return width*height;
  }

  /** Implement the findPerimeter method in GeometricObject */
  public double findPerimeter() {
    return 2*(width + height);
  }

  /** Override the toString method defined in the Object class */
  public String toString() {
    return "[Rectangle] width = " + width + 
      " and height = " + height;
  }
  
  public int compareTo(Object obj) {
    if (this.findArea() > ((Rectangle9_6)obj).findArea())
      return 1;
    else if (this.findArea() < ((Rectangle9_6)obj).findArea())
      return -1;
    else
      return 0;
  }
  
  public boolean equals(Object obj) {
    return this.findArea() == ((Rectangle9_6)obj).findArea();
  }  
}