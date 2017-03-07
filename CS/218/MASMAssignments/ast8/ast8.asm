;   Jacob Truman Section 02
;   Assignment 8


;  Main program to call procedures for:
;	1) Procedure for shaker sort (descending order)
;	2) Procedure for minimum, maximum, sum, abd average
;	3) Procedure for median and variance

;  Note, The selection sort procedure uses the asst #7
;        code with minor modifications.


.model	small

;----------------------------------------------------------

.data

lst1	dw	10,  12,  14,  16,  18,  20,  22,  24,  26,  28
	dw	31,  33,  35,  37,  39,  41,  43,  45,  47,  49
	dw	30,  32,  34,  36,  38,  40,  42,  44,  46,  48
	dw	29,  27,  25,  23,  21,  19,  17,  15,  13,  11
len1	dw	40
min1	dw	?
med1	dw	?
max1	dw	?
sum1	dw	?
ave1	dw	?
var1	dd	?

lst2	dw	-15,  15, -14,  14, -13,  13, -12,  12, -11,  11
	dw	-10,  10,  -9,   9,  -8,   8,  -7,   7,  -6,   6
	dw	 -5,   5,  -4,   4,  -3,   3,  -2,   2,  -1,   1
	dw	0
len2	dw	31
min2	dw	?
med2	dw	?
max2	dw	?
sum2	dw	?
ave2	dw	?
var2	dd	?

lst3	dw	123,   2, 146,  76,   0,  56, 264,  65, 155, -56
	dw	 47, 123,  -3,  40,  65, -11,  54,  28, -13,  22
	dw	 69,  26,  62,   7,  27,  27,   9, -77,  75,  14
	dw	 81,  25,  15,   2,  17,   5,  10, 129,  12, 134
	dw	161,   2, -51,   2,   1,   9, -14,  22,  15, -31
	dw	 27,  64,  10, 172,  24, -25,  16,  62,   8,  92
	dw	 11, -83, 233,  50,   5,   1,  15,   8, 413, 415
	dw	  9, 126,  62,   7, 227,  77, -99,  77, 175,  14
	dw	 94,  24,   4,  43,  76,  34,  26,   2, -56,  63
	dw	 24,  19,  17, 183,  10
len3	dw	95
min3	dw	?
med3	dw	?
max3	dw	?
sum3	dw	?
ave3	dw	?
var3	dd	?

lst4	dw	 23, 432, 246,  76, -11,  16, 164, 165, -95,  56
	dw	-37, -23,  -3, 140,  15, 111,  54,  28, -13, 122
	dw	 35,  26,  62,   7,  27,  27,   9, -77,  75,  14
	dw	 45,  25,  15,   2, -17,  15,  10, 129,  12, 134
	dw	161,   2, -51,   2,   2,  -9, -14,  22,  15, -31
	dw	 27,  44,  10, 172,  24, -25,  16,  62,  28,  92
	dw	 11, -83, 233,  50, -27,   1,  15,   8, 413, 415
	dw	  7, 126,  62,   7, 227, 177, -99,  77, 175,  14
	dw	194,  24,   2,  43,  76,  34,  26,   2, -56,  63
	dw	 24, -19,  22,  83,  10, -91, -92, 129, 129, -19
len4	dw	100
min4	dw	?
med4	dw	?
max4	dw	?
sum4	dw	?
ave4	dw	?
var4	dd	?

lst5	dw	 23, -12,  46, -36,  10, -16,  64, -56,  15, -32
	dw	-49,  44, -14,  34, -67,  43, -29,  61, -65,  36
	dw	 71, -47,  10, -27,  74, -65,  61, -97,  81, -29
	dw	-64,  41, -42,  33, -76,  34, -46,  23, -56,  63
	dw	 21, -18,  17, -43,  78, -12,  11, -10,  35, -10
	dw	-11,  83, -33,  50,  -5,   1, -15,   8, -13,  15
	dw	 79, -25,  52, -77,  87, -67,  91, -77,  52, -24
	dw	-79,  63, -36,  40, -35,  12, -54,  28, -13,  22
len5	dw	80
min5	dw	?
med5	dw	?
max5	dw	?
sum5	dw	?
ave5	dw	?
var5	dd	?


;------------
;  Constants:

FALSE	equ	-1
TRUE	equ	1


;----------------------------------------
; Temporary variables for sort procedure.

ten	dw	10

moved	dw	?
curmax	dw	?
curmin	dw	?
i	dw	?

two	dw	2


;------------------------------------------------------
; Temporary variables for standard deviation procedure.

tmp_avg	dw	?
dsum	dd	?
sqtmp	dw	?
tmp_sum	dw	?


;-----

.stack

