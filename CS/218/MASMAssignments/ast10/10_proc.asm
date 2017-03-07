;   Jacob Truman Section 02
;   Assignment 10


.model small
.486


.data

CR		equ	13
LF		equ	10
END_STR	equ	"$"


A_VALUE		equ	9421		; must be prime #
B_VALUE		equ	1

seed		dw	7

msg		db	CR, LF, "The qualifiers were: ", END_STR
msg1	db	CR, LF, "Invalid command line argument"
		db	CR, LF, END_STR

chrs	db	80 dup (?)

psp		dw	?
ten		dw	10
three	dw	3
two		dw	2
r_A		dw	9421
r_B		dw	1
c_high	dw	?
c_low	dw	?
d_high	dw	?
d_low	dw	?
r_num	dw	?
c_sum	dw	?
c_rad	dw	?

c_a		dw	?
c_y		dw	?
c_f		dw	?
c_b		dw	?

.code

get_arg	proc	near
push bp
mov  bp, sp
push ax
push bx
push cx
push dx
push si
push di
push es

;-----------------------------------
;- Get the PSP address from system -
;-----------------------------------
	mov	ah, 51h
	int	21h
	mov	psp, bx

;------------------------------------
;- See if proper chars were entered -
;------------------------------------

	mov	ax, psp
	mov	es, ax			; set ES to PSP addr

	mov	al, byte ptr es:0080h	; number of chars entered

	cmp	al, 0			; if 0 entered, print a message
	jle	do_no_msg

	cbw
	mov	cx, ax			; number of chars entered

	lea	bx, chrs
	mov	cx, 0
	mov c_sum, cx
	mov	si, 81h
	
spaces_lp:
	mov  al, byte ptr es:[si]
	cmp  al, 20h
	jne  chk_slash
	jmp  spaces_next
		chk_slash:
			cmp  al, 2fh
			je   chk_p
			jmp  do_no_msg
		chk_p:
			inc  si
			mov  al, byte ptr es:[si]
			cmp  al, 70h
			je   chk_equ
			jmp  do_no_msg
		chk_equ:
			inc  si
			mov  al, byte ptr es:[si]
			cmp  al, 3dh
			je   chk_num
			jmp  do_no_msg
		chk_num:
			inc  si
			mov  ax, 0
			mov	 cl, byte ptr es:[si]
			cmp  cl, CR
			je   end_slp
			cmp  cl, "0"
			jl   do_no_msg			
			cmp  cl, "9"
			jg   do_no_msg
			sub  cl, 30h
			mov	 ch, 0
			mov  ax, c_sum
			imul ten
			add  ax, cx
			cmp  ax, 10000
			jg   do_no_msg
			mov  c_sum, ax
			jmp  chk_num

		spaces_next:
	inc	 si
	jmp  spaces_lp
	
	end_slp:


;-----------------------------------
;- Copy chars to the data segement -
;-----------------------------------
	
	mov  ax, c_sum
	mov  bx, word ptr 4[bp]
	mov	 word ptr [bx], ax

	jmp	end_get_arg		; done...


; ----
;  No characters entered on command line, so print message.

do_no_msg:
	mov	ah, 09h
	lea	dx, msg1
	int	21h

	mov	ah, 4ch
	int	21h

end_get_arg:

pop  es
pop  di
pop  si
pop  dx
pop  cx
pop  bx
pop  ax
pop  bp

ret 2
get_arg endp


;---------------------------------------
;- Generates randum number (up to MAX) -
;- Rn+1 = (A * Rn + B) mod MAX         -
;- A=9421 and B=1                      -
;---------------------------------------


; --------------------------------------------------
;  Generate pseudo random number, via linear congruential
;  generator.

;  Arguments:
;	1) random number, address (6)
;	2) Limit, value (4)

rand	proc	near
	push bp
	mov	 bp, sp
	push ax
	push bx
	push cx
	push dx

	mov	ax, seed

	mov	dx, A_VALUE
	mul	dx				; A * R(n)

	add	ax, B_VALUE			; A * R(n) + B

	mov	dx, 0				; mod 2^16
	mov	seed, ax

	mov	cx, word ptr 4[bp]
	idiv	cx				; mod limit

	mov	bx, word ptr 6[bp]
	mov	word ptr [bx], dx

