/*************************************************************************
 *  Compilation:  javac Rotation.java
 *  Execution:    java Rotation filename angle
 *
 *  Rotate image a given number of degrees counterclockwise.
 * 
 *  % java Rotation baboon.jpg 30
 *
 *
 *************************************************************************/

// import java.awt.Color;

public class Rotation {

    public static void main(String[] args) {
        Picture pic1 = new Picture(args[0]);
        pic1.show();
        int width  = pic1.width();
        int height = pic1.height();

        double angle = Math.toRadians(Double.parseDouble(args[1]));
        double sin = Math.sin(angle);
        double cos = Math.cos(angle);
        double i0 = 0.5 * (width  - 1);     // point to rotate about
        double j0 = 0.5 * (height - 1);     // center of image

        Picture pic2 = new Picture(width, height);

        // rotation
        for (int i = 0; i < width; i++) {
            for (int j = 0; j < height; j++) {
                double a = i - i0;
                double b = j - j0;
                int ii = (int) (-a * cos + b * sin + i0);
                int jj = (int) ( a * sin + b * cos + j0);

                // plot pixel (i, j) the same color as (ii, jj) if it's in bounds
                if (ii >= 0 && ii < width && jj >= 0 && jj < height)
                    pic2.set(i, j, pic1.get(ii, jj));
            }
        }

        pic2.show();
    }
 

   
}
