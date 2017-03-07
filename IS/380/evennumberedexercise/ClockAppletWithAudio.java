// ClockAppletWithAudio.java: Display a running clock on the applet
// with audio
import java.applet.*;
import javax.swing.*;
import java.awt.event.*;
import java.awt.*;

public class ClockAppletWithAudio extends JApplet
  implements ActionListener {
  // Declare audio files
  protected AudioClip[] hourAudio = new AudioClip[12];
  protected AudioClip minuteAudio;
  protected AudioClip amAudio;
  protected AudioClip pmAudio;

  // Create a clock
  private StillClock clock = new StillClock();

  // Create a timer
  private Timer timer = new Timer(1000, this);

  // Create a label to display time
  private JLabel jlblDigitTime = new JLabel("", JLabel.CENTER);

  /** Initialize the applet */
  public void init() {
    Class thisClass = this.getClass();

    // Create audio clips for pronouncing hours
    for (int i = 0; i < 12; i++)
      hourAudio[i] = Applet.newAudioClip(
        thisClass.getResource("timeaudio/hour" + i + ".au"));

    // Create audio clips for pronouncing am and pm
    amAudio =
      Applet.newAudioClip(thisClass.getResource("timeaudio/am.au"));
    pmAudio =
      Applet.newAudioClip(thisClass.getResource("timeaudio/pm.au"));

    // Add clock and time label to the content pane of the applet
    getContentPane().add(clock, BorderLayout.CENTER);
    getContentPane().add(jlblDigitTime, BorderLayout.SOUTH);
  }

  /** Override the applet's start method */
  public void start() {
    timer.start(); // Resume clock
  }

  /** Override the applet's stop method */
  public void stop() {
    timer.stop(); // Suspend clock
  }

  public void actionPerformed(ActionEvent e) {
    clock.setCurrentTime();
    clock.repaint();
    jlblDigitTime.setText(clock.getHour() + ":" + clock.getMinute()
      + ":" + clock.getSecond());
    if (clock.getSecond() == 0)
      announceTime(clock.getMinute(), clock.getHour());
  }

  /** Announce the current time at every minute */
  public void announceTime(int m, int h) {
    // Announce hour
    hourAudio[h % 12].play();

    // Load the minute file
    minuteAudio = Applet.newAudioClip(this.getClass().getResource(
      "timeaudio/minute" + m + ".au"));

    // Time delay to allow hourAudio play to finish
    try {
      Thread.sleep(1500);
    }
    catch(InterruptedException ex) {
    }

    // Announce minute
    minuteAudio.play();

    // Time delay to allow minuteAudio play to finish
    try {
      Thread.sleep(1500);
    }
    catch(InterruptedException ex) {
    }

    // Announce am or pm
    if (h < 12)
      amAudio.play();
    else
      pmAudio.play();
  }

  public static void main(String[] args) {
    ClockAppletWithAudio applet = new ClockAppletWithAudio();
    applet.init();
    applet.start();
    JFrame frame = new JFrame();
    frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    frame.setTitle("ClockAppletWithAudio");
    frame.getContentPane().add(applet, BorderLayout.CENTER);
    frame.setSize(400, 320);
    frame.setVisible(true);
  }
}
