<?php

echo fib(13)."<BR>";
echo harm(5)."<BR>";
echo ack(2, 3)."<BR>";

function fib($x){
	if($x == 0){
		return 0;
	}elseif($x == 1){
		return 1;
	}else{
		return(fib($x - 1) + fib($x - 2));
	}
}

function harm($x){
	if($x == 0){
		return 0;
	}else{
		return(harm($x - 1) + (1 / $x));
	}
}

function ack($x, $y){
	if($x == 0){
		return $y + 1;
	}elseif(($x > 0) && ($y == 0)){
		return(ack(($x - 1), 1));
	}else{
		return(ack(($x - 1), ack($x, ($y - 1))));
	}
}

?>