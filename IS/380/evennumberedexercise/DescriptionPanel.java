// Define a panel for displaying image and text
import java.awt.*;
import javax.swing.*;

public class DescriptionPanel extends JPanel {
  /** Label for displaying an image icon */
  private JLabel jlblImage = new JLabel();

  /** Label for displaying a title */
  private JLabel jlblTitle = new JLabel();

  /** Text area for displaying text */
  private JTextArea jtaDescription;

  public DescriptionPanel() {
    // Group image label and title label in a panel
    JPanel panel = new JPanel();
    panel.setLayout(new BorderLayout());
    panel.add(jlblImage, BorderLayout.CENTER);
    panel.add(jlblTitle, BorderLayout.SOUTH);

    // Create a scroll pane to hold text area
    JScrollPane scrollPane = new JScrollPane
      (jtaDescription = new JTextArea());

    // Center the title on the label
    jlblTitle.setHorizontalAlignment(JLabel.CENTER);

    // Set the font for the title and text
    jlblTitle.setFont(new Font("SansSerif", Font.BOLD, 16));
    jtaDescription.setFont(new Font("Serif", Font.PLAIN, 14));

    // Set lineWrap and wrapStyleWord true for text area
    jtaDescription.setLineWrap(true);
    jtaDescription.setWrapStyleWord(true);
    jtaDescription.setEditable(false);

    // Set preferred size for the scroll pane
    scrollPane.setPreferredSize(new Dimension(200, 100));

    // Set BorderLayout for the whole panel, add panel and scrollpane
    setLayout(new BorderLayout(5, 5));
    add(scrollPane, BorderLayout.CENTER);
    add(panel, BorderLayout.WEST);
  }

  /** Set the title */
  public void setTitle(String title) {
    jlblTitle.setText(title);
  }

  /** Set the image icon */
  public void setImageIcon(ImageIcon icon) {
    jlblImage.setIcon(icon);
    Dimension dimension = new Dimension(icon.getIconWidth(),
      icon.getIconHeight());
    jlblImage.setPreferredSize(dimension);
  }

  /** Set the text description */
  public void setDescription(String text) {
    jtaDescription.setText(text);
  }
}
