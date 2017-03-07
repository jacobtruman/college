public class Test extends Object {
   public static void main(String[] args) {
     Test test = new Test();
   }

   public Test() {
     System.out.print("A");
   }
	
   {
     System.out.print("F");
   }

   {
     System.out.print("B");
   }

   static {
     System.out.print("C");
   }
	
   {
     System.out.print("D");
   }
	
   {
     System.out.print("E");
   }
}