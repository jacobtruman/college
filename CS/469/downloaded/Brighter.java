/*************************************************************************
 *  Compilation:  javac Brighter.java
 *  Execution:    java Brighter filename
 * 
 *  Reads in an image from a file, and create a brighter version.
 *
 *  % java Brighter image.jpg
 *
 *************************************************************************/

import java.awt.Color;

public class Brighter {

    public static void main(String[] args) {
        Picture pic1 = new Picture(args[0]);
        int width  = pic1.width();
        int height = pic1.height();
        pic1.show();

        Picture pic2 = new Picture(width, height);
        for (int i = 0; i < width; i++) {
            for (int j = 0; j < height; j++) {
                Color c1 = pic1.get(i, j);
                Color c2 = c1.brighter();
                pic2.set(i, j, c2);
            }
        }
        pic2.show();
    }
 

   
}
