// -------------------------
// Developer: Jacob Truman -
// Date: 4/11/06           -
// OvalsPanel.java         -
// -------------------------

import java.awt.*;
import javax.swing.*;

class OvalsPanel extends JPanel {
	public void paintComponent(Graphics g) {
		super.paintComponent(g);

		//Background
		g.setColor(Color.black);
		g.fillRect(0, 0, getWidth(), getHeight());
		
		int i = 0;

		//Color
		g.setColor(Color.red);
		//Head
		g.drawOval(getWidth() - (372 - (i * 60)), getHeight() - 140, 25, 25);
		//Legs
		g.drawLine(getWidth() - (380 - (i * 60)), getHeight(), getWidth() - (360 - (i * 60)), getHeight() - 40);
		g.drawLine(getWidth() - (340 - (i * 60)), getHeight(), getWidth() - (360 - (i * 60)), getHeight() - 40);
		//Body
		g.drawLine(getWidth() - (360 - (i * 60)), getHeight() - 40, getWidth() - (360 - (i * 60)), getHeight() - 115);
		//Arms
		g.drawLine(getWidth() - (390 - (i * 60)), getHeight() - 90, getWidth() - (360 - (i * 60)), getHeight() - 90);
		g.drawLine(getWidth() - (360 - (i * 60)), getHeight() - 90, getWidth() - (335 - (i * 60)), getHeight() - 110);

		i++;		
		//Color
		g.setColor(Color.cyan);
		//Head
		g.drawOval(getWidth() - (372 - (i * 60)), getHeight() - 190, 25, 25);
		//Legs
		g.drawLine(getWidth() - (380 - (i * 60)), getHeight(), getWidth() - (360 - (i * 60)), getHeight() - 40);
		g.drawLine(getWidth() - (340 - (i * 60)), getHeight(), getWidth() - (360 - (i * 60)), getHeight() - 40);
		//Body
		g.drawLine(getWidth() - (360 - (i * 60)), getHeight() - 40, getWidth() - (360 - (i * 60)), getHeight() - 165);
		//Arms
		g.drawLine(getWidth() - (390 - (i * 60)), getHeight() - 90, getWidth() - (360 - (i * 60)), getHeight() - 90);
		g.drawLine(getWidth() - (360 - (i * 60)), getHeight() - 90, getWidth() - (335 - (i * 60)), getHeight() - 110);
		
		i++;		
		//Color
		g.setColor(Color.green);
		//Head
		g.drawOval(getWidth() - (372 - (i * 60)), getHeight() - 185, 25, 25);
		//Legs
		g.drawLine(getWidth() - (380 - (i * 60)), getHeight(), getWidth() - (360 - (i * 60)), getHeight() - 40);
		g.drawLine(getWidth() - (340 - (i * 60)), getHeight(), getWidth() - (360 - (i * 60)), getHeight() - 40);
		//Body
		g.drawLine(getWidth() - (360 - (i * 60)), getHeight() - 40, getWidth() - (360 - (i * 60)), getHeight() - 160);
		//Arms
		g.drawLine(getWidth() - (390 - (i * 60)), getHeight() - 90, getWidth() - (360 - (i * 60)), getHeight() - 90);
		g.drawLine(getWidth() - (360 - (i * 60)), getHeight() - 90, getWidth() - (335 - (i * 60)), getHeight() - 110);
		
		i++;		
		//Color
		g.setColor(Color.yellow);
		//Head
		g.drawOval(getWidth() - (372 - (i * 60)), getHeight() - 135, 25, 25);
		//Legs
		g.drawLine(getWidth() - (380 - (i * 60)), getHeight(), getWidth() - (360 - (i * 60)), getHeight() - 40);
		g.drawLine(getWidth() - (340 - (i * 60)), getHeight(), getWidth() - (360 - (i * 60)), getHeight() - 40);
		//Body
		g.drawLine(getWidth() - (360 - (i * 60)), getHeight() - 40, getWidth() - (360 - (i * 60)), getHeight() - 110);
		//Arms
		g.drawLine(getWidth() - (390 - (i * 60)), getHeight() - 90, getWidth() - (360 - (i * 60)), getHeight() - 90);
		g.drawLine(getWidth() - (360 - (i * 60)), getHeight() - 90, getWidth() - (335 - (i * 60)), getHeight() - 110);
	}
}
