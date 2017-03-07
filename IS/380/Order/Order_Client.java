// -------------------------
// Developer: Jacob Truman -
// Date: 3/8/06            -
// Order_Client.java       -
// -------------------------

import java.util.*;
import java.text.DecimalFormat;
public class Order_Client{
	public static void main(String ars[]){

/* Listed below are the items you may add to an order
#    Name             Price
-----------------------------
1    Computer         $350.00
2    Printer          $40.00
3    Scanner          $45.50
4    Digital Camera   $150.99
*/

		// format for prices
		DecimalFormat df = new DecimalFormat("$0.00");
		
		// get date and time
		Date now = new Date();
		
		// create orders (order number, date, "item,qnty,item,qnty..."
		Order myOrder1 = new Order(1, now, "1,1,2,2");
		Order myOrder2 = new Order(2, now, "1,1,3,3,4,2");
		System.out.println("Order 1 Price: " + df.format(myOrder1.getOrderTotal()));
		System.out.println("Order 2 Price: " + df.format(myOrder2.getOrderTotal()));
	}
}