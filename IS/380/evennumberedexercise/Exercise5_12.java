// Exercise5_12.java: Selection sort using recursion
public class Exercise5_12 {
  public static void main (String[] args) {
    double[] myList = {5.0, 4.4, 1.9, 2.9, 3.4, 3.5};
    System.out.println("My list before sort is: ");

    // Print the original list
    printList(myList);
    selectionSort(myList);

    // Print the sorted list
    System.out.println("My list after sort is: ");
    printList(myList);
  }

  static void printList(double[] list) {
    for (int i = 0; i < list.length; i++)
      System.out.println(list[i]);
  }

  static void selectionSort(double[] list) {
    selectionSort(list, list.length);
  }

  static void selectionSort(double[] list, int size) {
    double currentMax;
    int currentMaxIndex;
    if (size <= 1) return;

    // Find the maximum in the list[0..i]
    currentMax = list[0];
    currentMaxIndex = 0;
    for (int j = 1; j < size; j++) {
      if (currentMax < list[j]) {
        currentMax = list[j];
        currentMaxIndex = j;
      }
    }

    // Move the largest number to the end of the list necessary
    if (currentMaxIndex != size-1) {
      list[currentMaxIndex] = list[size-1];
      list[size-1] = currentMax;
    }

    selectionSort(list, size-1);
  }
}

