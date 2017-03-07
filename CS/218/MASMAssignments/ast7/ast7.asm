;   Jacob Truman Section 02
;   Assignment 7


.model medium
.486


;-----------------------------------------------------------
          
.data

ilst	dw  122,  42, 146,  76, 120,  56, 164,  65, 155,  57
		dw	121, 188,  33,  05,  07, 101, 115, 108,  13, 115
		dw	 17,  26, 129, 117, 107, 105, 109,  10, 150,  14
		dw	147, 123,  45,  40,  65,  11,  54,  28,  13,  22
		dw	 69,  26,  71, 147,  28,  27, 119, 177,  75,  14
		dw	181,  25,  15,  22,  17,   5,  10, 129,  12, 134
		dw	 61,  34, 151,  32,  12,  29, 114,  22,  13, 131
		dw	127,  64,  10, 172,  24, 125,  16,  62,   8,  92
		dw	111, 183, 133,  50,   5,  19, 115,   8, 113,  15
		dw	 29, 126,  62,  17, 127,  77, 199,  79,  75,  14
		dw	114,  25,  84,  43,  76, 134,  26,  10,  56,  63
		dw	 24,  16,  17, 183,  12,  81, 320,   7, 199, 190
		dw	193, 132, 146, 186, 191, 186, 134, 125,  15,  76
		dw	 67, 183,   5, 114,  15,  11,  24, 128, 113, 112
		dw	 24,  16,  17,  83,  12, 121, 320,  17,  19,  90
		dw	135, 126, 122, 117, 127,  27,  19, 127, 125, 184
		dw	 97,  74, 190,   5,  24, 125, 116,  26,   5,  29
		dw	104, 124, 112, 143, 176,  34, 126, 112, 156, 103
		dw	 69,  26,  71,  47,  28,  27,   9, 177,  75,  14
		dw	153, 172, 146, 176, 170, 156, 164, 165, 155, 156
		dw	 94,  25,  84,  43,  76,  34,  26,  13,  56,  63
		dw	147, 153, 143, 140, 165, 191, 154, 168, 143, 162
		dw	 11,  83, 133,  50,  25,  21,  15,   8,  13,  15
		dw	169, 146, 162, 147, 157, 167, 169, 177, 175, 144
		dw	 27,  64,  10,  72,  24,  25,  16,  62,  28,  92
		dw	181, 155, 145, 132, 167, 185, 150, 149, 182,  34
		dw	 81,  25,  15,   9,  17,  25,  10, 129,  12, 134
		dw	177, 164, 160, 172, 184, 175, 166,  62, 158,  72
		dw	123,  42, 146,  76,  20,  56,  64,  66, 155,  57
		dw	 39, 126,  62,   7, 127,  77, 199,  79, 175,  14
len		dw	300
imin	dw	?
imed	dw	?
imax	dw	?
iavg	dw	?
mvd		dw	?

;-----------------------------------------------------------

.stack

.code

main proc far
	mov  ax, @data
	mov  ds, ax

;---------------------------
;-- Shaker Sort Algorithm --
;---------------------------
	
	lea  bx, ilst
	mov  dx, 0
	mov  mvd, dx	; moved flag
	mov  si, 0		; set si register for min offset
	mov  ax, 2
	mul  len
	mov  di, ax		; set di register for max offset
	sub  di, 2
	
shk_lp:

	mov  dx, 0
	mov  mvd, dx
	mov  cx, si
	sub  di, 2
	mx_lp:
		mov  ax, word ptr [si][bx]
		mov  dx, word ptr 2[si][bx]
		cmp  ax, dx							; compare ilst[i] and ilst[i+1]
		jl  skip_mxswap
			mov  word ptr [si][bx], dx
			mov  word ptr 2[si][bx], ax		; swap ilst[i] and ilst[i+1]
			mov  dx, 1
			mov  mvd, dx
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
		jl  skip_mnswap
			mov  word ptr [di][bx], dx
			mov  word ptr 2[di][bx], ax		; swap ilst[i] and ilst[i+1]
			mov  dx, 1
			mov  mvd, dx
		skip_mnswap:
		sub  di, 2
		cmp  di, si
		jge  mn_lp
		add  si, 2
	mov  di, cx
		
mov  dx, mvd
cmp  dx, 0
jne  shk_lp

;--------------------------------
;-- Assign List Minimum - imin --
;--------------------------------

mov  ax, word ptr [bx]
mov  imin, ax

;--------------------------------
;-- Assign List Maximum - imax --
;--------------------------------

mov  ax, 2
mul  len
mov  si, ax
sub  si, 2
mov  ax, word ptr [si][bx]
mov  imax, ax

;----------------------------
;-- Get List Median - imed --
;----------------------------
avgb:


mov  ax, len
mov  cx, 2
div  cx
cmp  dx, 0
je jmp_evn

mov  si, len
dec  si
mov  ax, word ptr [si][bx]
mov  imed, ax
cmp  ax, imed
je jmp_end

jmp_evn:
	mov  si, len
	mov  ax, word ptr [si][bx]
	add  ax, word ptr 2[si][bx]
	mov  cx, 2
	div  cx	
	mov  imed, ax

jmp_end:

;-----------------------------
;-- Get List Average - iavg --
;-----------------------------

mov  ax, 2
mul  len
sub  ax, 2
mov  si, ax
mov  ax, 0
avg_lp:
	add  ax, word ptr [si][bx]
	sub  si, 2
	cmp	 si, 0
	jg avg_lp
mov  cx, len
div  cx
mov  iavg, ax


;-----------------------------
;-- Done, terminate program --
;-----------------------------

last:
	mov  ah, 4ch
	int  21h
main endp

end main

