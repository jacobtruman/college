import javax.swing.*;

public class Exercise5_26 { 
    public static void main(String[] args) {
        char[][] board = new char[3][3];
        displayBoard(board);
        
        while (true) {
            
            // Prompt the first player
            int row = Integer.parseInt(JOptionPane.showInputDialog("Enter a row (0, 1, 2) for X player"));
            int column = Integer.parseInt(JOptionPane.showInputDialog("Enter a column (0, 1, 2) for X player"));
            
            board[row][column] = 'x';
            displayBoard(board);
            if (isWon('x', board)) {
                System.out.println("X player won");
                System.exit(0);
            }
            else if (isDraw(board)) {
                System.out.println("No winner");
                System.exit(0);
            }
            
            // Prompt the second player
            row = Integer.parseInt(JOptionPane.showInputDialog("Enter a row (0, 1, 2) for O player"));
            column = Integer.parseInt(JOptionPane.showInputDialog("Enter a column (0, 1, 2) for O player"));
            board[row][column] = 'O';
            displayBoard(board);
            
            if (isWon('O', board)) {
                System.out.println("O player won");
                System.exit(0);
            }
            else if (isDraw(board)) {
                System.out.println("No winner");
                System.exit(0);
            }
            
        }
    }
    
    static void displayBoard(char[][] board) {
        System.out.println("\n----------");
        
        for (int i = 0; i < 3; i++) {
            System.out.print("| ");
            for (int j = 0; j < 3; j++)
                System.out.print(board[i][j] + " | ");
            System.out.println("\n----------");
        }
    }
    
    public static boolean isWon(char ch, char[][] board) {
        // Check rows
        for (int i = 0; i < 3; i++)
            if (ch == board[i][0] && ch == board[i][1] && ch == board[i][2]) return true;
        
        // Check columns
        for (int j = 0; j < 3; j++)
            if (ch == board[0][j] && ch == board[1][j] && ch == board[2][j]) return true;
        
        // Check majoe diagonal
        if (ch == board[0][0] && ch == board[1][1] && ch == board[2][2]) return true;
        
        // Check sub diagonal
        if (ch == board[0][2] && ch == board[1][1] && ch == board[2][0]) return true;

        return false;
    }
    
    public static boolean isDraw(char[][] board) {
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                if (board[i][j] == '\u0000') return false;
        
        return true;
    }
}
