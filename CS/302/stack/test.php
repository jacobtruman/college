<?php

$points = array(
array('8', '1'),
array('3', '6'),
array('7', '5'),
array('2', '7'),
array('4', '3'),
array('6', '8'),
array('1', '4')
);

for ($i = 1;$i < count($points); $i++){
		$val[$i-1] = ($points[0][1] - $points[$i][1]) / ($points[0][0] - $points[$i][0]);
}

/*
8, 1
7, 5
6, 8
3, 6
2, 7
4, 3
1, 4
*/

//($x1[0][1] - $x1[$i][1]) / ($x1[0][0] - $x1[$i][0])
echoarray($points);
echo "<BR>";
echoslope ($val);
echo "<BR>";
mergesort(&$val, 1, count($points) - 1, &$points);
echoarray($points);
echo "<BR>";
echoslope ($val);

	function mergesort(&$array, $start, $end, &$x){
		if($start<$end){
        $half=floor(($start+$end)/2);
		mergesort($array,$start,$half, $x);
		mergesort($array,$half+1,$end, $x);
		merge($array,$start,$end,$half, $x);
		}
	}


	function merge(&$array,$start,$end,$half){

    $length=$end-$start+1; 
    $temp=array();

    $k=0;

    for ($i=$start; $i<=$half; $i++)
        $temp[$k++]=$array[$i];
   
    for ($j=$end; $j>=$half+1; $j--)
        $temp[$k++]=$array[$j];

    $i=0; 
	$j=$length-1; 
	$k=$start;

    while ($i<=$j){
        if ($temp[$i]<=$temp[$j]){
            $array[$k++]=$temp[$i++];
		}else{
        	$array[$k++]=$temp[$j--];
		}
	}
}

echo '<pre>';
//print_r ($points);
echo '</pre>';


function echoarray($x){
	for ($i = 0; $i < count($x); $i++){
		echo $x[$i][0]." ".$x[$i][1]."<BR>";
	}
}

function echoslope($x){
	for ($i = 0; $i < count($x); $i++){
		echo $i.". ".$x[$i]."<BR>";
	}
}
?> 