.code

;-----------------------------------------------------------
;  Main program to call sort routine then call stats routine
;   and the advanced stats procedure.

;  Call the sort routine with each set of data.
;   Arguments passed on the stack are:
;	list (address)
;	len (value)
;   The procedure will sort the list in place.

;  Call the stats procedure
;   Arguments passed on the stack are:
;	list (address)
;	len (value)
;	minimum (address)
;	maximum (address)
;	sum (address)
;	average (address)
;   The procedure will return the minimum, maximum, sum
;   and average values.

;  Call the procedure for advanced stats.
;   Arguments passed on the stack are:
;	list (address)
;	len (value)
;	median (address)
;	variance (address)
;   The procedure will return the median and variance.

;--------------------
;-- Main Procedure --
;--------------------

main	proc	far
	mov	ax, @data
	mov	ds, ax

;-------------
;  Data Set #1

	lea	ax, lst1
	push	ax
	push	len1
	call	shk_sort

	lea	ax, lst1
	push	ax
	push	len1
	lea	ax, min1
	push	ax
	lea	ax, max1
	push	ax
	lea	ax, sum1
	push	ax
	lea	ax, ave1
	push	ax
	call	stats
	
	lea	ax, lst1
	push	ax
	push	len1
	lea	ax, med1
	push	ax
	lea	ax, var1
	push	ax
	call	adv_stats

;-------------
;  Data Set #2

	lea	ax, lst2
	push	ax
	push	len2
	call	shk_sort

	lea	ax, lst2
	push	ax
	push	len2
	lea	ax, min2
	push	ax
	lea	ax, max2
	push	ax
	lea	ax, sum2
	push	ax
	lea	ax, ave2
	push	ax
	call	stats

	lea	ax, lst2
	push	ax
	push	len2
	lea	ax, med2
	push	ax
	lea	ax, var2
	push	ax
	call	adv_stats

;-------------
;  Data Set #3

	lea	ax, lst3
	push	ax
	push	len3
	call	shk_sort

	lea	ax, lst3
	push	ax
	push	len3
	lea	ax, min3
	push	ax
	lea	ax, max3
	push	ax
	lea	ax, sum3
	push	ax
	lea	ax, ave3
	push	ax
	call	stats

	lea	ax, lst3
	push	ax
	push	len3
	lea	ax, med3
	push	ax
	lea	ax, var3
	push	ax
	call	adv_stats

;-------------
;  Data Set #4

	lea	ax, lst4
	push	ax
	push	len4
	call	shk_sort

	lea	ax, lst4
	push	ax
	push	len4
	lea	ax, min4
	push	ax
	lea	ax, max4
	push	ax
	lea	ax, sum4
	push	ax
	lea	ax, ave4
	push	ax
	call	stats

	lea	ax, lst4
	push	ax
	push	len4
	lea	ax, med4
	push	ax
	lea	ax, var4
	push	ax
	call	adv_stats

;-------------
;  Data Set #5

	lea	ax, lst5
	push	ax
	push	len5
	call	shk_sort

	lea	ax, lst5
	push	ax
	push	len5
	lea	ax, min5
	push	ax
	lea	ax, max5
	push	ax
	lea	ax, sum5
	push	ax
	lea	ax, ave5
	push	ax
	call	stats

	lea	ax, lst5
	push	ax
	push	len5
	lea	ax, med5
	push	ax
	lea	ax, var5
	push	ax
	call	adv_stats

;-------------------------
; Done, terminate program.

last:
	mov	ah, 4ch
	int	21h
main	endp

;-------------------------------------------------------------

;  Procedures go here...

;---------------------------
;-- Shaker Sort Procedure --
;---------------------------

shk_sort	proc	near

	push bp
	mov  bp, sp
	push ax
	push bx
	push cx
	push dx
	push si
	push di
	mov  bx, word ptr 6[bp]	; get list address
	mov  cx, word ptr 4[bp]	; get list length

	mov  dx, 0
	mov  moved, dx	; moved flag
	mov  si, 0		; set si register for min offset
	mov  ax, 2
	mul  cx
	mov  di, ax		; set di register for max offset
	sub  di, 2
	
	shk_lp:

		mov  dx, 0
		mov  moved, dx
		mov  cx, si
		sub  di, 2
		mx_lp:
			mov  ax, word ptr [si][bx]
			mov  dx, word ptr 2[si][bx]
			cmp  ax, dx							; compare ilst[i] and ilst[i+1]
			jg  skip_mxswap
				mov  word ptr [si][bx], dx
				mov  word ptr 2[si][bx], ax		; swap ilst[i] and ilst[i+1]
				mov  dx, 1
				mov  moved, dx
			skip_mxswap:
			add  si, 2
			cmp  si, di
			jle  mx_lp
			mov  si, cx
		
		mov  cx, di
		sub  di, 2
		mn_lp:
			mov  ax, word ptr [di][bx]
			mov  dx, word ptr 2[di][bx]
			cmp  ax, dx							; compare ilst[i] and ilst[i+1]
			jg  skip_mnswap
				mov  word ptr [di][bx], dx
				mov  word ptr 2[di][bx], ax		; swap ilst[i] and ilst[i+1]
				mov  dx, 1
				mov  moved, dx
			skip_mnswap:
			sub  di, 2
			cmp  di, si
			jge  mn_lp
			add  si, 2
		mov  di, cx
		
	mov  dx, moved
	cmp  dx, 0
	jne  shk_lp
	
	pop  di
	pop  si
	pop  dx
	pop  cx
	pop  bx
	pop  ax
	pop  bp

	ret 2
