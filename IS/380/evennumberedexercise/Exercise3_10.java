public class Exercise3_10 {
    public static void main(String[] args) {
        System.out.println("pounds\t\tkilograms\t|\tkilograms\tpounds");
        System.out.println("---------------------------------------------");
        
        int pounds = 1; int kilograms = 20;
        for (int i = 1; i <= 100; pounds += 2, kilograms += 5, i++) {
            System.out.println(pounds + "\t\t" + pounds * 2.2 + "\t|\t" + kilograms + "\t\t" + kilograms / 2.2);
        }
    }
}