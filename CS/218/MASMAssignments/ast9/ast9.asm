;   Jacob Truman Section 02
;   Assignment 9


.model small
.486

;  Note, any locally used temporary
;  variables should be defined here.

.data

;-------------
;- Constants -
;-------------

LF	equ	10			; line feed
CR	equ	13			; carridge return
END_STR	equ	"$"			; end of string

newline	db	CR, LF, END_STR

ok_fl		db	?
num			dw	?
tmp_time	db	?, ?, ?
ten			dw	10
bten		db	10
seven		db	7
dayn		db	?
print_time	db	?, ?, ":", ?, ?, ":", ?, ?, ?, "m", CR, LF, END_STR


daylst		dw	"Su", "Mo", "Tu", "We", "Th", "Fr", "Sa"


;------------------- BUFFERS BEGIN -------------------

; Race Name buffer
rn_buff		db	21
rn_rd		db	?
rn_chrd		db	21 dup (?)

; Race Start Day buffer
rd_buff		db	3
rd_rd		db	?
rd_chrd		db	3 dup (?)

; Race Starts Time buffer
rt_buff		db	9
rt_rd		db	?
rt_chrd		db	9 dup (?)

; Race Length buffer
rl_buff		db	9
rl_rd		db	?
rl_chrd		db	9 dup (?)

;-------------------- BUFFERS END --------------------

;---------------------------------------------------
;- String definitions for read_race_info procedure -
;------------------ STRINGS BEGIN ------------------

pm_rnam		db	" Enter Race Name: ", END_STR
pm_rstd		db	" Enter Race Start Day"
		db	" (Su/Mo/Tu/We/Th/Fr/Sa): ", END_STR
pm_rsttm	db	" Enter Race Start Time (hh:mm:ss): ", END_STR
pm_rlen		db	" Enter Race Length (hh:mm:ss): ", END_STR

err_r_name	db	CR, LF, " *Error, must enter race name "
		db	"(4 char min).", CR, LF
		db	"  Please re-enter.", CR, LF, END_STR
err_r_stday	db	CR, LF, " *Error, must enter valid day"
		db	" (Su/Mo/Tu/We/Th/Fr/Sa): ", CR, LF
		db	"  Please re-enter.", CR, LF, END_STR
err_r_sttm	db	CR, LF, " *Error, must enter valid race start "
		db	"time (hh:mm:ss):", CR, LF
		db	"  Please re-enter.", CR, LF, END_STR
err_r_len	db	CR, LF, " *Error, must enter valid race length "
		db	"time (hh:mm:ss):", CR, LF
		db	"  Please re-enter.", CR, LF, END_STR


;---------------------------------------------------
;- String definitions for disp_race_info procedure -
;---------------------------------------------------

race_hdr	db	CR, LF, "------------------------------------"
		db	CR, LF, "Race Information:"
		db	CR, LF, CR, LF, END_STR

r_title1	db	" Race Name       : ", END_STR
r_title2	db	" Race Start Time : ", END_STR
r_title3	db	" Race End Time   : ", END_STR

days		db	"Sunday, $   "
		db	"Monday, $   "
		db	"Tuesday, $  "
		db	"Wednesday, $"
		db	"Thursday, $ "
		db	"Friday, $   "
		db	"Saturday, $ "
days_size	db	12

;------------------- STRINGS END -------------------


.code

read_race_info	proc	near

;-----------------------------------------------------
;- Print prompt for Race Name                        -
;- Get user input (1 line, min 4 chars, max 20 char) -
;-----------------------------------------------------

push bp
mov  bp, sp

push ax
push bx
push cx
push dx
push si
push di
push ds
push es

name_lp:

lea  ax, pm_rnam
push ax
lea  ax, rn_buff
push ax
call gprompt

	mov  cx, 3
	mov  ax, 0
	mov  al, rn_rd
	cmp  ax, cx 
	jle   name_er
	mov  ax, 0
	mov  al, rn_rd
	mov  si, ax
	lea  bx, rn_chrd
	mov  byte ptr [si][bx], END_STR
	inc  rn_rd
	jmp  name_end
	
name_er:
	mov	ah, 09h
	lea	dx, err_r_name
	int	21h
	
	jmp name_lp
name_end:

lea  si, rn_chrd	; Set DS:SI
mov  ax, ds
mov  es, ax
mov  di, word ptr 10[bp]	; Set ES:DI
mov  cx, 0
mov  cl, rn_rd	; Set CX
rep  movsb

mov	ah, 09h
lea	dx, newline
int	21h

;----------------------------------------------------
;- Print prompt for Race Start Day                  -
;- Get user input (1 line, min 2 chars, max 2 char) -
;- Only accepts: (Su/Mo/Tu/We/Th/Fr/Sa)             -
;----------------------------------------------------

