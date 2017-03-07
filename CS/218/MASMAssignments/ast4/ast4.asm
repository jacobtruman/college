;   Jacob Truman Section 02
;   Assignment 4


.model medium
.486


; ----------------------------------------------
;	   
.data

  list		dw	14, 45, 42, 43, 75, 34, 46, 22, 56, 63
			dw	17,  5, 26, 40, 65, 11, 54, 28, 13, 22
			dw	11, 25, 65, 12, 90, 22, 11, 29, 15, 24
			dw	17, 24, 80, 17, 24, 25, 16, 62, 18, 92
			dw	32, 35, 64, 15, 10, 65, 54, 67, 15, 56
			dw	22, 21, 56, 27, 27, 27, 82, 65, 55, 35
			dw	25, 19, 34, 45, 67,  5, 61, 35, 56, 53
			dw	32, 35, 64, 15, 10, 65, 54, 67, 15, 56
			dw	92, 25, 25, 12, 25, 17, 98, 77, 75, 34
			dw	23, 83, 73, 50, 15, 35, 25, 18, 13, 25

  lst_len	dw	100
  two		dw	2
  ten		dw	10
  tst		dw	?

  lst_min	dw	?
  lst_max	dw	?
  lst_sum	dw	?
  lst_ave	dw	?

  odd_cnt	dw	?
  odd_sum	dw	?
  odd_ave	dw	?

  ten_cnt	dw	?
  ten_sum	dw	?
  ten_ave	dw	?

; ----------------------------------------------

.stack

.code

main proc far
	mov  ax, @data
	mov  ds, ax

; -----
;	lst_min = list min value

	mov cx, lst_len
	lea bx, list
	mov ax, word ptr [bx]
	mov lst_min, ax
	mov si, 2
	
minend:

	mov lst_min, ax

lmin:

	mov ax, word ptr [si][bx]
	cmp ax, lst_min
	jl minend
	add si, 2

loop lmin

; -----
;	lst_max = list max value

	mov cx, lst_len
	dec cx
	lea bx, list
	mov ax, word ptr [bx]
	mov lst_max, ax
	mov si, 2
	
maxend:

	mov lst_max, ax

lmax:

	mov ax, word ptr [si][bx]
	cmp ax, lst_max
	jg maxend
	add si, 2

loop lmax

; -----
;	lst_sum = list sum

	mov cx, lst_len
	lea bx, list
	mov lst_sum, 0
	mov si, 0

lsum:
		
	mov ax, word ptr [si][bx]
	add lst_sum, ax
	add si, 2
	
loop lsum

; -----
;	lst_ave = list average

	mov ax, lst_sum
	cwd
	div lst_len
	mov lst_ave, ax

; -----
;	odd_cnt = count of odd numbers in list
;	odd_sum = sum of odd numbers in list

	mov cx, lst_len
	lea bx, list
	mov odd_cnt, -1
	mov odd_sum, 0
	mov si, 0
	mov ax, 0

oddend:

	inc odd_cnt
	add odd_sum, ax

lodd:

	mov dx, 0
	mov ax, word ptr [si][bx]
	cwd
	div two
	mov ax, word ptr [si][bx]
	add si, 2
	dec cx
	cmp dx, 0
jg oddend
	cmp cx, 0
jg lodd

; -----
;	odd_ave = average of odd numbers in list

	mov ax, odd_sum
	cwd
	div odd_cnt
	mov odd_ave, ax

; -----
;	ten_cnt = count of nums div by 10
;	ten_sum = sum of nums div by 10

	mov cx, lst_len
	lea bx, list
	mov ten_cnt, -1
	mov si, 0
	mov ax, 0

tenend:

	inc ten_cnt
	add ten_sum, ax

lten:

	mov dx, 0
	mov ax, word ptr [si][bx]
	cwd
	div ten
	mov ax, word ptr [si][bx]
	add si, 2
	dec cx
	cmp dx, 0
je tenend
	cmp cx, 0
jg lten

tenav:

; -----
;	ten_ave = average of nums div by 10

	mov ax, ten_sum
	cwd
	div ten_cnt
	mov ten_ave, ax

; -----
;	Done, terminate program.

last:
	mov  ah, 4ch
	int  21h
main endp

end main

