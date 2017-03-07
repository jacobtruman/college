import java.util.*;

public class Exercise18_4 {
  public static void main(String[] args) {
    ArrayList list1 = new ArrayList(Arrays.asList(
      new String[]{"George", "Jim", "John", "Blake", "Kevin", "Michael"}));

    ArrayList list1Clone1 = (ArrayList)list1.clone();
    ArrayList list1Clone2 = (ArrayList)list1.clone();

    ArrayList list2 = new ArrayList(Arrays.asList(
      new String[] {"George", "Katie", "Kevin", "Michelle", "Ryan"}));

    list1.addAll(list2);
    list1Clone1.removeAll(list2);
    list1Clone2.retainAll(list2);

    System.out.println("The union of the two sets is " + list1);
    System.out.println("The difference of the two sets is " + list1Clone1);
    System.out.println("The intersection of the two sets is " + list1Clone2);
  }
}
