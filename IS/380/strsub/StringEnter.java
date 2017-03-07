// -------------------------
// Developer: Jacob Truman -
// Date: 2/28/06           -
// StringEnter.java        -
// -------------------------

import javax.swing.JOptionPane;

public class StringEnter{
	public static void main(String[] args){

// Prompt user for First String
		String str1Msg = JOptionPane.showInputDialog(null,
							"Enter String",
							"String/SubString Test",
							JOptionPane.QUESTION_MESSAGE);
							
// Prompt user for Second String
		String str2Msg = JOptionPane.showInputDialog(null,
							"Enter Second String",
							"String/SubString Test",
							JOptionPane.QUESTION_MESSAGE);

int i;
String outMsg = "The First String IS NOT a substring of the Second String";
int strDif = str2Msg.length() - str1Msg.length();

if (strDif > 0){
	for (i = 0; i <= strDif; i++){
		if (str2Msg.substring(i, i + str1Msg.length()).equals(str1Msg)){
			outMsg = "The First String IS a substring of the Second String";
		}
	}
}

// Output Message		
	JOptionPane.showMessageDialog(null,
											outMsg,
											"Strings",
											JOptionPane.INFORMATION_MESSAGE);
		System.exit(0);
	}
}