day_lp:
lea  ax, pm_rstd
push ax
lea  ax, rd_buff
push ax
call gprompt

	mov  cx, 2
	mov  ax, 0
	mov  al, rd_rd
	cmp  ax, cx
	jl   day_er
	mov  cx, 0
	mov  bx, 0
	mov  ah, rd_chrd
	mov  al, 1[rd_chrd]
	dl_lp:
		cmp  bx, 14
		je   dlp_end
		mov  dx, daylst[bx]
		add  bx, 2
		cmp  ax, dx
		je   day_end
		inc  cx
		jmp  dl_lp
		dlp_end:
	jmp  day_er
	
day_er:
	mov	ah, 09h
	lea	dx, err_r_stday
	int	21h
	
	jmp day_lp
day_end:

mov bx, word ptr 8[bp]	; Set ES:DI
mov byte ptr [bx], cl

mov	ah, 09h
lea	dx, newline
int	21h

;----------------------------------------------------
;- Print prompt for Race Start Time                 -
;- Get user input (1 line, min 8 chars, max 8 char) -
;- Only accepts: (hh:mm:ss)                         -
;----------------------------------------------------

time_lp:
lea  ax, pm_rsttm
push ax
lea  ax, rt_buff
push ax
call gprompt

	mov  cx, 8
	mov  ax, 0
	mov  al, rt_rd
	cmp  ax, cx
	jl   time_er
	
	lea	 bx, rt_chrd
	
	mov  cx, 0			; Check for colons
	mov  ax, 0
	mov  al, 2[bx]
	cmp  al, 3Ah
	jne  time_er
	mov  al, 5[bx]
	cmp  al, 3Ah
	jne  time_er
	
		lea  di, tmp_time
		mov  ax, word ptr bx	; Check Hours
		push ax
		lea	 ax, num
		push ax
		lea  ax, ok_fl
		push ax
		call a_to_i
		cmp  ok_fl, 0
		je   time_er
		cmp  num, 24
		jge   time_er
		mov  ax, 0
		mov  ax, num
		mov  byte ptr [di], al

		add  bx, 3
		mov  ax, word ptr bx	; Check Minutes
		push ax
		lea	 ax, num
		push ax
		lea  ax, ok_fl
		push ax
		call a_to_i
		cmp  ok_fl, 0
		je   time_er
		cmp  num, 59
		jg   time_er
		mov  ax, 0
		mov  ax, num
		mov  byte ptr 1[di], al

		add  bx, 3
		mov  ax, word ptr bx	; Check Seconds
		push ax
		lea	 ax, num
		push ax
		lea  ax, ok_fl
		push ax
		call a_to_i
		cmp  ok_fl, 0
		je   time_er
		cmp  num, 59
		jg   time_er
		mov  ax, 0
		mov  ax, num
		mov  byte ptr 2[di], al

	jmp  time_end
	
time_er:
	mov	ah, 09h
	lea	dx, err_r_sttm
	int	21h
	
	jmp time_lp
time_end:

lea si, tmp_time	; Set DS:SI
mov ax, ds
mov es, ax
mov di, word ptr 6[bp]	; Set ES:DI
mov cx, 0
mov cl, 3	; Set CX
rep movsb

mov	ah, 09h
lea	dx, newline
int	21h

;----------------------------------------------------
;- Print prompt for Race Length                     -
;- Get user input (1 line, min 8 chars, max 8 char) -
;- Only accepts: (hh:mm:ss)                         -
;----------------------------------------------------

len_lp:
lea  ax, pm_rlen
push ax
lea  ax, rl_buff
push ax
call gprompt

	mov  cx, 8
	mov  ax, 0
	mov  al, rl_rd
	cmp  ax, cx
	jl   len_er
	
	lea	 bx, rl_chrd
	
	mov  cx, 0			; Check for colons
	mov  ax, 0
	mov  al, 2[bx]
	cmp  al, 3Ah
	jne  len_er
	mov  al, 5[bx]
	cmp  al, 3Ah
	jne  len_er
	
		lea  di, tmp_time
		mov  ax, word ptr bx	; Check Hours
		push ax
		lea	 ax, num
		push ax
		lea  ax, ok_fl
		push ax
		call a_to_i
		cmp  ok_fl, 0
		je   len_er
		cmp  num, 99
		jg   len_er
		mov  ax, 0
		mov  ax, num
		mov  byte ptr [di], al

		add  bx, 3
		mov  ax, word ptr bx	; Check Minutes
		push ax
		lea	 ax, num
		push ax
		lea  ax, ok_fl
		push ax
		call a_to_i
		cmp  ok_fl, 0
		je   len_er
		cmp  num, 59
		jg   len_er
		mov  ax, 0
		mov  ax, num
		mov  byte ptr 1[di], al

		add  bx, 3
		mov  ax, word ptr bx	; Check Seconds
		push ax
		lea	 ax, num
		push ax
		lea  ax, ok_fl
		push ax
		call a_to_i
		cmp  ok_fl, 0
		je   len_er
		cmp  num, 59
		jg   len_er
		mov  ax, 0
		mov  ax, num
		mov  byte ptr 2[di], al

	jmp  len_end
	
