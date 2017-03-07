// Exercise13_6.java: Compute future value
import java.awt.*;
import java.awt.event.*;
import java.text.*;
import java.util.*;
import javax.swing.*;

public class Exercise13_6 extends JFrame implements ActionListener {
  private JTextField jtfInvestmentAmount;
  private JTextField jtfYears;
  private JTextField jtfInterestRate;
  private JTextField jtfFutureValue;
  private JButton jbtCalculate;

  public static void main(String[] args) {
    JFrame frame = new Exercise13_6();
    frame.setSize(300, 200);
    frame.setTitle("Exercise13_6");
    frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    frame.setVisible(true);
  }

  public Exercise13_6() {
    // Create a new panel with GridLayout to hold labels and text boxes
    JPanel p = new JPanel();
    p.setLayout(new GridLayout(4, 2));
    p.add(new JLabel("Investment Amount"));
    p.add(jtfInvestmentAmount = new JTextField(8));
    p.add(new JLabel("Years"));
    p.add(jtfYears = new JTextField(8));
    p.add(new JLabel("Annual Interest Rate"));
    p.add(jtfInterestRate = new JTextField(8));
    p.add(new JLabel("Future value"));
    p.add(jtfFutureValue = new JTextField(8));
    jtfFutureValue.setEditable(false);

    // Add the panel and a button to the frame
    getContentPane().setLayout(new BorderLayout());
    getContentPane().add(p, BorderLayout.CENTER);
    getContentPane().add(jbtCalculate = new JButton("Calculate"), BorderLayout.SOUTH);

    jbtCalculate.setMnemonic('C');
    jtfInvestmentAmount.setHorizontalAlignment(JTextField.RIGHT);
    jtfYears.setHorizontalAlignment(JTextField.RIGHT);
    jtfInterestRate.setHorizontalAlignment(JTextField.RIGHT);
    jtfFutureValue.setHorizontalAlignment(JTextField.RIGHT);

    // Register listener
    jbtCalculate.addActionListener(this);
  }

  // Handle ActionEvent
  public void actionPerformed(ActionEvent e) {
    if (e.getSource() == jbtCalculate)
      calculate();
  }

  // Calculate future value
  public void calculate() {
    double investmentAmount =
    Double.valueOf(jtfInvestmentAmount.getText().trim()).doubleValue();
    int years =
      Integer.valueOf(jtfYears.getText().trim()).intValue();
    double interestRate = Double.valueOf(jtfInterestRate.getText().trim()).doubleValue();
    double futureValue = investmentAmount * Math.pow((1 + interestRate / (12 * 100)), 12 * years);
//    NumberFormat nf = NumberFormat.getCurrencyInstance(Locale.US);
//    jtfFutureValue.setText(nf.format(futureValue));
    jtfFutureValue.setText((int)(futureValue * 100) / 100.0 + "");
  }
}

