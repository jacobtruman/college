;  CSC218
;  Assignment #10

; -----
;  PROVIDED MAIN

;  DO NOT EDIT THIS FILE!!
;  Independently assembly this file and link
;   with the file that contains the procedures.

;  Refer to class handouts for details on linking
;  multiple sourse files.


; -----
;  Procedure called by main:

;  * Procedure: get_arg
;	Gets, checks, and returns command line argument.

;  * Procedure: rand
;	Generates randum number (up to MAX)

;  * Procedure: draw_border
;	Draws a 3 pixel wide border around screen.

;  * Procedure: draw_circle
;	Draws a circle using provided algorithm.


; ---------------------------------------
;  Simple macro to increment/change color variable.
;  Kinda ugly code...

inc_color	MACRO	clr
	local	nxt1, nxt2, nxt3, nxt4, color_done

	cmp	clr, BLUE
	jne	nxt1
	mov	clr, GREEN
	jmp	color_done
nxt1:	cmp	clr, GREEN
	jne	nxt2
	mov	clr, RED
	jmp	color_done
nxt2:	cmp	clr, RED
	jne	nxt3
	mov	clr, YELLOW
	jmp	color_done
nxt3:	cmp	clr, YELLOW
	jne	nxt4
	mov	clr, WHITE
	jmp	color_done
nxt4:	cmp	clr, WHITE
	jne	color_done
	mov	clr, BLUE
color_done:

endm


.model	small
.486


; ------------------------------------------------------------

.data

; -----
;  Define constants for main program.

VID_MODE	equ	12h
SCR_WIDTH	equ	640
SCR_HEIGHT	equ	480

BLUE		equ	1
GREEN		equ	2
RED		equ	4
YELLOW		equ	14
WHITE		equ	15

MIN_RADIUS	equ	15
MAX_RADIUS	equ	50


; -----
;  Define variables for main program.

circle_cnt	dw	?			; count of circles to draw

x_center	dw	?			; circle center, x pos
y_center	dw	?			; circle center, y pos
radius		dw	?			; circle radius
color		db	BLUE			; circle color


; ------------------------------------------------------------

.stack

.code

extrn	get_arg:near
extrn	draw_border:near
extrn	rand:near
extrn	draw_circle:near


main	proc	far
	mov	ax, @data
	mov	ds, ax

; -----
;  Get command line argument.
;  Note, if command line argument is invalid, "get_arg"
;        will display error message and terminate program.

;  The "get_args" procedure read the command line argument,
;  checks for errors, and converts to integer.  Returns the
;  single integer number of circles to draw.

	lea	ax, circle_cnt
	push	ax
	call	get_arg

; -----
;  Set-up and switch to video mode.

	mov	ax, VID_MODE
	int	10h

; -----
;  Draw border around screen (3-wide).

	mov	ax, SCR_WIDTH
	push	ax				; border/screen width
	mov	ax, SCR_HEIGHT
	push	ax				; border/screen height
	mov	ax, GREEN
	push	ax				; border color
	call	draw_border


; -----
;  Obtain randum number for radius.
;  Procedure "rand" generates randum number between 0 and MAX-1.
;  If radius too small, try again...

	mov	cx, circle_cnt

re_draw:
	lea	ax, radius
	push	ax				; randon number
	mov	ax, MAX_RADIUS
	push	ax				; MAX value
	call	rand

	cmp	radius, MIN_RADIUS
	jl	re_draw

; -----
;  Obtain randum number for circle center, x position.
;  Procedure "rand" generates randum number between 0 and MAX-1.
;  If x position too small, try again...

new_x_center:
	lea	ax, x_center
	push	ax
	mov	ax, 640
	sub	ax, MAX_RADIUS
	push	ax
	call	rand

	cmp	x_center, MAX_RADIUS
	jl	new_x_center

; -----
;  Obtain randum number for circle center, y position.
;  Procedure "rand" generates randum number between 0 and MAX-1.
;  If radius too small, try again...
;  If y position too small, try again...

new_y_center:
	lea	ax, y_center
	push	ax
	mov	ax, 480
	sub	ax, MAX_RADIUS
	push	ax
	call	rand
	cmp	y_center, MAX_RADIUS
	jl	new_y_center

; -----
;  Change color of circle.

	inc_color	color

; -----
;  Draw a circle.

	push	x_center
	push	y_center
	push	radius
	mov	al, color
	cbw
	push	ax
	call	draw_circle

; -----
;  Loop

	dec	cx			; "loop re_draw"
	cmp	cx, 0
	jle	lp_done
	jmp	re_draw
lp_done:


; -----
;  Circle drawn, wait for user input before exiting
;   graphics mode and returning.

	mov	ah, 07			; Pause, wait for key press
	int	21h

	mov	ax, 03h
	int	10h

; -----
;  Done, terminate program.

last:
	mov	ah, 4ch
	int	21h

main	endp


; --------------------------------------------------------------

end	main