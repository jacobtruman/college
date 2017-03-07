// Exercise4_10.java: Display prime numbers
public class Exercise4_10 {
  public static void main(String[] args) {
    int count = 0;

    for (int i = 2; count < 1000; i++) {
      // Display each number in five positions
      if (isPrime(i)) {
        if (i <= 9)
          System.out.print(i + "    ");
        else if (i <= 99)
          System.out.print(i + "   ");
        else if (i <= 999)
          System.out.print(i + "  ");
        else if (i <= 9999)
          System.out.print(i + " ");

        count++;

        if (count%10 == 0)
          System.out.println();
      }
    }
  }

  public static boolean isPrime(int num) {
    if ((num == 1) || (num == 2)) {
      return true;
    }

    for (int i = 2; i <= num / 2; i++) {
      if (num % i == 0)
        return false;
    }

    return true;
  }
}
