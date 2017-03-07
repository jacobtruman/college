;   Jacob Truman Section 02
;   Assignment 1


.model medium
.486


; ----------------------------------------------
          
.data
	nm1	dw	19
	nm2	dw	7
	an1	dw	?
	an2	dw	?
	an3	dw	?
	an4	dw	?
	re4	dw	?

; ----------------------------------------------

.stack

.code

main proc far
	mov  ax, @data
	mov  ds, ax

; -----
;	Example addition.
;	Calculate:   an1 = nm1 + nm2

	mov	ax, nm1
	add	ax, nm2
	mov	an1, ax

; -----
;	Example subtraction.
;	Calculate:   an2 = nm1 - nm2

	mov	ax, nm1
	sub	ax, nm2
	mov	an2, ax

; -----
;	Example multiplication.
;	Calculate:   an3 = nm1 * nm2

	mov	ax, nm1
	imul	nm2
	mov	an3, ax

; -----
;	Example division.
;	Calculate:   ans = nm1 / nm2

	mov	ax, nm1
	cwd
	idiv	nm2
	mov	an4, ax
	mov	re4, dx


; -----
;	Done, terminate program.

last:
	mov  ah, 4ch
	int  21h
main endp

end main

