// -------------------------
// Developer: Jacob Truman -
// Date: 3/8/06            -
// Product.java            -
// -------------------------

public class Product{

// Variables
private int prodNum;
private String prodName;
private double prodPrice;

// Constructors
	public Product(){
	}
	
	public Product(int pNum){
		switch (pNum) {
			case 1:
				setProdNum(pNum);
				setProdName("Computer");
				setProdPrice(350.00);
				break;
			case 2:
				setProdNum(pNum);
				setProdName("Printer");
				setProdPrice(40.00);
			break;
			case 3:
				setProdNum(pNum);
				setProdName("Scanner");
				setProdPrice(45.50);
			break;
			case 4:
				setProdNum(pNum);
				setProdName("Digital Camera");
				setProdPrice(150.99);
			break;
		}
	}

	public Product(int pNum, String pName, double pPrice){
		setProdNum(pNum);
		setProdName(pName);
		setProdPrice(pPrice);
	}
	
// Set Methods
	public void setProdNum(int pNum){
		this.prodNum = pNum;
	}

	public void setProdName(String pName){
		this.prodName = pName;
	}
	
	public void setProdPrice(double pPrice){
		this.prodPrice = pPrice;
	}

// Get Methods
	public int getProdNum(){
		return prodNum;
	}

	public String getProdName(){
		return prodName;
	}

	public double getProdPrice(){
		return prodPrice;
	}
}