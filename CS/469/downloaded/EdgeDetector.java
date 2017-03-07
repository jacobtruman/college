/*************************************************************************
 *  Compilation:  javac EdgeDetector.java
 *  Execution:    java EdgeDetector filename
 * 
 *  Reads in an image from a file, and flips it horizontally.
 *
 *  % java FlipX image.jpg
 *
 *************************************************************************/

import java.awt.Color;

public class EdgeDetector {

    // truncate color component to be between 0 and 255
    public static int truncate(int a) {
        if      (a <   0) return 0;
        else if (a > 255) return 255;
        else              return a;
    }

    public static void main(String[] args) {

        int[][] sobel1 = { {-1,  0,  1 },
                            {-2,  0,  2 },
                            {-1,  0,  1 }
                          };
        int[][] sobel2 = { { 1,  2,  1 },
                            { 0,  0,  0 },
                            {-1, -2, -1 }
                          };
								  
			/*int[][] laplacian1 = { {-1,  -1,  -1},
                            {-1,  4,  -1},
                            {-1,  -1, -1}
                          };*/

        Picture pic = new Picture("lena.jpg");
        int width    = pic.width();
        int height   = pic.height();
		Picture sobel = new Picture(width, height);
		//Picture laplacian = new Picture(width, height);


        for (int y = 1; y < height - 1; y++) {
            for (int x = 1; x < width - 1; x++) {

                // get 3-by-3 array of colors in neighborhood
                int[][] gray = new int[3][3];
                for (int i = 0; i < 3; i++) {
                    for (int j = 0; j < 3; j++) {
                        gray[i][j] = (int) Luminance.lum(pic.get(x-1+i, y-1+j));
                    }
                }

                // apply filter
                int gray1 = 0, gray2 = 0, gray3 = 0;
                for (int i = 0; i < 3; i++) {
                    for (int j = 0; j < 3; j++) {
                        gray1 += gray[i][j] * sobel1[i][j];
                        gray2 += gray[i][j] * sobel2[i][j];
								//gray3 += gray[i][j] * laplacian1[i][j];
                    }
                }
                // int magnitude = 255 - truncate(Math.abs(gray1) + Math.abs(gray2));
                int magnitude = 255 - truncate((int) Math.sqrt(gray1*gray1 + gray2*gray2));
                Color grayscale = new Color(magnitude, magnitude, magnitude);
                sobel.set(x, y, grayscale);
					 //laplacian.set(x, y, grayscale);
            }
        }
        pic.show();
        sobel.show();
		  //laplacian.show();
    	sobel.save("sobel.jpg");
    }
}
