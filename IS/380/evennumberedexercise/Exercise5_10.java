// Exercise5_10.java: Write a method that finds the index of
// the smallest element in an array of integers.
public class Exercise5_10 {
  // Main method
  public static void main(String[] args) {
    int[] list = {1, 2, 4, 5, 10, 100, 2, -22};

    System.out.println("The min is " + minIndex(list));
  }

  public static int minIndex(int[] list) {
    int min = list[0];
    int minIndex = 0;

    for (int i = 1; i < list.length; i++)
      if (min > list[i]) {
        min = list[i];
        minIndex = i;
      }

    return minIndex;
  }
}