import javax.swing.*;

public class Exercise3_20 {
  public static void main(String[] args) {
    // Enter n1
    String n1String = JOptionPane.showInputDialog(
        null, "Enter the first number:",
        "Exercise3_20 Input", JOptionPane.QUESTION_MESSAGE);

    int n1 = Integer.parseInt(n1String);

    // Enter n2
    String n2String = JOptionPane.showInputDialog(
        null, "Enter the second number:",
        "Exercise3_20 Input", JOptionPane.QUESTION_MESSAGE);

    int n2 = Integer.parseInt(n2String);

    int d = (n1 < n2) ? n1 : n2;
    for ( ; d >= 1; d--)
      if ((n1 % d == 0) && (n2 % d == 0))
        break;

    System.out.println("GCD of " + n1 + " and " + n2 + " is "
      + d);

    System.exit(0);
  }
}
