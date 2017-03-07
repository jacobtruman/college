// Exercise13_16.java: Display histogram in a separate window
import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class Exercise13_16 extends JFrame implements ActionListener {
  private JTextArea jta;
  private JButton jbtShowHistogram = new JButton("Show Histogram");
  private BarChart histogram = new BarChart();

  /** Create a new frame to hold the histogram panel */
  private JFrame histogramFrame = new JFrame();

  /** Default construct */
  public Exercise13_16() {
    // Store text area in a scroll pane
    JScrollPane scrollPane = new JScrollPane(jta = new JTextArea());
    scrollPane.setPreferredSize(new Dimension(300, 200));
    jta.setWrapStyleWord(true);
    jta.setLineWrap(true);

    // Place scroll pane and button in the frame
    getContentPane().add(scrollPane, BorderLayout.CENTER);
    getContentPane().add(jbtShowHistogram, BorderLayout.SOUTH);

    // Register listener
    jbtShowHistogram.addActionListener(this);

    // Create a new frame to hold the histogram panel
    histogramFrame.getContentPane().add(histogram);
    histogramFrame.pack();
    histogramFrame.setTitle("Bar Chart");
  }

  /** Handle the button action */
  public void actionPerformed(ActionEvent e) {
    // Count the letters in the text area
    int[] count = countLetters();

    double[] data = new double[26];
    for (int i = 0; i < 26; i++)
      data[i] = count[i];

    // Set data names
    String[] letters = new String[26];
    for (int i = 0; i < 26; i++)
      letters[i] = "" + (char)('A' + i);

    histogram.setData(letters, data);

    // Show the frame
    histogramFrame.setVisible(true);
  }

  /** Count the letters in the text area */
  private int[] countLetters() {
    // Count for 26 letters
    int[] count = new int[26];

    // Get contents from the text area
    String text = jta.getText();

    // Count occurrence of each letter (case insensitive)
    for (int i=0; i<text.length(); i++) {
      char character = text.charAt(i);

      if ((character >= 'A') && (character <= 'Z')) {
        count[(int)character - 65]++; // The ASCII for 'A' is 65
      }
      else if ((character >= 'a') && (character <= 'z')) {
        count[(int)character - 97]++; // The ASCII for 'a' is 97
      }
    }

    return count; // Return the count array
  }

  /** Main method */
  public static void main(String[] args) {
    Exercise13_16 frame = new Exercise13_16();
    frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    frame.setTitle("Exercise13_16");
    frame.pack();
    frame.setVisible(true);
  }
}
