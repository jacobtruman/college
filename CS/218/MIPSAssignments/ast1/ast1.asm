#   Jacob Truman Section 02
#   MIPS Assignment 1

#	Example program to display mimimum, maximum,
#	average, even mimimum, even maximum & even
#	average.


###########################################################
#  data segment

.data

array:	.word	220, 113, 182, 339,  64, 231, 421, 348, 136, 157
	.word	117, 171,  97, 161, 147, 537,  27, 151, 347, 154
	.word	 32, 351, 176, 287, 910,  10, 111, 523, 232, 445
	.word	163, 245,  71, 129, 218, 219, 122, 134,  70, 121
	.word	315, 145, 313, 274, 118,   9,  72,  26, 230, 135
	.word	 99, 204, 106, 107, 124, 125, 126, 229,  48, 392
	.word	132, 133,  36, 136,  38, 441, 243,  45, 247, 249
	.word	371, 271, 177, 228, 178, 184, 386, 186, 288, 188
	.word	 50, 152, 354, 256,  58, 160, 161,  62,  63,  64
	.word	199, 213, 124, 136, 140, 256, 375,  87, 115,  26
len:	.word	100

hdr:	.asciiz	"\nProgram to find:\n   * min, max, and average of a list of numbers.\n   * min, max, and average of the even values in\n     the list.\n\n"
new_ln:	.asciiz	"\n"

a1_msg:	.asciiz	"    List min = "
a2_msg:	.asciiz	"    List max = "
a3_msg:	.asciiz	"    List ave = "

a4_msg:	.asciiz	"    Even min = "
a5_msg:	.asciiz	"    Even max = "
a6_msg:	.asciiz	"    Even ave = "


###########################################################
#  text/code segment

#  This program will use pointers.
#	t0 - array address
#	t1 - count of elements
#	t2 - List min
#	t3 - List max
#	t4 - each word from array
#	t5 - List ave
#	t6 - Temp location for len
#	t7 - Rem to find even number
#	t8 - Even count
#	t9 - Even sum/ave
#	s0 - Even min
#	s1 - Even max

.text
.globl main

main:

# -----
#  Display header.

	la	$a0, hdr
	li	$v0, 4
	syscall				# print header

# -----
#  Find max and min of the array.

	la	$t0, array		# set $t0 addr of array
	lw	$t1, len		# set $t1 to length

	lw	$t2, ($t0)		# set min, $t2 to array[0]
	lw	$t3, ($t0)		# set max, $t3 to array[0]
	lw	$t5, ($t0)		# set ave, $t5 to array[0]
	li	$t8, 0			# set Even Count, $t8 to 0
	li	$t9, 0			# set Even Sum/Ave, $t9 to 0

	add	$t0, $t0, 4		# skip array[0]
	add	$t1, $t1, -1	# length=length-1

loop:
	lw	$t4, ($t0)		# get array[n]

	add $t5, $t5, $t4
	rem $t7, $t4, 2
	bge	$t7, 1, noEMax
	add $t8, $t8, 1			# add one to the even length
	add $t9, $t9, $t4		# add to the even sum
	bge	$t8, 2, chkEMin
	move	$s0, $t4		# set init min
	move	$s1, $t4		# set init max

chkEMin:

	bge	$t4, $s0, noEMin	# is new min?
	move	$s0, $t4		# set new min

noEMin:
	ble	$t4, $s1, noEMax	# is new max?
	move	$s1, $t4		# set new max

noEMax:

	bge	$t4, $t2, noMin		# is new min?
	move	$t2, $t4		# set new min

noMin:
	ble	$t4, $t3, noMax		# is new max?
	move	$t3, $t4		# set new max

noMax:
	add	$t1, $t1, -1		# decrement counter
	add	$t0, $t0, 4			# increment addr by word
	bnez	$t1, loop

# -----
#  Get the Averages
lw $t6, len
div $t5, $t5, $t6
div $t9, $t9, $t8

# -----
#  Display results.

#-------- Whole list

	la	$a0, a1_msg
	li	$v0, 4
	syscall				# print "List min = "

	move	$a0, $t2
	li	$v0, 1
	syscall				# print min

	la	$a0, new_ln		# print a newline
	li	$v0, 4
	syscall

	la	$a0, a2_msg
	li	$v0, 4
	syscall				# print "List max = "

	move	$a0, $t3
	li	$v0, 1
	syscall				# print max

	la	$a0, new_ln		# print a newline
	li	$v0, 4
	syscall
	
	la	$a0, a3_msg
	li	$v0, 4
	syscall				# print "List ave = "

	move	$a0, $t5
	li	$v0, 1
	syscall				# print ave

	la	$a0, new_ln		# print a newline
	li	$v0, 4
	syscall
	
	la	$a0, new_ln		# print another newline
	li	$v0, 4
	syscall

#-------- Evens

	la	$a0, a4_msg
	li	$v0, 4
	syscall				# print "Even min = "

	move	$a0, $s0
	li	$v0, 1
	syscall				# print min

	la	$a0, new_ln		# print a newline
	li	$v0, 4
	syscall

	la	$a0, a5_msg
	li	$v0, 4
	syscall				# print "Even max = "

	move	$a0, $s1
	li	$v0, 1
	syscall				# print max

	la	$a0, new_ln		# print a newline
	li	$v0, 4
	syscall
	
	la	$a0, a6_msg
	li	$v0, 4
	syscall				# print "Even ave = "

	move	$a0, $t9
	li	$v0, 1
	syscall				# print ave

	la	$a0, new_ln		# print a newline
	li	$v0, 4
	syscall

# -----
#  Done, terminate program.

	li	$v0, 10
	syscall				# all done!