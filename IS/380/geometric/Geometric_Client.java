// -------------------------
// Developer: Jacob Truman -
// Date: 4/2/06            -
// Geometric_Client.java   -
// -------------------------
public class Geometric_Client{
	public static void main(String ars[]){
	
	Rectangle myRectangle = new Rectangle();
	System.out.println(((Colorable)myRectangle).howToColor());
	
	System.out.println();
	
	Circle myCircle = new Circle();
	System.out.println(((Colorable)myCircle).howToColor());
	
	System.out.println();
	
	Cylinder myCylinder = new Cylinder();
	System.out.println(((Colorable)myCylinder).howToColor());
	
	}
}