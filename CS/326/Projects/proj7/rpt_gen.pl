#!/usr/bin/perl -w

####################
# Jacob Truman
# CS326
# Project 7
#
# Grade Report Gen
# rpt_gen.pl
####################

# GET DATE
use POSIX;
$today = strftime( "%A, %B %d, %Y", localtime() );
##########

@recs = ();

sub printRec(){
	for($i = 0; $i < 12; $i++){
		print "$recs[$i], ";
	}
	print "\n";
}

$repType = $ARGV[0];
$MYFILE = $ARGV[1];

if(!-e($MYFILE)){
	die "Error: $MYFILE does not exist.\n";
}else{
	open(MYFILE) or die("Error: Could not open $MYFILE.\n");
}

##################
#   IDS REPORT   #
##################

sub idsRep(){
	<MYFILE>;
	$tmp = <MYFILE>;

	$~ = IDSTOP;
	($id, $ln, @possible) = split(/,/, $tmp);
	write();

	$paTotal = 0;
	$ptTotal = 0;
	for($i = 0; $i < 8; $i++){
		if ($possible[$i] =~ /^-?\d/){
			$paTotal += $possible[$i];
		}
	}
	for($i = 8; $i < 10; $i++){
		if ($possible[$i] =~ /^-?\d/){
			$ptTotal += $possible[$i];
		}
	}

	$~ = IDS;
	$j = 0;
	while($tmp = <MYFILE>){
		$hTotal = 0;
		$aTotal = 0;
		$tTotal = 0;
		$atTotal = 0;
		($id, $ln, $fn, @scrs) = split(/,/, $tmp);
		for($i = 0; $i < 8; $i++){
			if ($scrs[$i] =~ /^-?\d/){
				$hTotal += $scrs[$i];
				$aTotal[$i] += $scrs[$i];
			}
		}
		$score = (($hTotal / $paTotal) / 2) * 100;
		for($i = 8; $i < 10; $i++){
			if ($scrs[$i] =~ /^-?\d/){
				$tTotal += $scrs[$i];
				$atTotal[$i] += $scrs[$i];
			}
		}
		$score += (($tTotal / $ptTotal) / 2) * 100;
		$scores[$j] = $score;
		$j++;
		write();
	}
	for($i = 0; $i < 8; $i++){
		$avgs[$i] = $aTotal[$i] / $j;
	}
	for($i = 8; $i < 10; $i++){
		$avgs[$i] = $atTotal[$i] / $j;
	}
	for($i = 0; $i < $j; $i++){
		$tavg += $scores[$i];
	}
	$tavg /= $j;
	$~ = IDSBOTTOM;
	write();
}

####################
#   NAMES REPORT   #
####################

sub namesRep(){
	<MYFILE>;
	$tmp = <MYFILE>;

	($id, $ln, @possible) = split(/,/, $tmp);
	$~ = NAMESTOP;
	write();

	$paTotal = 0;
	$ptTotal = 0;
	for($i = 0; $i < 8; $i++){
		if ($possible[$i] =~ /^-?\d/){
			$paTotal += $possible[$i];
		}
	}
	for($i = 8; $i < 10; $i++){
		if ($possible[$i] =~ /^-?\d/){
			$ptTotal += $possible[$i];
		}
	}

	$~ = NAMES;
	$j = 0;
	while($tmp = <MYFILE>){
		$hTotal = 0;
		$aTotal = 0;
		$tTotal = 0;
		$atTotal = 0;
		$ascore = 0;
		$tscore = 0;
		($id, $ln, $fn, @scrs) = split(/,/, $tmp);
		for($i = 0; $i < 8; $i++){
			if ($scrs[$i] =~ /^-?\d/){
				$hTotal += $scrs[$i];
				$aTotal[$i] += $scrs[$i];
			}
		}
		$ascore = ($hTotal / $paTotal) * 100;
		for($i = 8; $i < 10; $i++){
			if ($scrs[$i] =~ /^-?\d/){
				$tTotal += $scrs[$i];
				$atTotal[$i] += $scrs[$i];
			}
		}
		$name = $fn." ".$ln;
		$name =~ s/ //;
		$name =~ s/" "/ /;
		$tscore += ($tTotal / $ptTotal) * 100;
		$score = ($ascore + $tscore) / 2;
		$j++;
		write();
	}
	$~ = NAMESBOTTOM;
	write();
}

######################
#   FORMAT SECTION   #
######################
# < left justified
# > right justified
# | center
######################

# IDS FORMAT #
##############

if($repType eq "-ids"){
	idsRep();
}elsif($repType eq "-names"){
	namesRep();
}


format IDSTOP =
CS13 Score Summary - IDs
@<<<<<<<<<<<<<<<<<<<<<<<<<<<<
$today


    ID    Ast1 Ast2 Ast3 Ast4 Ast5 Ast6 Ast7 Ast8   Tst1 Tst2   Score
    ----  ---- ---- ---- ---- ---- ---- ---- ----   ---- ----   -----
.
format IDS = 
    @>>>  @>>> @>>> @>>> @>>> @>>> @>>> @>>> @>>>   @>>> @>>>    @>>>
$id, @scrs, $score
.
format IDSBOTTOM = 
          ---- ---- ---- ---- ---- ---- ---- ----   ---- ----   -----
Possible  @>>> @>>> @>>> @>>> @>>> @>>> @>>> @>>>   @>>> @>>>
@possible
Average   @>>> @>>> @>>> @>>> @>>> @>>> @>>> @>>>   @>>> @>>>    @>>>
@avgs, $tavg
.

# NAMES FORMAT #
################

format NAMESTOP =
CS13 Score Summary - Names
@<<<<<<<<<<<<<<<<<<<<<<<<<<<<
$today


.
format NAMES = 
***********************************************************************
ID:   @<<<<
$id;
Name: @<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
$name

Scores:     Ast1 Ast2 Ast3 Ast4 Ast5 Ast6 Ast7 Ast8  Test1 Test2
            ---- ---- ---- ---- ---- ---- ---- ----  ----- -----
            @>>> @>>> @>>> @>>> @>>> @>>> @>>> @>>>   @>>>  @>>>
@scrs

Averages:   Asst Test  Total
            ---- ----  -----
            @>>> @>>>   @>>>
$ascore, $tscore, $score

.
format NAMESBOTTOM = 
***********************************************************************
.

close(MYFILE);