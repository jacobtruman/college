#  Jacob Truman
#  CSC218, MIPS Assignment #4

#  MIPS assembly language program to transpose
#   a matrix.


###########################################################
#  data segment

.data

hdr:	.asciiz	"\nProgram to transpose a matrix . \n\n"


# -----
#  Matrix Set #0 - matrix1(4,2) -> matrix1t(2,4)

xdim0:		.word	4
ydim0:		.word	2

matrix0:	.word	 10,  20,  30,  40
		.word	 50,  60,  70,  80

matrix0t:	.word	  0,   0
		.word	  0,   0
		.word	  0,   0
		.word	  0,   0

# -----
#  Matrix Set #1 - matrix1(4,2) -> matrix1t(2,4)

xdim1:		.word	2
ydim1:		.word	4

matrix1:	.word	 10,  20
		.word	 30,  40
		.word	 50,  60
		.word	 70,  80

matrix1t:	.word	  0,   0
		.word	  0,   0
		.word	  0,   0
		.word	  0,   0

# -----
#  Matrix Set #2 - matrix2(2,6) -> matrix2t(6,2)

xdim2:		.word	2
ydim2:		.word	6

matrix2:	.word	 10,  20
		.word	 30,  40
		.word	 50,  60
		.word	 70,  80
		.word	 90, 100
		.word	110, 120

matrix2t:	.word	 0,  0,  0,  0,  0,  0
		.word	 0,  0,  0,  0,  0,  0

# -----
#  Matrix Set #3 - matrix3(5,6) -> matrix3(6,5)

xdim3:		.word	5
ydim3:		.word	6

matrix3:	.word	 10,  20,  30,  40,  50
		.word	 12,  22,  32,  42,  52
		.word	 14,  24,  34,  44,  54
		.word	 16,  26,  36,  46,  56
		.word	 18,  28,  38,  48,  58
		.word	 20,  30,  40,  50,  60

matrix3t:	.word	  0,   0,   0,   0,   0
		.word	  0,   0,   0,   0,   0
		.word	  0,   0,   0,   0,   0
		.word	  0,   0,   0,   0,   0
		.word	  0,   0,   0,   0,   0
		.word	  0,   0,   0,   0,   0

# -----
#  Matrix Set #4 - matrix4(8,3) -> matrix(3,8)

xdim4:		.word	8
ydim4:		.word	3

matrix4:	.word	 1,  2,  3,  4,  5,  6,  7,  8
		.word	 9, 10, 11, 12, 13, 14, 15, 16
		.word	17, 18, 19, 20, 21, 22, 23, 24

matrix4t:	.word	 0,  0,  0
		.word	 0,  0,  0
		.word	 0,  0,  0
		.word	 0,  0,  0
		.word	 0,  0,  0
		.word	 0,  0,  0
		.word	 0,  0,  0
		.word	 0,  0,  0

# -----
#  Matrix Set #5 - matrix5(4,8) -> matrix5t(8,4)

xdim5:		.word	4
ydim5:		.word	8

matrix5:	.word	110, 120, 130, 140
		.word	150, 160, 170, 180
 		.word	190, 200, 210, 220
		.word	230, 240, 250, 260
		.word	300, 310, 320, 330
		.word	340, 350, 360, 370
		.word	380, 390, 400, 410
		.word	420, 430, 440, 450

matrix5t:	.word	  0,   0,   0,   0
		.word	  0,   0,   0,   0
		.word	  0,   0,   0,   0
		.word	  0,   0,   0,   0
		.word	  0,   0,   0,   0
		.word	  0,   0,   0,   0
		.word	  0,   0,   0,   0
		.word	  0,   0,   0,   0

# -----
#  Matrix Set #6 - matrix6(5,10) -> matrix6(10,5)

xdim6:		.word	10
ydim6:		.word	5

matrix6:	.word	10, 23, 45, 52, 60, 12, 23, 45, 32, 20
		.word	14, 58, 28, 54, 77, 24, 31, 51, 54, 41
		.word	27, 72, 31, 41, 82, 32, 48, 67, 76, 60
		.word	48, 59, 75, 98, 88, 49, 36, 53, 63, 46
		.word	50, 63, 82, 16, 91, 53, 12, 13, 37, 21

