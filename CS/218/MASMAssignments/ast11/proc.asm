;- Jacob Truman Section 02 -
;- Assignment 11           -
;---------------------------

.model small
.486

;--------
;- Data -
;--------
.data

;-------------
;- Constants -
;-------------

CR			equ	13			; ASCII carrige return
LF			equ	10			; ASCII line feed
END_STR		equ	"$"			; Service 09, string term

;-------------------
;- Other Variables -
;-------------------
psp		dw	?
ten		dw	10
bten		db	10
len		db	0
chrs	db	80 dup (?)
mydta  	db	21 dup(?)
f_att	db	?			; Attribute of file found
f_time	dw	?			; Time stamp of file
f_date	dw	?			; Date stamp of file
f_size	dd	?			; file size in bytes
f_name	db	13 dup (?)		; file name and ext
f_hand	dw	?

year	dw	0
month	dw	0
date	dw	0

;-----------
;- Strings -
;-----------

; file name and ext print string
print_name	db	20 dup (?)
			db	?, END_STR

; print date print string
print_date	db	?, ?, "/", ?, ?, "/", ?, ?, ?, ?, END_STR
newline		db	CR, LF, END_STR


msg1	db	CR, LF, "Invalid command line argument"
		db	CR, LF, END_STR
msg2	db	CR, LF, "Error when opening file"
		db	CR, LF, END_STR

;--------
;- Code -
;--------
.code

;--------------------------------
;- Get command line information -
;--------------------------------

get_cli	proc	near
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
	mov	es, ax					; set ES to PSP addr

	mov	al, byte ptr es:0080h	; number of chars entered

	cmp	al, 0					; if 0 entered, print a message
	jle	do_no_msg

	lea	bx, chrs
	mov	si, 81h
	
spaces_lp:
	mov  al, byte ptr es:[si]
	cmp  al, 20h	; space
	jne  chk_slash
	jmp  spaces_next
		chk_slash:
			cmp  al, 2fh		; check for /
			je   chk_let
			jmp  do_no_msg
		chk_let:
			inc  si
			mov  al, byte ptr es:[si]
			cmp  al, 76h		; check for v
			je   chk_spc
			cmp  al, 73h		; check for s
			je   chk_spc
			jmp  do_no_msg
		chk_spc:
			mov  bx, word ptr 4[bp]
			mov	 byte ptr [bx], al
			inc  si
			mov  al, byte ptr es:[si]
			cmp  al, 20h		; check for space
			je   chk_spcs
			jmp  do_no_msg

		spaces_next:
	inc	 si
	jmp  spaces_lp
	
	chk_spcs:
		mov  al, byte ptr es:[si]
		cmp  al, 20h			; check for space
		jne  end_spcs
		inc  si
		jmp  chk_spcs

end_spcs:

;-----------------------------------
;- Copy chars to the data segement -
;-----------------------------------

	mov  bx, word ptr 6[bp]
	cp_chars:
		mov  al, byte ptr es:[si]
		cmp  al, CR
		je   end_get_arg
		mov	 byte ptr [bx], al
		inc  len
		inc  bx
		inc  si  
		jmp  cp_chars

	jmp	end_get_arg				; done...


;-----------------------------------------------------------
;- No characters entered on command line, so print message -
;-----------------------------------------------------------

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

ret  4

get_cli	endp


;------------------------------------
;- Get, display, and set file dates -
;------------------------------------

disp_files	proc	near
push bp
mov  bp, sp
push ax
push bx
push cx
push dx
push si

mov ah, 1ah
lea dx, mydta
int 21h

mov	ah, 4eh
mov	cx, 0
mov dx, word ptr 6[bp]
int	21h
jc err_on_open

get_next:

;------------
;- Get year -
;------------
	mov	 ax, f_date
	mov	 cl, 9
	shr	 ax, cl
	add	 ax, 1980
	mov	 year, ax
		div  bten
		add  al, 30h
		add  ah, 30h
	mov  9[print_date], ah		; move 4th digit of yr to print str
		mul  bten
		div  bten
		add  al, 30h
		add  ah, 30h
	mov  8[print_date], ah		; move 3rd digit of yr to print str
		mul  bten
		div  bten
		add  al, 30h
		add  ah, 30h
	mov  7[print_date], ah		; move 2nd digit of yr to print str
		mul  bten
		div  bten
		add  al, 30h
		add  ah, 30h
	mov  6[print_date], ah		; move 1st digit of yr to print str
	
;-------------
;- Get month -
;-------------
	mov	 ax, f_date
	mov	 cl, 5
	shr	 ax, cl
	and	 ax, 000fh
	mov	 month, ax
		div  bten
		add  al, 30h
		add  ah, 30h
	mov  [print_date], al		; move 1st digit of date to print str
	mov  1[print_date], ah		; move 2nd digit of date to print str

;------------
;- Get date -
;------------
	mov	 ax, f_date
	and	 ax, 001fh
	mov	 date, ax
		div  bten
		add  al, 30h
		add  ah, 30h
	mov  3[print_date], al		; move 1st digit of mon to print str
	mov  4[print_date], ah		; move 2nd digit of mon to print str

;-------------
;- open file -
;-------------
	mov  ah, 3dh
	mov  al, 2
	lea  dx, f_name
	int  21h
	jc   err_on_open
	mov  f_hand, ax   ; file handle
	
	lea  bx, f_name
	mov  si, 0
	nm_lp:
		mov  al, byte ptr[si][bx]
		mov  [si][print_name], al	; move name to print string
		inc  si
		cmp  al, 0
		je   nm_end
		jmp  nm_lp
		
;---------------------------------------------
;- Print name and date depending on /s or /v -
;---------------------------------------------
	nm_end:		
		mov	 ah, 09h
		lea	 dx, print_name
		int	 21h

		mov dx, word ptr 4[bp]
		cmp  dx, 73h
		je   skp_dt
		mov	 ah, 09h
		lea	 dx, print_date
		int	 21h
		skp_dt:
		
		mov	 ah, 09h
		lea	 dx, newline
		int	 21h

;-------------
;- Get today -
;-------------
	mov ah, 2ah
	int 21h

;------------
;- Set year -
;------------
	mov ax, 0
	sub cx, 1980
	shl cx, 9   			; shift left 9 places
	or  ax, cx

;-------------
;- Set month -
;-------------
	mov cx, 0
	mov cl, dh
	shl cx, 5   			; shift left 5 places
	or  ax, cx
	mov dh, 0
	or  ax, dx

;------------
;- Set date -
;------------
	mov dx, ax
	mov ah, 57h
	mov al, 1
	mov bx, f_hand
	mov cx, f_time
	int 21h
	jc err_on_open

mov ah, 3eh   ; close file
mov bx, f_hand
int 21h

;-------------
;- find next -
;-------------
	mov ah, 4fh
	int 21h
	jc f_done
	jmp get_next

err_on_open:
	mov	ah, 09h
	lea	dx, msg2
	int	21h

	mov	ah, 4ch
	int	21h
	
f_done:				; done...

pop  si
pop  dx
pop  cx
pop  bx
pop  ax
pop  bp

ret  4

disp_files	endp


; Note, use end with no entry point.
end
