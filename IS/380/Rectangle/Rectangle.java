// -------------------------
// Developer: Jacob Truman -
// Date: 2/10/06           -
// Rectangle.java          -
// -------------------------
public class Rectangle{

//***********//
// Variables //
//***********//

	private double width;
	private double height;
	private String color;
	private String rectName;

//**************//
// Constructors //
//**************//

	// Default constructor - rectangle with width 1, height 1 and color black
	public Rectangle(){
		this(1.0, 1.0);
	}

	// Construct rectangle with specified width and height, color black
	public Rectangle(double width, double height){
		this(width, height, "black");
	}
  
	// Construct rectangle with specified width, height and color
	public Rectangle(double width, double height, String color){
		setWidth(width);
		setHeight(height);
		setColor(color);
	}

//****************//
// Set parameters //
//****************//
  
	// Set width of rectangle
	public void setWidth(double width){
		this.width = width;
	}
	
	// Set height of rectangle
	public void setHeight(double height){
		this.height = height;
	}
	
	// Set color of rectangle
	public void setColor(String color){
		this.color = color;
	}

//****************//
// Get parameters //
//****************//

	// Get the width of the rectangle
	public double getWidth(){
		return width;
	}
	
	// Get the height of the rectangle
	public double getHeight(){
		return height;
	}

	// Get the color of the rectangle
	public String getColor(){
		return color;
	}

//**************//
// Calculations //
//**************//

	// Find the area of the rectangle
	public double findArea(){
		return width*height;
	}

	public double findPerimeter(){
		return (width+height)*2;
	}
	
//*************//
// Display all //
//*************//
	public void prntAll(){
		prntAll("A Rectangle");
	}
	
	public void prntAll(String rectName){
		System.out.println(rectName);
		System.out.println("*****************************");
		System.out.println("Width:     "+this.getWidth());
		System.out.println("Height     "+this.getHeight());
		System.out.println("Color      "+this.getColor());
		System.out.println("Area:      "+this.findArea());
		System.out.println("Perimeter: "+this.findPerimeter());
		System.out.println("*****************************");
	}
}