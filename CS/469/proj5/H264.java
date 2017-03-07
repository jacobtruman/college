/*************************************************************************
 * Jacob Truman
 * CS 469
 * Project #5
 *
 *	H264.java
 *************************************************************************/

// imports
import javax.imageio.ImageIO;
import javax.swing.*;
import java.awt.image.BufferedImage;
import java.io.*;
import java.awt.Color;
import java.awt.*;
import java.awt.image.*;
import java.awt.Toolkit;


//public class H264 implements ActionListener{
public class H264{
	// variables
	private BufferedImage image, bPic;
	private JFrame picFrame;
	int h, w;
	Image Dimg, img;

	// create an image by reading in an image by filename
	public H264(String filename){
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
	public H264(String filename, String alg, int h, int w){
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

		for (int y = 0; y < h; y+=16){
			for (int x = 0; x < w; x+=16){
				for (int m = 0; m < 16; m++){
					for (int n = 0; n < 16; n++){
						
						int cr, cg, cb, newX, newY;
						newX = x + m;
						newY = y + n;
						if((newX < w) && (newY < h)){
							Color pixel = new Color(bPic.getRGB(newX, newY));

							cr = pixel.getRed();
							cg = pixel.getGreen();
							cb = pixel.getBlue();
							Color newPixel = new Color(cr, cg, cb);
							image.setRGB(newX, newY, newPixel.getRGB());
						}
					}
				}
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
		H264 pic = new H264("lena.jpg");
		pic.show("Original");
		int h = pic.height();
		int w = pic.width();

		H264 pic5 = new H264("lena.jpg", "H264", h, w);
		pic5.show("H264");
	}
}