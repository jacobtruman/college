// * ImgProcessor.java
// *
// * Jacob Truman
// * CS469 Section 1
// * Image Processor
// -------------------

import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JFileChooser;

public class ImgProcessor extends JPanel implements ActionListener{
	protected static JButton jbnNormal, jbnLaplacian, jbnSobel, jbnPrewitt, jbnRoberts, jbnCanny, jbnChoose, jbnR, jbnG, jbnB, jbnY, jbnI, jbnQ, jbnBU, jbnH264, jbnWavelet, jbnButter;
	static String fileName;
	
	public ImgProcessor(){

		jbnChoose = new JButton("Choose File");
		jbnChoose.addActionListener(this);
		add(jbnChoose);

		jbnNormal = new JButton("Normal");
		jbnNormal.addActionListener(this);
		add(jbnNormal);
		
		jbnLaplacian = new JButton("Laplacian");
		jbnLaplacian.addActionListener(this);
		add(jbnLaplacian);
		
		jbnSobel = new JButton("Sobel");
		jbnSobel.addActionListener(this);
		add(jbnSobel);
		
		jbnPrewitt = new JButton("Prewitt");
		jbnPrewitt.addActionListener(this);
		add(jbnPrewitt);
		
		jbnRoberts = new JButton("Roberts");
		jbnRoberts.addActionListener(this);
		add(jbnRoberts);
		
		jbnCanny = new JButton("Canny");
		jbnCanny.addActionListener(this);
		add(jbnCanny);
		
		jbnR = new JButton("R");
		jbnR.addActionListener(this);
		add(jbnR);

		jbnG = new JButton("G");
		jbnG.addActionListener(this);
		add(jbnG);
		
		jbnB = new JButton("B");
		jbnB.addActionListener(this);
		add(jbnB);
		
		jbnY = new JButton("Y");
		jbnY.addActionListener(this);
		add(jbnY);
		
		jbnI = new JButton("I");
		jbnI.addActionListener(this);
		add(jbnI);
		
		jbnQ = new JButton("Q");
		jbnQ.addActionListener(this);
		add(jbnQ);
		
		jbnBU = new JButton("Blow Up");
		jbnBU.addActionListener(this);
		add(jbnBU);
		
		jbnH264 = new JButton("H264");
		jbnH264.addActionListener(this);
		add(jbnH264);
		
		jbnWavelet = new JButton("Wavelet");
		jbnWavelet.addActionListener(this);
		add(jbnWavelet, BorderLayout.NORTH);
		
		jbnButter = new JButton("Butterworth");
		jbnButter.addActionListener(this);
		add(jbnButter, BorderLayout.SOUTH);
		
		disableButtons();

	}
	
	public void actionPerformed(ActionEvent e){
		//System.out.println(e.getActionCommand());

		if(e.getActionCommand() == "Choose File"){
			JFileChooser chooser = new JFileChooser();	 
			int returnVal = chooser.showOpenDialog(ImgProcessor.this);

			if(returnVal == JFileChooser.APPROVE_OPTION) {
				fileName = chooser.getCurrentDirectory() + "/" + chooser.getSelectedFile().getName();
			}else{
				fileName = "lena.jpg";
			}
			enableButtons();
		}else if(e.getActionCommand() == "Normal"){
			GetEdge origPic = new GetEdge(fileName);
			origPic.show(e.getActionCommand());
		}else if((e.getActionCommand() == "R") || (e.getActionCommand() == "G") || (e.getActionCommand() == "B") || (e.getActionCommand() == "Y") || (e.getActionCommand() == "I") || (e.getActionCommand() == "Q")){
			GetYIQ origPic = new GetYIQ(fileName);
			int h = origPic.height();
			int w = origPic.width();
			// get and show image after Selected edge detection
			GetYIQ pic = new GetYIQ(fileName, e.getActionCommand(), h, w);
			pic.show(e.getActionCommand());
		}else if(e.getActionCommand() == "Blow Up"){
			superSample origPic = new superSample(fileName);
			int h = origPic.height();
			int w = origPic.width();
			// get and show image after Selected edge detection
			superSample pic = new superSample(fileName, e.getActionCommand(), h, w);
			pic.show(e.getActionCommand());
		}else if(e.getActionCommand() == "H264"){
			H264 origPic = new H264(fileName);
			int h = origPic.height();
			int w = origPic.width();
			// get and show image after Selected edge detection
			H264 pic = new H264(fileName, e.getActionCommand(), h, w);
			pic.show(e.getActionCommand());
		}else if(e.getActionCommand() == "Wavelet"){
			Wavelet origPic = new Wavelet(fileName);
			int h = origPic.height();
			int w = origPic.width();
			// get and show image after Selected edge detection
			Wavelet pic = new Wavelet(fileName, e.getActionCommand(), h, w);
			pic.show(e.getActionCommand());
		}else if(e.getActionCommand() == "Butterworth"){
			Butterworth origPic = new Butterworth(fileName);
			int h = origPic.height();
			int w = origPic.width();
			// get and show image after Selected edge detection
			Butterworth pic = new Butterworth(fileName, e.getActionCommand(), h, w);
			pic.show(e.getActionCommand());
		}else{
			GetEdge origPic = new GetEdge(fileName);
			int h = origPic.height();
			int w = origPic.width();
			// get and show image after Selected edge detection
			GetEdge pic = new GetEdge(fileName, e.getActionCommand(), h, w);
			pic.show(e.getActionCommand());
		}
	}
	
	public void enableButtons(){
		jbnNormal.setEnabled(true);
		jbnLaplacian.setEnabled(true);
		jbnSobel.setEnabled(true);
		jbnPrewitt.setEnabled(true);
		jbnRoberts.setEnabled(true);
		jbnCanny.setEnabled(true);
		jbnR.setEnabled(true);
		jbnG.setEnabled(true);
		jbnB.setEnabled(true);
		jbnY.setEnabled(true);
		jbnI.setEnabled(true);
		jbnQ.setEnabled(true);
		jbnBU.setEnabled(true);
		jbnH264.setEnabled(true);
		jbnWavelet.setEnabled(true);
		jbnButter.setEnabled(true);
	}
	
	public void disableButtons(){
		jbnNormal.setEnabled(false);
		jbnLaplacian.setEnabled(false);
		jbnSobel.setEnabled(false);
		jbnPrewitt.setEnabled(false);
		jbnRoberts.setEnabled(false);
		jbnCanny.setEnabled(false);
		jbnR.setEnabled(false);
		jbnG.setEnabled(false);
		jbnB.setEnabled(false);
		jbnY.setEnabled(false);
		jbnI.setEnabled(false);
		jbnQ.setEnabled(false);
		jbnBU.setEnabled(false);
		jbnH264.setEnabled(false);
		jbnWavelet.setEnabled(false);
		jbnButter.setEnabled(false);
	}
	
	private static void createGUI(){
		
		JFrame.setDefaultLookAndFeelDecorated(true);	    
		JFrame frame = new JFrame("Image Processor");
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		ImgProcessor buttonContentPane = new ImgProcessor();
		buttonContentPane.setOpaque(true);
		frame.getRootPane().setDefaultButton(jbnSobel);
		frame.setContentPane(buttonContentPane);

		frame.pack();
		frame.setVisible(true);
    }
	
	public static void main(String[] args){
		createGUI();
	}
}