import javax.swing.*;
import java.sql.*;
import java.awt.*;

public class Exercise25_2 extends javax.swing.JApplet {
  String[] dataName;
  double[] data;

  /** Creates new form Exercise25_2 */
  public Exercise25_2() {
    try {
      // Declare driver and connection string
      String driver = "sun.jdbc.odbc.JdbcOdbcDriver";
      String connectionString = "jdbc:odbc:exampleMDBDataSource";
      /* For Oracle
      String driver = "oracle.jdbc.driver.OracleDriver";
      String connectionString =
      "jdbc:oracle:thin:scott/tiger@liang.armstrong.edu:1521:oracle";
      */
      // Load the Oracle JDBC Thin driver
      Class.forName(driver);

      // Connect to the sample database
      Connection conn = DriverManager.getConnection(connectionString);
      Statement stmt = conn.createStatement();
      ResultSet rs = stmt.executeQuery(
        "select deptId, count(*) from Student group by deptId;");

      // Count rows
      int count = 0;
      while (rs.next()) {
        count++;
      }

      dataName = new String[count];
      data = new double[count];

      // We have to obtain the result set again
      rs = stmt.executeQuery(
        "select deptId, count(*) from Student group by deptId;");
      int i = 0;
      while (rs.next()) {
        dataName[i] = rs.getString(1);
        data[i] = rs.getInt(2);
        i++;
      }
    }
    catch (Exception ex) {
      ex.printStackTrace();
    }

    chartModel1 = new Exercise21_6ChartModel();
    chartModel1.setChartData(dataName, data);
    pieChart1 = new Exercise21_6PieChart();
    barChart1 = new Exercise21_6BarChart();

    getContentPane().setLayout(new java.awt.GridLayout(1, 2));
    pieChart1.setModel(chartModel1);
    getContentPane().add(pieChart1);
    barChart1.setModel(chartModel1);
    getContentPane().add(barChart1);
  }

  /**Main method*/
  public static void main(String[] args) {
    Exercise25_2 applet = new Exercise25_2();
    JFrame frame = new JFrame();
    //EXIT_ON_CLOSE == 3
    frame.setDefaultCloseOperation(3);
    frame.setTitle("Exercise25_2");
    frame.getContentPane().add(applet, BorderLayout.CENTER);
    applet.init();
    applet.start();
    frame.setSize(400,320);
    Dimension d = Toolkit.getDefaultToolkit().getScreenSize();
    frame.setLocation((d.width - frame.getSize().width) / 2,
      (d.height - frame.getSize().height) / 2);
    frame.setVisible(true);
  }

  // Variables declaration - do not modify//GEN-BEGIN:variables
  private Exercise21_6PieChart pieChart1;
  private Exercise21_6ChartModel chartModel1;
  private Exercise21_6BarChart barChart1;
  // End of variables declaration//GEN-END:variables

}