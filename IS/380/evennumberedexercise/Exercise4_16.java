// Exercise4_16.java: Create a method for computing square roots
public class Exercise4_16 {
  // Main method
  public static void main(String[] args) {
    System.out.println(
      "The square root for 9 is " + SquareRoot.sqrt(9.0));
    System.out.println(
      "The square root for 2000 is " + SquareRoot.sqrt(2000.0));
  }
}

// This class contains sqrt method
class SquareRoot {
  // Find the square root of the value
  public static double sqrt(double num) {
    double nextGuess = 1.0;
    double lastGuess;

    do {
      lastGuess = nextGuess;
      nextGuess = (lastGuess + (num / lastGuess)) * 0.5;
    } while (Math.abs(nextGuess - lastGuess) >= 0.00001);

    return nextGuess;
  }
}
