import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class Exercise23_4 extends JApplet {
  private ImageViewer imageViewer = new ImageViewer();
  private FlowLayout flowLayout = new FlowLayout();

  // Create image icons
  private ImageIcon caImageIcon = ImageViewer.createImageIcon(
    "image/caIcon.gif", this);
  private ImageIcon usImageIcon = ImageViewer.createImageIcon(
    "image/usIcon.gif", this);

  private Image caImage = ImageViewer.createImage(
    "image/ca.gif", this);
  private Image usImage = ImageViewer.createImage(
    "image/us.gif", this);

  public Exercise23_4() {
    // Create actions
    Action caAction = new MyAction("CA", caImageIcon);
    Action usAction = new MyAction("US", usImageIcon);

    // Create menus
    JMenuBar jMenuBar1 = new JMenuBar();
    JMenu jmenuFlag = new JMenu("Flags");
    setJMenuBar(jMenuBar1);
    jMenuBar1.add(jmenuFlag);

    // Add actions to the menu
    jmenuFlag.add(caAction);
    jmenuFlag.add(usAction);

    // Add actions to the toolbar
    JToolBar jToolBar1 = new JToolBar(JToolBar.VERTICAL);
    jToolBar1.setBorder(BorderFactory.createLineBorder(Color.red));
    jToolBar1.add(caAction);
    jToolBar1.add(usAction);

    // Add tool bar to the east and panel to the center
    getContentPane().add(jToolBar1, BorderLayout.EAST);
    getContentPane().add(imageViewer, BorderLayout.CENTER);
  }

  private class MyAction extends AbstractAction {
    String name;

    MyAction(String name, Icon icon) {
      super(name, icon);
      putValue(Action.SHORT_DESCRIPTION, " Select the " + name +
        " flag to display");
      this.name = name;
    }

    public void actionPerformed(ActionEvent e) {
      if (name.equals("CA"))
        imageViewer.setImage(caImage);
      else if (name.equals("US"))
        imageViewer.setImage(usImage);
    }
  }

  public static void main(String[] args) {
    Exercise23_4 applet = new Exercise23_4();
    JFrame frame = new JFrame();
    //EXIT_ON_CLOSE == 3
    frame.setDefaultCloseOperation(3);
    frame.setTitle("Exercise23_4");
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