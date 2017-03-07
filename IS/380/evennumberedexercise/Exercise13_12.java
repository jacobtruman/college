// Exercise13_12.java: Demonstrate TextArea properties
import java.awt.*;
import java.awt.event.*;
import java.applet.*;
import javax.swing.*;
import javax.swing.border.*;

public class Exercise13_12 extends JFrame {
  boolean isStandalone = false;
  JScrollPane jScrollPane1 = new JScrollPane();
  JPanel jPanel1 = new JPanel();
  JTextArea jta = new JTextArea();
  TitledBorder titledBorder1;
  JRadioButton jrbWrapWords = new JRadioButton();
  JRadioButton jrbWrapCharacters = new JRadioButton();

  // Create a button group
  ButtonGroup btg = new ButtonGroup();
  JCheckBox jchkWrap = new JCheckBox();

  //Component initialization
  public Exercise13_12() {
    titledBorder1 = new TitledBorder("");
    this.setSize(new Dimension(400, 300));
    jta.setText("jTextArea1");
    jPanel1.setBorder(titledBorder1);
    titledBorder1.setTitle("Wrap Options");
    jrbWrapWords.setText("Wrap Words");
    jrbWrapWords.addActionListener(new java.awt.event.ActionListener() {

      public void actionPerformed(ActionEvent e) {
        jrbWrapWords_actionPerformed(e);
      }
    });
    jrbWrapCharacters.setText("Wrap Characters");
    jrbWrapCharacters.addActionListener(new java.awt.event.ActionListener() {

      public void actionPerformed(ActionEvent e) {
        jrbWrapCharacters_actionPerformed(e);
      }
    });
    jchkWrap.setText("Wrap");
    jchkWrap.addActionListener(new java.awt.event.ActionListener() {

      public void actionPerformed(ActionEvent e) {
        jchkWrap_actionPerformed(e);
      }
    });
    this.getContentPane().add(jScrollPane1, BorderLayout.CENTER);
    jScrollPane1.getViewport().add(jta, null);
    this.getContentPane().add(jPanel1, BorderLayout.SOUTH);
    jPanel1.add(jchkWrap, null);
    jPanel1.add(jrbWrapWords, null);
    jPanel1.add(jrbWrapCharacters, null);

    // Group radio buttons
    btg.add(jrbWrapWords);
    btg.add(jrbWrapCharacters);
  }

  //Main method
  public static void main(String[] args) {
    Exercise13_12 frame = new Exercise13_12();
    frame.setTitle("Exercise13_12");
    frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    frame.setSize(400, 320);
    Dimension d = Toolkit.getDefaultToolkit().getScreenSize();
    frame.setLocation((d.width - frame.getSize().width) / 2, (d.height - frame.getSize().height) / 2);
    frame.setVisible(true);
  }

  void jchkWrap_actionPerformed(ActionEvent e) {
    jta.setLineWrap(jchkWrap.isSelected());

    if (jchkWrap.isSelected()) {
      jrbWrapWords.setEnabled(true);
      jrbWrapCharacters.setEnabled(true);
    }
    else {
      jrbWrapWords.setEnabled(false);
      jrbWrapCharacters.setEnabled(false);
    }
  }

  void jrbWrapWords_actionPerformed(ActionEvent e) {
    jta.setWrapStyleWord(jrbWrapWords.isSelected());
    jta.revalidate();
  }

  void jrbWrapCharacters_actionPerformed(ActionEvent e) {
    jta.setWrapStyleWord(!jrbWrapCharacters.isSelected());
    jta.revalidate();
  }
}
