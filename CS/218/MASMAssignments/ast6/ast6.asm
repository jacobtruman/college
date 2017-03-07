;  CSC218, Assignment #6
;  Example Solution


;  Write a simple assembly language program to convert integers
;  to ASCII charatcers and output the ASCII strings to the screen
;  (using the provided routine).


.model medium
.486

; --------------------------------------------------------------
;  Macro, “i_to_a”, to convert an integer to an ascii string.
;   Each ASCII string must be right justified, blank filled,
;   and terminated with a "$"

i_to_a	macro	int_num_addr, asc_str_addr, str_siz
	local	i_lp1, i_lp2


; -----
;  Loop to convert an integer to an ascii string.
;   Places remainders on stack and counts.

	mov	bx, int_num_addr
	mov	ax, word ptr [bx]
	mov	dx, word ptr 2[bx]
	mov	cx, 0

i_lp1:
	div	wten
	add	dl, 30h
	push	dx				; store remainder on stack
	inc	cx
	mov	dx, 0				; successive division
	cmp	ax, 0
	jg	i_lp1

; -----
;  Loop to read characters off stack and place into the string.
;  First, calculate starting location of string based on size.

	mov	ax, str_siz			; max-cnt-"$"
	sub	ax, cx
	dec	ax

	mov	bx, asc_str_addr
	add	bx, ax

i_lp2:
	pop	ax				; get remainder from stack
	mov	byte ptr [bx], al		; place into string
	inc	bx
	loop	i_lp2

	mov	byte ptr [bx], END_STR		; add "$"

endm


; --------------------------------------------------------------
;  Macro, “ilst_to_alst”, to convert a series of integers
;  into a series of strings.
;  Uses the "i_to_a" macro for each integer in the list.

;  Assumes valid data, no error checking is performed.


ilst_to_alst	macro   int_arr, str_arr, len, str_siz
	local	main_ilp

; -----
;  Loop to access each of "len" integers.

	lea	si, int_arr
	lea	di, str_arr
	mov	cx, len

main_ilp:
	push	cx				; cx also used by i_to_a macro

	i_to_a	si, di, str_siz

	add	si, 4
	add	di, str_siz

	pop	cx

	loop	main_ilp

endm


; --------------------------------------------------------------
;  Provided macro to output ASCII stings to the screen.

;  Uses operating system service to output an ASCII string.
;    The specific service utilized (09h) requires the string
;    to be terminated with a NULL (integer zero).

;  General process:
;	- print header
;	LP:
;	- print numbers
;	- if 5th number, print CF/LF
;	- if more numbers, loop to LP

prt_strings	macro	str_lst, len, str_siz
	local	main_loop, skp_nline1, skp_nline2

; -----
;  Ouptut a header string...

	mov	ah, 09h
	lea	dx, hdr
	int	21h				; output header

; -----
;  Initializations for main loop.

	lea	si, str_lst
	mov	di, 0
	mov	cx, len

; -----
;  Print number.

main_loop:
	mov	ah, 09h
	mov	dx, si
	int	21h				; output header

	add	si, str_siz

; -----
;  If 5th number, print CF/LF.

	inc	di
	cmp	di, 5
	jl	skp_nline1

	mov	ah, 09h
	lea	dx, nline
	int	21h
	mov	di, 0
skp_nline1:


	loop	main_loop

; -----
;  Done, print new line (only if not already printed).

	cmp	di, 0
	je	skp_nline2

	mov	ah, 09h
	lea	dx, nline
	int	21h
skp_nline2:

endm


; --------------------------------------------------------------

.data

; -----
;  Variables and constants for print macro.

CR		equ	13
LF		equ	10
MAX_SIZ		equ	10
END_STR		equ	"$"

; -----
;  Misc. variales for prt_strings macro.

hdr		db	CR, LF, "----------", CR, LF, "ASCII List"
		db	CR, LF, END_STR
nline		db	CR, LF, END_STR


; -----
;  Misc. data definitions.

wten		dw	10
w_two		dw	2


; -----
;  Assignment #6 Provided Data:

STR_SIZE	equ	9

ilst0		dd	    12,     345,    6789,   12345,  123456
len0		dw	5
alst0		db	5 dup ( STR_SIZE dup (20h) )

ilst1		dd	152432,   61740,   10300,   25000,  110000
		dd	 54321,      32,  101010,  121201,     312
len1		dw	10
alst1		db	10 dup ( STR_SIZE dup (20h) )

ilst2		dd	115997,   12360,   13230,   21234,  111111
		dd	 11795,    6312,     420,    5532,   15533
len2		dw	10
alst2		db	10 dup ( STR_SIZE dup (20h) )

ilst3		dd	112627,   11622,   19110,   10669,   36516
		dd	111512,   14552,   11344,   10134,   18208
		dd	134112,    1231,    8765,   87312,  100012
		dd	112808,  112344
len3		dw	17
alst3		db	17 dup ( STR_SIZE dup (20h) )

ilst4		dd	111512,   14552,   11344,   10134,   18208
		dd	112808,  112344,     214,  111212,  111115
		dd	  1265,  112130,      85,  112233
len4		dw	14
alst4		db	14 dup ( STR_SIZE dup (20h) )

ilst5		dd	117864,    1068,   11721,   26000,  123584
		dd	   129,   31212,     117,   132163,   2112
		dd	 11345,   11068,   11721,   26000,  123584
len5		dw	15
alst5		db	15 dup ( STR_SIZE dup (20h) )

ilst6		dd	168795,    3110,      20,   13332,  110022
		dd	  7560,   12313,   11760,    4312,    7865
		dd	123241,   98231,      80,    4313,   31233
		dd	118637,   34513,    1691,   11312,    8551
		dd	 12241,   13231,    3280,    7653,   45127
len6		dw	25
alst6		db	25 dup ( STR_SIZE dup (20h) )


; -----
;  Misc. varibales for main.


; --------------------------------------------------------------

.stack

.code
main	proc	far
	mov	ax, @data
	mov	ds, ax

; -----
;  Invoke macro for each set of data.


	ilst_to_alst	ilst0, alst0, len0, STR_SIZE
	prt_strings	alst0, len0, STR_SIZE

	ilst_to_alst	ilst1, alst1, len1, STR_SIZE
	prt_strings	alst1, len1, STR_SIZE

	ilst_to_alst	ilst2, alst2, len2, STR_SIZE
	prt_strings	alst2, len2, STR_SIZE

	ilst_to_alst	ilst3, alst3, len3, STR_SIZE
	prt_strings	alst3, len3, STR_SIZE

	ilst_to_alst	ilst4, alst4, len4, STR_SIZE
	prt_strings	alst4, len4, STR_SIZE

	ilst_to_alst	ilst5, alst5, len5, STR_SIZE
	prt_strings	alst5, len5, STR_SIZE

	ilst_to_alst	ilst6, alst6, len6, STR_SIZE
	prt_strings	alst6, len6, STR_SIZE


; -----
; Done, terminate program.

last:
	mov	ah, 4ch
	int	21h
main endp

end	main
