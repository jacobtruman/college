#  Jacob Truman
#  CSC218, MIPS Assignment #3


#  MIPS assembly language main program and procedures:

#  * MIPS assembly language procedure, rnd_nums, to create a
#    series of random numbers, which are stored in an array.
#    The pseudo random number generator uses the linear
#    congruential generator method as follows:
#        R(n+1) = ( A * R(n) + B) mod 2^16

#  * Write a MIPS assembly language procedure, disp_lst, to
#    display a list of numbers.  The numbers should be printed
#    6 per line.  The numbers must be right justified (i.e.,
#    lined up on right side).  You may assume that the largest
#    number is 5 digits.

#  * Write a MIPS assembly language procedure, shk_sort, to
#    sort a list of numbers into ascending (small to large) order.
#    Uses the shaker sort algorithm.

#  * Write a MIPS assembly language procedure, lst_stats, that
#    will find the maximum, median, sum, and average of the list.
#    The average is calculated as a floating point value.

#  * Write a MIPS assembly language procedure, disp_stats, to
#    display the list stats.


#####################################################################
#  data segment

.data

# -----
#  Data declarations for main.


lst1:	.space	100				# 25 * 4
len1:	.word	25
seed1:	.word	9
med1:	.word	0
max1:	.word	0
sum1:	.word	0
ave1:	.float	0.0

lst2:	.space	420				# 105 * 4
len2:	.word	105
seed2:	.word	37
med2:	.word	0
max2:	.word	0
sum2:	.word	0
ave2:	.float	0.0

lst3:	.space	2400				# 1000 * 4
len3:	.word	600
seed3:	.word	199
med3:	.word	0
max3:	.word	0
sum3:	.word	0
ave3:	.float	0.0

lst4:	.space	5364				# 1341 * 4
len4:	.word	1341
seed4:	.word	1619
med4:	.word	0
max4:	.word	0
sum4:	.word	0
ave4:	.float	0.0

lst5:	.space	20948				# 5237 * 4
len5:	.word	5237
seed5:	.word	2473
med5:	.word	0
max5:	.word	0
sum5:	.word	0
ave5:	.float	0.0


hdr:	.asciiz	"\nAssignment #3\n\n"

hdr_nm:	.ascii	"\n---------------------------"
	.asciiz	"\nData Set #"

hdr_ln:	.asciiz	"\nLength: "

hdr_un:	.asciiz	"\n\n Unsorted List: \n\n"

hdr_sr:	.asciiz	"\n Sorted List: \n\n"



# -----
#  Local variables/constants for rnd_nums procedure.

seed:	.word	9

A = 9421
B = 1


# -----
#  Local variables/constants for shk_sort procedure.

TRUE = 1
FALSE = 0


# -----
#  Local variables/constants for disp_lst procedure.

blnk1:	.asciiz	" "
blnks1:	.asciiz	"  "
blnks2:	.asciiz	"   "
blnks3:	.asciiz	"    "
blnks4:	.asciiz	"     "
blnks5:	.asciiz	"      "

NUMS_PER_ROW = 6


# -----
#  Local variables for disp_stats procedure.

new_ln:	.asciiz	"\n"

str1:	.asciiz	"\n max = "
str2:	.asciiz	"\n med = "
str3:	.asciiz "\n sum = "
str4:	.asciiz	"\n ave = "



#####################################################################
#  text/code segment

.text

.globl	main
.ent	main
main:

# -----
#  Display Program Header.

	la	$a0, hdr
	li	$v0, 4
	syscall					# print header

	li	$s0, 1				# counter, data set number

# -----
#  Call routines:
#	* Gnerate random numbers
#	* Display unsorted numbers
#	* Sort numbers
#	* Find stats (max, median, sum, and average)
#	* Display sorted list
#	* Display stats  (max, median, sum, and average)


# ----------------------------
#  Data Set #1

	la	$a0, hdr_nm
	li	$v0, 4
	syscall

	move	$a0, $s0
	li	$v0, 1
	syscall

	la	$a0, hdr_ln
	li	$v0, 4
	syscall

	lw	$a0, len1
	li	$v0, 1
	syscall

	add	$s0, $s0, 1

#  Generate random numbers.

	la	$a0, lst1
	lw	$a1, len1
	lw	$a2, seed1
	jal	rnd_nums

