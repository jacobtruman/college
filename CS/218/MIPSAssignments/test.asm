.data

list:		.word	1112, 1119, 1125, 1129, 1131, 1135, 1139, 1142, 1144, 1149
len:		.word	10

int_lst:	.space	40				# 10 * 4

flt_lst:	.space	320				# 10 * 32

pi:			.float	3.14159

new_ln:	.asciiz	"\n"
blnk:	.asciiz	" "

hdr:	.asciiz "\n Averages of list/pi (int & float) \n"
int_hd:	.asciiz	"\n Int Ave = "
flt_hd:	.asciiz	"\n Float Ave = "

.text

.globl	main
.ent	main
main:

	la	$a0, hdr	# print header
	li	$v0, 4
	syscall

	la	$a0, list
	lw	$a1, len
	la	$a2, int_lst
	la	$a3, flt_lst
	jal	mk_lsts

	lw	$a1, len
	la	$a2, int_lst
	la	$a3, flt_lst
	jal	prnt_list

	li	$v0, 10
	syscall

.end main

.globl	mk_lsts
.ent	mk_lsts
mk_lsts:

sum_lp:
	lw  $t0, ($a0)
	rem $t5, $t0, 10
	add $t6, $t6, $t5
	
	sw  $t5, ($a2)
	
	mtc1     $t0, $f5
	cvt.s.w  $f5, $f5
	l.s      $f1, pi
	div.s    $f5, $f5, $f1
	add.s    $f6, $f6, $f5
	
	s.s  $f5, ($a3)
	
	add  $a0, $a0, 4
	add  $a2, $a2, 4
	add  $a3, $a3, 32
	sub  $a1, $a1, 1
	bnez $a1, sum_lp
	
	li      $t4, 10
	mtc1	$t4, $f4
	cvt.s.w	$f4, $f4
	
	div    $t6, $t6, $t4
	div.s  $f12, $f6, $f4
	
	la	 $a0, int_hd
	li	 $v0, 4
	syscall
	move $a0, $t6
	li   $v0, 1
	syscall

	la   $a0, flt_hd
	li   $v0, 4
	syscall
	li   $v0, 2
	syscall

	jr   $ra

.end  mk_lsts


.globl	prnt_list
.ent	prnt_list
prnt_list:
	lw  $a0, ($a2)
	l.s  $f12, ($a3)

	li   $v0, 1
	syscall
	la   $a0, blnk
	li   $v0, 4
	syscall
	li   $v0, 2
	syscall
	la   $a0, new_ln
	li   $v0, 4
	syscall
	
	add  $a2, $a2, 4
	add  $a3, $a3, 32
	sub  $a1, $a1, 1
	bnez $a1, prnt_list

.end  prnt_list