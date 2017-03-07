/*************************************************************************
 * Jacob Truman
 * CS 469
 *
 *	GetYIQ.java
 * Converts RGB to YIQ
 *************************************************************************/

// imports
import javax.imageio.ImageIO;
import javax.swing.*;
import java.awt.image.BufferedImage;
import java.io.*;
import java.awt.Color;

public class GetYIQ{
	// variables
	private BufferedImage image, bPic;
	private JFrame picFrame;

	// create an image by reading in an image by filename
	public GetYIQ(String filename){
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
	public GetYIQ(String filename, String which, int h, int w){
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

		for (int y = 1; y < height() - 1; y++){
			for (int x = 1; x < width() - 1; x++){
				int numr, numg, numb, numy, numi, numq;
				Color color = new Color(bPic.getRGB(x, y));
				numr = color.getRed();
				numg = color.getGreen();
				numb = color.getBlue();

				numy = (int)((numr * 0.299) + (numg * 0.587) + (numb * 0.114));
				numi = (int)((numr * 0.596) - (numg * 0.275) - (numb * 0.321));
				numq = (int)((numr * 0.212) - (numg * 0.528) + (numb * 0.311));
				
				
				/*numy = truncate(numy);
				numi = truncate(numi);
				numq = truncate(numq);*/
				numy = Math.abs(numy);
				numi = 255 - Math.abs(numi);
				numq = 255 - Math.abs(numq);

				Color newColor;
				if(which == "R"){
					newColor = new Color(numr, 0, 0);
				}else if(which == "G"){
					newColor = new Color(0, numg, 0);
				}else if(which == "B"){
					newColor = new Color(0, 0, numb);
				}else if(which == "Y"){
					newColor = new Color(numy, numy, numy);
				}else if(which == "I"){
					newColor = new Color(numi, numi, numi);
				}else if(which == "Q"){
					newColor = new Color(numq, numq, numq);
				}else{
					newColor = new Color(numr, numg, numb);
				}
					
				/*
				int r = c.getRed();
				int g = c.getGreen();
				int b = c.getBlue();
					
				R.set(i, j, new Color(r, 0, 0));
				G.set(i, j, new Color(0, g, 0));
				B.set(i, j, new Color(0, 0, b));

				|Y|   |0.299  0.587  0.114|   |R|
				|I| = |0.596 -0.275 -0.321| * |G|
				|Q|   |0.212 -0.528  0.311|   |B|
				*/
					
				image.setRGB(x, y, newColor.getRGB());
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