<?
class Mergesort
{

	function Merge_sort(&$array,$start,$end)
	{
		if($start<$end)
		{ 
        $half=floor(($start+$end)/2);
		$this->Merge_sort($array,$start,$half);
		$this->Merge_sort($array,$half+1,$end);
		$this->Merge($array,$start,$end,$half);
		}	
	}


	function Merge(&$array,$start,$end,$half)
	{

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

	function MS_get($array,$start,$end)
	{
		$temp=array();
		for($a=$start;$a<=$end;$a++)
		{
			$temp[]=$array[$a];
		}	
		$this->Merge_sort($temp,0,count($temp)-1);
		return $temp;
	}
	
}
?>