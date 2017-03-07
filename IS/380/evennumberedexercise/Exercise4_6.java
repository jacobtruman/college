public class Exercise4_6 {   
    public static void main(String[] args) {
        System.out.println(gcd(24, 16));
        System.out.println(gcd(255, 25));
    }
    
    public static int gcd(int m, int n) {
        int gcd = 1;
        int k = 1;
        
        while (k <= m && k <= n) {
            if (m % k == 0 && n % k == 0)
                gcd = k;
            k++;
        }
        
        return gcd;
    }    
}