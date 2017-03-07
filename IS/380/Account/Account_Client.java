// -------------------------
// Developer: Jacob Truman -
// Date: 2/14/06           -
// Account_Client.java     -
// -------------------------
public class Account_Client{
	public static void main(String ars[]){
	
	Account myAccount = new Account(1122, 20000, 4.5);
	myAccount.withdraw(2500);
	myAccount.deposit(3000);
	System.out.println("Account Balance: " + myAccount.getBalance());
	System.out.println("Monthly Interest: " + myAccount.getMonthlyInterestRate()*myAccount.getBalance());
	
	}
}