matrix6t:	.word	 0,  0,  0,  0,  0
		.word	 0,  0,  0,  0,  0
		.word	 0,  0,  0,  0,  0
		.word	 0,  0,  0,  0,  0
		.word	 0,  0,  0,  0,  0
		.word	 0,  0,  0,  0,  0
		.word	 0,  0,  0,  0,  0
		.word	 0,  0,  0,  0,  0
		.word	 0,  0,  0,  0,  0
		.word	 0,  0,  0,  0,  0

# -----
#  Matrix Set #7 - matrix7(5,35) -> matrix7t(35,5)

xdim7:		.word	5
ydim7:		.word	10

matrix7:	.word	 72,   9,  92,   6,  68
		.word	 89,   4,  65,   7,  77
		.word	820, 221,   9,  34, 123
		.word	  1, 183, 833,  52, 687
		.word	 62, 723,   4, 922,   5
		.word	213, 130,  16, 167,  15
		.word   190, 123, 983,  12, 431
		.word	112,  13,  31,  56,   3
		.word	114, 425,  66,  43,  54
		.word	916, 527, 738, 792,  32

matrix7t:	.word	  0,  0,  0,  0,  0,  0,  0,  0,  0,  0
		.word	  0,  0,  0,  0,  0,  0,  0,  0,  0,  0
		.word	  0,  0,  0,  0,  0,  0,  0,  0,  0,  0
		.word	  0,  0,  0,  0,  0,  0,  0,  0,  0,  0
		.word	  0,  0,  0,  0,  0,  0,  0,  0,  0,  0


# -----

mhdr:	.ascii	"\n----------------------------------------"
	.asciiz	"\nMatrix #"

hdr_a:	.asciiz	"\n\nMatrix\n"
hdr_at:	.asciiz	"Matrix Transposed\n"


# -----
#  Local variables for prt_matrix procedure.

new_ln:	.asciiz	"\n"
pipe:	.asciiz	"  | "
blnk1:	.asciiz	" "


###########################################################
#  text/code segment

.text

.globl main
.ent main
main:

# -----
#  Display main program header.

	la	$a0, hdr
	li	$v0, 4
	syscall					# print header

# -----
#  Set data set counter.

	li	$s0, 0

# -----
#  Matrix Set #0
#  Transpose Matrix(x,y) to MatrixT(y,x)

	la	$a0, mhdr
	li	$v0, 4
	syscall
	move	$a0, $s0
	li	$v0, 1
	syscall

	la	$a0, matrix0			# matrix(x,y)
	la	$a1, hdr_a			# header string
	lw	$a2, xdim0			# x dimension
	lw	$a3, ydim0			# y dimension
	jal	matrix_prt

	la	$a0, matrix0
	lw	$a1, xdim0
	lw	$a2, ydim0
	la	$a3, matrix0t
	jal	matrix_trans

	la	$a0, matrix0t			# matrix(y,x)
	la	$a1, hdr_at			# header string
	lw	$a2, ydim0			# x dimension
	lw	$a3, xdim0			# y dimension
	jal	matrix_prt

# -----
#  Matrix Set #1
#  Transpose Matrix(x,y) to MatrixT(y,x)

	add	$s0, $s0, 1

	la	$a0, mhdr
	li	$v0, 4
	syscall
	move	$a0, $s0
	li	$v0, 1
	syscall

	la	$a0, matrix1			# matrix(x,y)
	la	$a1, hdr_a			# header string
	lw	$a2, xdim1			# x dimension
	lw	$a3, ydim1			# y dimension
	jal	matrix_prt

	la	$a0, matrix1
	lw	$a1, xdim1
	lw	$a2, ydim1
	la	$a3, matrix1t
	jal	matrix_trans

	la	$a0, matrix1t			# matrix(y,x)
	la	$a1, hdr_at			# header string
	lw	$a2, ydim1			# x dimension
	lw	$a3, xdim1			# y dimension
	jal	matrix_prt

# -----
#  Matrix Set #2
#  Transpose Matrix(x,y) to MatrixT(y,x)

	add	$s0, $s0, 1

	la	$a0, mhdr
	li	$v0, 4
	syscall
	move	$a0, $s0
	li	$v0, 1
	syscall

	la	$a0, matrix2			# matrix(x,y)
	la	$a1, hdr_a			# header string
	lw	$a2, xdim2			# x dimension
	lw	$a3, ydim2			# y dimension
	jal	matrix_prt

	la	$a0, matrix2
	lw	$a1, xdim2
	lw	$a2, ydim2
	la	$a3, matrix2t
	jal	matrix_trans

	la	$a0, matrix2t			# matrix(y,x)
	la	$a1, hdr_at			# header string
	lw	$a2, ydim2			# x dimension
	lw	$a3, xdim2			# y dimension
	jal	matrix_prt

