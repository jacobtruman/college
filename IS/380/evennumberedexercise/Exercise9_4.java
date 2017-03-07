// TestCloneable.java: Use the TestCloneable interface
// to enable cloning
public class Exercise9_4 {
  /** Main method */
  public static void main(String[] args) {
    House house1 = new House(1, 1750.50);
    House house2 = (House)house1.clone();
    System.out.println(house1.getWhenBuilt() == house2.getWhenBuilt());
  }
}

class House implements Cloneable, Comparable {
  private int id;
  private double area;
  private java.util.Date whenBuilt;

  public House(int id, double area) {
    this.id = id;
    this.area = area;
    whenBuilt = new java.util.Date();
  }

  public double getId() {
    return id;
  }

  public double getArea() {
    return area;
  }

  public java.util.Date getWhenBuilt() {
    return whenBuilt;
  }

  /** Override the protected clone method defined in the Object
    class, and strengthen its accessibility */
  public Object clone() {
    try {
      House house = (House)super.clone();
      house.whenBuilt = (java.util.Date)(whenBuilt.clone());
      return house;
    }
    catch (CloneNotSupportedException ex) {
      return null;
    }
  }

  /** Implement the compareTo method defined in Comparable */
  public int compareTo(Object o) {
    if (area > ((House)o).area)
      return 1;
    else if (area < ((House)o).area)
      return -1;
    else
      return 0;
  }
}

// CloneableCircle is a subclass of Circle, which implements the
// Cloneable interface
class CloneableCircle extends Circle implements Cloneable {
  // Store the date when the object is created
  java.util.Date date = new java.util.Date();

  /** Construct a CloneableCircle with a specified radius */
  public CloneableCircle(double radius) {
    super(radius);
  }

  /** Override the protected clone method defined in the Object
     class, and strengthen its accessibility */
  public Object clone() {
    CloneableCircle circle = new CloneableCircle(getRadius());
    circle.date = (java.util.Date)(date.clone());
    return circle;
  }
}
