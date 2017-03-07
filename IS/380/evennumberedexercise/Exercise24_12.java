import java.awt.*;
import java.awt.event.*;
import java.io.*;
import javax.swing.*;
import java.util.*;

public class Exercise24_12 extends JApplet {
  //Construct the applet
  public Exercise24_12() {
    // Load the data from the file to the vectors
    Vector columnHeader = new Vector();
    Vector rows = new Vector();
    try {
      BufferedReader in = new BufferedReader(
        new FileReader("Exercise24_12Table.txt"));

      // Read the first line as header
      String line = in.readLine();
      StringTokenizer tokens = new StringTokenizer(line, ",\n\r");
      while (tokens.hasMoreTokens())
        columnHeader.addElement(tokens.nextToken());

      while ((line = in.readLine()) != null) {
        Vector row = new Vector();
        tokens = new StringTokenizer(line, ",\n\r");
        while (tokens.hasMoreTokens())
          row.addElement(tokens.nextToken());
        rows.addElement(row);
      }
    }
    catch (Exception ex) {
      ex.printStackTrace();
    }

    JTable jTable1 = new JTable(rows, columnHeader);
    jTable1.setRowHeight(25);
    getContentPane().add(new JScrollPane(jTable1), BorderLayout.CENTER);
  }

  //Main method
  public static void main(String[] args) {
    Exercise24_12 applet = new Exercise24_12();
    JFrame frame = new JFrame();
    //EXIT_ON_CLOSE == 3
    frame.setDefaultCloseOperation(3);
    frame.setTitle("Exercise24_12");
    frame.getContentPane().add(applet, BorderLayout.CENTER);
    applet.init();
    applet.start();
    frame.setSize(400, 320);
    Dimension d = Toolkit.getDefaultToolkit().getScreenSize();
    frame.setLocation((d.width - frame.getSize().width) / 2,
      (d.height - frame.getSize().height) / 2);
    frame.setVisible(true);
  }
}