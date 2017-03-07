// Exercise14_20.java: Create a customizable animation applet
import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import javax.swing.border.*;
import java.net.URL;
import java.applet.*;

public class Exercise14_20 extends JApplet implements ActionListener {
  JTextField jtfSpeed = new JTextField();
  JTextField jtfPrefix = new JTextField();
  JTextField jtfNumOfImages = new JTextField();
  JTextField jtfAudioFile = new JTextField();
  JButton jbtStartAnimation = new JButton("Start Animation");
  PlayImage playImage = new PlayImage();

  Image[] images;
  AudioClip audioClip;
  int sleepTime;
  int numOfImages;

  // Initialize the applet
  public void init() {
    // Panel p to hold animation control
    JPanel p = new JPanel();
    p.setLayout(new GridLayout(4, 2));
    p.add(new JLabel("Animation speed in milliseconds"));
    p.add(jtfSpeed);
    p.add(new JLabel("Image file prefix"));
    p.add(jtfPrefix);
    p.add(new JLabel("Number of images"));
    p.add(jtfNumOfImages);
    p.add(new JLabel("Audio file"));
    p.add(jtfAudioFile);
    p.setBorder(new TitledBorder(
      "Enter information for animation"));

    // Panel jpButton to hold the button
    JPanel jpButton = new JPanel();
    jpButton.setLayout(new FlowLayout(FlowLayout.RIGHT));
    jpButton.add(jbtStartAnimation);

    // Add the button, image panel, and panel p to the applet
    getContentPane().add(jpButton, BorderLayout.NORTH);
    getContentPane().add(playImage, BorderLayout.CENTER);
    getContentPane().add(p, BorderLayout.SOUTH);

    // Register listener
    jbtStartAnimation.addActionListener(this);
  }

  // Handle button action
  public void actionPerformed(ActionEvent e) {
    startAnimation();
  }

  public void startAnimation() {
    MediaTracker imageTracker = new MediaTracker(this);

    // Obtain a Toolkit instance
    Toolkit toolkit = Toolkit.getDefaultToolkit();

    URL url = null;

    String prefix = jtfPrefix.getText().trim();
    numOfImages =
      new Integer(jtfNumOfImages.getText().trim()).intValue();
    String audioFile = jtfAudioFile.getText().trim();
    sleepTime = new Integer(jtfSpeed.getText().trim()).intValue();

    // Load the image, the image files are named
    // L1 - L52 in Images directory
    images = new Image[numOfImages];
    for (int i=0; i<images.length; i++) {
      // Get the URL for the file name
      url = this.getClass().getResource("image/" + prefix + (i+1)
        + ".gif");

      images[i] = toolkit.getImage(url);

      // Register images with the imageTracker
      imageTracker.addImage(images[i], i);
    }

    // Play a sound
    try {
      url = this.getClass().getResource(audioFile);
    }
    catch (Exception ex) {
      System.out.println(ex);
    }
    System.out.println("url = " + url);

    audioClip = Applet.newAudioClip(url);

    // Wait for all the images to be completely loaded
    try {
      imageTracker.waitForAll();
    }
    catch (InterruptedException ex) {
      System.out.println(ex);
    }

    // Dispose of imageTracker and audioClip since they are no longer needed
    imageTracker = null;

    // Start image animation
    playImage.beginAnimation();
  }

  // Main method
  public static void main(String[] args) {
    // Create a frame
    JFrame frame = new JFrame("Exercise14_20");

    // Create an instance of the applet
    Exercise14_20 applet = new Exercise14_20();

    // Add the applet instance to the frame
    frame.getContentPane().add(applet, BorderLayout.CENTER);
    frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

    // Invoke init() and start()
    applet.init();
    applet.start();

    // Display the frame
    frame.setSize(500, 400);
    frame.setVisible(true);
  }

  class PlayImage extends JPanel implements Runnable {
    private Thread thread = null;
    int currentImageIndex = 0;
    Image imageToDisplay;

    // Determine the thread status
    protected boolean suspended = false;

    // Constructor
    public PlayImage() {
      // Start with the first image
      currentImageIndex = 0;

      thread = new Thread(this);

      setBorder(new LineBorder(Color.red, 1));
    }

    public void beginAnimation() {
      thread.start();
      if (audioClip != null) audioClip.loop();
    }

    public void start() {
      resume();
    }

    public void stop() {
      suspend();
    }

    public synchronized void resume() {
      if (suspended) {
        suspended = false;
        notify();
      }
    }

    public synchronized void suspend() {
      suspended = true;
    }

    public void destroy() {
      thread = null;
    }

    public void run() {
      while (true) {
        imageToDisplay =
          images[currentImageIndex%numOfImages];

        // Make sure currentImageIndex is nonnegative
        if (currentImageIndex == 0) currentImageIndex = 52;
        currentImageIndex = currentImageIndex + 1;
        repaint();

        try {
          thread.sleep(sleepTime);
          synchronized (this) {
            while (suspended)
              wait();
          }
        }
        catch (InterruptedException ex) {
        }
      }
    }

    // Display an image
    public void paintComponent(Graphics g) {
      super.paintComponent(g);

      if (imageToDisplay != null) {
        g.drawImage(imageToDisplay, 0, 0, getSize().width,
          getSize().height, this);
      }
    }
  }
}