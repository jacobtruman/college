/** 
 * Jacob Truman
 * Project #3
 *
 * Simple triangle creation and usage.
 */

import java.awt.Graphics;
import javax.swing.*;

public class Triangle{
	public int height;				// The height of this triangle
	public Point rCenter;		// Point object for center of triangle.

	// -------------------------------------------------------------------------------------------------------------
	// Creates a triangle with default location (100,100) with a default height 20.
	public Triangle(){
		this (new Point(100, 100), 20);
	}

	// -------------------------------------------------------------------------------------------------------------
	// Creates a triangle with default location (100,100).
	//	@param h height of the triangle
	public Triangle(int h){
		this (new Point(100, 100), h);
	}

	// -------------------------------------------------------------------------------------------------------------
	// Creates a triangle with the specified origin and size.
	//	Triangle center is Point().
	//	@param h height of the triangle
	public Triangle(Point p, int h){
		rCenter = p;
		height = h;
	}

	// -------------------------------------------------------------------------------------------------------------
	// Moves the triangle to the specified (x,y) position.
	public void move(int x, int y){
		rCenter.x = x;
		rCenter.y = y;
	}

	// -------------------------------------------------------------------------------------------------------------
	//  Returns the computed area of the triangle.
	public int area(){
		return (height * height);
	}

	// -------------------------------------------------------------------------------------------------------------
	// Draw the triangle.
	//	Draw the triangle lines heightd on the center point's (x,y) position.
	public void drawTriangle(Graphics g){
		int[] xs = new int[3];
		int[] ys = new int[3];
		xs[0] = rCenter.x;
		xs[1] = rCenter.x - (height / 2);
		xs[2] = rCenter.x + (height / 2);
		ys[0] = rCenter.y - (height / 2);
		ys[1] = rCenter.y + (height / 2);
		ys[2] = rCenter.y + (height / 2);
		g.drawPolygon(xs, ys, 3);
	}

	// -------------------------------------------------------------------------------------------------------------
	// Draw the triangle and display the position.
	//	Draw the triangle lines heightd on the center point's (x,y) position.
	//	The (x,y) position string is displayed on the approximate upper right hand side.
	public void drawTriangleAndPos(Graphics g){
		drawTriangle(g);
		g.drawString("(" + rCenter.x + "," + rCenter.y + ")",
						rCenter.x+(height/2)+5, rCenter.y-(height/2)+5);
	}

	// -------------------------------------------------------------------------------------------------------------
	// Draw the triangle and add a simple caption (starting at botton left).  Assumes triangle is already drawn!
	public void caption(Graphics g, String capt_str){
		g.drawString(capt_str, rCenter.x-(height/2), rCenter.y+(height/2)+15);
	}

	// -------------------------------------------------------------------------------------------------------------
	// Shrink a triangle.
	public void shrink(int percent){
		height = height / (100 / percent);
	}


	// -------------------------------------------------------------------------------------------------------------
	// Expand a triangle.
	public void expand(int percent){
		height = (height * 100) / percent;
	}

}
