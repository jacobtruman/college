// SliderDemo.java: Use sliders to move the message
import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import javax.swing.event.*;

public class SliderDemo extends JFrame implements ChangeListener {
  // Create horizontal and vertical sliders
  private JSlider jsldHort = new JSlider(JSlider.HORIZONTAL);
  private JSlider jsldVert = new JSlider(JSlider.VERTICAL);

  // Create a MessagePanel
  private MessagePanel messagePanel =
    new MessagePanel("Welcome to Java");

  /** Main method */
  public static void main(String[] args) {
    SliderDemo frame = new SliderDemo();
    frame.setTitle("SliderDemo");
    frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    frame.pack();
    frame.setVisible(true);
  }

  /** Default constructor */
  public SliderDemo() {
    // Add sliders and message panel to the frame
    getContentPane().setLayout(new BorderLayout());
    getContentPane().add(messagePanel, BorderLayout.CENTER);
    getContentPane().add(jsldVert, BorderLayout.EAST);
    getContentPane().add(jsldHort, BorderLayout.SOUTH);

    // Set properties for sliders
    jsldHort.setPaintLabels(true);
    jsldHort.setPaintTicks(true);
    jsldHort.setMajorTickSpacing(10);
    jsldHort.setMinorTickSpacing(1);
    jsldHort.setPaintTrack(false);
    jsldVert.setInverted(true);

    // Register listener for the sliders
    jsldHort.addChangeListener(this);
    jsldVert.addChangeListener(this);
  }

  /** Handle scroll bar adjustment actions */
  public void stateChanged(ChangeEvent e) {
    if (e.getSource() == jsldHort) {
      // getValue() and getMaximumValue() return int, but for better
      // precision, use double
      double value = jsldHort.getValue();
      double maximumValue = jsldHort.getMaximum();
      double newX = (value * messagePanel.getWidth() / maximumValue);
      messagePanel.setXCoordinate((int)newX);
    }
    else if (e.getSource() == jsldVert) {
      // getValue() and getMaximumValue() return int, but for better
      // precision, use double
      double value = jsldVert.getValue();
      double maximumValue = jsldVert.getMaximum();
      double newY = (value * messagePanel.getHeight() / maximumValue);
      messagePanel.setYCoordinate((int)newY);
    }
  }
}