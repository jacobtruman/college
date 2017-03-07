import java.util.*;
import java.io.*;

public class Exercise18_2 {
  public static void main(String[] args) {
    if (args.length != 1) {
      System.out.println(
        "Usage: java Exercise18_2 fullfilename");
      System.exit(0);
    }

    String filename = args[0];

    // Create a tree set to hold the words
    TreeSet treeSet = new TreeSet();

    try {
      BufferedReader in = new BufferedReader(new FileReader
        (filename));

      String line;

      while ((line = in.readLine()) != null) {
        StringTokenizer st = new StringTokenizer(line,
          " \n\t\r.,)(-\"");

        while (st.hasMoreTokens())
          treeSet.add(st.nextToken());
      }
    }
    catch (Exception ex) {
      System.err.println(ex);
    }

    // Get an iterator for the set
    Iterator iterator = treeSet.iterator();

    // Display mappings
    System.out.println("\nDisplay words in ascending order ");
    while (iterator.hasNext()) {
      System.out.println(iterator.next());
    }
  }
}

