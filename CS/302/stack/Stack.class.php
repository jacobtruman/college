<?php
class Stack {

    var $_stack = array();
    
    function push($element1, $element2) {
		$temp = array($element1, $element2);
        array_push($this->_stack, &$temp);
    }
    
    function &pop() {
        $element = &$this->top();
        array_pop($this->_stack);
        return $element;
    }
    
    function &top($point) {
        $count = count($this->_stack);
        if ($count == 0) {
            return null;
        }
        return $this->_stack[count($this->_stack)-1][$point];
    }
	
    function &utop($point) {
        $count = count($this->_stack);
        if ($count == 0) {
            return null;
        }
        return $this->_stack[count($this->_stack)-2][$point];
    }
	
	function &bottom($point) {
        $count = count($this->_stack);
        if ($count == 0) {
            return null;
        }
        return $this->_stack[0][$point];
    }
    
    function get_length() {
        return count($this->_stack);
    }
	
	function &slope($point){

	$key = $this->_stack[0];

		if ($point == 'all'){
			for($i = 1;$i < count($this->_stack); $i++){
				$temp = $this->_stack[$i];
				$slope = ($key[1] - $temp[1])/($key[0] - $temp[0]);
				echo $i.". ".$key[1]." - ".$temp[1]." / ".$key[0]." - ".$temp[0]." = ";
				echo $slope."<BR>";
			}
		}else{
			$temp = $this->_stack[$point];
			$slope = ($key[1] - $temp[1])/($key[0] - $temp[0]);
			return $slope;
		}
	}
}
?>