// Exercise11_8.java: Display multiplication table
import java.awt.*;
import javax.swing.*;

public class Exercise11_8 extends JFrame {
  public Exercise11_8() {
    getContentPane().add(new MultiplicationTablePanel());
  }

  public static void main(String[] args) {
    Exercise11_8 frame = new Exercise11_8();
    frame.setSize(300, 400);
    frame.setTitle("Exercise11_8");
    frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    frame.setVisible(true);
  }
}

class MultiplicationTablePanel extends JPanel {
  protected void paintComponent(Graphics g) {
    super.paintComponent(g);

    int x = 10;
    int y = 40;
    String s = "";
    int i = 0;

    // Display the title
    g.setColor(Color.red);
    g.setFont(new Font("Times", Font.BOLD, 20));
    g.drawString("Multiplication Table", x+50, y);

    g.setFont(new Font("Times",Font.BOLD,15));

    y += 30;
    for (i = 1; i < 10; i++)
      g.drawString(" " + i, x + 10, y + 10 + i * 20);

    x += 40;
    for (i = 1; i < 10; i++) {
      s = s + "   " + i;
    }
    g.drawString(s, x, y);

    y += 10;
    g.drawRect(x, y, 200, 200);

    s = "";
    y += 20;

    for (i = 1; i < 10; i++) {
      for (int j = 1; j < 10; j++) {
        if (i*j < 10)
          s = s + "   " + i * j;
        else
          s = s + " " + i * j;
      }

      g.drawString(s, x, y);
      s = "";
      y += 20;
    }
  }
}
