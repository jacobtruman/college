// -------------------------
// Developer: Jacob Truman -
// Date: 2/21/06           -
// Card_Client.java        -
// -------------------------
import java.util.Random;
public class Card_Client{
	public static void main(String ars[]){

	int rfNum, rsNum, i, j;
	Random generator = new Random();
	Card[] hand = new Card[20];

		for (i = 0; i < 20; i++){
			rfNum = generator.nextInt(12) + 0;
			rsNum = generator.nextInt(3) + 0;
			hand[i] = new Card(rfNum, rsNum);
			for (j = 0; j < i; j++){
				if ((hand[i].getFace() == hand[j].getFace()) && (hand[i].getSuit() == hand[j].getSuit())){
					rfNum = generator.nextInt(12) + 0;
					rsNum = generator.nextInt(3) + 0;
					hand[i].setFace(rfNum);
					hand[i].setSuit(rsNum);
					j = 0;
				}
			}
			hand[i].prntCard();
		}
	}
}