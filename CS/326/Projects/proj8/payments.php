<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<!------------------------
Jacob Truman
Project 8

Simple Payment Calculator
payments.html
------------------------->
<html>
<head>
	<title>Simple Payment Calculator</title>
<link rel='stylesheet' type='text/css' href='style.css'>
</head>
<h1>
	CS 326
</h1>
Simple Payment Calculator
<hr>
<body>
<script language='javascript' type='text/javascript'>
	pattern = /^[0-9]*$/;
	var monVal = 0, totVal = 0;
	
	function procForm(formname){
		with (formname){
			if(checkNum(bAmt.value, bAmt.alt) == false){
				bAmt.focus();
				return false;
			}
			if (checkNum(iRate.value, iRate.alt) == false){
				iRate.focus();
				return false;
			}
			if (checkNum(yPay.value, yPay.alt) == false){
				yPay.focus();
				return false;
			}
		}
//		calcCost(formname);
		return true;
	}
	
	function checkNum(val, msg){
		if(!pattern.test(val) || (val == '') || (val == null)){
			alert("Error: \"" + msg + "\" must contain a number");
			return false;
		}else{
			return true;
		}
	}

</script>

<?php
	if(!empty($_POST['bAmt'])){
		$monVal = ($_POST['bAmt'] * (($_POST['iRate'] / 100) / 12)) / (1 - pow((1 / (1 + (($_POST['iRate'] / 100) / 12))), $_POST['yPay'] * 12));
		$totalVal = $monVal * ($_POST['yPay'] * 12);
	}
?>
<form name='myForm' method='POST' action='payments.php' onsubmit='return procForm(this)'>
	<table class='myTable'>
		<tr>
			<td colspan='3' height='50'>
				<font size='3'>
					<b>
						Payment Calculator
					</b>
				</font>
			</td>
		</tr>
		<tr>
			<td colspan='3'>
				<hr color='#000000'>
			</td>
		</tr>
		<tr>
			<td colspan='3' height='30'>
				<b>
					Monthly Payment Calculator
				</b>
			</td>
		</tr>
		<tr>
			<td>
				Amount Borrowed
			</td>
			<td>
				$
			</td>
			<td>
				<input type='text' name='bAmt' value='<?php echo $_POST['bAmt'];?>' alt='Amount Borrowed' class='formfield'>
			</td>
		</tr>
		<tr>
			<td>
				Interest Rate
			</td>
			<td>
				%
			</td>
			<td>
				<input type='text' name='iRate' value='<?php echo $_POST['iRate'];?>' alt='Interest Rate' class='formfield'>
			</td>
		</tr>
		<tr>
			<td>
				Years to Pay
			</td>
			<td>
				&nbsp;
			</td>
			<td>
				<input type='text' name='yPay' value='<?php echo $_POST['yPay'];?>' alt='Years to Pay' class='formfield'>
			</td>
		</tr>
		<tr>
			<td>
				Monthly
			</td>
			<td>
				$
			</td>
			<td>
				<input type='text' name='mon' value='<?php echo $monVal;?>' alt='Monthly' class='disformfield' disabled>
			</td>
		</tr>
		<tr>
			<td>
				Total Cost
			</td>
			<td>
				$
			</td>
			<td>
				<input type='text' name='total' value='<?php echo $totalVal;?>' alt='Total Cost' class='disformfield' disabled>
			</td>
		</tr>
		<tr>
			<td colspan='3'>
				<hr color='#000000'>
			</td>
		</tr>
		<tr>
			<td align='right'>
				<input type='submit' value='Calculate' class='formbutton'>
			</td>
			<td>
				&nbsp;
			</td>
			<td>
				<input type='reset' value='Reset' class='formbutton'>
			</td>
		</tr>
	</table>
</form>
</body>
</html>
