import java.awt.*;
import javax.swing.*;

public class Exercise21_6 extends javax.swing.JApplet {
  private Exercise21_6ChartModel chartModel1;
  private Exercise21_6BarChart barChart1;
  private Exercise21_6PieChart pieChart1;

  public Exercise21_6() {
    chartModel1 = new Exercise21_6ChartModel();
    barChart1 = new Exercise21_6BarChart();
    pieChart1 = new Exercise21_6PieChart();

    getContentPane().setLayout(new java.awt.GridLayout(1, 2));

    barChart1.setModel(chartModel1);
    getContentPane().add(barChart1);

    pieChart1.setModel(chartModel1);
    getContentPane().add(pieChart1);
  }

  public static void main(String[] args) {
    Exercise21_6 applet = new Exercise21_6();
    JFrame frame = new JFrame();
    //EXIT_ON_CLOSE == 3
    frame.setDefaultCloseOperation(3);
    frame.setTitle("Exercise21_6");
    frame.getContentPane().add(applet, BorderLayout.CENTER);
    applet.init();
    applet.start();
    frame.setSize(400,320);
    Dimension d = Toolkit.getDefaultToolkit().getScreenSize();
    frame.setLocation((d.width - frame.getSize().width) / 2,
                      (d.height - frame.getSize().height) / 2);
    frame.setVisible(true);
  }
}
