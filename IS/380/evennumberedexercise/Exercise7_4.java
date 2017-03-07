public class Exercise7_4 {
  public static void main(String[] args) {
    int count = count("Welcome", 'e');
    System.out.println(count);
  }

  public static int count(String str, char ch) {
    int count = 0;
    for (int i=0; i<str.length(); i++) {
      if (str.charAt(i) == ch) count++;
    }
    return count;
  }
}
