import java.util.*;
import javax.swing.JOptionPane;

public class Exercise18_6 {
  public static void main(String[] args) {
    // Create a tree map to hold words and key and count as value
    TreeMap treeMap = new TreeMap();

    while (true) {
      // Enter an integer
      String numberString = JOptionPane.showInputDialog(null,
        "Enter an integer:", "Exercise18_6 Input",
        JOptionPane.QUESTION_MESSAGE);

      // Convert string to int
      int number = Integer.parseInt(numberString);

      if (number == 0) break;

      Integer key = new Integer(number);

      if (treeMap.get(key) != null) {
        int value = ((Integer)treeMap.get(key)).intValue();
        value++;
        treeMap.put(key, new Integer(value));
      }
      else {
        treeMap.put(key, new Integer(1));
      }
    }

    Integer max = (Integer)(Collections.max(treeMap.values()));
    Set keys = treeMap.keySet();
    Iterator iterator = keys.iterator();

    while (iterator.hasNext()) {
      Object key = iterator.next();
      Integer value = (Integer)(treeMap.get(key));
      if (value.equals(max)) {
        System.out.println("Number " + key + " occurred most");
      }
    }

    System.exit(0);
  }
}

