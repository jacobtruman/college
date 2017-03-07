// -------------------------
// Developer: Jacob Truman -
// Date: 5/8/06            -
// StopLight.java          -
// -------------------------

import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class StopLight extends JFrame implements ItemListener {
	private JRadioButton jrbOvalRed, jrbOvalYellow, jrbOvalGreen;
	private DisplayFigure displayFigure = new DisplayFigure();

	public static void main(String[] args) {
		StopLight frame = new StopLight();
		frame.setSize(300, 250);
		frame.setTitle("Stop Light");
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.setVisible(true);
		frame.displayFigure.setFigure(1);
	}

	public StopLight() {
		// -----------------------
		// Panel for radio buttons
		// -----------------------
		JPanel myPanel = new JPanel();
		myPanel.setLayout(new FlowLayout());
		myPanel.add(jrbOvalRed = new JRadioButton("Red"));
		myPanel.add(jrbOvalYellow = new JRadioButton("Yellow"));
		myPanel.add(jrbOvalGreen = new JRadioButton("Green"));

		// -------------------
		// Group radio buttons
		// -------------------
		ButtonGroup btg = new ButtonGroup();
		btg.add(jrbOvalRed);
		btg.add(jrbOvalYellow);
		btg.add(jrbOvalGreen);

		// -----------------------------------------
		// Put figure panel and myPanek in the frame
		// -----------------------------------------
		getContentPane().add(displayFigure, BorderLayout.CENTER);
		getContentPane().add(myPanel, BorderLayout.SOUTH);

		// -----------------
		// Register listener
		// -----------------
		jrbOvalRed.addItemListener(this);
		jrbOvalYellow.addItemListener(this);
		jrbOvalGreen.addItemListener(this);
	}

	// ----------------
	// Handle ItemEvent
	// ----------------
	public void itemStateChanged(ItemEvent e) {
		if (jrbOvalRed.isSelected()) {
			displayFigure.setFigure(2);
		}
		else if (jrbOvalYellow.isSelected()) {
			displayFigure.setFigure(3);
		}
		else if (jrbOvalGreen.isSelected()) {
			displayFigure.setFigure(4);
		}
	}
}

class DisplayFigure extends JPanel {
	private int figureID;

	public DisplayFigure() {
	}

	public void setFigure(int x) {
		figureID = x;
		repaint();
	}

	public void paintComponent(Graphics g) {
		super.paintComponent(g);

		// ------------------------
		// Initialize default color
		// ------------------------
		g.setColor(Color.black);

		switch (figureID) {
			// ------------------------------------------------------------
			// Case 1: Draw Rectangle and 3 circles - no color, none filled
			// ------------------------------------------------------------
			case 1:
				g.drawRect(100, 10, 75, 170);
				g.drawOval(115, 20, 45, 45);
				g.drawOval(115, 70, 45, 45);
				g.drawOval(115, 120, 45, 45);
			break;
			// ----------------------------------------------------------
			// Case 2: Draw Rectangle and 3 circles - fill top circle red
			// ----------------------------------------------------------
			case 2:
				g.drawRect(100, 10, 75, 170);
				g.drawOval(115, 70, 45, 45);
				g.drawOval(115, 120, 45, 45);;
				g.setColor(Color.red);
				g.fillOval(115, 20, 45, 45);
			break;
			// ----------------------------------------------------------------
			// Case 3: Draw Rectangle and 3 circles - fill middle circle yellow
			// ----------------------------------------------------------------
			case 3:
				g.drawRect(100, 10, 75, 170);
				g.drawOval(115, 20, 45, 45);
				g.drawOval(115, 120, 45, 45);
				g.setColor(Color.yellow);
				g.fillOval(115, 70, 45, 45);
			break;
			// ---------------------------------------------------------------
			// Case 4: Draw Rectangle and 3 circles - fill bottom circle green
			// ---------------------------------------------------------------
			case 4:
				g.drawRect(100, 10, 75, 170);
				g.drawOval(115, 20, 45, 45);
				g.drawOval(115, 70, 45, 45);
				g.setColor(Color.green);
				g.fillOval(115, 120, 45, 45);
			break;
		}
	}
}