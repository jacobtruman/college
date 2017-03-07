public class Exercise7_8 {
    public static void main(String[] args) {
        System.out.println(parseBinary("11111111"));
    }
    
    public static int parseBinary(String binaryString) {
        int value = binaryString.charAt(0) - '0';
        for (int i = 1; i < binaryString.length(); i++) {
            value = value * 2 + binaryString.charAt(i) - '0';
        }
        
        return value;
    }
}
