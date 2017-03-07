// Exercise7_18b.java: Write a program that passes an unspecified
// number of integers as separate command-line arguments and
// displays their total.
import java.util.StringTokenizer;

public class Exercise7_18b {
  public static void main(String[] args) {
    int sum = 0;

    StringTokenizer st = new StringTokenizer(args[0]);

    while (st.hasMoreTokens()) {
      sum += Integer.parseInt(st.nextToken());
    }

    System.out.println("The total is " + sum);
  }
}
