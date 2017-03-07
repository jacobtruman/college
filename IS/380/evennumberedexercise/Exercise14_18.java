// Exercise14_18.java: Play, loop, stop a sound clip
import java.awt.*;
import java.awt.event.*;
import java.applet.*;
import java.util.*;
import javax.swing.*;
import java.net.URL;

public class Exercise14_18 extends JApplet implements ActionListener {
  private AudioClip audioClip;
  private JButton jbtPlay, jbtLoop, jbtStop;

  public void init() {
    URL url = this.getClass().getResource("ticker.au");
    audioClip = Applet.newAudioClip(url);

    getContentPane().setLayout(new FlowLayout());
    getContentPane().add(jbtPlay = new JButton("Play"));
    getContentPane().add(jbtLoop= new JButton("Loop"));
    getContentPane().add(jbtStop = new JButton("Stop"));

    jbtPlay.addActionListener(this);
    jbtLoop.addActionListener(this);
    jbtStop.addActionListener(this);
  }

  public void actionPerformed(ActionEvent e) {
    String actionCommand = e.getActionCommand();
    if (actionCommand.equals("Play")) {
      audioClip.play();
    }
    else if (actionCommand.equals("Loop")) {
      audioClip.loop();
    }
    else if (actionCommand.equals("Stop")) {
      audioClip.stop();
    }
  }

  // Main method
  public static void main(String[] args) {
    // Create a frame
    JFrame frame = new JFrame("Exercise14_18");

    // Create an instance of the applet
    Exercise14_18 applet = new Exercise14_18();

    // Add the applet instance to the frame
    frame.getContentPane().add(applet, BorderLayout.CENTER);
    frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

    // Invoke init() and start()
    applet.init();
    applet.start();

    // Display the frame
    frame.setSize(300, 300);
    frame.setVisible(true);
  }
}
