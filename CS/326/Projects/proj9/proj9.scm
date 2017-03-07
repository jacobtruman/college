(- (* 8 3) (/ 12 4))
(+ (* (- 9 7) 2 5) 4)
(* (- (+ (+ 4 5) 3) 2) 2)
(+ 1 (/ (- 2 3) (* 4 5)))

(define (f x)
    (+ (- 2 x) (* x (+ x 5))))
(f 5)
(< 2 4)

(< 2 4)
(> (+ 5 7) (/ 1431 114))

(- (* 8 7) (+ 10 5))
(* 5 (+ 4 (- -5 -3)))
(/ 3 (- 5 (/ 21 7)))

(define (square x)
  (* x x))
(square 5)

(define (rarea x y)
  (* x y))

(rarea 3 4)

(define (poly1 x)
  (+ (+ (* 3 (* x x)) (* 7 x)) 42))

(poly1 5)

(define (poly2 x)
  (+ (- (* x (* x x)) (* 5 x)) 6))

(poly2 5)

(define (fact x)
   (if (= x 0) 1
     (* x (fact (- x 1)))))
(fact 5)

(define (fib x)
   (cond ((= x 0) 0)
         ((= x 1) 1)
         (else (+ (fib (- x 1)) (fib (- x 2))))))
(fib 5)

(define (harmonic x)
   (cond ((= x 0) 1)
         (else (+ (harmonic (- x 1)) (/ 1 x)))))

(harmonic 5)

(define (ack m n)
   (cond ((= m 0) (+ n 1))
         ((> m 0) (ack (- m 1) 1))
         (else (ack (- m 1) (ack m (- n 1))))))

(ack 2 3)

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

