import java.awt.*;
import java.net.URL;
import javax.swing.*;

public class ImageViewer extends Component {
  /** Hold value of property image. */
  private java.awt.Image image;

  /** Hold value of property imageFilename. */
  private String imageFilename = " ";

  /** Hold value of property stretched. */
  private boolean stretched = true;

  /** Hold value of property xCoordinate. */
  private int xCoordinate;

  /** Hold value of property yCoordinate. */
  private int yCoordinate;

  /** Default constructor */
  public ImageViewer() {
  }

  public ImageViewer(Image image) {
    this.image = image;
    repaint();
  }

  /**Create an image icon from an image file through the resource
   * of the object.
   */
  public static ImageIcon createImageIcon(String imageFilename,
    Object object) {
    URL url = object.getClass().getResource(imageFilename);
    return new ImageIcon(url);
  }

  /**Create an image from an image file through the resource
   * of the object.
   */
  public static Image createImage(String imageFilename,
    Object object) {
    ImageIcon imageIcon = createImageIcon(imageFilename, object);
    if (imageIcon != null)
      return imageIcon.getImage();
    else
      return null;
  }

  public void paint(Graphics g) {
    if (image != null)
      if (isStretched())
        g.drawImage(image, xCoordinate, yCoordinate,
          getSize().width, getSize().height, this);
      else
        g.drawImage(image, xCoordinate, yCoordinate, this);
  }

  /** Return value of property image */
  public java.awt.Image getImage() {
    return image;
  }

  /** Set a new value for property image */
  public void setImage(java.awt.Image image) {
    this.image = image;
    repaint();
  }

  /** Return value of property imageFilename */
  public String getImageFilename() {
    return imageFilename;
  }

  /** Set a new value for property imageFilename */
  public void setImageFilename(String imageFilename) {
    this.imageFilename = imageFilename;
    image = createImage(imageFilename, this);
    repaint();
  }

  /** Return value of property stretched */
  public boolean isStretched() {
    return stretched;
  }

  /** Set a new value for property stretched */
  public void setStretched(boolean stretched) {
    this.stretched = stretched;
    repaint();
  }

  /** Return value of property xCoordinate */
  public int getXCoordinate() {
    return xCoordinate;
  }

  /** Set a new value for property xCoordinate */
  public void setXCoordinate(int xCoordinate) {
    this.xCoordinate = xCoordinate;
    repaint();
  }

  /** Return value of property yCoordinate */
  public int getYCoordinate() {
    return yCoordinate;
  }

  /** Set a new value for property yCoordinate */
  public void setYCoordinate(int yCoordinate) {
    this.yCoordinate = yCoordinate;
    repaint();
  }
}