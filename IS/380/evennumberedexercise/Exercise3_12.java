// Exercise3_12.java
public class Exercise3_12 {
    public static void main(String[] args) {
        double tuition = 10000;
        
        for (int i = 1; i <= 10; i++)
            tuition = tuition * 1.10;
        
        System.out.println("Tuition in ten years is " + tuition);
    }  
}
