/*************************************************************************
 *  Compilation:  javac Glass.java
 *  Execution:    java Glass filename
 * 
 *  Reads in an image from a file, and apply an image filter that
 *  makes it look like it's being seen through glass. This effect is
 *  accomplished by plotting pixel (i, j) in the color of a random
 *  neighboring pixel (ii, jj).
 *
 *  % java Glass baboon.jpg
 *
 *************************************************************************/

import java.awt.Color;

public class Glass {

    // return random integer between a and b
    public static int random(int a, int b) {
        return a + (int) (Math.random() * (b-a+1));
    }

    public static void main(String[] args) {
        Picture pic1 = new Picture(args[0]);
        pic1.show();
        int width  = pic1.width();
        int height = pic1.height();
        Picture pic2 = new Picture(width, height);

        // convert to grayscale
        for (int i = 0; i < width; i++) {
            for (int j = 0; j < height; j++) {
                int ii = (width  + i + random(-5, 5)) % width;
                int jj = (height + j + random(-5, 5)) % height;
                Color c = pic1.get(ii, jj);
                pic2.set(i, j, c);
            }
        }

        pic2.show();
    }
   
}
