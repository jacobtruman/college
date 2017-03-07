import java.awt.*;
import java.awt.event.*;
import java.applet.*;
import javax.swing.*;
import javax.swing.table.*;
import javax.swing.border.*;
import java.text.*;

public class Exam4 extends JApplet {
  JPanel jPanel1 = new JPanel();
  JLabel jLabel1 = new JLabel();

  JTextField jtfLoanAmount = new JTextField();
  JLabel jLabel2 = new JLabel();
 
  JTextField jtfNumberOfYears = new JTextField();
  JLabel jLabel3 = new JLabel();
  JTextField jftAnnualInterestRate = new JTextField();
  JButton jbtLoanSchedule = new JButton();
  TitledBorder titledBorder1;
  JScrollPane jScrollPane1 = new JScrollPane();

  DefaultTableModel tableModel = new DefaultTableModel();

  JTable jtbLoanSchedule = new JTable(tableModel);
  JPanel jPanel2 = new JPanel();
  BorderLayout borderLayout1 = new BorderLayout();
  GridLayout gridLayout1 = new GridLayout();

  /**Construct the applet*/
  public Exam4() {
    titledBorder1 = new TitledBorder("");
    this.setSize(new Dimension(705, 399));
    jLabel1.setText("Loan Amount");
    jLabel2.setText("Number of Years");
    jLabel3.setText("Annual Interest Rate");
    jbtLoanSchedule.setText("Display Loan Schedule");
    jbtLoanSchedule.addActionListener(new java.awt.event.ActionListener() {
      public void actionPerformed(ActionEvent e) {
        jbtLoanSchedule_actionPerformed(e);
      }
    });
    jPanel1.setLayout(gridLayout1);
    jPanel1.setBorder(titledBorder1);
    titledBorder1.setTitle("Enter Loan Amount, Number of Years, and Annual Interest Rate");
    jPanel2.setLayout(borderLayout1);
    gridLayout1.setRows(3);
    gridLayout1.setColumns(2);
    this.getContentPane().add(jScrollPane1, BorderLayout.CENTER);
    this.getContentPane().add(jPanel2, BorderLayout.NORTH);
    jPanel2.add(jbtLoanSchedule, BorderLayout.EAST);
    jPanel2.add(jPanel1, BorderLayout.CENTER);
    jPanel1.add(jLabel1, null);
    jPanel1.add(jtfLoanAmount, null);
    jPanel1.add(jLabel2, null);
    jPanel1.add(jtfNumberOfYears, null);
    jPanel1.add(jLabel3, null);
    jPanel1.add(jftAnnualInterestRate, null);
    jScrollPane1.getViewport().add(jtbLoanSchedule, null);

    

  jtfLoanAmount.setHorizontalAlignment(JTextField.RIGHT);
  jtfNumberOfYears.setHorizontalAlignment(JTextField.RIGHT);
  jftAnnualInterestRate.setHorizontalAlignment(JTextField.RIGHT);
    tableModel.setColumnIdentifiers(new String[]{"Payment#",
      "Interest", "Principal", "Balance"});
  }

  void jbtLoanSchedule_actionPerformed(ActionEvent e) {
    // Obtain loan amount, annual interest rate, and number of years
    double loanAmount =
      Double.parseDouble(jtfLoanAmount.getText().trim());
    
    double annualInterestRate =
      Double.parseDouble(jftAnnualInterestRate.getText().trim());
    int numOfYears =
      Integer.parseInt(jtfNumberOfYears.getText().trim());

    // Obtain monthly interest rate
    double monthlyInterestRate = annualInterestRate / 1200;

    // Compute mortgage
    double monthlyPayment = loanAmount * monthlyInterestRate /
      (1 - (Math.pow(1 / (1 + monthlyInterestRate), numOfYears * 12)));

    double balance = loanAmount;
    double interest;
    double principal;
    NumberFormat currencyForm = NumberFormat.getCurrencyInstance();
  
    tableModel.setRowCount(0);

    int i;
    for (i = 1; i <= numOfYears * 12; i++) {
      interest = monthlyInterestRate * balance;
      principal = monthlyPayment - interest;
      balance -= principal;
      tableModel.addRow(new Object[]{new Integer(i),
        currencyForm.format(interest),
        currencyForm.format(principal),
        currencyForm.format(balance)});
    }
  }

  public static void main(String[] args) {
    Exam4 applet = new Exam4();
    JFrame frame = new JFrame();
    //EXIT_ON_CLOSE == 3
    frame.setDefaultCloseOperation(3);
    frame.setTitle("Test");
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