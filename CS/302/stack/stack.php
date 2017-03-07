<TITLE>
	Stack
</TITLE>
<?php
require_once 'Stack.class.php';

$m = 7;
/*
$points = array(
array('8', '1'),
array('6', '8'),
array('3', '6'),
array('2', '7'),
array('4', '3'),
array('7', '5'),
array('1', '4')
);
*/

$points = array(
array('8', '1'),
array('7', '5'),
array('6', '8'),
array('3', '6'),
array('2', '7'),
array('4', '3'),
array('1', '4')
);


function extreme(&$x, $m, &$ex){
$temp[0] = $ex;
	for ($i = 1; $i < $m; $i++){
		if ($x[$i][0] > $ex[0]){
			$ex = $x[$i];
			$temp[$i] = $temp[0];
			$temp[0] = $ex;
		}else if($x[$i][0] == $ex[0]){
			if ($x[$i][1] < $ex[1]){
				$ex = $x[$i];
				$temp[$i] = $temp[0];
				$temp[0] = $ex;
			}
		}else{
			$temp[$i] = $x[$i];
		}
		//echo $ex[0]." ".$ex[1]."<BR>";
	}
	$x = $temp;
}

$lo = 1;
$hi = $m - 1;

/*
8, 1
7, 5
6, 8
3, 6
2, 7
1, 4
*/

echoarray($points);

function swap(&$v, $i, $j) { 
	$temp = $v[$i]; 
	$v[$i] = $v[$j]; 
	$v[$j] = $temp; 
}

$theStack = new Stack();

for ($i = 0; $i < $m+1; $i++){
	cvhull($i, $points, $theStack);
}

function cvhull($i, $points, $theStack){
	if ($theStack->get_length() <= 1){
	}else{
		$ax = $theStack->utop(0);
		$ay = $theStack->utop(1);
		$bx = $theStack->top(0);
		$by = $theStack->top(1);
		$cx = $points[$i][0];
		$cy = $points[$i][1];
		//$d = ((($theStack->utop(0)-$theStack->top(0))*($theStack->top(1)-$points[$i][1])) - (($theStack->utop(1)-$theStack->top(1))*($theStack->top(0)-$points[$i][0])));
		$d = $ax * ($by - $cy) + $bx * ($cy - $ay) + $cx * ($ay - $by);
		 if ($d > 0){
		 	//echo $d." is greater<BR>";
		 }else{
		 	//echo $d." is less<BR>";
			$theStack->pop();
			cvhull($i, $points, $theStack);
		 }
	}
	if (isset($points[$i][0])){
		$theStack->push($points[$i][0], $points[$i][1]);
	}else{
		return 0;
	}
}
$theStack->push($points[0][0], $points[0][1]);

//echoarray($theStack);

function echoarray($x){
	echo '<pre>';
	print_r($x);
	echo '</pre>';
}
?>
