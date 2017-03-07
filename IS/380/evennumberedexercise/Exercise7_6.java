public class Exercise7_6 {
  public static void main(String[] args) {
    System.out.println(countLetters("Java in 2008"));
  }

  public static int countLetters(String s) {
    int count = 0;
    for (int i = 0; i < s.length(); i++) {
      if (Character.isLetter(s.charAt(i))) count++;
     }

    return count;
 }
}
