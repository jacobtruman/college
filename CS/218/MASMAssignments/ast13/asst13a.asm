;---------------------------
;- Jacob Truman Section 02 -
;- Assignment 13           -
;---------------------------

text    segment public  'CODE'

assume  cs:text, ds:text, es:text, ss:text

       org     100h
start:
       jmp     init


;---------------------------------------------------
; interrupt service routine - timer interrupt.

tm_chk  proc    far

push ax
push bx

;     if sw_on:
cmp  cs:sw_on, TRUE
jne  exit_tm
inc  cs:tick_cnt
cmp  cs:tick_cnt, 18    ; check 1 sec (18.2 interupts per sec)
jne  exit_tm
mov  cs:tick_cnt, 0
; update elapsed time


lea  bx, cs:ela_time
mov  al, byte ptr 4[bx]
sub  al, 30h
mul  cs:ten
mov  ah, al
mov  al, byte ptr 3[bx]
sub  al, 30h
add  al, ah
mov  ah, 0
inc  al
cmp  al, 60
jne  next1
jmp  next2

next1:
div  cs:ten
jmp  end_stup

next2:
mov  ax, 0

end_stup:
add  ah, 30h
add  al, 30h
mov  byte ptr [bx], al
mov  byte ptr 1[bx], ah

mov  al, byte ptr 1[bx]
sub  al, 30h
mul  cs:ten
mov  ah, al
mov  al, byte ptr [bx]
sub  al, 30h
add  al, ah
mov  ah, 0
inc  al
cmp  al, 99
jne  next3
jmp  next4

next3:
div  cs:ten
jmp  end_htup

next4:
mov  ax, 0

end_htup:
add  ah, 30h
add  al, 30h
mov  byte ptr [bx], al
mov  byte ptr 1[bx], ah

call disp_times

exit_tm:
pop  bx
pop  ax
       iret
tm_chk  endp



;---------------------------------------
key_chk proc    far

; - get key scan code
; - check for f9, f10, f11, f12
;       f9 - toggle sw_on/sw_off
;       f10 - if sw_off, jmp disp_tm
;       f11 - if sw_off, reset times
;       f12 - if sw_off, de-install
; F9  - 43h
; F10 - 44h
; F11 - 57h
; F12 - 58h

push ax
push bx
push cx
push dx
push es
push ds

cli                             ; stop interupts
in   al, 60h    ; get scan code
sti                             ; start interupts

cmp  al, 43h
je   is_f9
cmp  al, 44h
je   is_f10
cmp  al, 57h
je   is_f11
cmp  al, 58h
je   is_f12

jmp  exit_key

is_f9:

neg  cs:sw_on
cmp  cs:sw_on, TRUE
jne  exit_key

call init_times
jmp  disp_tm

is_f10:

call init_times
jmp  exit_key

is_f11:

cmp  cs:sw_on, TRUE
je   exit_key
call disp_times
jmp  exit_key

is_f12:

mov  ax, cs
mov  ds, ax
mov  ds, word ptr cs:psp
mov  es, ds:[2ch]
mov  ah, 49h
int  21h

mov  ax, word ptr cs:psp
mov  es, ax
mov  ah, 49h
int  21h

mov  ax, cs:old09_seg
mov  ds, ax
mov  ah, 25h
mov  al, 09h
mov  dx, word ptr cs:old09_off
int  21h

mov  ax, cs:old1c_seg
mov  ds, ax
mov  ah, 25h
mov  al, 1ch
mov  dx, word ptr cs:old1c_off
int  21h

jmp  end_key

disp_tm:
;-------------------------------------------
;- set stack, call disp_times, reset stack -
;-------------------------------------------

       mov     word ptr cs:old_sp, sp
       mov     word ptr cs:old_ss, ss
       mov     ax, cs
       cli
       mov     ss, ax
       mov     sp, offset cs:stk_top
       sti

       call disp_times

       cli
       mov     ss, word ptr cs:old_ss
       mov     sp, word ptr cs:old_sp
       sti

