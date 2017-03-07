// Drawing lines, rectangles, or ovals based on user input.

import java.awt.Graphics;
import javax.swing.*;

public class proj1 extends JApplet {

    // draw shapes on applet's background
    public void paint ( Graphics g ) {
        super.paint ( g );       // call paint method inherited from JApplet

        g.drawString ( "Ed Jorgensen", 15, 25 );
        g.drawString ( "Project #1", 15, 40 );

        // draw rectangles
        for ( int i = 0; i < 10; i++ ) {  // loop 10 times (0-9)
            g.drawRect( 15 + i * 10, 75 + i * 10,
                    50 + i * 10, 50 + i * 10 );
        } // end for

        // draw ovals
        for ( int i = 0; i < 10; i++ ) {  // loop 10 times (0-9)
            g.drawOval( 300 + i * 10, 75 + i * 10,
                    50 + i * 10, 50 + i * 10 );
        } // end for

    } // end method paint

} // end class SwitchTest
