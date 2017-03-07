// RadiusException.java: An exception class for describing
// invalid radius exception
public class RadiusException extends Exception {
  /** Information to be passed to the handlers */
  private double radius;

  /** Construct an exception */
  public RadiusException(double radius) {
    this.radius = radius;
  }

  /** Return the radius */
  public double getRadius() {
    return radius;
  }

  /** Override the "toString" method */
  public String toString() {
    return "Radius is " + radius;
  }
}