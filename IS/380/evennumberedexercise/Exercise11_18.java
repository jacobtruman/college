import java.awt.*;
import javax.swing.*;

public class Exercise11_18 extends JFrame {
    public Exercise11_18() {
    Container container = getContentPane();
    container.setLayout(new GridLayout(1, 3, 20, 5));

    BarChart chart1 = new BarChart();
    double[] data1 = {20, 10, 30, 40};
    String[] dataName1 = {"Project -- 20%", "Quizzes -- 10%", "Midtems -- 30%", "Final -- 40%"};
    chart1.setData(dataName1, data1);
    container.add(chart1);
  }

  public static void main(String[] args) {
    Exercise11_18 frame = new Exercise11_18();
    frame.setTitle("Exercise11_18");
    frame.setSize(500, 200);
    frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    frame.setVisible(true);
  }
}