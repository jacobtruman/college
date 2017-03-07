// -------------------------
// Developer: Jacob Truman -
// Date: 2/10/06           -
// Rectangle_Client.java   -
// -------------------------
public class Rectangle_Client{
	public static void main(String[] args){
            Rectangle rect0 = new Rectangle(4, 40);
				Rectangle rect1 = new Rectangle(0.1, 10.8);
				rect0.setColor("yellow");
				rect1.setColor("red");
				rect0.prntAll("Rectangle 1");
				rect1.prntAll("Rectangle 2");
        }
}