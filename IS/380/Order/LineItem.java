// -------------------------
// Developer: Jacob Truman -
// Date: 3/8/06            -
// LineItem.java           -
// -------------------------

public class LineItem{

// Variables
private Product lineProduct;
private int itemNum;
private int itemQnty;

// Contructors
	public LineItem(){
	}
	
	public LineItem(int iNum, int iQnty){
		setItemNum(iNum);
		setItemQnty(iQnty);
	}

// Set Methods
	public void setItemNum(int iNum){
		this.itemNum = iNum;
		this.lineProduct = new Product(iNum);
	}
	
	public void setItemQnty(int iQnty){
		this.itemQnty = iQnty;
	}

// Get Methods
	public int getItemNum(){
		return itemNum;
	}
	
	public int getItemQnty(){
		return itemQnty;
	}
	
// Calculate Line Price
	public double getLinePrice(){
		return lineProduct.getProdPrice() * itemQnty;
	}
}