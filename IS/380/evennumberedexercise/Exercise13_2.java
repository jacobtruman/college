// Exercise13_2.java: Select and draw figures on the panel
import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class Exercise13_2 extends JFrame implements ItemListener {
  private JRadioButton jrbLine, jrbRectangle, jrbOval,
  jrbArc, jrbPolygon;
  private DisplayFigure displayFigure = new DisplayFigure();

  public static void main(String[] args) {
    Exercise13_2 frame = new Exercise13_2();
    frame.setSize(400, 300);
    frame.setTitle("Exercise13_2");
    frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    frame.setVisible(true);
  }

  public Exercise13_2() {
    // Panel p to hold radio buttons
    JPanel p = new JPanel();
    p.setLayout(new FlowLayout());
    p.add(jrbLine = new JRadioButton("Line"));
    p.add(jrbRectangle = new JRadioButton("Rectangle"));
    p.add(jrbOval = new JRadioButton("Oval"));
    p.add(jrbArc = new JRadioButton("Arc"));
    p.add(jrbPolygon = new JRadioButton("Polygon"));

    // Group radio buttons
    ButtonGroup btg = new ButtonGroup();
    btg.add(jrbLine);
    btg.add(jrbRectangle);
    btg.add(jrbOval);
    btg.add(jrbArc);
    btg.add(jrbPolygon);

    // Place figure panel and p in the frame
    getContentPane().add(displayFigure, BorderLayout.CENTER);
    getContentPane().add(p, BorderLayout.SOUTH);

    // Register listener
    jrbLine.addItemListener(this);
    jrbRectangle.addItemListener(this);
    jrbOval.addItemListener(this);
    jrbArc.addItemListener(this);
    jrbPolygon.addItemListener(this);
  }

  // Handle ItemEvent
  public void itemStateChanged(ItemEvent e) {
    if (jrbLine.isSelected()) {
      displayFigure.setFigure(1);
    }
    else if (jrbRectangle.isSelected()) {
      displayFigure.setFigure(2);
    }
    else if (jrbOval.isSelected()) {
      displayFigure.setFigure(3);
    }
    else if (jrbArc.isSelected()) {
      displayFigure.setFigure(4);
    }
    else if (jrbPolygon.isSelected()) {
      displayFigure.setFigure(5);
    }
  }
}

class DisplayFigure extends JPanel {
  private int figureID;

  public DisplayFigure() {
  }

  public void setFigure(int i) {
    figureID = i;
    repaint();
  }

  public void paintComponent(Graphics g) {
    super.paintComponent(g);

    g.setColor(Color.red);

    switch (figureID) {
      case 1: g.drawLine(10, 10, 45, 45);
      break;
      case 2:
        // Set new color
        g.setColor(Color.red);

        // Draw a rectangle
        g.drawRect(5, 5, getWidth() / 2 - 10, getHeight() / 2 - 10);

        // Draw a rounded rectangle
        g.drawRoundRect(getWidth() / 2 + 5, 5,
          getWidth() / 2 - 10, getHeight() / 2 - 10, 60, 30);

        // Change the color to cyan
        g.setColor(Color.cyan);

        // Draw a 3D rectangle
        g.fill3DRect(5, getHeight() / 2 + 5, getWidth() / 2 - 10,
          getHeight() / 2 - 10, true);

        // Draw a raised 3D rectangle
        g.fill3DRect(getWidth() / 2 + 5, getHeight() / 2 + 5,
          getWidth() / 2 - 10, getHeight() / 2 - 10, false);
        break;
      case 3:
        g.drawOval(5, 5, getWidth() / 2 - 10, getHeight() / 2 - 10);
        g.setColor(Color.red);
        g.drawOval(getWidth() / 2 + 5, 5, getWidth() / 2 - 10,
          getHeight() / 2 - 10);
        g.setColor(Color.yellow);
        g.fillOval(5, getHeight() / 2 + 5, getWidth() / 2 - 10,
          getHeight() / 2 - 10);
        g.setColor(Color.orange);
        g.fillOval(getWidth() / 2 + 5, getHeight() / 2 + 5,
          getWidth() / 2 - 10, getHeight() / 2 - 10);
        break;
      case 4:
        int xCenter = getWidth() / 2;
        int yCenter = getHeight() / 2;
        int radius =
          (int)(Math.min(getWidth(), getHeight()) * 0.4);

        int x = xCenter - radius;
        int y = yCenter - radius;

        g.fillArc(x, y, 2 * radius, 2 * radius, 0, 30);
        g.fillArc(x, y, 2 * radius, 2 * radius, 90, 30);
        g.fillArc(x, y, 2 * radius, 2 * radius, 180, 30);
        g.fillArc(x, y, 2 * radius, 2 * radius, 270, 30);
        break;
      case 5:
        xCenter = getWidth() / 2;
        yCenter = getHeight() / 2;
        radius =
          (int)(Math.min(getWidth(), getHeight()) * 0.4);

        // Create a Polygon object
        Polygon polygon = new Polygon();

        // Add points to the polygon
        polygon.addPoint(xCenter + radius, yCenter);
        polygon.addPoint((int)(xCenter + radius *
          Math.cos(2 * Math.PI / 6)), (int)(yCenter - radius *
          Math.sin(2 * Math.PI / 6)));
        polygon.addPoint((int)(xCenter + radius *
          Math.cos(2 * 2 * Math.PI / 6)), (int)(yCenter - radius *
          Math.sin(2 * 2 * Math.PI / 6)));
        polygon.addPoint((int)(xCenter + radius *
          Math.cos(3 * 2 * Math.PI / 6)), (int)(yCenter - radius *
          Math.sin(3 * 2 * Math.PI / 6)));
        polygon.addPoint((int)(xCenter + radius *
          Math.cos(4 * 2 * Math.PI / 6)), (int)(yCenter - radius *
          Math.sin(4 * 2 * Math.PI / 6)));
        polygon.addPoint((int)(xCenter + radius *
          Math.cos(5 * 2 * Math.PI / 6)), (int)(yCenter - radius *
          Math.sin(5 * 2 * Math.PI / 6)));

        // Draw the polygon
        g.drawPolygon(polygon);
        break;
    }
  }
}

