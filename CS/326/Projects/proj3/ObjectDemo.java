/** 
 * Jacob Truman
 * Project #3
 *
 * Simple object creation and usage.
 */

import java.awt.Graphics;
import javax.swing.*;

public class ObjectDemo extends JApplet {

    public void paint ( Graphics scr ) {

	super.paint(scr);			// call paint method inherited from JApplet

	// -------------------------------------------------------------------------------------------------------------
	// Declare/create some point objects and display.

	Point MyPt1 = new Point (50, 480);
	Point MyPt2 = new Point (75, 400);
	Point MyPt3 = new Point ();

	MyPt1.drawPoint(scr);
	MyPt2.drawPointAndPos(scr);
	MyPt3.drawPointAndPos(scr);


	// -------------------------------------------------------------------------------------------------------------
	// Declare/create some circle objects and display.
	//  Note, circle is centered at a "Point" object.

	Point CircCntr1 = new Point (250,300);
	Circle MyCirc1 = new Circle (CircCntr1, 40);
	Circle MyCirc2 = new Circle ();
	Point CircCntr3 = new Point (400,75);
	Circle MyCirc3 = new Circle (CircCntr3, 60);

	MyCirc1.drawCircle(scr);
	MyCirc1.caption(scr, "Circle #1");

	MyCirc2.move(250, 100);
	MyCirc2.drawCircleAndPos(scr);
	MyCirc2.caption(scr, "C2 Area = "+MyCirc3.area());

	MyCirc3.drawCircleAndPos(scr);				// Draw the circle3
	MyCirc3.caption(scr, "Circle 3");

	MyCirc3.move(400, 175);						// Move circle3
	MyCirc3.shrink(50);							// Shrink circle3 by 50%
	MyCirc3.drawCircleAndPos(scr);				// Draw smaller circle3 in new location
	MyCirc3.caption(scr, "C 3a, Area = "+MyCirc3.area());

	MyCirc3.move(400, 300);						// Move circle3 again.
	MyCirc3.expand(200);						// Expand circle 3 by 200%
	MyCirc3.drawCircleAndPos(scr);				// Draw larger circle3 in new location
	MyCirc3.caption(scr, "C 3b, Area = "+MyCirc3.area());

	MyCirc3.move(400, 425);						// Move circle3 again.
	MyCirc3.shrink(25);							// Shrink circle3 by 50%
	MyCirc3.drawCircleAndPos(scr);				// Draw circle3 in new location.
	MyCirc3.caption(scr, "C 3c, Area = "+MyCirc3.area());


	// -------------------------------------------------------------------------------------------------------------
	// Declare/create some rectangle objects and display.
	//  Note, rectangle is centered at a "Point" object.

	Point MyRectPt1 = new Point (650, 100);
	Rectangle MyRect1 = new Rectangle (MyRectPt1, 10, 20);
	Point MyRectPt2 = new Point (650, 150);
	Rectangle MyRect2 = new Rectangle (MyRectPt2, 20, 10);
	Rectangle MyRect3 = new Rectangle(30,30);

	MyRect1.drawRectangle(scr);
	MyRect1.caption(scr, "R1, Area="+MyRect1.area());

	MyRect2.drawRectangleAndPos(scr);
	MyRect2.caption(scr, "R #2a, Area="+MyRect2.area());

	MyRect2.move(650, 400);
	MyRect2.shrink(50);
	MyRect2.drawRectangleAndPos(scr);
	MyRect2.caption(scr, "R #2b, Area="+MyRect2.area());

	MyRect3.move(650, 200);
	MyRect3.drawRectangleAndPos(scr);
	MyRect3.caption(scr, "Rect 3a, Area="+MyRect3.area());
	MyRect3.move(650, 300);
	MyRect3.expand(100);
	MyRect3.drawRectangleAndPos(scr);
	MyRect3.caption(scr, "Rect 3b, Area="+MyRect3.area());


	// -------------------------------------------------------------------------------------------------------------
	// Declare/create some triangle objects and display.
	//  Note, triangle is centered at a "Point" object.

	Point MyTriPt1 = new Point (75, 100);
	Triangle MyTri1 = new Triangle (MyTriPt1, 85);
	Triangle MyTri2 = new Triangle();
	Triangle MyTri3 = new Triangle(25);

	MyTri1.drawTriangle(scr);
	MyTri1.caption(scr, "T1 Big");
	MyTri1.shrink(50);
	MyTri1.drawTriangle(scr);
	MyTri1.caption(scr, "T1 Small");

	MyTri2.move(75, 200);
	MyTri2.drawTriangleAndPos(scr);
	MyTri2.caption(scr, "Tri 2");

	MyTri3.move(75,300);
	MyTri3.drawTriangle(scr);
	MyTri3.caption(scr, "Tri #3");
	MyTri3.expand(200);
	MyTri3.drawTriangle(scr);
	MyTri3.caption(scr, "Tri #3a");

	}

}
