/*************************************************************************
 *  Compilation:  javac ColorSeparation.java
 *  Execution:    java ColorSeparation filename
 * 
 *  Reads in an image from a file, and displays the red, green, and
 *  blue portions in three separate windows.
 *
 *  % java ColorSeparation baboon.jpg
 *
 *************************************************************************/

import java.awt.Color;

public class ColorSeparation {

    public static void main(String[] args) {
        
        // read in the picture specified by command-line argument
        Picture pic = new Picture(args[0]);
        int width  = pic.width();
        int height = pic.height();

        // create three empy pictures of the same dimension
        Picture R = new Picture(width, height);
        Picture G = new Picture(width, height);
        Picture B = new Picture(width, height);

        // separate colors
        for (int i = 0; i < width; i++) {
            for (int j = 0; j < height; j++) {
                Color c = pic.get(i, j);
                int r = c.getRed();
                int g = c.getGreen();
                int b = c.getBlue();
                R.set(i, j, new Color(r, 0, 0));
                G.set(i, j, new Color(0, g, 0));
                B.set(i, j, new Color(0, 0, b));
            }
        }

        // display each one in its own window
        R.show();
        G.show();
        B.show();
    }
 
   
}
