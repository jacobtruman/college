// Exercise4_12.java: Print a table of square roots
public class Exercise4_12 {
  public static void main(String[] args) {
    System.out.println("RealNumber\t\tSquareRoot");
    System.out.println("-------------------------------");

    for (int num = 0; num <= 20; num++) {
      System.out.println(num + "\t\t\t" + Math.sqrt(num));
    }
  }
}

