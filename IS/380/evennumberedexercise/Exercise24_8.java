import java.awt.*;
import java.awt.event.*;
import java.applet.*;
import javax.swing.*;

public class Exercise24_8 extends JApplet {
  private JComboBox jcboColor = new JComboBox(new String[] {
    "BLACK", "BLUE", "CYAN", "DARK_GRAY", "GRAY", "GREEN",
    "LIGHT_GRAY", "MAGENTA", "ORANGE", "PINK", "RED", "WHITE",
    "YELLOW"});
  private JLabel jlbl = new JLabel("Welcome to Java", JLabel.CENTER);

  public Exercise24_8() {
    getContentPane().add(jcboColor, BorderLayout.NORTH);
    getContentPane().add(jlbl, BorderLayout.CENTER);

    jcboColor.setRenderer(new Exercise24_8CellRenderer());

    jcboColor.addActionListener(new ActionListener() {
      public void actionPerformed(ActionEvent e) {
        if (jcboColor.getSelectedItem().equals("BLACK"))
          jlbl.setForeground(Color.black);
        else if (jcboColor.getSelectedItem().equals("BLUE"))
          jlbl.setForeground(Color.blue);
        else if (jcboColor.getSelectedItem().equals("CYAN"))
          jlbl.setForeground(Color.cyan);
        else if (jcboColor.getSelectedItem().equals("DARK_GRAY"))
          jlbl.setForeground(Color.darkGray);
        else if (jcboColor.getSelectedItem().equals("GRAY"))
          jlbl.setForeground(Color.gray);
        else if (jcboColor.getSelectedItem().equals("GREEN"))
          jlbl.setForeground(Color.green);
        else if (jcboColor.getSelectedItem().equals("LIGHT_GRAY"))
          jlbl.setForeground(Color.lightGray);
        else if (jcboColor.getSelectedItem().equals("MAGENTA"))
          jlbl.setForeground(Color.magenta);
        else if (jcboColor.getSelectedItem().equals("ORANGE"))
          jlbl.setForeground(Color.orange);
        else if (jcboColor.getSelectedItem().equals("PINK"))
          jlbl.setForeground(Color.pink);
        else if (jcboColor.getSelectedItem().equals("RED"))
          jlbl.setForeground(Color.red);
        else if (jcboColor.getSelectedItem().equals("WHITE"))
          jlbl.setForeground(Color.white);
        else if (jcboColor.getSelectedItem().equals("YELLOW"))
          jlbl.setForeground(Color.yellow);
      }
    });
  }

  public static void main(String[] args) {
    Exercise24_8 applet = new Exercise24_8();
    JFrame frame = new JFrame();
    //EXIT_ON_CLOSE == 3
    frame.setDefaultCloseOperation(3);
    frame.setTitle("Exercise24_8");
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