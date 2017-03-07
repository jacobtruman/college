import java.util.*;

public class Exercise7_16 {
    public static void main(String[] args) {
        
        System.out.print("Please enter int values: ");
        Scanner scanner = new Scanner(System.in);
        
        
        int sum = 0;
        while (scanner.hasNext())
            sum += scanner.nextInt();
        
        System.out.println("Sum is " + sum);
        
    }
    
}
