import java.awt.*;
import java.awt.event.*;
import java.applet.*;
import javax.swing.*;

import java.awt.*;
import java.awt.event.*;
import java.applet.*;
import javax.swing.*;

public class Exercise24_4 extends JApplet {
  private DefaultListModel listModel = new DefaultListModel();
  private JList jlst = new JList(listModel);
  private JButton jbtAdd = new JButton("Add new item");
  private JButton jbtRemove = new JButton("Remove selected item");

  /** Construct the applet */
  public Exercise24_4() {
    // Add items to the list model
    listModel.addElement("Item1");
    listModel.addElement("Item2");
    listModel.addElement("Item3");
    listModel.addElement("Item4");
    listModel.addElement("Item5");
    listModel.addElement("Item6");

    JPanel panel = new JPanel();
    panel.add(jbtAdd);
    panel.add(jbtRemove);

    getContentPane().add(panel, BorderLayout.NORTH);
    getContentPane().add(new JScrollPane(jlst), BorderLayout.CENTER);

    // Register listeners
    jbtAdd.addActionListener(new ActionListener() {
      public void actionPerformed(ActionEvent e) {
        String newItem =
          JOptionPane.showInputDialog("Enter a new item");

        if (newItem != null)
          if (jlst.getSelectedIndex() == -1)
            listModel.addElement(newItem);
          else
            listModel.add(jlst.getSelectedIndex(), newItem);
      }
    });

    // Remove all items
    jbtRemove.addActionListener(new ActionListener() {
      public void actionPerformed(ActionEvent e) {
        removeSelectedItems();
      }
    });

    // Listener for keyboard event
    jlst.addKeyListener(new java.awt.event.KeyAdapter() {
      public void keyPressed(KeyEvent e) {
        if (e.getKeyCode() == KeyEvent.VK_DELETE)
          removeSelectedItems();
      }
    });
  }

  private void removeSelectedItems() {
    int[] selectedIndices = jlst.getSelectedIndices();

    for (int i = selectedIndices.length - 1; i >= 0; i--)
      listModel.remove(selectedIndices[i]);
  }

  //Main method
  public static void main(String[] args) {
    Exercise24_4 applet = new Exercise24_4();
    JFrame frame = new JFrame();
    //EXIT_ON_CLOSE == 3
    frame.setDefaultCloseOperation(3);
    frame.setTitle("Exercise24_4");
    frame.getContentPane().add(applet, BorderLayout.CENTER);
    applet.init();
    applet.start();
    frame.setSize(400,320);
    Dimension d = Toolkit.getDefaultToolkit().getScreenSize();
    frame.setLocation((d.width - frame.getSize().width) / 2,
                      (d.height - frame.getSize().height) / 2);
    frame.setVisible(true);
  }
}