/** 
 * Jacob Truman
 * Project #3
 *
 * Simple circle creation and usage.
 */

import java.awt.Graphics;
import javax.swing.*;

public class Circle{
	public int diameter;		// The diameter of this circle.
	public Point rCenter;		// Point object for center of circle.

	// -------------------------------------------------------------------------------------------------------------
	// Creates a circle with default location (100,100) with a default diameter 20.
	public Circle(){
		this(new Point(100, 100), 20);
	}

	// -------------------------------------------------------------------------------------------------------------
	// Creates a circle with default location (100,100).
	//	@param d diameter of the rectangle
	public Circle(int diameter){
		this(new Point(100, 100), diameter);
	}

	// -------------------------------------------------------------------------------------------------------------
	// Creates a circle with the specified origin and size.
	//	Rectangle center is Point().
	//	@param d diameter of the circle
	public Circle(Point p, int d){
		rCenter = p;
		diameter = d;
	}

	// -------------------------------------------------------------------------------------------------------------
	// Moves the circle to the specified (x,y) position.
	public void move(int x, int y) {
		rCenter.x = x;
		rCenter.y = y;
	}

	// -------------------------------------------------------------------------------------------------------------
	//  Returns the computed area of the circle.
	public double area(){
		return Math.round(diameter*Math.PI);
	}

	// -------------------------------------------------------------------------------------------------------------
	// Draw the circle.
	//	Draw the circle based on the center point's (x,y) position.
	public void drawCircle( Graphics g ) {
		g.drawOval(rCenter.x-(diameter/2), rCenter.y-(diameter/2), diameter, diameter);
	}

	// -------------------------------------------------------------------------------------------------------------
	// Draw the circle and display the position.
	//	Draw the circle lines based on the center point's (x,y) position.
	//	The (x,y) position string is displayed on the approximate upper right hand side.
	public void drawCircleAndPos( Graphics g ) {
		g.drawOval( rCenter.x-(diameter/2), rCenter.y-(diameter/2), diameter, diameter);
		g.drawString( "(" + rCenter.x + "," + rCenter.y + ")",
						rCenter.x+(diameter/2)+5, rCenter.y-(diameter/2)+5 );
	}

	// -------------------------------------------------------------------------------------------------------------
	// Draw a simple caption (starting at botton left).  Assumes circle is already drawn!
	public void caption( Graphics g, String capt_str ) {
		g.drawString(capt_str, rCenter.x-(diameter/2), rCenter.y+(diameter/2)+15);
	}
	
	// -------------------------------------------------------------------------------------------------------------
	// Shrink a circle
	public void shrink(int percent){
		diameter = diameter / (100 / percent);
	}


	// -------------------------------------------------------------------------------------------------------------
	// Expand a circle
	public void expand(int percent){
		diameter = (diameter * 100) / percent;
	}
}
