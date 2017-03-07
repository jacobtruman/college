;; ----------------------------------
; Project #9

(- (* 8 3) (/ 12 4))
(+ (* (- 9 7) 2 5) 4)
(* (- (+ (+ 4 5) 3) 2) 2)
(+ 1 (/ (- 2 3) (* 4 5)))

(define (f x)
    (+ (- 2 x) (* x (+ x 5))))
(f 3)
(f 5)
(< 2 4)

(< 2 4)
(> (+ 5 7) (/ 1431 114))

(- (* 8 7) (+ 10 5))
(* 5 (+ 4 (- -5 -3)))
(/ 3 (- 5 (/ 21 7)))

(define (square x)
  (* x x))

(define (pow x y)
  (cond ((> y 2) (* x (pow x (- y 1))))
        (else (* x x))))

(define (rarea x y)
  (* x y))

(define (poly1 x)
  (+ (+ (* 3 (* x x)) (* 7 x)) 42))

(define (poly2 x)
  (+ (- (* x (* x x)) (* 5 x)) 6))

(define (payment x y z)
  (/ (* x (/ (/ y 100) 12)) (- 1 (pow (/ 1 (+ 1 (/ (/ y 100) 12))) (* z 12)))))

(define (fact x)
   (if (= x 0) 1
     (* x (fact (- x 1)))))

(define (fib x)
   (cond ((= x 0) 0)
         ((= x 1) 1)
         (else (+ (fib (- x 1)) (fib (- x 2))))))

(define (harmonic x)
   (cond ((= x 0) 1)
         (else (+ (harmonic (- x 1)) (/ 1 x)))))

(define (ack m n)
   (cond ((= m 0) (+ n 1))
         ((and (= n 0) (> m 0)) (ack (- m 1) 1))
         (else (ack (- m 1) (ack m (- n 1))))))

(list '1 '2 '3 '4 '5)
(list 'a 'b 'c 'd)
(list 'one 'two 'three 'four)
(list '1 '2 '(3 4) '5)
(cons 1 '(2 3))
(cons 1 '(3 5 (7 9)))
(car '(3 5 7 9))
(car '((1 3) 4 5))
(cdr '(3 5 7 9))
(cdr '(2 3))
(length '(1 3 5 7 9))
(reverse '(1 3 5 7 9))
(append '(1 3) '(5 7 9))


;; -----------------------------------
; Tests

; Test squares
(format "---------------------")
(format "Tests - squares")
(square 4)
(square 9)

; Test rarea
(format "Tests - rarea")
(rarea 3 5)
(rarea 13 22)

(format "Tests - poly1")
(poly1 5)
(poly1 9)

(format "Tests - poly2")
(poly2 5)
(poly2 9)

(format "Tests - payment")
(payment 10000 10 10)
(payment 5000 5 7)

(format "Tests - fact")
(fact 5)
(fact 10)

(format "Tests - fib")
(fib 13)
(fib 28)

(format "Tests - harmonic")
(harmonic 3)
(harmonic 7)
(harmonic 5)
(harmonic 10)

(format "Tests - ack")
(ack 1 2)
(ack 2 3)
(ack 3 4)
