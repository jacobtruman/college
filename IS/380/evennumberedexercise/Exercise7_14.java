import java.util.*;
import javax.swing.JOptionPane;

public class Exercise7_14 {
    /**Main method*/
    public static void main(String[] args) {
        // Receive the amount entered from the dialog box
        String s = JOptionPane.showInputDialog(
        "Enter a string:");
        
        StringTokenizer tokens = new StringTokenizer(s, ".,:\"\'? ");
                
        while (tokens.hasMoreTokens())
            System.out.println(tokens.nextToken());     
        
        System.exit(0);
    }
}