#  Display unsorted numbers

	la	$a0, hdr_un
	li	$v0, 4
	syscall

	la	$a0, lst1
	lw	$a1, len1
	jal	disp_lst

#  Sort numbers.

	la	$a0, lst1
	lw	$a1, len1
	jal	shk_sort

#  Generate lists stats.

	la	$a0, lst1			# arg #1
	lw	$a1, len1			# arg #2
	la	$a2, max1			# arg #3
	la	$a3, med1			# arg #4
	subu	$sp, $sp, 8
	la	$t0, sum1
	sw	$t0, ($sp)			# arg #5, on stack
	la	$t1, ave1
	sw	$t1, 4($sp)			# arg #6, on stack

	jal	lst_stats

	addu	$sp, $sp, 8			# clear stack

#  Display sorted numbers.

	la	$a0, hdr_sr
	li	$v0, 4
	syscall

	la	$a0, lst1
	lw	$a1, len1
	jal	disp_lst

#  Display stats.

	l.s	$f12, ave1
	lw	$a1, max1
	lw	$a2, med1
	lw	$a3, sum1
	jal	disp_stats


# ----------------------------
#  Data Set #2

	la	$a0, hdr_nm
	li	$v0, 4
	syscall

	move	$a0, $s0
	li	$v0, 1
	syscall

	la	$a0, hdr_ln
	li	$v0, 4
	syscall

	lw	$a0, len2
	li	$v0, 1
	syscall

	add	$s0, $s0, 1

#  Generate random numbers.

	la	$a0, lst2
	lw	$a1, len2
	lw	$a2, seed2
	jal	rnd_nums

#  Display unsorted numbers

	la	$a0, hdr_un
	li	$v0, 4
	syscall

	la	$a0, lst2
	lw	$a1, len2
	jal	disp_lst

#  Sort numbers.

	la	$a0, lst2
	lw	$a1, len2
	jal	shk_sort

#  Generate lists stats.

	la	$a0, lst2
	lw	$a1, len2
	la	$a2, max2
	la	$a3, med2
	subu	$sp, $sp, 8
	la	$t0, sum2
	sw	$t0, ($sp)
	la	$t1, ave2
	sw	$t1, 4($sp)

	jal	lst_stats

	addu	$sp, $sp, 8			# clear stack

#  Display sorted numbers.

	la	$a0, hdr_sr
	li	$v0, 4
	syscall

	la	$a0, lst2
	lw	$a1, len2
	jal	disp_lst

#  Display stats.

	l.s	$f12, ave2
	lw	$a1, max2
	lw	$a2, med2
	lw	$a3, sum2
	jal	disp_stats


# ----------------------------
#  Data Set #3

	la	$a0, hdr_nm
	li	$v0, 4
	syscall

	move	$a0, $s0
	li	$v0, 1
	syscall

	la	$a0, hdr_ln
	li	$v0, 4
	syscall

	lw	$a0, len3
	li	$v0, 1
	syscall

	add	$s0, $s0, 1

#  Generate random numbers.

	la	$a0, lst3
	lw	$a1, len3
	lw	$a2, seed3
	jal	rnd_nums

#  Display unsorted numbers

	la	$a0, hdr_un
	li	$v0, 4
	syscall

	la	$a0, lst3
	lw	$a1, len3
	jal	disp_lst

#  Sort numbers.

	la	$a0, lst3
	lw	$a1, len3
	jal	shk_sort

#  Generate lists stats.

	la	$a0, lst3
	lw	$a1, len3
	la	$a2, max3
	la	$a3, med3
	subu	$sp, $sp, 8
	la	$t0, sum3
	sw	$t0, ($sp)
	la	$t1, ave3
	sw	$t1, 4($sp)

	jal	lst_stats

	addu	$sp, $sp, 8			# clear stack

#  Display sorted numbers.

	la	$a0, hdr_sr
	li	$v0, 4
	syscall

	la	$a0, lst3
	lw	$a1, len3
	jal	disp_lst

#  Display stats.

	l.s	$f12, ave3
	lw	$a1, max3
	lw	$a2, med3
	lw	$a3, sum3
	jal	disp_stats


# ----------------------------
#  Data Set #4

	la	$a0, hdr_nm
	li	$v0, 4
	syscall

	move	$a0, $s0
	li	$v0, 1
	syscall

	la	$a0, hdr_ln
	li	$v0, 4
	syscall

	lw	$a0, len4
	li	$v0, 1
	syscall

	add	$s0, $s0, 1

