/*************************************************************************
 * Jacob Truman
 * CS 469
 * Project #6
 *
 *	Wavelet.java
 *************************************************************************/

// imports
import javax.imageio.ImageIO;
import javax.swing.*;
import java.awt.image.BufferedImage;
import java.io.*;
import java.awt.Color;


//public class Wavelet implements ActionListener{
public class Wavelet{
	// variables
	private static BufferedImage image, bPic;
	private JFrame picFrame;
	double winvMat[][];
	double hinvMat[][];
	double wfwdMat[][];
	double hfwdMat[][];
	

	// create an image by reading in an image by filename
	public Wavelet(String filename){
		try{
			// try to read image file
			File file = new File(filename);
			if (file.isFile()){
				image = ImageIO.read(file);
			}
		}
		catch (IOException e){
			throw new RuntimeException("Could not open file: " + filename);
		}
	}
	
	// create an image by reading in an image by filename, run algorithm specified
	public Wavelet(String filename, String alg, int h, int w){
		linearPr p = new linearPr();
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

		genMatrix(h, w);
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
	public static double lum(Color color){
		int r = color.getRed();
		int g = color.getGreen();
		int b = color.getBlue();
		return .299*r + .587*g + .114*b;
   }
	
	public static void genMatrix(int h, int w){

		double[][] winvMat = new double[w][w];
		double[][] hinvMat = new double[h][h];
		double[][] wfwdMat = new double[w][w];
		double[][] hfwdMat = new double[h][h];

		for(int i = 0; i < w; i++){
			for(int j = 0; j < w; j++){
				if((i == j) && (i % 2 == 0)){
					winvMat[i][j] = 1;
					wfwdMat[i][j] = 0.5;
				}else if((i == j) && (i % 2 != 0)){
					winvMat[i][j] = -1;
					wfwdMat[i][j] = -0.5;
				}else if(((i == j - 1) && (i % 2 == 0)) || ((j == i - 1) && (j % 2 == 0))){
					winvMat[i][j] = 1;
					wfwdMat[i][j] = 0.5;
				}else{
					winvMat[i][j] = 0;
					wfwdMat[i][j] = 0;
				}
//				System.out.print(winvMat[i][j]);
//				System.out.print(" ");
			}
//			System.out.println("newLine");
		}

		for(int i = 0; i < h; i++){
			for(int j = 0; j < h; j++){
				if((i == j) && (i % 2 == 0)){
					hinvMat[i][j] = 1;
					hfwdMat[i][j] = 0.5;
				}else if((i == j) && (i % 2 != 0)){
					hinvMat[i][j] = -1;
					hfwdMat[i][j] = -0.5;
				}else if(((i == j - 1) && (i % 2 == 0)) || ((j == i - 1) && (j % 2 == 0))){
					hinvMat[i][j] = 1;
					hfwdMat[i][j] = 0.5;
				}else{
					hinvMat[i][j] = 0;
					hfwdMat[i][j] = 0;
				}
//				System.out.print(hinvMat[i][j]);
//				System.out.print(" ");
			}
//			System.out.println("newLine");
		}

		matWavelet mrw = new matWavelet();
		matWavelet mgw = new matWavelet();
		matWavelet mbw = new matWavelet();
		linearPr p = new linearPr();
		double[][] cr = new double[h][w];
		double[][] cg = new double[h][w];
		double[][] cb = new double[h][w];
		double[][] icr = new double[w][h];
		double[][] icg = new double[w][h];
		double[][] icb = new double[w][h];

		for (int y = 0; y < h; y++){
			for (int x = 0; x < w; x++){
				Color pixel = new Color(bPic.getRGB(x, y));

				cr[y][x] = pixel.getRed();
				cg[y][x] = pixel.getGreen();
				cb[y][x] = pixel.getBlue();
//				Color newPixel = new Color(cr[y][x], cg[y][x], cb[y][x]);
//				image.setRGB(x, y, newPixel.getRGB());
			}
		}
		for (int x = 0; x < h; x++){
			mrw.transStep(wfwdMat, cr[x]);
			mgw.transStep(wfwdMat, cg[x]);
			mbw.transStep(wfwdMat, cb[x]);
		}
		
		for (int y = 0; y < h; y++){
			for (int x = 0; x < w; x++){
				icr[x][y] = cr[y][x];
				icg[x][y] = cg[y][x];
				icb[x][y] = cb[y][x];
			}
		}

		for (int x = 0; x < h; x++){
			mrw.transStep(hfwdMat, icr[x]);
			mgw.transStep(hfwdMat, icg[x]);
			mbw.transStep(hfwdMat, icb[x]);
		}
		
		for (int y = 0; y < h; y++){
			for (int x = 0; x < w; x++){
				cr[y][x] = icr[x][y];
				cg[y][x] = icg[x][y];
				cb[y][x] = icb[x][y];
			}
		}

		for (int y = 0; y < h; y++){
			for (int x = 0; x < w; x++){
				if((int)cr[y][x] < 0){
//					System.out.println((int)cr[y][x]);
					cr[y][x] = 0;
				}
				if((int)cg[y][x] < 0){
					cg[y][x] = 0;
				}
				if((int)cb[y][x] < 0){
					cb[y][x] = 0;
				}
				if((int)cr[y][x] > 255){
//					System.out.println((int)cr[y][x]);
					cr[y][x] = 255;
				}
				if((int)cg[y][x] > 255){
					cg[y][x] = 255;
				}
				if((int)cb[y][x] > 255){
					cb[y][x] = 255;
				}

				Color newPixel = new Color((int)cr[y][x], (int)cg[y][x], (int)cb[y][x]);
				image.setRGB(x, y, newPixel.getRGB());
			}
		}
	}
}