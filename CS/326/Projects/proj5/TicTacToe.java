// * TicTacToe.java
// * Project #5
// *
// * Jacob Truman
// * CS326 Section 1
// * Simple TicTacToe
// -------------------

//  Note, in order to address some incompatibility issues, use the Java AWT stuff
//	(Applet, Label, Button, Panel, etc.) instead of the later Swing stuff
//	(JApplet, JLabel, JButton, JPanel, etc.).


import java.awt.*;
import java.applet.*;
import java.awt.event.*;
import javax.swing.*;
import java.text.*;

public class TicTacToe extends Applet implements ActionListener, MouseListener{

	String startMsg = new String("Welcome to TicTacToe. X's Turn.");
	// ------------------------------------------------------------
	// 1. Create your fields
	// ------------------------------------------------------------
	//  a. Arrays
	//  -- A 3 x 3 array of Label objects. Call it grid
	//  -- A 3 x 3 array of chars. Call it game
	
	Label[][] grid = new Label[3][3];
	char[][] game = new char[3][3];
	
	//  b. Other graphical fields
	//  -- A Button named restart
	//  -- A Panel named p
	//  -- A Label named status
	
	Button restart = new Button("Restart Game");
	Panel p = new Panel();
	Label status = new Label(startMsg);

	//  c. Primitive variables
	//  -- an int named numClicks  (number of clicks in game)
	//  -- a boolean named isDone  (set to false)
	//  -- a boolean named isXTurn (set to true)

	public int numClicks = 0;
	public boolean isDone = false;
	public boolean isXTurn = true;

	// ------------------------------------------------------------
	// 2. The init() method
	// ------------------------------------------------------------
	public void init(){
	// a. Set the layout for the applet (BorderLayout()) 
	// b. Add restart label to bottom of the applet.
	//    -- Hook up the restart button
	// c. Add your status label to the top of the applet
	//    -- Set background to yellow, foreground to blue
	//    -- Set font to 12 point bold Helvetica

		setLayout(new BorderLayout());
		add(restart, BorderLayout.SOUTH);
		restart.addActionListener(this);

		status.setFont(new Font("Helvetica", Font.BOLD, 12));
		status.setBackground(Color.yellow);
		status.setForeground(Color.blue);
		add(status, BorderLayout.NORTH);

	// d. Initialize your main Panel
	//    -- set the layout (GridLayout(3, 3, 3, 3));
	//    -- set a nice font
	//    -- initialize the background to black
	//    -- add the Panel to the center of your applet
	
		p.setLayout(new GridLayout(3, 3, 3, 3));
		p.setFont(new Font("Verdana", Font.BOLD, 20));
		p.setBackground(Color.black);
		add(p, BorderLayout.CENTER);

	// e. Create and initialize your Label objects
	//    -- Start with a nested loop (row, col)
	//    -- Inside the inner loop
	//       > Create a new Label object (blank), place in array
	//         grid[row][col] = new Label(" ", Label.CENTER);
	//       > Attach a MouseListener to it
	//       > Set the background color (white)
	//       > Add it to your panel
	//       > Put a blank in each element of your game array

		for(int row = 0; row < 3; row++){
			for(int col = 0; col < 3; col++){
				grid[row][col] = new Label(" ", Label.CENTER);
				game[row][col] = ' ';
				grid[row][col].addMouseListener(this);
				grid[row][col].setBackground(Color.white);
				p.add(grid[row][col]);
			}
		}
	}

