// Exercise11_14.java: Display a clock in a panel
import java.awt.*;
import javax.swing.*;

public class Exercise11_14 extends JFrame {
  public static void main(String[] args) {
    // Obtain the total seconds since the midnight, Jan 1, 1970
    long totalSeconds = System.currentTimeMillis() / 1000;

    // Compute the current second in the minute in the hour
    int currentSecond = (int)(totalSeconds % 60);

    // Obtain the total minutes
    long totalMinutes = totalSeconds / 60;

    // Compute the current minute in the hour
    int currentMinute = (int)(totalMinutes % 60);

    // Obtain the total hours
    long totalHours = totalMinutes / 60;

    // Compute the current hour
    int currentHour = (int)(totalHours % 24);

    // Create a frame to hold the clock
    Exercise11_14 frame = new Exercise11_14();
    frame.setTitle("Exercise11_14");
    frame.getContentPane().add(new DrawClock
      (currentHour, currentMinute, currentSecond));
    MessagePanel messagePanel = new MessagePanel(
      currentHour + ":" + currentMinute + ":" + currentSecond +" GMT");
    messagePanel.setCentered(true);
    messagePanel.setForeground(Color.blue);
    frame.getContentPane().add(messagePanel, BorderLayout.SOUTH);
    frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    frame.setSize(300, 350);
    frame.setVisible(true);
  }
}

class DrawClock extends JPanel {
  private int hour;
  private int minute;
  private int second;
  protected int xCenter, yCenter;
  protected int clockRadius;

  // Construct a clock panel
  public DrawClock(int hour, int minute, int second) {
    this.hour = hour;
    this.minute = minute;
    this.second = second;
  }

  // Draw the clock
  protected void paintComponent(Graphics g) {
    super.paintComponent(g);

    // Initialize clock parameters
    clockRadius =
      (int)(Math.min(getSize().width, getSize().height)*0.9*0.5);
    xCenter = (getSize().width)/2;
    yCenter = (getSize().height)/2;

    // Draw circle
    g.setColor(Color.black);
    g.drawOval(xCenter - clockRadius,yCenter - clockRadius,
      2*clockRadius, 2*clockRadius);

    // Draw second hand
    int sLength = (int)(clockRadius*0.7);
    int xSecond =
      (int)(xCenter + sLength*Math.sin(second*(2*Math.PI/60)));
    int ySecond =
      (int)(yCenter - sLength*Math.cos(second*(2*Math.PI/60)));
    g.setColor(Color.red);
    g.drawLine(xCenter, yCenter, xSecond, ySecond);

    // Draw minute hand
    int mLength = (int)(clockRadius * 0.6);
    int xMinute =
      (int)(xCenter + mLength * Math.sin(minute * (2 * Math.PI / 60)));
    int yMinute =
      (int)(yCenter - mLength * Math.cos(minute * (2 * Math.PI / 60)));
    g.setColor(Color.blue);
    g.drawLine(xCenter, yCenter, xMinute, yMinute);

    // Draw hour hand
    int hLength = (int)(clockRadius * 0.5);
    int xHour = (int)(xCenter +
      hLength * Math.sin((hour+minute/60.0) * (2 * Math.PI / 12)));
    int yHour = (int)(yCenter -
      hLength * Math.cos((hour + minute/60.0) * (2 * Math.PI / 12)));
    g.setColor(Color.black);
    g.drawLine(xCenter, yCenter, xHour, yHour);

    // Display more details on the clock
    for (int i=0; i<60; i++) {
      double percent;

      if (i%5 == 0) {
        percent = 0.9;
      }
      else {
        percent = 0.95;
      }

      int xOuter = (int)(xCenter +
        clockRadius * Math.sin(i * (2 * Math.PI / 60)));
      int yOuter = (int)(yCenter -
        clockRadius * Math.cos(i * (2 * Math.PI / 60)));
      int xInner = (int)(xCenter +
        percent * clockRadius * Math.sin(i * (2 * Math.PI / 60)));
      int yInner = (int)(yCenter -
        percent * clockRadius * Math.cos(i * (2 * Math.PI / 60)));

      g.drawLine(xOuter, yOuter, xInner, yInner);
    }

    // Display hours on the clock
    g.setColor(Color.black);
    for (int i = 0; i < 12; i++) {
      int x = (int)(xCenter +
        0.8 * clockRadius * Math.sin(i * (2 * Math.PI / 12)));
      int y = (int)(yCenter -
        0.8*clockRadius * Math.cos(i * (2 * Math.PI / 12)));

      g.drawString("" + ((i == 0) ? 12 : i), x, y);
    }
  }
}
