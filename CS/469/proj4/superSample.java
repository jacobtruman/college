/*************************************************************************
 * Jacob Truman
 * CS 469
 * Project #4
 *
 *	superSample.java
 * Blow up image
 *************************************************************************/

// imports
import javax.imageio.ImageIO;
import javax.swing.*;
import java.awt.image.BufferedImage;
import java.io.*;
import java.awt.Color;


//public class superSample implements ActionListener{
public class superSample{
	// variables
	private BufferedImage image, bPic;
	private JFrame picFrame;

	// create an image by reading in an image by filename
	public superSample(String filename){
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
	public superSample(String filename, String alg, int h, int w){
		image = new BufferedImage(w * 2, h * 2, BufferedImage.TYPE_INT_RGB);
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

//		for (int y = 1; y < height() - 1; y++){
//			for (int x = 1; x < width() - 1; x++){
		for (int y = 1; y < h - 1; y++){
			for (int x = 1; x < w - 1; x++){

	 
				int cr, cg, cb;
				Color color1 = new Color(bPic.getRGB(x, y));
				Color color2 = new Color(bPic.getRGB(x+1, y));
				Color color3 = new Color(bPic.getRGB(x, y+1));
				Color color4 = new Color(bPic.getRGB(x+1, y+1));

				cr = color1.getRed();
				cg = color1.getGreen();
				cb = color1.getBlue();
				Color newColor1 = new Color(cr, cg, cb);
				image.setRGB(x*2 - 1, y*2 - 1, newColor1.getRGB());
				
				cr = color2.getRed();
				cg = color2.getGreen();
				cb = color2.getBlue();
				Color newColor2 = new Color(cr, cg, cb);
				image.setRGB(x*2, y*2 - 1, newColor2.getRGB());
				
				cr = color3.getRed();
				cg = color3.getGreen();
				cb = color3.getBlue();
				Color newColor3 = new Color(cr, cg, cb);
				image.setRGB(x*2 - 1, y*2, newColor3.getRGB());
				
				cr = color4.getRed();
				cg = color4.getGreen();
				cb = color4.getBlue();
				Color newColor4 = new Color(cr, cg, cb);
				image.setRGB(x*2, y*2, newColor4.getRGB());
			}
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
	public static double lum(Color color){
		int r = color.getRed();
		int g = color.getGreen();
		int b = color.getBlue();
		return .299*r + .587*g + .114*b;
   }

	// main function - open images and display them
	public static void main(String[] args){
		// get and show original image
		superSample pic = new superSample("lena.jpg");
		pic.show("Original");
		int h = pic.height();
		int w = pic.width();
		

		superSample pic5 = new superSample("lena.jpg", "BloUp", h, w);
		pic5.show("BlowUp");
	}
}