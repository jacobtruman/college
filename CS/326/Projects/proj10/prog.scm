;; Jacob Truman
;; CS 326
;; Project 10
;; *******************

(define (sum lst)
  (cond ((null? lst) 0)
        (else (+ (car lst) (sum (cdr lst))))))

(define (product lst)
  (cond ((null? lst) 1)
        (else (* (car lst) (product (cdr lst))))))

(define (lst-mul lst x)
  (if (null? lst) null
      (append (list (* (car lst) x)) (lst-mul (cdr lst) x))))

(define (len lst)
  (cond ((null? lst) 0)
        (else (+ 1 (len (cdr lst))))))

(define (average lst)
  (cond ((null? lst) 0)
        (else (/ (sum lst) (len lst)))))

(define (revlst lst)
  (if (null? lst) null
      (append (revlst (cdr lst)) (list (car lst)))))

(define (inter lst1 lst2)
  (if (null? lst1) null
      (cond ((member (car lst1) lst2) (append (list (car lst1)) (inter (cdr lst1) lst2)))
            (else (inter (cdr lst1) lst2)))))

(define (union lst1 lst2)
  (cond ((null? lst1) lst2)
        ((member (car lst1) lst2)
         (union (cdr lst1) lst2))
        (else (cons (car lst1) (union (cdr lst1) lst2)))))

(define (diff lst1 lst2)
  (if (null? lst1) null
      (cond ((member (car lst1) lst2) (diff (cdr lst1) lst2))
            (else (append (list (car lst1)) (diff (cdr lst1) lst2))))))

(define (remove lst x)
  (if (null? lst) null
      (cond ((= (car lst) x) (remove (cdr lst) x))
            (else (append (list (car lst)) (remove (cdr lst) x))))))

(define (least lst)
  (cond ((= (length lst) 1) (car lst))
        ((< (car lst) (car (cdr lst)))
         (least (cons (car lst) (cdr (cdr lst)))))
        (else (least (cons (car (cdr lst)) (cdr (cdr lst)))))))

(define (sel-sort lst)
  (if (null? lst) null
      (append (list (least lst)) (sel-sort (remove lst (least lst))))))


;; ***********************************
;; Project #10 - Tests

(format "sum")
(sum '(1 2 3 4 5 6 7))
(sum '(100 100 300 200))
(sum '())

(format "product")
(product '(2 3 4 5))
(product '(10 20 30))
(product '())

(format "lst-mul")
(lst-mul '(2 3 4) 3)
(lst-mul '(102 123 534 342) 10)
(lst-mul '(10) 1203132)

(format "len")
(len '(1 2 3 4 5 6 7 8))
(len '(1))
(len '())

(format "average")
(average '(4 5 6 7 8))
(average '(21 32 46 51 69))
(average '(112311 653462 9124522))
(average '(3))

(format "revlst")
(revlst '(1 2 3 4 5 6))
(revlst '(9 87 6 5 4 3 2 1))

(format "intersection")
(inter '(2 3 4 5) '(3 4 5 6))
(inter '(1 2 3 4) '(2 4))
(inter '(2 5 7) '(3 5 9 10 12))

(format "union")
(union '(2 3 4 5) '(3 4 5 6))
(union '(1 2 3) '(2 8))
(union '(1 2 3) '(5 6 7 8 9))

(format "difference")
(diff '(2 3 4 5) '(3 4 5 6))
(diff '(1 3 5 7 9) '(2 4 6 8))
(diff '(1) '(2 3 4))

(format "remove")
(remove '(2 3 4) 3)
(remove '(12 14 87 12 18) 87)

(format "least")
(least '(5 2 7))
(least '(42121 31532 51522))

(format "selection sort")
(sel-sort '(9 1 8 2 7 3 6 4 5))
(sel-sort '(9 1 7 3 5))
(sel-sort '(42121 87122 12412 31532 91231 51522))