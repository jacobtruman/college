// Exercise24_16.java: Traversing trees
import java.awt.*;
import javax.swing.*;
import javax.swing.tree.*;
import java.util.*;

public class Exercise24_16 extends JApplet {
  public Exercise24_16() {
    // Create a default tree
    JTree tree = new JTree();

    DefaultMutableTreeNode root =
      (DefaultMutableTreeNode)(tree.getModel().getRoot());

    JPanel panel = new JPanel();
    panel.setLayout(new BorderLayout());
    panel.add(new JScrollPane(new JTree(root)));

    JTextArea jtaMessage = new JTextArea();
    jtaMessage.setWrapStyleWord(true);
    jtaMessage.setLineWrap(true);
    getContentPane().add(new JSplitPane(JSplitPane.VERTICAL_SPLIT,
      panel, new JScrollPane(jtaMessage)), BorderLayout.CENTER);

    String output = "";
    // Breadth-first traversal
    Enumeration enumeration = root.breadthFirstEnumeration();
    while (enumeration.hasMoreElements())
      output += enumeration.nextElement().toString() + " ";
    jtaMessage.append("\nBreath-first traversal from the root is "
      + output);

    // depth-first traversal
    output = "";
    enumeration = root.depthFirstEnumeration();
    while (enumeration.hasMoreElements())
      output += enumeration.nextElement().toString() + " ";
    jtaMessage.append("\nDepth-first traversal from the root is "
      + output);

    // Preorder traversal
    output = "";
    enumeration = root.preorderEnumeration();
    while (enumeration.hasMoreElements())
      output += enumeration.nextElement().toString() + " ";
    jtaMessage.append("\nPreorder traversal from the root is "
      + output);

    // Preorder traversal
    output = "";
    enumeration = root.postorderEnumeration();
    while (enumeration.hasMoreElements())
      output += enumeration.nextElement().toString() + " ";
    jtaMessage.append("\nPostorder traversal from the root is "
      + output);
  }

  public static void main(String[] args) {
    Exercise24_16 applet = new Exercise24_16();
    JFrame frame = new JFrame();
    //EXIT_ON_CLOSE == 3
    frame.setDefaultCloseOperation(3);
    frame.setTitle("Exercise24_16");
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