#   Jacob Truman Section 02
#   MIPS Assignment 2

#	Example program to display mimimum, maximum,
#	average, even mimimum, even maximum & even
#	average.


###########################################################
#  data segment

.data

a_sides:	.word  1112, 1119, 1125, 1129, 1131, 1135, 1139, 1142, 1144, 1149
			.word  2241, 2243, 2246, 2249, 2251, 2252, 2254, 2258, 2261, 2265
			.word  3457, 3487, 3499, 3501, 3523, 3524, 3525, 3526, 3575, 3594
			.word  4634, 4652, 4674, 4686, 4697, 4704, 4716, 4720, 4736, 4753
			.word  5501, 5513, 5524, 5536, 5540, 5556, 5575, 5587, 5590, 5596
b_sides:	.word  1206, 1212, 1222, 1231, 1246, 1250, 1254, 1278, 1288, 1292
			.word  2332, 2351, 2376, 2387, 2390, 2400, 2411, 2423, 2432, 2445
			.word  3369, 3374, 3377, 3379, 3382, 3384, 3386, 3388, 3392, 3393
			.word  4400, 4404, 4406, 4407, 4424, 4425, 4426, 4429, 4448, 4492
			.word  5782, 5795, 5807, 5812, 5827, 5847, 5867, 5879, 5888, 5894

areas:		.space	200
len:		.word	50
min:		.word	0
med:		.word	0
max:		.word	0
sum:		.word	0
ave:		.word	0

#-----------
#- Strings -
#-----------

hdr:		.asciiz	"\nProgram to calculate right triangle areas:\n   Areas(n) = ( a_sides(n) * b_sides(n) ) / 2\n Then find the min, med, max, sum, and average for areas.\n\n"
new_ln:		.asciiz	"\n"
spcs:		.asciiz	"  "

ars_msg:	.asciiz	"Right Triangle Areas:"

min_msg:	.asciiz	"    Areas min = "
med_msg:	.asciiz	"    Areas med = "
max_msg:	.asciiz	"    Areas max = "
sum_msg:	.asciiz	"    Areas sum = "
ave_msg:	.asciiz	"    Areas ave = "


###########################################################
#  text/code segment

#  This program will use pointers.
#	t0 - a_sides address
#	s0 - b_sides address
#	s1 - len
#	t9 - areas address
#
#	t1 - Areas min
#	t2 - Areas med
#	t3 - Areas max
#	t4 - Areas sum
#	t5 - Areas ave

.text
.globl main

main:

# -----
#  Display header.

	la	$a0, hdr
	li	$v0, 4
	syscall				# print header

#------------------
#- Find the areas -
#------------------

	la	$a0, ars_msg
	li	$v0, 4
	syscall				# print "ars_msg"
	
	la	$a0, new_ln		# print a newline
	li	$v0, 4
	syscall

	la	$t0, a_sides	# set $t0 addr of a_sides
	la	$s0, a_sides	# set $s0 addr of b_sides
	la	$t9, areas		# set $t9 addr of areas
	lw	$s1, len		# set $s1 to length
	li  $s5, 5			# set 5 counter to 5
	li  $t4, 0			# set Areas sum to 0

a_loop:
	li  $s4, 0			# set surrent area to 0
	lw	$s2, ($t0)		# get a_sides[n]
	lw	$s3, ($s0)		# get a_sides[n]
	
	mul $s4, $s2, $s3
	div $s4, $s4, 2
	sw	$s4, ($t9)
	
	add $t4, $t4, $s4	# add area to sum
	
	move	$a0, $s4
	li	$v0, 1
	syscall				# print area
	
	la	$a0, spcs		# print spaces
	li	$v0, 4
	syscall

	add $s5, $s5, -1
	bnez $s5, skip_nl
	
	la	$a0, new_ln		# print a newline
	li	$v0, 4
	syscall
	
	skip_nl:
	bge	$s5, 1, skip_s5
	li  $s5, 5			# set 5 counter to 5
	skip_s5:

	add	$s1, $s1, -1		# decrement counter
	add	$t0, $t0, 4			# increment addr by word
	add	$s0, $s0, 4			# increment addr by word
	add	$t9, $t9, 4			# increment addr by word
	bnez $s1, a_loop


	la	$a0, new_ln		# print a newline
	li	$v0, 4
	syscall
	
	la	$a0, new_ln		# print a newline
	li	$v0, 4
	syscall
	
#------------------------------------------------
#- Find min, med, max, sum and ave of the areas -
#------------------------------------------------

	la	$t9, areas		# set $t9 addr of areas
	lw	$s1, len		# set $s1 to length
	lw	$t1, ($t9)		# set min, $t1 to areas[0]
	mul $s6, $s1, 4
	sub $s6, $s6, 4
	add	$t9, $t9, $s6
	lw	$t3, ($t9)		# set max, $t3 to areas[0]
	la	$t9, areas
	div $t5, $t4, $s1

	div $s7, $s1, 2
	mul $s7, $s7, 4
	add $t9, $t9, $s7
	lw  $t2, ($t9)		# get lower number in middle
	lw  $t6, 4($t9)		# get higher number in middle
	add $t2, $t2, $t6	# add lower and higher together
	div $t2, $t2, 2		# divide by two for med
	

#-------------------
#- Display results -
#-------------------

#-------- Whole list

	la	$a0, min_msg
	li	$v0, 4
	syscall				# print "Areas min = "

	move	$a0, $t1
	li	$v0, 1
	syscall				# print min

	la	$a0, new_ln		# print a newline
	li	$v0, 4
	syscall
	
	la	$a0, med_msg
	li	$v0, 4
	syscall				# print "Areas med = "

	move	$a0, $t2
	li	$v0, 1
	syscall				# print med

	la	$a0, new_ln		# print a n	ewline
	li	$v0, 4
	syscall
	
	la	$a0, max_msg
	li	$v0, 4
	syscall				# print "Areas max = "

	move	$a0, $t3
	li	$v0, 1
	syscall				# print max

	la	$a0, new_ln		# print a newline
	li	$v0, 4
	syscall
	
	la	$a0, sum_msg
	li	$v0, 4
	syscall				# print "Areas sum = "

	move	$a0, $t4
	li	$v0, 1
	syscall				# print sum

	la	$a0, new_ln		# print a newline
	li	$v0, 4
	syscall
	
	la	$a0, ave_msg
	li	$v0, 4
	syscall				# print "Areas ave = "

	move	$a0, $t5
	li	$v0, 1
	syscall				# print ave

	la	$a0, new_ln		# print a newline
	li	$v0, 4
	syscall

# -----
#  Done, terminate program.

	li	$v0, 10
	syscall				# all done!