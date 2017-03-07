#!/usr/bin/perl -w

#----------------
# Jacob Truman
# Project 6
#
# Tic Tac Toe
# ttt.pl
#----------------

my  @mv = ();
$prompt = "Are you ready to play tic tac toe?\nPlease answer Y or N\n";

# sub routine to print the current game board
sub DisplayBoard(){
	print " ----- ----- ----- \n";
	print "|     |     |     |\n";
	print "|  $mv[1]  |  $mv[2]  |  $mv[3]  |\n";
	print "|    1|    2|    3|\n";
	print " ----- ----- ----- \n";
	print "|     |     |     |\n";
	print "|  $mv[4]  |  $mv[5]  |  $mv[6]  |\n";
	print "|    4|    5|    6|\n";
	print " ----- ----- ----- \n";
	print "|     |     |     |\n";
	print "|  $mv[7]  |  $mv[8]  |  $mv[9]  |\n";
	print "|    7|    8|    9|\n";
	print " ----- ----- ----- \n";
}

# sub routine to print prompt and get user input
sub getInput{
	local($promptString) = @_;
	print $promptString;
	$_ = <STDIN>;
	return $_;
}

# generate computer move
sub GetComputerMove(){
	for($j = 1; $j <= 9; $j++){
		if($mv[$j] eq ' '){
			$mv[$j] = 'O';
			$retVal = 1;
			$winner = CheckForWinner();
			last;
		}
	}
	return $retVal;
}

# get human move
sub GetHumanMove(){
	$ans = &getInput("What is your next move? Please enter 1-9\n");
	if(($ans >= 1) && ($ans <= 9) && ($mv[$ans] eq ' ')){
		$mv[$ans] = 'X';
		$retVal = 0;
		$winner = CheckForWinner();
	}else{
		print "Invalid Move, please try again\n";
		$retVal = 1;
	}
	return $retVal;
}

# check to see if there is a winner and who it is
sub CheckForWinner(){
	if(($mv[1] ne ' ') && ($mv[1] eq $mv[5]) && ($mv[1] eq $mv[9])){
		$isDone = 1;
		return $mv[1];
	}elsif(($mv[7] ne ' ') && ($mv[7] eq $mv[5]) && ($mv[7] eq $mv[3])){
		$isDone = 1;
		return $mv[7];
	}elsif(($mv[1] ne ' ') && ($mv[1] eq $mv[2]) && ($mv[1] eq $mv[3])){
		$isDone = 1;
		return $mv[1];
	}elsif(($mv[4] ne ' ') && ($mv[4] eq $mv[5]) && ($mv[4] eq $mv[6])){
		$isDone = 1;
		return $mv[4];
	}elsif(($mv[7] ne ' ') && ($mv[7] eq $mv[8]) && ($mv[7] eq $mv[9])){
		$isDone = 1;
		return $mv[7];
	}elsif(($mv[1] ne ' ') && ($mv[1] eq $mv[4]) && ($mv[1] eq $mv[7])){
		$isDone = 1;
		return $mv[1];
	}elsif(($mv[2] ne ' ') && ($mv[2] eq $mv[5]) && ($mv[2] eq $mv[8])){
		$isDone = 1;
		return $mv[2];
	}elsif(($mv[3] ne ' ') && ($mv[3] eq $mv[8]) && ($mv[3] eq $mv[9])){
		$isDone = 1;
		return $mv[3];
	}else{
		$isDone = 0;
	}
}

# prompt user
while(1){
	$ans = &getInput($prompt);
	# moves array inititialization
	for($i = 1; $i <= 9; $i++){
		# set each one to a space
		$mv[$i] = " ";
	}

	if(($ans eq "y\n") || ($ans eq "Y\n")){
		print "\nYou will be X.\nYou go first!\n\n";
		$isDone = 0;
		$isXTurn = 1;
		while(!$isDone){
			if($isXTurn){
				DisplayBoard();
				$isXTurn = GetHumanMove();
			}else{
				$isXTurn = GetComputerMove();
			}
		}
		DisplayBoard();
		print "\n$winner is the Winner!!!\n\n";
		$prompt = "Would you like to play again?\nPlease answer Y or N\n"; 
	}elsif(($ans eq "n\n") || ($ans eq "N\n") || ($ans eq "q\n") || ($ans eq "Q\n")){
		print "Ok, goodbye!";
		last;
	}else{
		print "Improper input";
		next;
	}
}