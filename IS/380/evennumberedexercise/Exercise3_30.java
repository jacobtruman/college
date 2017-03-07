// Exercise3_30.java: Approximate PI
public class Exercise3_30 {
  public static void main(String[] args) {
    double pi = 0;
    double term;
    int sign = 1;

    for (int i = 1; i <= 100000; i++) {
      term = sign * 4.0 / (2 * i - 1);
      pi += term;
      sign = -1 * sign;

      if (i == 10000 || i == 20000 || i == 30000 || i == 40000 ||
          i == 50000 || i == 60000 || i == 70000 || i == 80000 ||
          i == 90000 || i == 100000)
      System.out.println("The PI is " + pi + " for i = " + i);
    }
  }
}
