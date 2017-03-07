public class Exercise7_10 {
    public static void main(String[] args) {
        System.out.println(convertDecimalToBinary(8));
        System.out.println(convertDecimalToBinary(298));
        System.out.println(convertDecimalToBinary(9123));
    }
    
    public static String convertDecimalToBinary(int value) {
        StringBuffer buffer = new StringBuffer();
        
        while (value != 0) {
            int bit = value % 2;
            buffer.insert(0, bit);
            value = value / 2;
        }
        
        return buffer.toString();
    }
}
