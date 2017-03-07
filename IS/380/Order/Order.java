// -------------------------
// Developer: Jacob Truman -
// Date: 3/8/06            -
// Order.java              -
// -------------------------

public class Order{

// Variables
	private int orderNum;
	private java.util.Date orderDate;
	private LineItem[] orderItems;
	private String lineItem;
	
// Constructors
	public Order(){
	}
	
	public Order(int oNum, java.util.Date oDate, String lineItems){
		setOrderNum(oNum);
		setOrderDate(oDate);
		setLineItems(lineItems);
	}
	
// Get methods
	public int getOrderNum(){
		return orderNum;
	}
	
	public java.util.Date getOrderDate(){
		return orderDate;
	}
	
// Set methods
	public void setOrderNum(int oNum){
		this.orderNum = oNum;
	}
	
	public void setOrderDate(java.util.Date oDate){
		this.orderDate = oDate;
	}
	
	public void setLineItems(String lItems){	
		String[] temp;
		temp = lItems.split(",");
		int tempItem;
		int tempQnty;
		orderItems = new LineItem[(temp.length / 2)];
		int j = 0;
		for (int i = 0; i < temp.length; i++){
			tempItem = Integer.valueOf(temp[i]).intValue();
			tempQnty = Integer.valueOf(temp[++i]).intValue();
			this.orderItems[j] = new LineItem(tempItem, tempQnty);
			j++;
		}
	}
	
// Line Items Calculation
	public double getOrderTotal(){
		double rTotal = 0.0;
		for (int i = 0; i < orderItems.length; i++){
			rTotal += orderItems[i].getLinePrice();
		}
		return rTotal;
	}
}