  // ------------------------------------------------------------
  // 3. Handle the Mouse Clicked Event
  // ------------------------------------------------------------
	public void mouseClicked(MouseEvent evt){

		// if (isDone), don't do anything.
		if(!isDone){
			// Get event.
			Label clicked = (Label) evt.getSource();

			next:
			for (int row = 0; row < 3; row++){
				for (int col = 0; col < 3; col++){
					if (clicked == grid[row][col]){
						// a. if text in clicked is not " "
						//    then print "Invalid Move" using status()
						//    and break next; [a labeled break]
						if(clicked.getText() != " "){
							status.setText("Invalid Move");
						}else
	
						// b. if text in clicked is " " and isXTurn is true
						//  -- set the text in clicked to "X"
						//  -- set the foreground in clicked to red
						//  -- set the game[row][col] to 'X'

						if((clicked.getText() == " ") && (isXTurn)){
							clicked.setText("X");
							clicked.setForeground(Color.red);
							game[row][col] = 'X';
							play(getDocumentBase(), "soundXboing.au");
							isXTurn = false;
							numClicks++;
						}else{

						// c. Otherwise (previous two false)
						//  -- set the text in clicked to "O"
						//  -- set the foreground to blue
						//  -- set the game[row][col] to 'O'
							clicked.setText("O");
							clicked.setForeground(Color.blue);
							game[row][col] = 'O';
							play(getDocumentBase(), "soundOboing.au");
							isXTurn = true;
							numClicks++;
						}

						// d. Toggle isXTurn, incrment numClicks

						// Check to see if game is over after each click
						gameOver();
					}
				}
			}
		}
	}


	// ------------------------------------------------------------
	// 4. The resetGame() method
	// ------------------------------------------------------------
	void resetGame(){
		// a. Write a nested for loop (row, col)
		// b. For each element in grid, set text to " "
		// c. For each element in game, set value to ' '
		for(int row = 0; row < 3; row++){
			for(int col = 0; col < 3; col++){
				grid[row][col].setText(" ");
				game[row][col] = ' ';
			}
		}
		// d. Set numClicks to zero
		// e. Set isXTurn to true
		numClicks = 0;
		isXTurn = true;
		isDone = false;
		status.setText(startMsg);

	}

	// ------------------------------------------------------------
	// The actionPerformed() method (resets the game)
	// ------------------------------------------------------------
	public void actionPerformed(ActionEvent ae){
		resetGame();
	}

	// ------------------------------------------------------------
	// The gameOver() method [see if there is a winner]
	// ------------------------------------------------------------
	void gameOver(){
		char winner = ' ';

		//  Check values in array named game
		// a. Check the first diagonal (upper-left to lower right)
		//    Set winner to upper-left if all are equal.

		if((game[0][0] != ' ') && (game[1][1] != ' ') && (game[2][2] != ' ')){
			if((game[0][0] == game[1][1]) && (game[1][1] == game[2][2])){
				winner = game[0][0];
			}
		}

		// b. if no winner, then check second diagonal
		//    (lower-left to upper-right). If all three are the
		//    same then winner is lower-right corner

		if((game[2][0] != ' ') && (game[1][1] != ' ') && (game[0][2] != ' ')){
			if((game[2][0] == game[1][1]) && (game[1][1] == game[0][2])){
				winner = game[2][0];
			}
		}

		// c. if no winner on diagonals, then check rows
		//    -- start by creating a loop for rows
		//    -- on each row check if all three columns are same
		//    -- if they are, then winner is game[i][0]
		//    -- if not, use rows to represent the columns
		//       and check if each row is the same

		for(int i = 0; i < 3; i++){
			if((game[i][0] != ' ') && (game[i][1] != ' ') && (game[i][2] != ' ')){
				if((game[i][0] == game[i][1]) && (game[i][1] == game[i][2])){
					winner = game[i][0];
				}
			}else if((game[0][i] != ' ') && (game[1][i] != ' ') && (game[2][i] != ' ')){
				if((game[0][i] == game[1][i]) && (game[1][i] == game[2][i])){
					winner = game[0][i];
				}
			}
		}

		// Assume game is finished (then check)...


		// Check for tie (winner blank and numClick=9)
		if (winner == ' ' && numClicks == 9){
			status.setText("Tie Game");
			play( getDocumentBase(), "soundDoh.wav");
			isDone = true;
		}else if (winner != ' '){// Check for game done
			status.setText("Game Over: " + winner + " Won!!!");
			play( getDocumentBase(), "soundWoohoo.wav");
			isDone = true;
		}else{// Otherwise a continuing game
			status.setText((isXTurn ? "X's Turn" : "O's Turn"));
			isDone = false;
		}

	}

	// -------------------------------------------------------
	//  Dummy methods for MouseListener interface
	// -------------------------------------------------------
	public void mouseEntered(MouseEvent e)  { }
	public void mouseExited(MouseEvent e)   { }
	public void mousePressed(MouseEvent e)  { }
	public void mouseReleased(MouseEvent e) { }
}