len_er:
	mov	ah, 09h
	lea	dx, err_r_len
	int	21h
	
	jmp len_lp
len_end:

lea si, tmp_time	; Set DS:SI
mov ax, ds
mov es, ax
mov di, word ptr 4[bp]	; Set ES:DI
mov cx, 0
mov cl, 3	; Set CX
rep movsb

mov	ah, 09h
lea	dx, newline
int	21h

pop  es
pop  ds
pop  di
pop  si
pop  dx
pop  cx
pop  bx
pop  ax
pop  bp

ret 8

read_race_info endp


;-------------------------------------------------------------------
;- CALCULATE END TIME, GIVEN THE LENGTH AND THE START DAY AND TIME -
;- Arguments passed:                                               -
;- r_start_day (address) 12                                        -
;- r_start_time (address) 10                                       -
;- r_len (address) 8                                               -
;- r_end_day (address) 6                                           -
;- r_end_time (address) 4                                          -
;-------------------------------------------------------------------

calc_end_time	proc	near

push bp
mov  bp, sp

push ax
push bx
push cx

mov  cx, 0

mov  ax, 0
mov  bx, word ptr 10[bp]		; get start time seconds
mov  al, byte ptr 2[bx]
mov  bx, word ptr 8[bp]			; get len seconds
add  al, byte ptr 2[bx]
cmp  ax, 60
jge  sub_sec
jmp  add_min

sub_sec:
	sub  ax, 60
	inc  cx

add_min:
mov  bx, word ptr 4[bp]
mov  byte ptr 2[bx], al			; set end time seconds

mov  bx, word ptr 10[bp]		; get start time minutes
add  cl, byte ptr 1[bx]
mov  bx, word ptr 8[bp]			; get len minutes
add  cl, byte ptr 1[bx]
mov  ax, 0
cmp  cx, 60
jge  sub_min
jmp  add_hr

sub_min:
	sub  cx, 60
	inc  ax

add_hr:
mov  bx, word ptr 4[bp]
mov  byte ptr 1[bx], cl			; set end time minutes

mov  bx, word ptr 10[bp]		; get start time hours
add  al, byte ptr [bx]
mov  bx, word ptr 8[bp]			; get len hours
add  al, byte ptr [bx]
mov  cl, 24
div  cl

mov  bx, word ptr 4[bp]
mov  byte ptr [bx], ah			; set end time hours
mov  ah, 0
div  seven

mov  bx, word ptr 12[bp]		; get start day
add  ah, byte ptr [bx]
cmp  ah, 7
jge  nxt_wk
jmp  set_eday

nxt_wk:
	mov  al, ah
	mov  ah, 0
	div  seven

set_eday:
	mov  bx, word ptr 6[bp]
	mov  byte ptr [bx], ah			; set end day

pop  cx
pop  bx
pop  ax
pop  bp

ret 10
calc_end_time endp


;----------------------------
;- DISPLAY RACE INFO        -
;- Arguments passed:        -
;- r_name (address) 12      -
;- r_start_day (address) 10 -
;- r_start_time (address) 8 -
;- r_end_day (address) 6    -
;- r_end_time (address) 4   -
;----------------------------

disp_race_info	proc	near

push bp
mov  bp, sp

