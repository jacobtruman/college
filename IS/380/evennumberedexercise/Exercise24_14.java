import javax.swing.*;
import javax.swing.tree.*;
import javax.swing.event.*;
import java.awt.*;

public class Exercise24_14 extends javax.swing.JApplet {
  // Declare a tree model
  DefaultTreeModel treeModel;

  /** Creates new form Exercise24_14 */
  public Exercise24_14() {
    // Create a tree model and set the tree model in jTree1
    treeModel = createTreeModel();

    initComponents();
  }

  /** This method is called from within the constructor to
   * initialize the form.
   * WARNING: Do NOT modify this code. The content of this method is
   * always regenerated by the Form Editor.
   */
  private void initComponents() {//GEN-BEGIN:initComponents
    jSplitPane1 = new javax.swing.JSplitPane();
    jScrollPane1 = new javax.swing.JScrollPane();
    jTree1 = new javax.swing.JTree();
    jScrollPane2 = new javax.swing.JScrollPane();
    jta = new javax.swing.JTextArea();

    jTree1.setModel(treeModel);
    jTree1.addTreeSelectionListener(new javax.swing.event.TreeSelectionListener() {
      public void valueChanged(javax.swing.event.TreeSelectionEvent evt) {
        jTree1ValueChanged(evt);
      }
    });

    jScrollPane1.setViewportView(jTree1);

    jSplitPane1.setLeftComponent(jScrollPane1);

    jta.setLineWrap(true);
    jta.setWrapStyleWord(true);
    jScrollPane2.setViewportView(jta);

    jSplitPane1.setRightComponent(jScrollPane2);

    getContentPane().add(jSplitPane1, java.awt.BorderLayout.CENTER);

  }//GEN-END:initComponents

  private void jTree1ValueChanged(javax.swing.event.TreeSelectionEvent evt) {//GEN-FIRST:event_jTree1ValueChanged
    TreePath path = evt.getNewLeadSelectionPath();
    TreeNode treeNode = (TreeNode)path.getLastPathComponent();
    System.out.println("The selected node is " + treeNode.toString());

    if (treeNode.toString().equals
      ("Chapter 1: Introduction to Computers, Programs, and Java")) {
      jta.setText("The first part of the book is a stepping stone that will prepare you to embark on the journey of learning Java. You will begin to know Java and will develop fundamental programming skills. Specifically, you will learn how to write simple Java programs with primitive data types, control statements, methods, and arrays.");
    }
  }//GEN-LAST:event_jTree1ValueChanged

  private DefaultTreeModel createTreeModel() {
    DefaultMutableTreeNode root = new DefaultMutableTreeNode
      ("Introduction to Java Programming");

    DefaultMutableTreeNode parent = new DefaultMutableTreeNode
      ("Part I: Fundamentals of Programming");
    root.add(parent);

    parent.add(new DefaultMutableTreeNode
      ("Chapter 1: Introduction to Computers, Programs, and Java"));
    parent.add(new DefaultMutableTreeNode
      ("Chapter 2: Primitive Data Types and Operations"));
    parent.add(new DefaultMutableTreeNode
      ("Chapter 3: Control Statements"));
    parent.add(new DefaultMutableTreeNode
      ("Chapter 4: Methods"));
    parent.add(new DefaultMutableTreeNode
      ("Chapter 5: Arrays"));

    parent = new DefaultMutableTreeNode
      ("Part II: Object-Oriented Programming");
    root.add(parent);

    parent.add(new DefaultMutableTreeNode
      ("Chapter 6: Objects and Classes "));
    parent.add(new DefaultMutableTreeNode
      ("Chapter 7: Strings"));
    parent.add(new DefaultMutableTreeNode
      ("Chapter 8: Inheritance and Polymorphism"));
    parent.add(new DefaultMutableTreeNode
      ("Chapter 9: Abstract Classes and Interfaces"));
    parent.add(new DefaultMutableTreeNode
      ("Chapter 10: OO Analysis and Design"));

    parent = new DefaultMutableTreeNode
      ("Part III: GUI Programming");
    root.add(parent);

    parent.add(new DefaultMutableTreeNode
      ("Chapter 11: Getting Started with GUI Programming"));
    parent.add(new DefaultMutableTreeNode
      ("Chapter 12: Event-Driven Programming"));
    parent.add(new DefaultMutableTreeNode
      ("Chapter 13: Creating User Interfaces"));
    parent.add(new DefaultMutableTreeNode
      ("Chapter 14: Applets"));

    parent = new DefaultMutableTreeNode
      ("Part IV: Exception Handling and Simple IO");
    root.add(parent);

    parent.add(new DefaultMutableTreeNode
      ("Chapter 15: Exceptions and Assertions"));
    parent.add(new DefaultMutableTreeNode
      ("Chapter 16: Simple IO"));

    parent = new DefaultMutableTreeNode
      ("Part V: Data Structures and Collections Framework");
    root.add(parent);

    parent.add(new DefaultMutableTreeNode
      ("Chapter 17: Data Structure Implementations"));
    parent.add(new DefaultMutableTreeNode
      ("Chapter 18: Collections Framework"));

    return new DefaultTreeModel(root);
  }

  // Variables declaration - do not modify//GEN-BEGIN:variables
  private javax.swing.JScrollPane jScrollPane2;
  private javax.swing.JScrollPane jScrollPane1;
  private javax.swing.JSplitPane jSplitPane1;
  private javax.swing.JTextArea jta;
  private javax.swing.JTree jTree1;
  // End of variables declaration//GEN-END:variables

  //Main method
  public static void main(String[] args) {
    Exercise24_14 applet = new Exercise24_14();
    JFrame frame = new JFrame();
    //EXIT_ON_CLOSE == 3
    frame.setDefaultCloseOperation(3);
    frame.setTitle("Exercise24_14");
    frame.getContentPane().add(applet, BorderLayout.CENTER);
    applet.init();
    applet.start();
    frame.setSize(400,320);
    Dimension d = Toolkit.getDefaultToolkit().getScreenSize();
    frame.setLocation((d.width - frame.getSize().width) / 2, (d.height - frame.getSize().height) / 2);
    frame.setVisible(true);
  }

  //static initializer for setting look & feel
  static {
    try {
      //UIManager.setLookAndFeel(UIManager.getSystemLookAndFeelClassName());
      //UIManager.setLookAndFeel(UIManager.getCrossPlatformLookAndFeelClassName());
    }
    catch(Exception e) {
    }
  }
}