;--------
;- Exit -
;--------
exit_key:
       cli
       mov  al, 20h
       out  20h, al
       sti

end_key:

pop  ds
pop  es
pop  dx
pop  cx
pop  bx
pop  ax

;-----------------------------
;- do original 09h interrupt -
;-----------------------------
       jmp dword ptr cs:old09

       iret
key_chk endp


init_times      proc    near
;----------------
;- Get the time -
;----------------
       mov     ah, 02h
       int     1ah

;------------------------------------------------------
;- Loop to:                                           -
;- Get hour, convert to ascii and mov to msg the time -
;- Get min, convert to ascii and mov to msg the time  -
;- Get sec, convert to ascii and mov to msg the time  -
;------------------------------------------------------
mov  si, 0              ; starting location for numbers

tm_lp:
       mov  al, ch
       cmp  si, 0
       je   tm_next
       mov  al, cl
       cmp  si, 3
       je   tm_next
       mov  al, dh
       tm_next:
       cbw
       mov  bl, 10h
       idiv bl
       add  ah, 30h
       add  al, 30h
       lea  bx, cs:ini_time
       mov  byte ptr [si][bx], al              ; mov to ini_time string
       inc  si
       mov  byte ptr [si][bx], ah              ; mov to ini_time string
       inc  si
       cmp  si, 8
       je   end_tmlp
       mov  byte ptr [si][bx], ":"             ; mov to ini_time string
       inc  si
       jmp  tm_lp
       end_tmlp:

;------------------------------------
;- Initialize Elapsed time to 00:00 -
;------------------------------------
       lea  bx, cs:ela_time
       mov al, 30h
       mov  byte ptr 4[bx], al         ; mov to ela_time string
       inc  si
       mov  byte ptr 3[bx], al         ; mov to ela_time string
       inc  si
       mov  byte ptr 2[bx], ":"        ; mov to ela_time string
       inc  si
       mov  byte ptr 1[bx], al         ; mov to ela_time string
       inc  si
       mov  byte ptr [bx], al          ; mov to ela_time string

ret
init_times endp


;---------------------------------------

disp_times     proc near

; routine to display times
;  - convert times to ASCII
;  - get/save cursor position
;  - use "int 10h" to display times
;  - restore cursor position

push bp
mov  bp, sp
push ax
push bx
push cx
push dx
push si
push es

;----------------------------------------------------------
;- Get video parameters and save the current display page -
;----------------------------------------------------------
       mov  ah, 0fh
       int  10h
       mov  cs:dis_page, bh

;----------------------------------------
;  Get current cursor position and save -
;----------------------------------------
       mov  ah, 03h
       mov  bh, cs:dis_page
       int  10h
       mov  cs:old_row, dh
       mov  cs:old_col, dl

;---------------------------------------------
;- Set new cursor position to initial values -
;---------------------------------------------
       mov  ah, 02h
       mov  dh, INIT_ROW
       mov  dl, INIT_COL
       mov  bh, cs:dis_page
       int  10h

;---------------------------
;- Output the initial time -
;---------------------------
       push es
       push cs
       pop  es
       mov  bp, offset cs:ini_str
       mov  ah, 13h
       mov  al, 1
       mov  bh, cs:dis_page
       mov  bl, 0fh                    ; Set text color
       mov  cx, cs:ini_slen
       mov  dh, INIT_ROW
       add  dh, 1
       mov  dl, INIT_COL
       int  10h
       pop  es

       mov  bp, offset cs:ini_time
       mov  ah, 13h
       mov  al, 1
       mov  bh, cs:dis_page
       mov  bl, 0fh                    ; Set text color
       mov  cx, cs:ini_len
       int  10h

       inc  dh
       mov  dl, INIT_COL

