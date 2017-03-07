// -------------------------
// Developer: Jacob Truman -
// Date: 1/31/06           -
// Description: Convert    -
//      feet to meters and -
//      meters to feet     -
// -------------------------
public class FeetMeter{
	public static void main(String[] args){
		// print header
		System.out.println("Feet        Meters    |    Meters        Feet");
		double mtr = 0.0;
		double ft = 0.0;
		// for loop for feet to meters and meters to feet table
		for (double i = 1; i <= 10; i++){			
			System.out.print(i+"         "+footToMeter(i)+"  ");
			// calculate meters starting at 20
			mtr = (i + 3) * 5;
			System.out.println("    |    "+mtr+"         "+meterToFoot(mtr)+"  ");
		}
	}
	
	// method to calculate meters based on feet (3 decimal places)
	public static double footToMeter(double foot){
		double num = Math.rint ((foot * 0.305) * 1000) / 1000;
		return num;
	}
	
	// method to calculate feet based on meters (3 decimal places)
	public static double meterToFoot(double meter){
		double num = Math.rint ((meter / 0.305) * 1000) / 1000;
		return num;
	}
}