push ax
push bx
push dx
push si


	mov	 ah, 09h
	lea	 dx, race_hdr
	int	 21h

	mov	 ah, 09h
	lea	 dx, r_title1
	int	 21h
	
	mov  dx, 0
	mov  bx, word ptr 12[bp]		; get race name	
	mov	 ah, 09h
	lea	 dx, byte ptr [bx]
	int	 21h
	
	mov	 ah, 09h
	lea	 dx, newline
	int	 21h
	
	mov	 ah, 09h
	lea	 dx, r_title2
	int	 21h
	
	mov  dx, 0
	mov  bx, word ptr 10[bp]		; get race start day
	mov  ax, 0
	mov  al, byte ptr [bx]
	mul  days_size
	mov  si, ax
	lea  bx, days
	
	mov	 ah, 09h
	lea	 dx, byte ptr [si][bx]
	int	 21h
	
	mov  bx, word ptr 8[bp]		; get race start time
	mov  ax, 0
	mov  al, byte ptr [bx]
	cmp  al, 12
	jl  set_low
	mov  8[print_time], "p"
	cmp  al, 12
	je   set_high
	sub  al, 12
	jmp  set_high
	set_low:
		mov  8[print_time], "a"
		cmp  al, 0
		jne  set_high
		mov  al, 12
	set_high:
		mov  ah, 0
		div  bten
		add  al, 30h
		add  ah, 30h
	mov  [print_time], al
	mov  1[print_time], ah
	
	mov  ax, 0
	mov  al, byte ptr 1[bx]
		div  bten
		add  al, 30h
		add  ah, 30h
	mov  3[print_time], al
	mov  4[print_time], ah
	
	mov  ax, 0
	mov  al, byte ptr 2[bx]
		div  bten
		add  al, 30h
		add  ah, 30h
	mov  6[print_time], al
	mov  7[print_time], ah

	mov	 ah, 09h
	lea	 dx, print_time
	int	 21h
	
	mov	 ah, 09h
	lea	 dx, r_title3
	int	 21h
	
	mov  dx, 0
	mov  bx, word ptr 6[bp]		; get race end day
	mov  ax, 0
	mov  al, byte ptr [bx]
	mul  days_size
	mov  si, ax
	lea  bx, days
	
	mov	 ah, 09h
	lea	 dx, byte ptr [si][bx]
	int	 21h
	
	mov  bx, word ptr 4[bp]		; get race end time
	mov  ax, 0
	mov  al, byte ptr [bx]
	cmp  al, 12
	jl   set_elow
	mov  8[print_time], "p"
	cmp  al, 12
	je   set_ehigh
	sub  al, 12
	jmp  set_ehigh
	set_elow:
		mov  8[print_time], "a"
		cmp  al, 0
		jne  set_ehigh
		mov  al, 12
	set_ehigh:
		mov  ah, 0
		div  bten
		add  al, 30h
		add  ah, 30h
	mov  [print_time], al
	mov  1[print_time], ah
	
	mov  ax, 0
	mov  al, byte ptr 1[bx]
		div  bten
		add  al, 30h
		add  ah, 30h
	mov  3[print_time], al
	mov  4[print_time], ah
	
	mov  ax, 0
	mov  al, byte ptr 2[bx]
		div  bten
		add  al, 30h
		add  ah, 30h
	mov  6[print_time], al
	mov  7[print_time], ah
	
	mov	 ah, 09h
	lea	 dx, print_time
	int	 21h

pop  si
pop  ax
pop  bx
pop  dx
pop  bp

ret 10
disp_race_info endp


;--------------------------------------------------------
;- PROMPT FOR INFORMATION AND STORE IT IN PASSED BUFFER -
;- Arguments passed:                                    -
;- Prompt string (address) 6                            -
;- Buffer (addresses) 4                                 -
;--------------------------------------------------------

gprompt	proc	near
	push bp
	mov  bp, sp
	push ax
	push bx
	push dx

	mov  bx, 0
	mov	 bx, word ptr 6[bp]

	mov	ah, 09h
	lea	dx, byte ptr [bx]
	int	21h

	mov	bx, word ptr 4[bp]
	
	mov	ah, 0ah
	lea	dx, byte ptr [bx]
	int	21h

	pop  dx
	pop  bx
	pop  ax
	pop  bp

	ret  4
gprompt endp


;----------------------------------------------------------------
;- Procedure "a_to_i", to convert an ASCII string to an integer -
;----------------------------------------------------------------

;  Arguments passed:
;	string (address) 16
;	integer (address) 14
;	ok_fl (address) 12

a_to_i	proc	near
	push	ax
	push	bx
	push	cx
	push	dx
	push	bp
	mov	bp, sp

	mov	bx, word ptr 12[bp]		; get ok_fl address
	mov	word ptr [bx], 1		; assume ok.

	mov	bx, word ptr 16[bp]		; string address
	mov	ax, 0

a_lp:	mov	cl, byte ptr [bx]
	cmp	cl, CR				; done?
	je	a_lp_done
	cmp	cl, 3Ah				; done?
	je	a_lp_done

	cmp	cl, "0"				; is valid?
	jl	was_bad
	cmp	cl, "9"
	jg	was_bad

	sub	cl, 30h				; sub "0"
	mov	ch, 0

	imul	ten				; mult sum by 10
	add	ax, cx				; add to sum
	inc	bx
	jmp	a_lp

was_bad:
	mov	bx, word ptr 12[bp]		; ok_flag address
	mov	word ptr [bx], 0		; set ok_flag to false
	mov	ax, 0

a_lp_done:
	mov	bx, word ptr 14[bp]
	mov	word ptr [bx], ax

	pop	bp
	pop	dx
	pop	cx
	pop	bx
	pop	ax
	ret	6
a_to_i	endp

; Note, use end with no entry point.
end
