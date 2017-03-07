// -------------------------
// Developer: Jacob Truman -
// Date: 3/21/06           -
// Checking.java            -
// -------------------------

public class Checking extends Account{
	double newBalance;

  /**Default constructor*/
  public Checking(){
    this(0, 0, 0);
  }

  /**Construct Account with a specified id, balance and interest rate*/
	public Checking(int id, double balance, double annualInterestRate){
		super(id, balance, annualInterestRate);
	}

	/**Implement the withdraw method*/
	public void withdraw(double amount){
		newBalance = super.getBalance() - amount;
		if (newBalance < -1500){
			System.out.println("Cannot Withdraw - Exceeded Overdraft");
		}else{
			setBalance(newBalance);
		}
	}

}