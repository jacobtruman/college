/*************************************************************************
 * Jacob Truman
 * CS 469
 * Project #1
 *
 *	GetEdge.java
 * Using different algorithms, get the edge of a picture
 *************************************************************************/

// imports
import javax.imageio.ImageIO;
import javax.swing.*;
import java.awt.image.BufferedImage;
import java.io.*;
import java.awt.Color;


//public class GetEdge implements ActionListener{
public class GetEdge{
	// variables
	private BufferedImage image, bPic;
	private JFrame picFrame;

	// create an image by reading in an image by filename
	public GetEdge(String filename){
		try{
			// try to read image file
			File file = new File(filename);
			if (file.isFile()) {
				image = ImageIO.read(file);
			}
		}
		catch (IOException e){
			throw new RuntimeException("Could not open file: " + filename);
		}
	}
	
	// create an image by reading in an image by filename, run algorithm specified
	public GetEdge(String filename, String alg, int h, int w){
		image = new BufferedImage(w, h, BufferedImage.TYPE_INT_RGB);
		try{
			// try to read image file
			File file = new File(filename);
			if (file.isFile()) {
				bPic = ImageIO.read(file);
			}
		}
		catch (IOException e){
			throw new RuntimeException("Could not open file: " + filename);
		}

		if ((alg == "Sobel") || (alg == "Prewitt") || (alg == "Laplacian") || (alg == "Roberts") || (alg == "Canny")){
			// define filter(s)
			int arrSize = 3;
			int[][] filter1 = {{-1, 0, 1},
									{-2, 0, 2},
									{-1, 0, 1}};
			int[][] filter2 = {{1, 2, 1},
									{0, 0, 0},
									{-1, -2, -1}};
			int[][] filter3 = {{-1, 0, 1},
									{-1, 0, 1},
									{-1, 0, 1}};
			int[][] filter4 = {{1, 1, 1},
									{0, 0, 0},
									{-1, -1, -1}};
			int[][] filter5 = {{0, -1, 0 },
									{-1, 4, -1},
									{0, -1, 0}};
			int[][] filter6 = {{-1, 0, -1},
									{0, 4, 0 },
									{-1, 0, -1}};
			int[][] filter7 = {{1, 0},
									{0, -1}};
			int[][] filter8 = {{0, 1},
									{-1, 0}};
			if(alg == "Roberts"){
				arrSize = 2;
			}
			for (int y = 1; y < height() - 1; y++){
				for (int x = 1; x < width() - 1; x++){
					// get arrSize-by-arrSize array of colors close by
					int[][] gray = new int[arrSize][arrSize];
					for (int i = 0; i < arrSize; i++) {
						for (int j = 0; j < arrSize; j++) {
							gray[i][j] = (int) lum(new Color(bPic.getRGB(x-1+i, y-1+j)));
						}
					}
					// apply filter
					int gray1 = 0, gray2 = 0;
					for (int i = 0; i < arrSize; i++) {
						for (int j = 0; j < arrSize; j++) {
							if((alg == "Sobel") || (alg == "Canny")){
								gray1 += gray[i][j] * filter1[i][j];
								gray2 += gray[i][j] * filter2[i][j];
							}else if(alg == "Prewitt"){
								gray1 += gray[i][j] * filter3[i][j];
								gray2 += gray[i][j] * filter4[i][j];
							}else if(alg == "Laplacian"){
								gray1 += gray[i][j] * filter5[i][j];
								gray2 += gray[i][j] * filter6[i][j];
							}else if(alg == "Roberts"){
								gray1 += gray[i][j] * filter7[i][j];
								gray2 += gray[i][j] * filter8[i][j];
							}
						}
					}
					int magnitude = 0;
					int theta = 1;
					if ((alg == "Sobel") || (alg == "Prewitt") || (alg == "Canny")){
						magnitude = 0 + truncate((int) Math.sqrt(gray1*gray1 + gray2*gray2));
						if(alg == "Canny"){
							//magnitude = 0 + truncate((int) Math.atan(gray1 / gray1));
						}
					}else if(alg == "Laplacian"){
						magnitude = 0 + truncate((int) Math.sqrt(gray1*gray1));
					}else if(alg == "Roberts"){
						magnitude = 0 + truncate((int) Math.max(gray1, gray1));
					}
					Color grayscale = new Color(magnitude, magnitude, magnitude);
					image.setRGB(x, y, grayscale.getRGB());
				}
			}
		}
	}
	
	// truncate val to either 0 or 255
	public static int truncate(int a) {
		if(a < 0){
			return 0;
		}else if(a > 255){
			return 255;
		}else{
			return a;
		}
	}

	// to embed in a JPanel, JFrame or other GUI widget
	public JLabel getJLabel() {
		if (image == null){
			return null;
		}
		ImageIcon icon = new ImageIcon(image);
		return new JLabel(icon);
	}

	// show the image
	public void show(String title) {
		// create the GUI for viewing the image if needed
		if (picFrame == null) {
			picFrame = new JFrame();

			picFrame.setContentPane(getJLabel());
			picFrame.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
			picFrame.setTitle(title + " Picture Frame");
			picFrame.setResizable(false);
			picFrame.pack();
			picFrame.setVisible(true);
		}
		// draw
		picFrame.repaint();
	}


	// get height
	public int height(){
		return image.getHeight(null);
	}
	
	// get width
	public int width(){
		return image.getWidth(null);
	}

   // return the monochrome luminance of given color
	public static double lum(Color color) {
		int r = color.getRed();
		int g = color.getGreen();
		int b = color.getBlue();
		return .299*r + .587*g + .114*b;
   }
}