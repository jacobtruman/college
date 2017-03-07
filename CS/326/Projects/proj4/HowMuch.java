// * HowMuch.java
// * Project #4
// *
// * Jacob Truman
// * CS326 Section 1
// ------------------

// Import Statements
// ------------------
import	java.awt.*;
import	java.applet.*;
import	java.awt.event.*;
import	javax.swing.*;

public class HowMuch extends Applet implements ActionListener{
	// 3. Create your object attributes here
	double month = 0, total = 0;
	
	JTextField jtfLoanAmount = new JTextField(15);
	JTextField jtfInterestRate = new JTextField(15);
	JTextField jtfLoanTime = new JTextField(15);
	JLabel jlLoanAmount = new JLabel("Ammount Borrowed: ");
	JLabel jlInterestRate = new JLabel("Interest Rate: ");
	JLabel jlLoanTime = new JLabel("Years to Pay: ");
	JLabel jlLoanMonth = new JLabel("Monthly: ");
	JLabel jlLoanTotal = new JLabel("Total Cost: ");

	JLabel jlaLoanMonth = new JLabel("$ 0               ");
	JLabel jlaLoanTotal = new JLabel("$ 0               ");

	JButton calcButton = new JButton("Calculate");


	public void init(){
		// This line simply arranges the components
		// Do NOT remove this line or put code before it
		setLayout(new GridLayout(0, 2, 5, 5));
		
		// 4. "Talk" to your objects here
		add(jlLoanAmount);
		add(jtfLoanAmount);
		add(jlInterestRate);
		add(jtfInterestRate);
		add(jlLoanTime);
		add(jtfLoanTime);
		add(jlLoanMonth);
		add(jlaLoanMonth);
		add(jlLoanTotal);
		add(jlaLoanTotal);
		add(calcButton);


		// 5. Hook-up the Java event system
		calcButton.addActionListener(this);

	}

	// Method to handle ActionEvents
	public void actionPerformed(ActionEvent act_evt){
		String amount, interest, time, mTotal, tTotal;
	
		// 6. Extract text from each text field
		amount = jtfLoanAmount.getText();
		interest = jtfInterestRate.getText();
		time = jtfLoanTime.getText();


		// 7. Create numeric variables and convert text


		// 8. Make the necessary calculations


		// 9. Display the formatted results


	}
}
