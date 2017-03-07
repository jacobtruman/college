// -------------------------
// Developer: Jacob Truman -
// Date: 2/21/06           -
// Card.java               -
// -------------------------
public class Card{
	private String[] faces = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace"};
	private String[] suits = {"Spades", "Clubs", "Diamonds", "Hearts"};
	private int face;
	private int suit;

	/**Default constructor setting face to Ace, suit to spades*/
	public Card(){
		this(0, 0);
	}
	
	/**Constructor specifying face and suit*/
	public Card(int face, int suit){
		setFace(face);
		setSuit(suit);
	}
	
	/**Return face*/
	public String getFace(){
		return faces[face];
	}
	
	/**Return face*/
	public String getSuit(){
		return suits[suit];
	}

	/**Set a new face*/
	public void setFace(int face){
		this.face = face;
	}
	
	/**Set a new suit*/
	public void setSuit(int suit){
		this.suit = suit;
	}

	/**Print Card*/
	public void prntCard(){
		System.out.println(getFace() + " " + getSuit());
	}
}