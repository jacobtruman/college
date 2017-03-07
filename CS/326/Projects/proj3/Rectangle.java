/** 
 * Jacob Truman
 * Project #3
 *
 * Simple rectangle creation and usage.
 */

import java.awt.Graphics;
import javax.swing.*;

public class Rectangle{
	public int width;				// The width of this rectangle
	public int height;			// The height of this rectangle.
	public Point rCenter;		// Point object for center of rectangle.

	// -------------------------------------------------------------------------------------------------------------
	// Creates a rectangle with default location (100,100) with a default size (20,20).

	public Rectangle(){
		this (new Point(100, 100), 20, 20);
	}

	// -------------------------------------------------------------------------------------------------------------
	// Creates a rectangle with default location (100,100).
	//	@param w width of the rectangle
	//	@param h height of the rectangle

	public Rectangle(int w, int h){
		this (new Point(100, 100), w, h);
	}

	// -------------------------------------------------------------------------------------------------------------
	// Creates a rectangle with the specified origin and size.
	//	Rectangle center is Point().
	//	@param w width of the rectangle
	//	@param h height of the rectangle

	public Rectangle(Point p, int w, int h){
		rCenter = p;
		width = w;
		height = h;
	}

	// -------------------------------------------------------------------------------------------------------------
	// Moves the rectangle to the specified (x,y) position.
	public void move(int x, int y){
		rCenter.x = x;
		rCenter.y = y;
	}

	// -------------------------------------------------------------------------------------------------------------
	//  Returns the computed area of the rectangle.
	public int area(){
		return (width * height);
	}

	// -------------------------------------------------------------------------------------------------------------
	// Draw the rectangle.
	//	Draw the rectangle lines based on the center point's (x,y) position.
	public void drawRectangle(Graphics g){
		g.drawRect (rCenter.x-(width/2), rCenter.y-(height/2), width, height);
	}

	// -------------------------------------------------------------------------------------------------------------
	// Draw the rectangle and display the position.
	//	Draw the rectangle lines based on the center point's (x,y) position.
	//	The (x,y) position string is displayed on the approximate upper right hand side.
	public void drawRectangleAndPos(Graphics g){
		g.drawRect(rCenter.x-(width/2), rCenter.y-(height/2), width, height);
		g.drawString("(" + rCenter.x + "," + rCenter.y + ")",
						rCenter.x+(width/2)+5, rCenter.y-(height/2)+5);
	}

	// -------------------------------------------------------------------------------------------------------------
	// Draw the rectangle and add a simple caption (starting at botton left).  Assumes rectangle is already drawn!
	public void caption(Graphics g, String capt_str){
		g.drawString(capt_str, rCenter.x-(width/2), rCenter.y+(height/2)+15);
	}

	// -------------------------------------------------------------------------------------------------------------
	// Shrink a rectangle.
	public void shrink(int percent){
		width = width / (100 / percent);
		height = height / (100 / percent);
	}


	// -------------------------------------------------------------------------------------------------------------
	// Expand a rectangle.
	public void expand(int percent){
		width = (width * 100) / percent;
		height = (height * 100) / percent;
	}

}
