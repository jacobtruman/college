public class Exercise3_8 {
    public static void main(String[] args) {
        System.out.println("pounds\t\tkilograms");
        System.out.println("-------------------------");
        
        int pounds = 1; 
        for (int i = 1; i <= 100; pounds += 2, i++) {
            System.out.println(pounds + "\t\t" + pounds * 2.2);
        }
    }
}
