public class Exercise6_10 {
    public static void main(String[] args) {
        System.out.println("Monthly payment is " + Loan1.monthlyPayment(
        7, 15, 120000));
    }
}

class Loan1 {
    private double annualInterestRate;
    private int numberOfYears;
    private double loanAmount;
    private java.util.Date loanDate;
    
    /** Construct a loan with interest rate 2.5, 1 year, and $1000 */
    public Loan1() {
        this(2.5, 1, 1000);
    }
    
    /** Construct a loan with specified annual interest rate,
     * number of years and loan amount
     */
    public Loan1(double annualInterestRate, int numberOfYears,
    double loanAmount) {
        this.annualInterestRate = annualInterestRate;
        this.numberOfYears = numberOfYears;
        this.loanAmount = loanAmount;
        loanDate = new java.util.Date();
    }
    
    /** Return annualInterestRate */
    public double getAnnualInterestRate() {
        return annualInterestRate;
    }
    
    /** Set a new annualInterestRate */
    public void setAnnualInterestRate(double annualInterestRate) {
        this.annualInterestRate = annualInterestRate;
    }
    
    /** Return numberOfYears */
    public int getNumberOfYears() {
        return numberOfYears;
    }
    
    /** Set a new numberOfYears */
    public void setNumberOfYears(int numberOfYears) {
        this.numberOfYears = numberOfYears;
    }
    
    /** Return loanAmount */
    public double getLoanAmount() {
        return loanAmount;
    }
    
    /** Set a newloanAmount */
    public void setLoanAmount(double loanAmount) {
        this.loanAmount = loanAmount;
    }
    
    /** Find monthly payment */
    public double monthlyPayment() {
        double monthlyInterestRate = annualInterestRate / 1200;
        return loanAmount * monthlyInterestRate / (1 -
        (Math.pow(1 / (1 + monthlyInterestRate), numberOfYears * 12)));
    }
    
    /** Find total payment */
    public double totalPayment() {
        return monthlyPayment() * numberOfYears * 12;
    }
    
    /** Return loan date */
    public java.util.Date getLoanDate() {
        return loanDate;
    }
    
    public static double monthlyPayment(double annualInterestRate, int numOfYears,
    double loanAmount) {
        double monthlyInterestRate = annualInterestRate/1200;
        return loanAmount*monthlyInterestRate/
        (1 - (Math.pow(1/(1 + monthlyInterestRate), numOfYears*12)));
    }
    
    public static double totalPayment(double annualInterestRate, int numOfYears,
    double loanAmount) {
        return monthlyPayment(annualInterestRate, numOfYears, loanAmount)*numOfYears*12;
    }
}
