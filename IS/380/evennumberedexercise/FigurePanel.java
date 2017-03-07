import java.awt.*;
import javax.swing.JPanel;

public class FigurePanel extends JPanel {
  private int figureType = 1;

  // Define constants
  public static final int SQUARE = 1;
  public static final int RECTANGLE = 2;
  public static final int CIRCLE = 3;
  public static final int OVAL = 4;

  /** Constructor */
  public FigurePanel() {
  }

  /** Constructs a FigurePanel with the specified type */
  public FigurePanel(int type) {
    this.figureType = type;
    repaint();
  }

  /** Draw a figure on the panel */
  public void paintComponent(Graphics g) {
    super.paintComponent(g);

    // Get the appropriate size for the figure
    int width = getSize().width;
    int height = getSize().height;
    int side = (int)(0.80 * Math.min(width, height));

    switch (figureType) {
      case SQUARE: // Display a square
        g.drawRect((width-side) / 2, (height-side) / 2, side, side);
        break;
      case RECTANGLE: // Display a rectangle
        g.drawRect((int)(0.1 * width), (int)(0.1 * height),
          (int)(0.8 * width), (int)(0.8 * height));
        break;
      case CIRCLE: // Display a circle
        g.drawOval((width - side) / 2, (height-side) / 2, side, side);
        break;
      case OVAL: // Display an oval
        g.drawOval((int)(0.1 * width), (int)(0.1 * height),
          (int)(0.8 * width), (int)(0.8 * height));
        break;
    }
  }

  /** Setter figureType */
  public void setFigureType(int newFigureType) {
    figureType = newFigureType;
  }

  /** Return figureType */
  public int getFigureType() {
    return figureType;
  }

  /** Specify preferred size */
  public Dimension getPreferredSize() {
    return new Dimension(80, 80);
  }
}