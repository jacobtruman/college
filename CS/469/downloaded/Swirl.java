/*************************************************************************
 *  Compilation:  javac Swirl.java
 *  Execution:    java Swirl filename
 *
 *  Swirl image.
 * 
 *  % java Swirl baboon.jpg
 *
 *************************************************************************/

public class Swirl {

    public static void main(String[] args) {
        Picture pic1 = new Picture(args[0]);
        pic1.show();
        int width  = pic1.width();
        int height = pic1.height();
        double i0 = 0.5 * (width  - 1);
        double j0 = 0.5 * (height - 1);

        Picture pic2 = new Picture(width, height);

        // swirl
        for (int i = 0; i < width; i++) {
            for (int j = 0; j < height; j++) {
                double di = i - i0;
                double dj = j - j0;
                double r = Math.sqrt(di*di + dj*dj);
                double angle = Math.PI / 256 * r;
                int ii = (int) (-di * Math.cos(angle) + dj * Math.sin(angle) + i0);
                int jj = (int) ( di * Math.sin(angle) + dj * Math.cos(angle) + j0);

                // plot pixel (i, j) the same color as (ii, jj) if it's in bounds
                if (ii >= 0 && ii < width && jj >= 0 && jj < height)
                    pic2.set(i, j, pic1.get(ii, jj));
            }
        }

        pic2.show();
    }
 

   
}
