// ScrollBarDemo.java: Use scroll bars to move the message
import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class ScrollBarDemo extends JFrame
  implements AdjustmentListener {
  // Create horizontal and vertical scroll bars
  private JScrollBar jscbHort =
    new JScrollBar(JScrollBar.HORIZONTAL);
  private JScrollBar jscbVert =
    new JScrollBar(JScrollBar.VERTICAL);

  // Create a MessagePanel
  private MessagePanel messagePanel =
    new MessagePanel("Welcome to Java");

  /** Main method */
  public static void main(String[] args) {
    ScrollBarDemo frame = new ScrollBarDemo();
    frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    frame.pack();
    frame.setVisible(true);
  }

  /** Default constructor */
  public ScrollBarDemo() {
    setTitle("ScrollBarDemo");

    // Add scroll bars and message panel to the frame
    getContentPane().setLayout(new BorderLayout());
    getContentPane().add(messagePanel, BorderLayout.CENTER);
    getContentPane().add(jscbVert, BorderLayout.EAST);
    getContentPane().add(jscbHort, BorderLayout.SOUTH);

    // Register listener for the scroll bars
    jscbHort.addAdjustmentListener(this);
    jscbVert.addAdjustmentListener(this);
  }

  /** Handle scroll bar adjustment actions */
  public void adjustmentValueChanged(AdjustmentEvent e) {
    if (e.getSource() == jscbHort) {
      // getValue() and getMaximumValue() return int, but for better
      // precision, use double
      double value = jscbHort.getValue();
      double maximumValue = jscbHort.getMaximum();
      double newX = (value * messagePanel.getWidth() / maximumValue);
      messagePanel.setXCoordinate((int)newX);
    }
    else if (e.getSource() == jscbVert) {
      // getValue() and getMaximumValue() return int, but for better
      // precision, use double
      double value = jscbVert.getValue();
      double maximumValue = jscbVert.getMaximum();
      double newY = (value * messagePanel.getHeight() / maximumValue);
      messagePanel.setYCoordinate((int)newY);
    }
  }
}