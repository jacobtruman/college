;   Jacob Truman Section 02
;   Assignment 5

.model medium
.486

; --------------------------------------------------------------
;  Macro to find area of right triangle.
;	areas(n) = ( a(n) * b(n) ) / 2

rtri_areas	macro	a_side, b_side, len, areas
	local area_lp

	mov cx, len
	lea si, a_side
	lea di, b_side
	lea bx, areas
	
area_lp:
	mov dx, 0
	mov al, byte ptr[si]
	mul byte ptr[di]
	div btwo
	mov byte ptr[bx], al
	inc si
	inc di
	inc bx
	loop area_lp

endm

; --------------------------------------------------------------
;  Macro to calculate the below formula:
;	r_pnt(n) = ( areas(n) * ( a(n)^2 + b(n)^2 ) ) / 3

rtri_ppnt	macro	a_side, b_side, areas, len, r_pnt
	local ppnt_lp

	mov cx, len
	lea di, r_pnt
	mov si, 0
	
ppnt_lp:
	lea bx, a_side
	mov al, byte ptr[bx][si]
	mul al
	mov dx, ax
	
	lea bx, b_side
	mov al, byte ptr[bx][si]
	mul al
	add ax, dx
	
	lea bx, areas
	mov dl, byte ptr[bx][si]
	mul dx
	div wfifteen

	mov word ptr[di], ax
	inc si
	add di, 2
	mov ax, 0
	mov dx, 0
	loop ppnt_lp

endm

; --------------------------------------------------------------
;  Macro to find the sum and average for right triangles arrays.

rtri_a_stats	macro	areas, len, asum, aave
	local astats_lp

	mov cx, len
	lea bx, areas
	mov asum, 0
	mov ax, 0
	mov dx, 0
	
astats_lp:
	mov al, byte ptr[bx]
	add asum, ax
	inc bx
	loop astats_lp

mov ax, asum
div len
mov aave, al

endm

; --------------------------------------------------------------
;  Macro to find the sum and average “r_pnt” array.

rtri_r_stats	macro	r_pnt, len, rsum, rave
	local rstats_lp

	mov cx, len
	lea bx, r_pnt
	mov rsum, 0
	mov ax, 0
	mov dx, 0
	
rstats_lp:
	mov ax, word ptr[bx]
	add rsum, ax
	add bx, 2
	loop rstats_lp

mov ax, rsum
div len
mov rave, ax

endm

; --------------------------------------------------------------

.data

a_side1		db	10, 15, 10, 13, 14, 17, 10,  6, 13, 11
b_side1		db	15,  2, 13,  6, 12, 16,  7, 12, 10, 12
areas1		db	10 dup (?)
r_pnt1		dw	10 dup (?)
len1		dw	10
asum1		dw	?
aave1		db	?
rsum1		dw	?
rave1		dw	?

a_side2		db	14,  9, 14, 13, 12, 10, 13, 12, 12, 12
		db	 3, 11, 12,  5, 10, 12
b_side2		db	15, 14, 13, 16, 14, 12, 11, 17, 13, 15
		db	14,  9, 14, 13, 12, 14
areas2		db	16 dup (?)
r_pnt2		dw	16 dup (?)
len2		dw	16
asum2		dw	?
aave2		db	?
rsum2		dw	?
rave2		dw	?

a_side3		db	13,  4, 13, 11, 12, 14, 13, 14,  6, 15
		db	 4, 12, 11,  3,  8, 12, 14, 13, 18
b_side3		db	12, 18, 11, 14, 16, 11, 13, 13,  4, 11
		db	 4, 12, 13, 12, 13,  2, 14,  7, 18
areas3		db	19 dup (?)
r_pnt3		dw	19 dup (?)
len3		dw	19
asum3		dw	?
aave3		db	?
rsum3		dw	?
rave3		dw	?

a_side4		db	11, 13, 15, 13, 16, 14, 13, 10,  1, 15
		db	14,  4, 13, 11, 11,  4, 13,  9,  7, 13
b_side4		db	10, 13,  5, 15, 12, 17, 10, 21, 14, 15
		db	12, 17, 18, 13, 10, 11, 12, 11, 15, 13
areas4		db	20 dup (?)
r_pnt4		dw	20 dup (?)
len4		dw	20
asum4		dw	?
aave4		db	?
rsum4		dw	?
rave4		dw	?

a_side5		db	10, 14, 13,  7, 14, 14, 13, 10, 11, 16
		db	14,  3, 14, 19,  2, 17, 11, 13,  2, 10
		db	 9, 11,  4, 11, 15
b_side5		db	12, 11, 16, 11,  1,  4, 17, 12, 17, 15
		db	11,  3, 16,  7, 15, 11, 10, 18,  2, 12
		db	 9, 11, 14,  5, 12
areas5		db	25 dup (?)
r_pnt5		dw	25 dup (?)
len5		dw	25
asum5		dw	?
aave5		db	?
rsum5		dw	?
rave5		dw	?


; -----

btwo		db	2
wfifteen	dw	15


; --------------------------------------------------------------

.stack

.code
main	proc	far
	mov	ax, @data
	mov	ds, ax

; -----
;  Invoke macro for each set of data.
;  Note, the order of invoking the macro's does not matter.

	rtri_areas	a_side1, b_side1, len1, areas1
	rtri_ppnt	a_side1, b_side1, areas1, len1, r_pnt1
	rtri_a_stats	areas1, len1, asum1, aave1
	rtri_r_stats	r_pnt1, len1, rsum1, rave1

	rtri_areas	a_side2, b_side2, len2, areas2
	rtri_ppnt	a_side2, b_side2, areas2, len2, r_pnt2
	rtri_a_stats	areas2, len2, asum2, aave2
	rtri_r_stats	r_pnt2, len2, rsum2, rave2

	rtri_areas	a_side3, b_side3, len3, areas3
	rtri_ppnt	a_side3, b_side3, areas3, len3, r_pnt3
	rtri_a_stats	areas3, len3, asum3, aave3
	rtri_r_stats	r_pnt3, len3, rsum3, rave3

	rtri_areas	a_side4, b_side4, len4, areas4
	rtri_ppnt	a_side4, b_side4, areas4, len4, r_pnt4
	rtri_a_stats	areas4, len4, asum4, aave4
	rtri_r_stats	r_pnt4, len4, rsum4, rave4

	rtri_areas	a_side5, b_side5, len5, areas5
	rtri_ppnt	a_side5, b_side5, areas5, len5, r_pnt5
	rtri_a_stats	areas5, len5, asum5, aave5
	rtri_r_stats	r_pnt5, len5, rsum5, rave5


; -----
;  Done, terminate program.

last:
	mov	ah, 4ch
	int	21h
main endp

end	main

