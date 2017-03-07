public class TestRadiusException {
    public static void main(String[] args) {
        try {
          CircleWithException1 c = new CircleWithException1(4);
          c.setRadius(-5);
        }
        catch (RadiusException ex) {
          System.out.println("The invalid radius is " + ex.getRadius());  
        }
    }
}

// CircleWithException1.java: setRadius throws an exception
class CircleWithException1 {
  /** The radius of the circle */
  private double radius;

  /** The number of the objects created */
  private static int numberOfObjects = 0;  

  /** Construct a circle with radius 1 */
  public CircleWithException1() {
    this(1.0);
  }

  /** Construct a circle with a specified radius */
  public CircleWithException1(double newRadius) {
    try {
        setRadius(newRadius);
    }
    catch (RadiusException ex) {
        
    }
    numberOfObjects++;
  }

  /** Return radius */
  public double getRadius() {
    return radius;
  }

  /** Set a new radius */
  public void setRadius(double newRadius) 
    throws RadiusException {
    if (newRadius >= 0)
      radius =  newRadius;
    else
      throw new RadiusException(newRadius);
  }

  /** Return numberOfObjects */
  public static int getNumberOfObjects() {
    return numberOfObjects;
  }

  /** Return the area of this circle */
  public double findArea() {
    return radius * radius * 3.14159;
  }
}
