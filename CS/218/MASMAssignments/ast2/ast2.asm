;   Jacob Truman Section 02
;   Assignment 2


.model medium
.486


; ----------------------------------------------
          
.data
	nm1		dw	25
	nm2		dw	13
	re1		dw	?
	re2		dw	?
	re3		dw	?
	fl1		dd	7.625
	fl2		dd	3.14
	iname	db	"Ed Jorgensen"
	mynam	db	"Jacob Truman"

; ----------------------------------------------

.stack

.code

main proc far
	mov  ax, @data
	mov  ds, ax

; -----
;	Example addition.
;	Calculate:   re1 = nm1 + nm2

	mov	ax, nm1
	add	ax, nm2
	mov	re1, ax

; -----
;	Example subtraction.
;	Calculate:   re2 = nm2 - nm1

	mov	ax, nm2
	sub	ax, nm1
	mov	re2, ax

; -----
;	Example subtraction.
;	Calculate:   re3 = nm1 - nm2

	mov	ax, nm1
	sub	ax, nm2
	mov	re3, ax

; -----
;	Done, terminate program.

last:
	mov  ah, 4ch
	int  21h
main endp

end main

