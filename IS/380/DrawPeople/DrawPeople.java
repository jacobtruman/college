// -------------------------
// Developer: Jacob Truman -
// Date: 4/11/06           -
// DrawPeople.java         -
// -------------------------

import java.awt.*;
import javax.swing.*;

public class DrawPeople extends JFrame {
	public static void main(String[] args) {
		JButton jbnR;
		JFrame frame = new JFrame();
		frame.setSize(500, 250);
		frame.setTitle("Draw People");
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.setVisible(true);
		jbnR = new JButton("R");
      jbnR.setVerticalTextPosition(AbstractButton.CENTER);
      jbnR.setHorizontalTextPosition(AbstractButton.LEADING);
		
		frame.add(jbnR);

	}

	public DrawPeople() {
		Container container = getContentPane();
		container.setLayout(new GridLayout(1,1));
		container.add(new OvalsPanel());
	}
}
