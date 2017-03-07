/*************************************************************************
 *  Compilation:  javac Wave.java
 *  Execution:    java Wave filename
 *
 *  Produce a wave effect.
 * 
 *  % java Wave baboon.jpg
 *
 *
 *************************************************************************/

import java.awt.Color;

public class Wave {

    public static void main(String[] args) {
        Picture pic1 = new Picture(args[0]);
        pic1.show();
        int width  = pic1.width();
        int height = pic1.height();

        Picture pic2 = new Picture(width, height);

        // wave filter
        for (int i = 0; i < width; i++) {
            for (int j = 0; j < height; j++) {
                int ii = i;
                int jj = (int) (j + 20 * Math.sin(i * 2 * Math.PI / 64));
                if (jj >= 0 && jj < height)
                    pic2.set(i, j, pic1.get(ii, jj));
            }
        }

        pic2.show();
    }
 

}
