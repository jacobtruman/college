// Exercise10_4.java
public class Exercise10_4 {
  public static void main(String[] args) {
    new Exercise10_4();
  }

  public Exercise10_4() {
    // Define the arrays to be tested.
    Student[] s = new Student[3];
    s[0] = new Student(new Name("Derek", 'S', "Dexony"));
    s[1] = new Student(new Name("Stacy", 'M', "Waters"));
    s[2] = new Student(new Name("Adamo", 'U', "Leetmz"));

    String[] str = {"Orange", "Jackblade", "Apple"};
    Integer[] i = {new Integer(5), new Integer(0), new Integer(3)};

    // Display current array of students
    printList(s);
    System.out.println();

    // Display max of students
    System.out.println("Max is " + max(s));
    System.out.println();

    // Display sorted students
    sort(s);
    printList(s);
    System.out.println();

    // Display current array of strings
    printList(str);
    System.out.println();

    // Display max of strings
    System.out.println("Max is " + max(str));
    System.out.println();

    // Display sorted strings
    sort(str);
    printList(str);
    System.out.println();

    // Display current array of intergers
    printList(i);
    System.out.println();

    // Display max of ints
    System.out.println("Max is " + max(i));
    System.out.println();

    // Display sorted ints
    sort(i);
    printList(i);
  }

  public static void printList(Object[] object) {
    for (int i = 0; i < object.length; i++) {
      System.out.println(object[i]);
    }
  } // End of method printList(Object[])

  public static Object max(Object[] object) {
    // Find max of array object
    Object maxOfA = object[0];
    for(int i = 1; i < object.length; i++) {
      if ((((Comparable) maxOfA).compareTo(object[i])) == -1) {
        maxOfA = object[i];
      }
    }

    // Return results.
    return maxOfA;
  }  // End of method max(Object[])

  public static void sort(Object[] object) {
    // Set the variables for the current min, minIndex, and compare value
    Object currentMin;
    int currentMinIndex;
    int compareInt;

    // Begin loop to work through the list.
    for (int i = 0; i < object.length; i++) {
       // Find the minimum in the list.
       currentMin = object[i];
       currentMinIndex = i;
       for (int k = i + 1; k < object.length; k++) {
         compareInt = ((Comparable) currentMin).compareTo(object[k]);
         if(compareInt > 0) {
           currentMin = object[k];
           currentMinIndex = k;
         }
       }

       // Swap list[i] with list[currentMaxIndex] if needed.
       if (currentMinIndex != i) {
         object[currentMinIndex] = object[i];
         object[i] = currentMin;
       }
    }
  } // End of instance method sort(Object[])


class Student extends Person implements Comparable, Cloneable {
  // Variables
  private String major;

  // Constructors
  public Student(Name name) {
    super(name);
    major = "Computer Science";
  }

  // Default Constructor
  public Student() {

  }

  // Instance Methods
  public String getMajor() {
    return major;
  }

  public void setMajor(String major) {
    this.major = major;
  }

  public String toString() {
    Name name = this.getName();
    return name.getFullName() + '\n' + "Major: " + major;
  }

  public boolean equals(Object object) {
    Name name = this.getName();
    Name otherName = ((Student) object).getName();

    if ((name.getFullName().equals(otherName.getLastName()))
        && (major.equals(((Student) object).getMajor()))) {
      return true;
    }
    return false;
  }

  public int compareTo(Object object) {
    Name name = this.getName();
    String lastName = name.getLastName();
    Name otherName = ((Student) object).getName();
    String otherLastName = otherName.getLastName();
    int i = 0;


    if ((lastName.compareTo(otherLastName)) > 0) {
      i = 1;
    }
    else if ((lastName.compareTo(otherLastName)) < 0) {
      i = -1;
    }
    return i;
  }
}


/**
 * Class: CSCI 1302
 * Instructor: Y. Daniel Liang
 * Description: Defines the object Person, to be extended by Student.
 * @author: Derek S. Diebold
 * @version: 1.0
 * @date: 1/16/2001
 */
public class Person {
  // Variables
  private Name name;

  // Constructors
  public Person(Name name) {
    this.name = name;
  }

  // Default Constructor
  public Person() {

  }

  // Instance Methods
  public Name getName() {
    return name;
  }

  public void setName(Name name) {
    this.name = name;
  }

  public String toString() {
    return name.getFullName();
  }

  public boolean equals(Object object) {
    Name otherName = ((Person) object).getName();
    if (name.getFullName().equals(otherName.getFullName())) {
      return true;
    }
    return false;
  }
}

class Name {
  // Variables
  private String firstName;
  private char mi;
  private String lastName;

  // Constructors
  public Name(String firstName, char mi, String lastName) {
    // Set new variables to instance.
    this.firstName = firstName;
    this.mi = mi;
    this.lastName = lastName;
  }

  // Default Constructor
  public Name() {

  }

  // Instance Methods
  public String getFirstName() {
    return firstName;
  }

  public void setFirstName(String firstName) {
    this.firstName = firstName;
  }

  public char getMi() {
    return mi;
  }

  public void setMi(char mi) {
    this.mi = mi;
  }

  public String getLastName() {
    return lastName;
  }

  public void setLastName(String lastName) {
    this.lastName = lastName;
  }

  public String getFullName() {
    return firstName + " " + mi + " " + lastName;
  }
}
}