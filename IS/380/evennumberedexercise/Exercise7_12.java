public class Exercise7_12 {
  public static void main(String args[]) {
    System.out.println(isAnagram("silent", "listen"));
    System.out.println(isAnagram("garden", "ranged"));
    System.out.println(isAnagram("split", "lisp"));
  }

  public static boolean isAnagram(String s1, String s2) {
    String newS1 = Exercise7_11.sort(s1);
    String newS2 = Exercise7_11.sort(s2);

    if (newS1.length() != newS2.length()) return false;

    for (int i = 0; i < newS1.length(); i++) {
      if (newS1.charAt(i) != newS2.charAt(i))
        return false;
    }

    return true;
  }
}
