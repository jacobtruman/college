#  Jacob Truman
#  CSC218, MIPS Assignment #5

#  Write a simple assembly language program to
#  find Great Common Divisor (GCD) recursivly using
#  two different methods.  Compare methods.


#####################################################################
#  data segment

.data

# -----
#  Variables for main

hdr:	.ascii	"\nMIPS Assignment #5\n"
		.asciiz	"Find Greatest Common Divisor (GCD)\n\n"

m:	.word	0
n:	.word	0

gcd1:	.word	0
gcd2:	.word	0

g_cnt1:	.word	0
g_cnt2:	.word	0


# -----
#  Local variables for get_data.

mpmt:	.asciiz	"\nEnter M = "
npmt:	.asciiz	"Enter N = "

err1:	.ascii	"\nError, must enter M and N such that (M >= N > 0) \n"
	.asciiz	"Please re-enter data.\n"



# -----
#  Local variables for prt_results.

ln:	.asciiz	"\n\n---------------\n"

msg1:	.asciiz	"\nM value: "
msg2:	.asciiz	"N Value:  "
msg3:	.asciiz	"\nGCD(1): "
msg4:	.asciiz	"\nGCD(2): "
msg5:	.asciiz	"\nGCD(1) - Count: "
msg6:	.asciiz	"\nGCD(2) - Count: "

spc:	.asciiz	"   "
nline:	.asciiz	"\n"



#####################################################################
#  text/code segment

.text

.globl main
.ent main
main:

# -----
#  Display program header.

	la	$a0, hdr
	li	$v0, 4
	syscall					# print header

# -----
#  Read M and N values (such that M >= N > 0).

	jal	get_data
	sw	$v0, m
	sw	$v1, n

# -----

	lw	$a0, m
	lw	$a1, n
	jal	fnd_gcd1
	sw	$v0, gcd1


	lw	$a0, m
	lw	$a1, n
	jal	fnd_gcd2
	sw	$v0, gcd2

# -----
#  Call routine to display results.

	lw	$a0, m
	lw	$a1, n
	lw	$a2, gcd1
	lw	$a3, gcd2
	subu	$sp, $sp, 8
	lw	$t0, g_cnt1
	sw	$t0, ($sp)
	lw	$t1, g_cnt2
	sw	$t1, 4($sp)

	jal	prt_results

	addu	$sp, $sp, 8


# -----
#  Done, terminate program.

	li	$v0, 10
	syscall					# all done...

.end main


#####################################################################
#  Read M and N values.
#  Ensure that M >= N > 0.

# -----
#    Arguments:
#	n/a

#    Returns:
#	$v0 - m value
#	$v1 - n value

.globl	get_data
.ent	get_data

get_data:

# -----
#  Save registers.
	subu	$sp, $sp, 8
	sw	$fp, ($sp)
	sw	$a0, 4($sp)

	addu	$fp, $sp, 8

# -----
#  Prompt for and read N_MAX from user.

j nm_prmpt

nm_erprmpt:

	la	$a0, err1		# M message
	li	$v0, 4
	syscall

nm_prmpt:
	la	$a0, mpmt		# M message
	li	$v0, 4
	syscall
	
	li	$v0, 5
	syscall
	
	move $t1, $v0
	
	la	$a0, npmt		# N message
	li	$v0, 4
	syscall

	li	$v0, 5
	syscall
	
	move $v1, $v0
	move $v0, $t1


# -----
#  Display error message and re-prompt.
	
	ble $v1, 0, nm_erprmpt
	blt	$v0, $v1, nm_erprmpt

# -----
#  Done, pop registers and return to main.

	lw	$fp, ($sp)
	lw	$a0, 4($sp)
	addu	$sp, $sp, 8

	jr	$ra
.end	get_data


#####################################################################
#  Procedure to recursivly find Greatest Common Denominator (GCD).

#  GCD Algorithm 2: Euclid's Algorithm
#  This algorithm dates from c. 200 B.C.

#  for M >= N > 0
#	gcd(m,n) =
#		n  if mod(m,n)=0
#		gcd(n, remainder(m/n) ) 

# -----
#  Arguments:
#	$a0 - M value
#	$a1 - N value

#  Returns:
#	$v0 - GCD of (M,N)

.globl	fnd_gcd1
.ent	fnd_gcd1
fnd_gcd1:

	subu $sp, $sp, 4
	sw   $ra, ($sp)
