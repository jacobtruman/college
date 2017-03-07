// driver class
public class Room2_Client {
	public static void main(String[] args)  {
            Room2 beh107 = new Room2(20, 20);
	    Room2 beh239 = new Room2(12, 12);
            
            System.out.println("Sizes of beh107 are " + beh107.getLength() + " and " + beh107.getWidth());            
            System.out.println("Area of beh107 is " + beh107.computeArea());            
            System.out.println("Sizes of beh239 are " + beh239.getLength() + " and " + beh239.getWidth());            
            System.out.println("Area of beh239 is " + beh239.computeArea());            
        }
}