# -----
#  Matrix Set #3
#  Transpose Matrix(x,y) to MatrixT(y,x)

	add	$s0, $s0, 1

	la	$a0, mhdr
	li	$v0, 4
	syscall
	move	$a0, $s0
	li	$v0, 1
	syscall

	la	$a0, matrix3			# matrix(x,y)
	la	$a1, hdr_a			# header string
	lw	$a2, xdim3			# x dimension
	lw	$a3, ydim3			# y dimension
	jal	matrix_prt

	la	$a0, matrix3
	lw	$a1, xdim3
	lw	$a2, ydim3
	la	$a3, matrix3t
	jal	matrix_trans

	la	$a0, matrix3t			# matrix(y,x)
	la	$a1, hdr_at			# header string
	lw	$a2, ydim3			# x dimension
	lw	$a3, xdim3			# y dimension
	jal	matrix_prt

# -----
#  Matrix Set #4
#  Transpose Matrix(x,y) to MatrixT(y,x)

	add	$s0, $s0, 1

	la	$a0, mhdr
	li	$v0, 4
	syscall
	move	$a0, $s0
	li	$v0, 1
	syscall

	la	$a0, matrix4			# matrix(x,y)
	la	$a1, hdr_a			# header string
	lw	$a2, xdim4			# x dimension
	lw	$a3, ydim4			# y dimension
	jal	matrix_prt

	la	$a0, matrix4
	lw	$a1, xdim4
	lw	$a2, ydim4
	la	$a3, matrix4t
	jal	matrix_trans

	la	$a0, matrix4t			# matrix(y,x)
	la	$a1, hdr_at			# header string
	lw	$a2, ydim4			# x dimension
	lw	$a3, xdim4			# y dimension
	jal	matrix_prt

# -----
#  Matrix Set #5
#  Transpose Matrix(x,y) to MatrixT(y,x)

	add	$s0, $s0, 1

	la	$a0, mhdr
	li	$v0, 4
	syscall
	move	$a0, $s0
	li	$v0, 1
	syscall

	la	$a0, matrix5			# matrix(x,y)
	la	$a1, hdr_a			# header string
	lw	$a2, xdim5			# x dimension
	lw	$a3, ydim5			# y dimension
	jal	matrix_prt

	la	$a0, matrix5
	lw	$a1, xdim5
	lw	$a2, ydim5
	la	$a3, matrix5t
	jal	matrix_trans

	la	$a0, matrix5t			# matrix(y,x)
	la	$a1, hdr_at			# header string
	lw	$a2, ydim5			# x dimension
	lw	$a3, xdim5			# y dimension
	jal	matrix_prt

# -----
#  Matrix Set #6
#  Transpose Matrix(x,y) to MatrixT(y,x)

	add	$s0, $s0, 1

	la	$a0, mhdr
	li	$v0, 4
	syscall
	move	$a0, $s0
	li	$v0, 1
	syscall

	la	$a0, matrix6			# matrix(x,y)
	la	$a1, hdr_a			# header string
	lw	$a2, xdim6			# x dimension
	lw	$a3, ydim6			# y dimension
	jal	matrix_prt

	la	$a0, matrix6
	lw	$a1, xdim6
	lw	$a2, ydim6
	la	$a3, matrix6t
	jal	matrix_trans

	la	$a0, matrix6t			# matrix(y,x)
	la	$a1, hdr_at			# header string
	lw	$a2, ydim6			# x dimension
	lw	$a3, xdim6			# y dimension
	jal	matrix_prt

# -----
#  Matrix Set #7
#  Transpose Matrix(x,y) to MatrixT(y,x)

	add	$s0, $s0, 1

	la	$a0, mhdr
	li	$v0, 4
	syscall
	move	$a0, $s0
	li	$v0, 1
	syscall

	la	$a0, matrix7			# matrix(x,y)
	la	$a1, hdr_a			# header string
	lw	$a2, xdim7			# x dimension
	lw	$a3, ydim7			# y dimension
	jal	matrix_prt

	la	$a0, matrix7
	lw	$a1, xdim7
	lw	$a2, ydim7
	la	$a3, matrix7t
	jal	matrix_trans

	la	$a0, matrix7t			# matrix(y,x)
	la	$a1, hdr_at			# header string
	lw	$a2, ydim7			# x dimension
	lw	$a3, xdim7			# y dimension
	jal	matrix_prt

