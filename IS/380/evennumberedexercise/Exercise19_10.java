// Exercise19_10.java
import java.applet.*;
import java.awt.*;
import javax.swing.*;

public class Exercise19_10 extends ClockAppletWithAudio {
  // Declare a thread for announcing time
  AnnounceTime announceTime = new AnnounceTime();

  /**Initialize the applet*/
  public void init() {
    super.init();
  }

  /**Override this method defined in ClockAppletWithAudio
     to announce the current time at every minute*/
  public void announceTime(int m, int h) {
    // Set the current hour
    announceTime.setHourAudio(hourAudio[h % 12]);
    // Load the minute file
    minuteAudio = Applet.newAudioClip(this.getClass().getResource(
      "timeaudio/minute" + m + ".au"));
    // Set the current minute
    announceTime.setMinuteAudio(minuteAudio);

    if (h < 12)
      announceTime.setAmPm(amAudio);
    else
      announceTime.setAmPm(pmAudio);

     announceTime.start();
  }

  // Define a thread class for announcing time
  class AnnounceTime extends Thread {
    private AudioClip hourAudio, minuteAudio, amPM;

    public void setHourAudio(AudioClip hourAudio) {
      this.hourAudio = hourAudio;
    }

    public void setMinuteAudio(AudioClip minuteAudio) {
      this.minuteAudio = minuteAudio;
    }

    public void setAmPm(AudioClip amPM) {
      this.amPM = amPM;
    }

    public void run() {
      if (hourAudio == null || minuteAudio == null || amPM == null)
        return;

    // Announce hour
    hourAudio.play();

    // Time delay to allow hourAudio play to finish
    // before playing the clip
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
    amPM.play();
  }
  }
 
  // Enable the applet to run standalone
  // Main method
  public static void main(String[] args) {
    // Create a frame
    JFrame frame = new JFrame("Exercise19_10");

    // Create an instance of the applet
    Exercise19_10 applet = new Exercise19_10();

    // Add the applet instance to the frame
    frame.getContentPane().add(applet, BorderLayout.CENTER);
    frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

    // Invoke init() and start()
    applet.init();
    applet.start();

    // Display the frame
    frame.setSize(200, 200);
    frame.setVisible(true);
  }
}