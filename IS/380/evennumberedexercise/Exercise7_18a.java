// Exercise7_18a.java: Write a program that passes an unspecified
// number of integers as separate command-line arguments and
// displays their total.
public class Exercise7_18a {
  public static void main(String[] args) {
    int sum = 0;

    for (int i = 0; i < args.length; i++) {
      sum += Integer.parseInt(args[i]);
    }

    System.out.println("The total is " + sum);
  }
}

