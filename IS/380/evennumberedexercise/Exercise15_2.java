// Exercise15_2.java: Perform division on two integers
import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class Exercise15_2 extends JApplet
    implements ActionListener {
  // Text fields for Number 1, Number 2, and Result
  private JTextField jtfNum1, jtfNum2, jtfResult;

  // Create the "Divide" button
  private JButton jbtDiv = new JButton("Divide");

  // Default Constructor
  public Exercise15_2() {
    // Panel p1 to hold text fields and labels
    JPanel p1 = new JPanel();
    p1.setLayout(new FlowLayout());
    p1.add(new JLabel("Number 1"));
    p1.add(jtfNum1 = new JTextField(3));
    p1.add(new JLabel("Number 2"));
    p1.add(jtfNum2 = new JTextField(3));
    p1.add(new JLabel("Result"));
    p1.add(jtfResult = new JTextField(4));
    jtfResult.setEditable(false);
    jtfResult.setHorizontalAlignment(SwingConstants.RIGHT);

    getContentPane().add(p1, BorderLayout.CENTER);
    getContentPane().add(jbtDiv, BorderLayout.SOUTH);

    // Register listener
    jbtDiv.addActionListener(this);
  }

  /** Handle ActionEvent from the Divide button */
  public void actionPerformed(ActionEvent e) {
    if (e.getSource() == jbtDiv) {
      try {
        // Get numbers
        int num1 = Integer.parseInt(jtfNum1.getText().trim());
        int num2 = Integer.parseInt(jtfNum2.getText().trim());

        int result = num1 / num2;

        // Set result in jtfResult
        jtfResult.setText(String.valueOf(result));
      }
      catch (ArithmeticException ex) {
        JOptionPane.showMessageDialog(this, "Arithmetic errors",
                            "Warning", JOptionPane.WARNING_MESSAGE);
      }
      catch (NumberFormatException ex) {
        JOptionPane.showMessageDialog(this, "Number format errors",
                            "Warning", JOptionPane.WARNING_MESSAGE);
      }
    }
  }

  public static void main(String[] args) {
    // Create a frame
    JFrame frame = new JFrame("Exercise15_2");

    // Create an instance of the applet
    Exercise15_2 applet = new Exercise15_2();

    // Add the applet instance to the frame
    frame.getContentPane().add(applet, BorderLayout.CENTER);

    // Display the frame
    frame.setSize(300, 300);
    frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    frame.setVisible(true);
  }
}