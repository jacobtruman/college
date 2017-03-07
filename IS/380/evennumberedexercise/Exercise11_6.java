// Exercise11_6.java:
import javax.swing.*;
import java.awt.*;

public class Exercise11_6 extends JFrame {
  // Create two buttons
  private OvalButton jbtOk = new OvalButton("OK");
  private OvalButton jbtCancel = new OvalButton("Cancel");

  /** Default constructor */
  public Exercise11_6() {
    // Set the window title
    setTitle("Exercise11_6");

    // Set FlowLayout manager to arrange the components
    // inside the frame
    getContentPane().setLayout(new FlowLayout());

    // Add buttons to the frame
    getContentPane().add(jbtOk);
    getContentPane().add(jbtCancel);
  }

  /** Main method */
  public static void main(String[] args) {
    Exercise11_6 frame = new Exercise11_6();
    frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    frame.setSize(100, 80);
    frame.setVisible(true);
  }
}

class OvalButton extends JButton {
  public OvalButton() {
  }

  public OvalButton(String text) {
    super(text);
  }

  protected void paintComponent(Graphics g) {
    // Draw an oval
    super.paintComponent(g);
    g.drawOval(5, 5, getWidth() - 10, getHeight() - 10);
  }

  /** Override get method for preferredSize */
  public Dimension getPreferredSize() {
    return new Dimension(100, 50);
  }

  /** Override get method for minimumSize */
  public Dimension getMinimumSize() {
    return new Dimension(100, 50);
  }

  /** Main method */
  public static void main(String[] args) {
    // Create a frame and add two OvalButtons to
    // the frame
  }
}

