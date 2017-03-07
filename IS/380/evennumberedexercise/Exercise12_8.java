// Exercise12_8.java: Display a flashing label
import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class Exercise12_8 extends JFrame {
  public Exercise12_8() {
    this.getContentPane().add(new FlashLabel("Welcome to Java"));
  }
  
  // Main method
  public static void main(String[] args) {
    // Create a frame
    JFrame frame = new Exercise12_8();
    frame.setTitle("Exercise12_8");
    frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    
    // Display the frame
    frame.setSize(200, 200);
    frame.setVisible(true);
  }
  
  class FlashLabel extends JPanel implements ActionListener {
    private boolean show = true;
    private Timer timer = new Timer(200, this);
    
    String label = "Welcome to Java";
    
    public FlashLabel(String label) {
      this.label = label;
      timer.start();
    }
    
    public void setLabel(String label) {
      this.label = label;
    }
    
    public void actionPerformed(ActionEvent e) {
      repaint();
    }
    
    public void paintComponent(Graphics g) {
      super.paintComponent(g);
      
      if (show)
        g.drawString(label, 20, 20);
      show = !show;
    }
    
    public Dimension getPreferredSize() {
      return new Dimension(200, 50);
    }
  }
}