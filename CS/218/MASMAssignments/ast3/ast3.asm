;   Jacob Truman Section 02
;   Assignment 3


.model medium
.486


; ----------------------------------------------
;	   
.data
	nm1	dw	21
	nm2	dw	12
	nm3	dw	8
	nm4	dw	13
	an1	dw	?
	an2	dw	?
	an3	dw	?
	an4	dw	?
	an5	dw	?
	an6	dw	?
	an7	dw	?
	an8	dw	?

; ----------------------------------------------

.stack

.code

main proc far
	mov  ax, @data
	mov  ds, ax

; -----
;	an1 = nm1 + nm3

	mov	ax, nm1
	add	ax, nm3
	mov	an1, ax

; -----
;	an2 = nm2 + nm4

	mov	ax, nm2
	add	ax, nm4
	mov	an2, ax

; -----
;	an3 = nm1 - nm3

	mov	ax, nm1
	sub	ax, nm3
	mov	an3, ax

; -----
;	an4 = nm2 - nm4

	mov	ax, nm2
	sub	ax, nm4
	mov	an4, ax

; -----
;	an5 = nm1 * nm3

	mov	ax, nm1
	imul	nm3
	mov	an5, ax

; -----
;	an6 = nm2 * nm4

	mov	ax, nm2
	imul	nm4
	mov	an6, ax

; -----
;	an7 = nm1 / nm4

	mov	ax, nm1
	cwd
	idiv	nm4
	mov	an7, ax

; -----
;	an8 = nm4 / nm3

	mov	ax, nm4
	cwd
	idiv	nm3
	mov	an8, ax

; -----
;	Done, terminate program.

last:
	mov  ah, 4ch
	int  21h
main endp

end main

