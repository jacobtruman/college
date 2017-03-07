// -------------------------
// Developer: Jacob Truman -
// Date: 2/14/06           -
// Account.java            -
// -------------------------
// Room.java
public class Account{
	private int id;
	private double balance;
	private double annualInterestRate;

  /**Default constructor*/
  public Account(){
    this(0, 0, 0);
  }

  /**Construct Account with a specified id, balance and interest rate*/
	public Account(int id, double balance, double annualInterestRate){
		setId(id);
		setBalance(balance);
		setAnnualInterestRate(annualInterestRate);
	}

  /**Return id*/
	public int getId(){
		return id;
	}

  /**Return balance*/
	public double getBalance(){
		return balance;
	}
	
  /**Return annualInterestRate*/
	public double getAnnualInterestRate(){
		return annualInterestRate;
	}
	
  /**Return annualInterestRate*/
	public double getMonthlyInterestRate(){
		return annualInterestRate/12;
	}

  /**Set a new id*/
	public void setId(int id){
		this.id = id;
	}
	
  /**Set a new balance*/
	public void setBalance(double balance){
		this.balance = balance;
	}
	
  /**Set a new annualInterestRate*/
	public void setAnnualInterestRate(double annualInterestRate){
		this.annualInterestRate = annualInterestRate;
	}

  /**Implement the withdraw method*/
	public void withdraw(double amount){
		setBalance(balance-amount);
	}

  /**Implement the deposit method*/
	public void deposit(double amount){
		setBalance(balance+amount);
	}
}