shk_sort endp

;---------------------
;-- Stats Procedure --
;---------------------

stats	proc	near

	push bp
	mov  bp, sp
	push ax
	push bx
	push cx
	push si
	mov  bx, word ptr 14[bp]		; get list address
	mov  cx, word ptr 12[bp]		; get list length
	
	;-------------------------
	;-- Assign List Minimum --
	;-------------------------

	mov  ax, 2
	mul  cx
	mov  si, ax
	sub  si, 2
	mov  ax, word ptr [si][bx]
	mov  bx, word ptr 10[bp]		; get Min address
	mov  word ptr [bx], ax

	mov  bx, word ptr 14[bp]		; reset list address

	;-------------------------
	;-- Assign List Maximum --
	;-------------------------

	mov  ax, word ptr [bx]
	mov  bx, word ptr 8[bp]			; get Max address
	mov  word ptr [bx], ax
	
	mov  bx, word ptr 14[bp]		; reset list address

	;------------------
	;-- Get List Sum --
	;------------------

	mov  ax, 2
	mul  cx
	sub  ax, 2
	mov  si, ax
	mov  ax, 0
	mov  tmp_sum, 0
	avg_lp:
		mov  ax, word ptr [si][bx]
		add  tmp_sum, ax
		sub  si, 2
		cmp	 si, 0
		jge avg_lp
	mov  ax, tmp_sum
	mov  bx, word ptr 6[bp]			; get Sum address
	mov  word ptr [bx], ax
	
	;----------------------
	;-- Get List Average --
	;----------------------

	idiv cx
	mov  bx, word ptr 4[bp]			; get Ave address
	mov  word ptr [bx], ax
	mov  tmp_avg, ax

	pop  si
	pop  cx
	pop  bx
	pop  ax
	pop  bp

	ret 6
stats endp

;------------------------------
;-- Advanced Stats Procedure --
;------------------------------

adv_stats	proc	near
	push bp
	mov  bp, sp
	push ax
	push bx
	push cx
	push dx
	push si
	mov  dx, 0
	mov  bx, word ptr 10[bp]		; get list address
	mov  ax, word ptr 8[bp]			; get list length

	;---------------------
	;-- Get List Median --
	;---------------------

	div  two
	mov  cx, word ptr 8[bp]			; get list length
	cmp  dx, 0
	je jmp_evn

	mov  si, cx
	dec  si
	mov  ax, word ptr [si][bx]
	mov  bx, word ptr 6[bp]			; get Med address
	mov  word ptr [bx], ax
	jmp jmp_end

	jmp_evn:
		mov  si, cx
		mov  ax, word ptr [si][bx]
		sub  si, 2
		add  ax, word ptr [si][bx]
		idiv two
		mov  bx, word ptr 6[bp]		; get Med address
		mov  word ptr [bx], ax

	jmp_end:
	
	;-----------------------
	;-- Get List Variance --
	;-----------------------

	mov  bx, word ptr 10[bp]		; reset list address
	mov  di, word ptr 4[bp]			; get Var address
	mov  ax, 2
	mul  cx
	sub  ax, 2
	mov  si, ax
	mov  ax, 0
	var_lp:
		mov  ax, word ptr [si][bx]
		sub  ax, tmp_avg
		imul ax
		add  word ptr [di], ax
		adc  word ptr 2[di], dx
		mov  sqtmp, ax
		sub  si, 2
		cmp  si, 0
		jge var_lp
	mov  ax, word ptr [di]
	mov  dx, word ptr 2[di]
	dec  cx
	idiv cx
	mov  word ptr [di], ax

	pop  si
	pop  dx
	pop  cx
	pop  bx
	pop  ax
	pop  bp

	ret 4
adv_stats endp

;-------------------------------------------------------------

end	main