#  Generate random numbers.

	la	$a0, lst4
	lw	$a1, len4
	lw	$a2, seed4
	jal	rnd_nums

#  Display unsorted numbers

	la	$a0, hdr_un
	li	$v0, 4
	syscall

	la	$a0, lst4
	lw	$a1, len4
	jal	disp_lst

#  Sort numbers.

	la	$a0, lst4
	lw	$a1, len4
	jal	shk_sort

#  Generate lists stats.

	la	$a0, lst4
	lw	$a1, len4
	la	$a2, max4
	la	$a3, med4
	subu	$sp, $sp, 8
	la	$t0, sum4
	sw	$t0, ($sp)
	la	$t1, ave4
	sw	$t1, 4($sp)

	jal	lst_stats

	addu	$sp, $sp, 8			# clear stack

#  Display sorted numbers.

	la	$a0, hdr_sr
	li	$v0, 4
	syscall

	la	$a0, lst4
	lw	$a1, len4
	jal	disp_lst

#  Display stats.

	l.s	$f12, ave4
	lw	$a1, max4
	lw	$a2, med4
	lw	$a3, sum4
	jal	disp_stats


# ----------------------------
#  Data Set #5

	la	$a0, hdr_nm
	li	$v0, 4
	syscall

	move	$a0, $s0
	li	$v0, 1
	syscall

	la	$a0, hdr_ln
	li	$v0, 4
	syscall

	lw	$a0, len5
	li	$v0, 1
	syscall

	add	$s0, $s0, 1

#  Generate random numbers.

	la	$a0, lst5
	lw	$a1, len5
	lw	$a2, seed5
	jal	rnd_nums

#  Display unsorted numbers

	la	$a0, hdr_un
	li	$v0, 4
	syscall

	la	$a0, lst5
	lw	$a1, len5
	jal	disp_lst

#  Sort numbers.

	la	$a0, lst5
	lw	$a1, len5
	jal	shk_sort

#  Generate lists stats.

	la	$a0, lst5
	lw	$a1, len5
	la	$a2, max5
	la	$a3, med5
	subu	$sp, $sp, 8
	la	$t0, sum5
	sw	$t0, ($sp)
	la	$t1, ave5
	sw	$t1, 4($sp)

	jal	lst_stats

	addu	$sp, $sp, 8			# clear stack

#  Display sorted numbers.

	la	$a0, hdr_sr
	li	$v0, 4
	syscall

	la	$a0, lst5
	lw	$a1, len5
	jal	disp_lst

#  Display stats.

	l.s	$f12, ave5
	lw	$a1, max5
	lw	$a2, med5
	lw	$a3, sum5
	jal	disp_stats


# -----
#  Done, terminate program.

	li	$v0, 10
	syscall					# au revoir...

.end main


#####################################################################
#  Generate pseudo random numbers using the linear
#  congruential generator method.
#    R(n+1) = (A × Rn + B) mod 2^16

#  Initial values (as per assignment):
#	A = 9421
#	B = 1

# -----
#    Arguments:
#	$a0 - starting address of the list
#	$a1 - count of random numbers to generate
#	$a2 - seed

#    Returns:
#	N/A

.globl	rnd_nums
.ent	rnd_nums
rnd_nums:

	move $t0, $a0
	move $t1, $a1
	move $t2, $a2
	
	rnd_lp:
		mul $t3, $t2, A
		add $t4, $t3, B
		and $t2, $t4, 0x0000ffff
		sw $t2, ($t0)
		add $t0, $t0, 4
		sub $t1, $t1, 1
		bnez $t1, rnd_lp

	jr	$ra

.end	rnd_nums


#####################################################################
#  Sort a list of numbers using shaker sort.

#    moved = false
#    curmin = 0
#    curmax = (len-1)
#    do {
#       moved = false
#       for (i=curmin; i <= curmax-1; i++){
#         if ( list(i) > list(i+1) ) {
#            swap ( list(i), list(i+1) )
#            moved = true
#         }
#		}
#       curmax = curmax - 1
#       for (i=curmax-1; i >= curmin; i--){
#         if ( list(i) > list(i+1) ) {
#            swap ( list(i), list(i+1) )
#            moved = true
#         }
#		}
#       curmin = curmin + 1
#    } while (moved)

