// -------------------------
// Developer: Jacob Truman -
// Date: 3/28/06           -
// Account_Client.java     -
// -------------------------
public class Account_Client{
	public static void main(String ars[]){
	
	Account[] A = new Account[4];
	Savings s1 = new Savings(1122, 20000, 4.5);
	Savings s2 = new Savings(200, 20000, 1.2);
	Checking c1 = new Checking(2032, 4000, 3.2);
	Checking c2 = new Checking(3000, 200, 5.1);
	A[0] = s1;
	A[1] = s2;
	A[2] = c1;
	A[3] = c2;

		for (int i = 0; i < 4; i++){
			A[i].withdraw(2100);
			A[i].deposit(3000);
			System.out.println("Account " + i + " Balance: " + A[i].getBalance());
			System.out.println("Account " + i + " Monthly Interest: " + A[i].getMonthlyInterestRate()*A[i].getBalance());	
		}
	}
}