# -----
#  Save registers.
	
	lw   $t0, g_cnt1
	add  $t0, $t0, 1
	sw   $t0, g_cnt1
	
	move $v0, $a1
	rem  $t0, $a0, $a1
	beqz $t0, gcd1_done
	
	move $a0, $a1
	move $a1, $t0
	jal  fnd_gcd1
	
gcd1_done:
	
# -----
#  Restore registers.

	lw   $ra, ($sp)
	addu $sp, $sp, 4

# -----
#  Done, return.

	jr	$ra
.end fnd_gcd1


#####################################################################
#  Procedure to recursivly find Greatest Common Denominator (GCD).

#  GCD Algorithm 3: Dijkstra's Algorithm

#  for M >= N > 0
#	gcd(m,n) =
#		m - if m=n
#		gcd(m-n,n) - if m>n
#		gcd(m,n-m) - if m<n

# -----
#  Arguments:
#	$a0 - M value
#	$a1 - N value

#  Returns:
#	$v0 - GCD of (M,N)

.globl	fnd_gcd2
.ent	fnd_gcd2
fnd_gcd2:

# -----
#  Save registers.

	subu $sp, $sp, 4
	sw   $ra, ($sp)
	
	lw   $t0, g_cnt2
	add  $t0, $t0, 1
	sw   $t0, g_cnt2
	
	move $v0, $a0
	beq  $a0, $a1, gcd2_done
	blt  $a0, $a1, nxt
	
	sub  $a0, $a0, $a1
	jal  fnd_gcd2
	
nxt:
	beq  $a0, $a1, gcd2_done
	sub  $a1, $a1, $a0
	jal  fnd_gcd2
	
gcd2_done:

# -----
#  Restore registers.

	lw   $ra, ($sp)
	addu $sp, $sp, 4

# -----
#  Done, return.

	jr	$ra
.end fnd_gcd2



#####################################################################
#  Perform initializations...

# -----
#    Arguments:
#	$a0 - M value
#	$a1 - N value
#	$a2 - GCD(1) of (M,N)
#	$a3 - GCD(2) of (M,N)
#	($fp) - count from gcd1
#	4($fp) - count from gcd2

#    Returns:
#	n/a

.globl	prt_results
.ent	prt_results
prt_results:

# -----
#  Push registers and save values.

	subu	$sp, $sp, 20
	sw	$s0, 0($sp)
	sw	$s1, 4($sp)
	sw	$s2, 8($sp)
	sw	$s3, 12($sp)
	sw	$fp, 16($sp)

	addu	$fp, $sp, 20

	move	$s0, $a0
	move	$s1, $a1
	move	$s2, $a2
	move	$s3, $a3

# -----
#  Display initial header.

	la	$a0, ln
	li	$v0, 4
	syscall

# -----
#  Display M and N values.

	la	$a0, msg1
	li	$v0, 4
	syscall

	move	$a0, $s0
	li	$v0, 1
	syscall

	la	$a0, nline
	li	$v0, 4
	syscall

	la	$a0, msg2
	li	$v0, 4
	syscall

	move	$a0, $s1
	li	$v0, 1
	syscall

	la	$a0, nline
	li	$v0, 4
	syscall

# -----
#  Display GCD's.

	la	$a0, msg3
	li	$v0, 4
	syscall

	move	$a0, $s2
	li	$v0, 1
	syscall

	la	$a0, msg4
	li	$v0, 4
	syscall

	move	$a0, $s3
	li	$v0, 1
	syscall

	la	$a0, nline
	li	$v0, 4
	syscall

# -----
#  Display counts

	la	$a0, msg5
	li	$v0, 4
	syscall

	lw	$a0, ($fp)
	li	$v0, 1
	syscall

	la	$a0, msg6
	li	$v0, 4
	syscall

	lw	$a0, 4($fp)
	li	$v0, 1
	syscall

	la	$a0, nline
	li	$v0, 4
	syscall

# -----
#  Done, pop registers and return to main.

	lw	$s0, 0($sp)
	lw	$s1, 4($sp)
	lw	$s2, 8($sp)
	lw	$s3, 12($sp)
	lw	$fp, 16($sp)
	addu	$sp, $sp, 20

	jr	$ra

.end	prt_results


#####################################################################

