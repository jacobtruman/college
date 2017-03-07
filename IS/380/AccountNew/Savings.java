// -------------------------
// Developer: Jacob Truman -
// Date: 3/21/06           -
// Savings.java            -
// -------------------------

public class Savings extends Account{
	double newBalance;

  /**Default constructor*/
  public Savings(){
    this(0, 0, 0);
  }

  /**Construct Account with a specified id, balance and interest rate*/
	public Savings(int id, double balance, double annualInterestRate){
		super(id, balance, annualInterestRate);
	}

	/**Implement the withdraw method*/
	public void withdraw(double amount){
		newBalance = super.getBalance() - amount;
		if (newBalance < 0){
			System.out.println("Cannot Withdraw - Insufficient Funds");
		}else{
			setBalance(newBalance);
		}
	}

}