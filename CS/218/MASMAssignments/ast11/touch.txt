;  CSC218
;  Assignmnet #11 - Provided Main

;  Program will read a command line option (/v or /s) and
;  file specification from the command line and update all
;  the files meeting that specification to the current date.

;  The program should display the file name and, based on the
;  option, the file date (before updating) for all files
;  matching the specification from the command line.


; ----------------------------------------------

.model small
.486

; ----------------------------------------------

.data

; -----
; Constants.

CR		equ	13
LF		equ	10
END_STR		equ	"$"


; -----
;  Variables for main routine.

hdr		db	"CSC218 Touch Utility, v1.0"
		db	CR, LF, CR, LF, END_STR

f_spec		db	128 dup (0)
c_option	db	?				; v or s


; ----------------------------------------------

.stack
.code

extrn	get_cli:near
extrn	disp_files:near


; ----------------------------------------------
; Main routine...

main   proc	far
	mov	ax, @data
	mov	ds, ax

; -----
;  Print header.

	mov	ah, 09h
	lea	dx, hdr
	int	21h

; -----
;  Get command line information.

	lea	ax, f_spec
	push	ax
	lea	ax, c_option
	push	ax
	call	get_cli

; -----
;  Get, display, and set file dates.

	lea	ax, f_spec
	push	ax
	mov	al, c_option
	push	ax
	call	disp_files

; -----
;  Done, terminate program.

last:
	mov	ah, 4ch
	int	21h
main	endp

end	main