; -----
;  Return to calling routine.

	pop	dx
	pop	cx
	pop	bx
	pop	ax
	pop	bp
	ret	4
rand	endp


;---------------------------------------------
;- Draws a 3 pixel wide border around screen -
;---------------------------------------------

draw_border	proc	near

push bp
mov  bp, sp
push ax
push bx
push cx
push dx

	mov	 si, word ptr 8[bp]		; width
	mov	 di, word ptr 6[bp]		; height
	mov	 ax, word ptr 4[bp]		; color
	mov  ah, 0ch
	mov  cx, 0

	tbdr_lp:
		mov  bx, 0
		mov  dx, 0
		int  10h
		inc  dx
		int  10h
		inc  dx
		int  10h
		mov  dx, di
		dec  dx
		int  10h
		dec  dx
		int  10h
		dec  dx
		int  10h
		inc  cx
		cmp  cx, si
		jle  tbdr_lp
		
	mov  dx, 0
	bbdr_lp:
		mov  bx, 0
		mov  cx, 0
		int  10h
		inc  cx
		int  10h
		inc  cx
		int  10h
		mov  cx, si
		dec  cx
		int  10h
		dec  cx
		int  10h
		dec  cx
		int  10h
		inc  dx
		cmp  dx, di
		jle  bbdr_lp

pop  dx
pop  cx
pop  bx
pop  ax
pop  bp

ret 6

draw_border endp


;------------------
;- Draws a circle -
;------------------

draw_circle	proc	near

push bp
mov  bp, sp
push ax
push bx
push cx
push dx

	mov	 si, word ptr 10[bp]	; x_center
	mov	 di, word ptr 8[bp]		; y_center
	mov	 bx, word ptr 6[bp]		; radius
	mov  c_rad, bx
	mov  ax, -2
	imul c_rad
	inc  ax
	mov  c_a, ax
	mov  bx, 1
	mov  c_b, bx
	mov  bx, 0
	mov  c_y, bx
	mov  c_f, bx
	mov	 ax, word ptr 4[bp]		; color
	mov  ah, 0ch

	crl_lp:
		mov  dx, si
		add  dx, c_rad
		mov  d_high, dx
		mov  cx, di
		add  cx, c_y
		int  10h
		mov  dx, si
		sub  dx, c_rad
		mov  d_low, dx
		mov  cx, di
		sub  cx, c_y
		int  10h
		lline_lp:
			inc  d_low
			mov  dx, d_low
			int  10h
			cmp  dx, d_high
			jl   lline_lp
		mov  dx, si
		add  dx, c_rad
		mov  cx, di
		sub  cx, c_y
		mov  d_high, dx
		int  10h
		mov  dx, si
		sub  dx, c_rad
		mov  cx, di
		add  cx, c_y
		mov  d_low, dx
		int  10h
		rline_lp:
			inc  d_low
			mov  dx, d_low
			int  10h
			cmp  dx, d_high
			jl   rline_lp
		
		mov  dx, 0
		mov  dx, c_f
		cmp  dx, c_rad
		jle  cir_f
		mov  dx, 0
		dec  c_rad
		mov  dx, c_f
		add  dx, c_a
		mov  c_f, dx
		mov  dx, 0
		mov  dx, c_a
		add  dx, two
		mov  c_a, dx
		jmp  endc_f
		cir_f:
			mov  dx, 0
			inc  c_y
			mov  dx, c_f
			add  dx, c_b
			mov  c_f, dx
			mov  dx, 0
			mov  dx, c_b
			add  dx, three
			mov  c_b, dx
		endc_f:
		cmp  c_rad, 0
		jle  end_clp
		jmp  crl_lp
		
end_clp:

pop  dx
pop  cx
pop  bx
pop  ax
pop  bp

ret 8

draw_circle endp

; Note, use end with no entry point.
end