;---------------------------
;- Output the elapsed time -
;---------------------------
       push es
       push cs
       pop  es
       mov  bp, offset cs:ela_str
       mov  ah, 13h
       mov  al, 1
       mov  bh, cs:dis_page
       mov  bl, 0fh                    ; Set text color
       mov  cx, cs:ela_slen
       int  10h
       pop  es

       mov  bp, offset cs:ela_time
       mov  ah, 13h
       mov  al, 1
       mov  bh, cs:dis_page
       mov  bl, 0fh                    ; Set text color
       mov  cx, cs:ela_len
       int  10h

;-------------------------------
;- Restore old cursor position -
;-------------------------------
       mov  ah, 02h
       mov  dh, cs:old_row
       mov  dl, cs:old_col
       mov  bh, cs:dis_page
       int  10h

pop  es
pop  si
pop  dx
pop  cx
pop  bx
pop  ax
pop  bp

       ret
disp_times endp



;---------------------------------------

reset_times    proc near

; reset initial time and set elapsed time=0.

       ret
reset_times    endp


;-----------------------------------------------------
; interrupt handler requires data located in cs.
; requires use of "cs:" to over-ride DS usage.

CR                      equ     13
LF                      equ     10
END_STR         equ     "$"

TRUE            equ     1
FALSE           equ     -1
psp                     dw      ?
sw_on           db      -1
INIT_ROW        equ     1                       ; starting position
INIT_COL        equ     60
dis_page        db      0
old_row         db      0
old_col         db      0
ini_str         db      "Initial:  "
ini_time        db      "00:00:00"
ini_slen        dw      10
ini_len         dw      8
ela_str         db      "Elapsed:     "
ela_time        db      "00:00"
ela_slen        dw      13
ela_len         dw      5
ten                     db      10

stk_bot         dw      99 dup(?)
stk_top         dw      ?
old_ss          dw      0
old_sp          dw      0
tick_cnt        dw      0

old09   label   dword
old09_off       dw      ?
old09_seg       dw      ?

old1c   label   dword
old1c_off       dw      ?
old1c_seg       dw      ?

prog_end:

inst_msg        db      "Stop Watch Utility Installed - by Jacob Truman"
                       db      CR, LF
                       db      "F9 Stop/Stop,  F10 Reset,  F11 Display,  F12 Remove"
                       db      CR, LF, END_STR

unin_msg        db      "Stop Watch Utility Un-Installed - by Jacob Truman"
                       db      CR, LF, END_STR

; Note, the label "prog_end" indicates the
; end "memory resident" code.


;-----------------------------------------------------
; initialization:
; must initialize the interrupt vectors for the
; interrupt handler.  then, terminate the
; program leaving the interrupt handler code
; and data  resident in memory.
; note, can use DOS int 21h functions here.

init:
; * get/set initial time
; * get/save old interupts (09h, 1ch)
; * set IVT with new addresses
; * display installation message
; * terminate and stay resident

mov  ah, 51h                            ; get PSP addr
int  21h
mov  psp, bx
mov  ax, psp
mov  es, ax                                     ; set ES to PSP addr

mov  ah, 35h    ; get whats in the IVT
mov  al, 09h
int  21h

mov  word ptr cs:old09_seg, es          ; save whats in the IVT
mov  word ptr cs:old09_off, bx

mov  ax, cs
mov  ds, ax
mov  ah, 25h
mov  al, 09h
mov  dx, offset cs:key_chk
int  21h

mov  ah, 35h    ; get whats in the IVT
mov  al, 1ch
int  21h

mov  word ptr cs:old1c_seg, es          ; save whats in the IVT
mov  word ptr cs:old1c_off, bx

mov  ax, cs
mov  ds, ax
mov  ah, 25h
mov  al, 1ch
mov  dx, offset cs:tm_chk
int  21h

mov  ax, cs
mov  ds, ax
mov  ah, 09h
lea  dx, cs:inst_msg
int  21h

mov  ah, 31h
mov  dx, offset cs:prog_end
mov  cl, 4
shr  dx, cl
inc  dx
int  21h

text     ends
end     start

; note, must use an explicit entry point
;---------------------------------------------------