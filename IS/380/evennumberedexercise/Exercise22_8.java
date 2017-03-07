import javax.swing.*;
import java.awt.*;

public class Exercise22_8 extends javax.swing.JApplet {
  /** Creates new form Exercise22_8 */
  public Exercise22_8() {
    jSplitPane1 = new javax.swing.JSplitPane(
      JSplitPane.VERTICAL_SPLIT, jSplitPane2 = new JSplitPane(),
      jSplitPane3 = new JSplitPane());

    jSplitPane2.setLeftComponent(figurePanel1);
    jSplitPane2.setRightComponent(figurePanel2);
    jSplitPane3.setLeftComponent(figurePanel3);
    jSplitPane3.setRightComponent(figurePanel4);

    getContentPane().add(jSplitPane1, java.awt.BorderLayout.CENTER);
  }

  // Variables declaration - do not modify//GEN-BEGIN:variables
  private FigurePanel figurePanel4 = new FigurePanel(FigurePanel.SQUARE);
  private FigurePanel figurePanel3 = new FigurePanel(FigurePanel.RECTANGLE);
  private FigurePanel figurePanel2 = new FigurePanel(FigurePanel.CIRCLE);
  private FigurePanel figurePanel1 = new FigurePanel(FigurePanel.OVAL);

  private javax.swing.JSplitPane jSplitPane3;
  private javax.swing.JSplitPane jSplitPane2;
  private javax.swing.JSplitPane jSplitPane1;
  // End of variables declaration//GEN-END:variables

  public static void main(String[] args) {
    Exercise22_8 applet = new Exercise22_8();
    JFrame frame = new JFrame();
    frame.setDefaultCloseOperation(3);
    frame.setTitle("Exercise22_8");
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