# -----
#    Arguments:
#	$a0 - starting address of the list
#	$a1 - list length

#    Returns:
#	n/a

.globl shk_sort
.ent shk_sort
shk_sort:

# $t0 = moved
# $t1 = curmin
# $t2 = curmax
# $t3 = i
# $s2 = list(i)
# $s3 = list(i+1)

	move $s1, $a1
	li $t0, 0				# moved = false
	li $t1, 0				# curmin = 0
	move $t2, $s1				# curmax = len
	sub $t2, $t2, 1			# curmax = len - 1

#lw	$s2, ($a0)

	srt_lp:
		li $t0, 0			# moved = false
		move $t3, $t1
		sub_lp1:
			mul $t4, $t3, 4		#i * 4
			add $t4, $t4, $a0	#+ offset
			lw	$s2, ($t4)
			add $t4, $t4, 4		#+ 4
			lw	$s3, ($t4)
			ble $s2, $s3, swap_lp1
			sw	$s2, ($t4)
			sub $t4, $t4, 4		#- 4
			sw	$s3, ($t4)
			li $t0, 1			# moved = true
			swap_lp1:
			add $t3, $t3, 1
			blt $t3, $t2, sub_lp1

		sub $t2, $t2, 1
		move $t3, $t2
		sub $t3, $t3, 1
		sub_lp2:
			mul $t4, $t3, 4		#i * 4
			add $t4, $t4, $a0	#+ offset
			lw	$s2, ($t4)
			add $t4, $t4, 4		#+ 4
			lw	$s3, ($t4)
			ble $s2, $s3, swap_lp2
			sw	$s2, ($t4)
			sub $t4, $t4, 4		#- 4
			sw	$s3, ($t4)
			li $t0, 1			# moved = true
			swap_lp2:
			sub $t3, $t3, 1
			bge $t3, $t1, sub_lp2
		add $t1, $t1, 1
		bnez $t0, srt_lp

	jr	$ra
.end shk_sort


#####################################################################
#  MIPS assembly language procedure, lst_stats, that will
#   find the maximum, median, sum and average of the list.
#   Finds the maximum after the list is sorted (i.e, max=list(len-1)).
#   The average is calculated as floating point value.

# -----
#    Arguments:
#	$a0 - starting address of the list
#	$a1 - list length
#	$a2 - addr of max
#	$a3 - addr of med
#	($sp) - addr of sum
#	4($sp) - addr of ave (float)

#    Returns (via addresses):
#	maximum
#	median
#	sum
#	average

.globl lst_stats
.ent lst_stats
lst_stats:

# -----
#  Save registers.

	subu	$sp, $sp, 8
	sw	$fp, ($sp)
	sw	$ra, 4($sp)

	addu	$fp, $sp, 8

# -----
#  Get max, list(n).
	
	mul $s5, $a1, 4		#i * 4
	add $s5, $s5, $a0	#+ offset
	sub $s5, $s5, 4
	lw	$s1, ($s5)
	sw	$s1, ($a2)

# -----
#  Find median value.

	rem $t0, $a1, 2
	bnez $t0, jmp_odd

	div $s5, $a1, 2		#i / 2
	mul $s5, $s5, 4		#i * 4
	add $s5, $s5, $a0	#+ offset
	lw $s2, ($s5)
	sub $s5, $s5, 4
	lw $s3, ($s5)
	add $s2, $s2, $s3
	div $s2, $s2, 2
		
	b stor_med
	jmp_odd:

	div $s5, $a1, 2		#i / 2
	mul $s5, $s5, 4		#i * 4
	add $s5, $s5, $a0	#+ offset
	lw	$s2, ($s5)
	
	stor_med:	
	sw	$s2, ($a3)

# -----
#  Find sum.

	# loop to set $t2 = sum

	lw	$t6, ($fp)		# get address of sum

	move $s0, $a0	# set $s0 to list addr
	move $s1, $a1	# set $s1 to list len
	lw $t2, ($s0)
	add $s0, $s0, 4
	sub $s1, $s1, 1
	sum_lp:
		lw $s3, ($s0)
		add $t2, $t2, $s3
		add $s0, $s0, 4
		sub $s1, $s1, 1
		bnez $s1, sum_lp
		
	sw	$t2, ($t6)		# store sum

