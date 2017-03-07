import java.util.*;
import java.text.*;
public class Test {
  public static void main(String[] args) {
NumberFormat numberFormat = NumberFormat.getPercentInstance(Locale.US);
DecimalFormat decimalFormat = (DecimalFormat)numberFormat;
decimalFormat.applyPattern("00.0##%");
System.out.println(decimalFormat.format(111.2226));
System.out.println(decimalFormat.format(1111.2226));
System.out.println(decimalFormat.format(1.22));
System.out.println(decimalFormat.format(1));

  }
}
