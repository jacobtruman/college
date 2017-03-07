// Exercise12_10.java: Display a moving label
import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class Exercise12_10 extends JFrame {
  public Exercise12_10() {
    this.getContentPane().add(new Fan());
  }
  
  // Main method
  public static void main(String[] args) {
    // Create a frame
    Exercise12_10 frame = new Exercise12_10();
    frame.setTitle("Exercise12_10: Running Fan");
    frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    
    // Display the frame
    frame.setSize(200, 200);
    frame.setVisible(true);
  }
}