# -----
#  Done, terminate program.

	li	$v0, 10
	syscall

.end main


# -------------------------------------------------------
#  Procedure to transpose a matrix.

# -----
#  Matrix multiplication formula:

#	for (i=0; i<YDIM; i++)
#		for j=0; j<XDIM; j++)
#			MT(i,j) = M(j,i)
#		end_for
#	end_for

# -----
#  Formula for multiple dimension array indexing:
#	addr of ARRY(x,y) = [ (x * x_dimension) + y ] * data_size

#	$t0 - x
#	$t1 - y

# -----
#  Arguments
#	$a0 - address matrix a
#	$a1 - value, x dimension
#	$a2 - value, y dimension
#	$a3 - address matrix a^t

.globl	matrix_trans
.ent	matrix_trans
matrix_trans:

# -----
#  Transpose a matrix
#	for (i=0; i<XDIM; i++)
#		for j=0; j<YDIM; j++)
#			MT(j,i) = M(i,j)
#		end_for
#	end_for

#--------------------------------------------------
#- Formula for multiple dimension array indexing: -
#- (((x * x-dim) + y) * data size) + base address -
#--------------------------------------------------

#	$t0 - x
#	$t1 - y

li   $t0, 0
li   $t1, 0

move $s5, $a0

trns_lp:

	mul  $t2, $t0, $a1
	addu $t2, $t2, $t1
	mul  $t2, $t2, 4
	addu $t2, $t2, $s5
	lw   $t3, ($t2)

	mul  $t5, $t1, $a2
	addu $t5, $t5, $t0
	mul  $t5, $t5, 4
	addu $t5, $t5, $a3
	sw   $t3, ($t5)

	add  $t1, $t1, 1
	blt  $t1, $a1, trns_lp

	li   $t1, 0
	add  $t0, $t0, 1
	blt  $t0, $a2, trns_lp

# -----
#  Done, return to main.

	jr	$ra
.end	matrix_trans


# ---------------------------------------------------------
#  Print matrix - M(i,j)

#  Arguments:
#	$a0 - starting address of matrix to ptint
#	$a1 - address of header string
#	$a2 - x dimension of matrix
#	$a3 - y dimension of matrix

.globl	matrix_prt
.ent	matrix_prt
matrix_prt:

# -----
#  Save registers.


# -----
#  Save arguments

	move $s1, $a0	# addr of matrix

#	for (i=0; i<YDIM; i++)
#		print |
#			for j=0; j<XDIM; j++)
#				print M(j,i)
#			end_for
#		print |
#	end_for

li   $t0, 0
li   $t1, 0

la   $a0, new_ln		# print a newline
li   $v0, 4
syscall

move $a0, $a1		# print header
li   $v0, 4
syscall

la   $a0, new_ln		# print a newline
li   $v0, 4
syscall

# $t0 - x val
# $t1 - y val

prnt_lp:

	bnez $t1, no_pp	
	la	$a0, pipe		# print a "|"
	li	$v0, 4
	syscall

no_pp:

	mul  $t2, $t0, $a2
	addu $t2, $t2, $t1
	mul  $t2, $t2, 4
	addu $t2, $t2, $s1
	lw   $t3, ($t2)

	blt $t3, 10, five_ln
	blt $t3, 100, four_ln
	blt $t3, 1000, three_ln
	blt $t3, 10000, two_ln
	blt $t3, 100000, one_ln

five_ln:
	la	$a0, blnk1		# print blank 5
	li	$v0, 4
	syscall
four_ln:
	la	$a0, blnk1		# print blank 4
	li	$v0, 4
	syscall
three_ln:
	la	$a0, blnk1		# print blank 3
	li	$v0, 4
	syscall
two_ln:
	la	$a0, blnk1		# print blank 2
	li	$v0, 4
	syscall
one_ln:
	la	$a0, blnk1		# print blank 1
	li	$v0, 4
	syscall
	
	move $a0, $t3		# print num
	li	$v0, 1
	syscall

	add  $t1, $t1, 1
	blt  $t1, $a2, prnt_lp
	
	la	$a0, pipe		# print a "|"
	li	$v0, 4
	syscall
	
	la	$a0, new_ln		# print a newline
	li	$v0, 4
	syscall
	
	li   $t1, 0
	add  $t0, $t0, 1
	
	blt  $t0, $a3, prnt_lp

# -----
#  Restore registers.


# -----
#  Done, return to main.

	jr	$ra
.end matrix_prt

