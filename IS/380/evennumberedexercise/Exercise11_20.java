// Exercise11_20.java
import java.awt.*;
import javax.swing.*;

public class Exercise11_20 extends JFrame {
    public Exercise11_20() {
    Container container = getContentPane();
    container.setLayout(new GridLayout(1, 2));
    StillClock clock1 = new StillClock(4, 20, 45);
    StillClock clock2 = new StillClock(22, 46, 15);
    container.add(clock1);
    container.add(clock2);
  }

  public static void main(String[] args) {
    Exercise11_20 frame = new Exercise11_20();
    frame.setTitle("Exercise11_20");
    frame.setSize(400, 400);
    frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    frame.setVisible(true);
  }
}
