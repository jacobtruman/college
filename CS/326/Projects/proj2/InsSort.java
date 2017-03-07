/** 
 * Jacob Truman
 * Project #2
 * 
 * Learn basic Java kanguage constructs.
 * Sort a list of numbers.
 *
 *	     begin
 *		for  i = 1 to len-1
 *		temp := list(i)
 *		j := i - 1
 *		while ( (j >= 0) and (list(j) > temp) )
 *			list(j+1) := list(j)
 *			j := j - 1
 *			end_while
 *		list(j+1) := temp
 *		end_for
 *	end_begin
 *
 */

import java.awt.Graphics;
import javax.swing.*;

public class InsSort extends JApplet {

    public void paint ( Graphics g ) {

	super.paint ( g );				// call paint method inherited from JApplet

	//-----------------------------------------------------
        // Display name.

	int	x_pos = 15;
	int	y_pos = 25;

        g.drawString( "Jacob Truman", x_pos, y_pos );
	y_pos += 15;
        g.drawString ( "Project #2", x_pos, y_pos );
	y_pos += 45;

	int	list[];					// declare reference to array
	list = new int[10];				// create array
	int	i, j, tmp, sum = 0, avg;


	//-----------------------------------------------------
	// Generate list of random numbers.

	for ( i=0; i<list.length; i++) {
		list[i] = (int) (Math.random() * 100); }


	//-----------------------------------------------------
        // Display unsorted list.

	g.drawString("Unsorted List:", x_pos, y_pos);
	y_pos += 15;
	for ( i = 0 ; i < list.length ; i++ ) {
		g.drawString("\t  "+list[i], x_pos, y_pos);
		x_pos += 20;
	}


	//-----------------------------------------------------
        // Sort list.

/*
 *	     begin
 *		for  i = 1 to len-1
 *		temp := list(i)
 *		j := i - 1
 *		while ( (j >= 0) and (list(j) > temp) )
 *			list(j+1) := list(j)
 *			j := j - 1
 *			end_while
 *		list(j+1) := temp
 *		end_for
 *	end_begin
*/
	for (i = 0; i < list.length; i++) {
		tmp = list[i];
		j = i - 1;
		while ((j >= 0) && (list[j] > tmp)){
			list[j + 1] = list[j];
			j = j - 1;
		}
		list[j + 1] = tmp;
	}

	//-----------------------------------------------------
        // Display sorted list.

	x_pos = 15;
	y_pos += 25;
	g.drawString("Sorted List:", x_pos, y_pos);
	y_pos += 15;


	for ( i = 0 ; i < list.length ; i++ ) {
		g.drawString("\t  "+list[i], x_pos, y_pos);
		x_pos += 20;
	}

	//-----------------------------------------------------
        // Compute and display sum and average.

	x_pos = 15;
	y_pos += 25;
	g.drawString("List Sum:", x_pos, y_pos);
	y_pos += 15;

	for ( i = 0 ; i < list.length ; i++ ) {
		sum += list[i];
	}

	g.drawString("\t  "+sum, x_pos, y_pos);

	x_pos = 15;
	y_pos += 25;
	g.drawString("List Average:", x_pos, y_pos);
	y_pos += 15;

	avg = sum / list.length;

	g.drawString("\t  "+avg, x_pos, y_pos);

	}

}