# -----
#  Calculate average.

	mtc1	$t2, $f6		# $t2 = sum (from above)
	cvt.s.w	$f6, $f6		# convert int to float

	mtc1	$a1, $f8		# $a1 = length
	cvt.s.w	$f8, $f8		# convert int to float

	div.s	$f20, $f6, $f8		# $f20 = sum / len

	lw	$t6, 4($fp)		# get address of average
	s.s	$f20, ($t6)		# store average

# -----
#  Done, restore registers and return.

	lw	$fp, ($sp)
	lw	$ra, 4($sp)
	addu	$sp, $sp, 8

	jr	$ra
.end lst_stats


#####################################################################
#  MIPS assembly language procedure, disp_lst, to display
#   a list of numbers.  The numbers should be printed 6 per line.
#   The numbers are right justified (i.e., lined up on right
#   side).  Assumes that the largest number is 5 digits.

#  Note, due to the system calls, the saved registers must
#        be used.  As such, push/pop saved registers altered.

# -----
#    Arguments:
#	$a0 - starting address of the list
#	$a1 - list length

#    Returns:
#	N/A

.globl	disp_lst
.ent	disp_lst
disp_lst:

# -----
#  Save registers.

	subu $sp, $sp, 16
	sw $s0, 0($sp)
	sw $s1, 4($sp)
	sw $s2, 8($sp)
	sw $s3, 12($sp)
	move $s0, $a0
	move $s1, $a1
	li $s3, 6

# -----
#  Loop to display numbers in list...

prnt_lp:

	la	$a0, blnk1		# print blank
	li	$v0, 4
	syscall

	lw	$s2, ($s0)
	ble, $s2, 10, five_ln
	blt, $s2, 100, four_ln
	blt, $s2, 1000, three_ln
	blt, $s2, 10000, two_ln
	blt, $s2, 100000, one_ln

five_ln:
	la	$a0, blnk1		# print blank
	li	$v0, 4
	syscall
four_ln:
	la	$a0, blnk1		# print blank
	li	$v0, 4
	syscall
three_ln:
	la	$a0, blnk1		# print blank
	li	$v0, 4
	syscall
two_ln:
	la	$a0, blnk1		# print blank
	li	$v0, 4
	syscall
one_ln:
	la	$a0, blnk1		# print blank
	li	$v0, 4
	syscall

	move $a0, $s2
	li	$v0, 1
	syscall				# print num	

	sub $s3, $s3, 1
	bnez $s3, jmp_nl
	
	la	$a0, new_ln		# print a newline
	li	$v0, 4
	syscall
	
	li $s3, 6
	jmp_nl:
	
	add $s0, $s0, 4
	sub $s1, $s1, 1
	bnez $s1, prnt_lp

# -----
#  Display CR/LF for formatting.

	la	$a0, new_ln
	li	$v0, 4
	syscall

# -----
#  Restore registers.

	lw $s0, 0($sp)
	lw $s1, 4($sp)
	lw $s2, 8($sp)
	lw $s3, 12($sp)
	addu $sp, $sp, 16

# -----
#  Done, return to main.

	jr	$ra
.end disp_lst


#####################################################################
#  MIPS assembly language procedure, disp_stats, to display
#   the final results.  The procedure prints maximum, median,
#   sum and average.

# -----
#    Arguments:
#	$f12 - average
#	$a1 - maximum
#	$a2 - median
#	$a3 - sum

#    Returns:
#	n/a

.globl	disp_stats
.ent	disp_stats
disp_stats:

# -----
#  Save registers.


# -----
#  Save arguments to saved registers
#   (since system calls change arg registers).

	la	$a0, str1		# print a max:
	li	$v0, 4
	syscall

	move $a0, $a1
	li	$v0, 1
	syscall				# print max
	
	la	$a0, str2		# print a med:
	li	$v0, 4
	syscall

	move $a0, $a2
	li	$v0, 1
	syscall				# print med
	
	la	$a0, str3		# print a sum:
	li	$v0, 4
	syscall

	move $a0, $a3
	li	$v0, 1
	syscall				# print sum
	
	la	$a0, str4		# print a sum:
	li	$v0, 4
	syscall

#	move $f0, $f12
	li	$v0, 2
	syscall				# print ave

# -----
#  Restore registers.


# -----
#  Done, return.

	jr	$ra
.end	disp_stats


#####################################################################
