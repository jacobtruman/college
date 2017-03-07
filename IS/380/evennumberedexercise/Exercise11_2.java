// Exercise11_2.java: Practice on containers and layout
import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class Exercise11_2 extends JFrame implements ActionListener {
  private JButton jbt1, jbt2, jbt3, jbt4, jbt5, jbt6;

  public static void main(String[] args) {
    Exercise11_2 frame = new Exercise11_2();
    frame.pack();
    frame.setTitle("Exercise11_2");
    frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    frame.setVisible(true);
  }

  public Exercise11_2() {
    // Create panel p1 add three buttons
    JPanel p1 = new JPanel();
    p1.setLayout(new FlowLayout());
    p1.add(jbt1 = new JButton("Button 1"));
    p1.add(jbt2 = new JButton("Button 2"));
    p1.add(jbt3 = new JButton("Button 3"));

    // Create Panel p2 and add three buttons
    JPanel p2 = new JPanel();
    p2.setLayout(new FlowLayout());
    p2.add(jbt4 = new JButton("Button 4"));
    p2.add(jbt5 = new JButton("Button 5"));
    p2.add(jbt6 = new JButton("Button 6"));

    // Place p1 and p2 in the frame
    getContentPane().setLayout(new BorderLayout());
    getContentPane().add(p1, BorderLayout.SOUTH);
    getContentPane().add(p2, BorderLayout.CENTER);

    // Register listeners
    jbt1.addActionListener(this);
    jbt2.addActionListener(this);
    jbt3.addActionListener(this);
    jbt4.addActionListener(this);
    jbt5.addActionListener(this);
    jbt6.addActionListener(this);
  }

  public void actionPerformed(ActionEvent e) {
    System.out.println(e.getActionCommand() + " was clicked");
  }
}