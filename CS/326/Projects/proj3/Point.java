/** 
 * Jacob Truman
 * Project #3
 *
 * Simple object creation and usage.
 * Based on Sun's "Point.java" converted into an Applet.
 **/

import java.awt.Graphics;

public class Point {
	public int x = 0;
	public int y = 0;

	// -------------------------------------------------------------------------------------------------------------
	// Constructor 1, create point at default location (upper left corner).
	public Point () {
		this.x = 20;
		this.y = 20;
	}

	// -------------------------------------------------------------------------------------------------------------
	// Constructor 2, create point at specified location.
	public Point (int x_pos, int y_pos) {
		this.x = x_pos;
		this.y = y_pos;
	}

	// -------------------------------------------------------------------------------------------------------------
	// Method to display point.
	public void drawPoint ( Graphics g ) {
		g.fillOval ( x-3, y-3, 7, 7 );
	}

	// -------------------------------------------------------------------------------------------------------------
	// Method to display point and the (x,y) position.
	//	Position is displayed on the upper right side of the point.
	public void drawPointAndPos ( Graphics g ) {
		g.fillOval ( x-3, y-3, 7, 7 );
		g.drawString ( "(" + x + "," + y + ")", x+7, y-3 );
	}

	// -------------------------------------------------------------------------------------------------------------
	// Method to move point to a new, user specified (x,y) position.
	public void movePoint ( int new_x, int new_y ) {
		x = new_x;
		y = new_y;
	}

}
