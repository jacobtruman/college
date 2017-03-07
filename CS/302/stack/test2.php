<?php 
$x1 = array(
array('8', '1'),
array('6', '8'),
array('2', '7'),
array('7', '5'),
array('1', '4'),
array('4', '3'),
array('3', '6')
);

/*	
8, 1
7, 5
6, 8
3, 6
2, 7
4, 3
1, 4
*/

for ($i = 1;$i < count($x1); $i++){
		$val[$i-1][3] = ($x1[0][1] - $x1[$i][1]) / ($x1[0][0] - $x1[$i][0]);
}

mergesort(&$val, 0, count($val) - 1);

	function mergesort(&$array, $start, $end){
		if($start<$end){ 
        $half=floor(($start+$end)/2);
		mergesort($array,$start,$half);
		mergesort($array,$half+1,$end);
		Merge($array,$start,$end,$half);
		}
	}


	function Merge(&$array,$start,$end,$half){

    $length=$end-$start+1; 
    $temp=array();


    $k=0;

    for ($i=$start; $i<=$half; $i++)
        $temp[$k++]=$array[$i];
   
    for ($j=$end; $j>=$half+1; $j--)
        $temp[$k++]=$array[$j];

    $i=0; $j=$length-1; $k=$start;

    while ($i<=$j)
        if ($temp[$i]<=$temp[$j])
            $array[$k++]=$temp[$i++];
        else
        	$array[$k++]=$temp[$j--];

	}

	function msget($array,$start,$end){
		$temp=array();
		for($a=$start;$a<=$end;$a++)
		{
			$temp[]=$array[$a];
		}	
		mergesort($temp,0,count($temp)-1);
		return $temp;
	}

echo '<pre>';
print_r ($val);
echo '</pre>';
?> 