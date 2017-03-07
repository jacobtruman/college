// Exercise14_4.java:
import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class Exercise14_4 extends JApplet implements ActionListener {
  private Exercise13_6 investmentFrame = new Exercise13_6();
  private JFrame loanFrame = new JFrame("Loan Calculator");
  private JButton jbtInvestment = new JButton("Investment Calculator");
  private JButton jbtLoan = new JButton("Loan Calculator");

  public void init() {
    getContentPane().setLayout(new FlowLayout());
    getContentPane().add(jbtInvestment);
    getContentPane().add(jbtLoan);
    jbtInvestment.addActionListener(this);
    jbtLoan.addActionListener(this);
  }

  public void actionPerformed(ActionEvent e) {
    if (e.getSource() == jbtInvestment) {
      investmentFrame.setSize(300, 200);
      investmentFrame.setTitle("Investment Calculator");
      investmentFrame.setVisible(true);
    }
    else if (e.getSource() == jbtLoan) {
      loanFrame.setSize(300, 200);
      LoanApplet applet = new LoanApplet();
      loanFrame.getContentPane().add(applet);
      applet.init();
      loanFrame.setVisible(true);
    }
  }
}