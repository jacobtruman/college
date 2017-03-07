% Jacob Truman
% CS 326
% Proj 11
%***************

% Factorial
%***********

fact(0, 1).
fact(N, X) :-
	N1 is N - 1,
	fact(N1, Y),
	X is Y * N.

% Length of list
%****************

length([], 0).
length([X / Tail], N) :-
	length(Tail, X),
	N is X + 1.

% Family Tree
%*************

parent(alan, clive).
parent(andrea, clive).
parent(clive, dave).
parent(clarissa, dave).
parent(clive, doris).
parent(clarissa, doris).
parent(bruce, clarissa).
parent(betty, clarissa).
parent(eddie, greg).
parent(elsie, greg).
parent(fred, greta).
parent(freda, greta).
parent(greg, henry).
parent(greta, henry).

male(alan).
male(clive).
male(bruce).
male(dave).
male(eddie).
male(fred).
male(greg).
male(henry).

female(andrea).
female(clarissa).
female(doris).
female(bette).
female(elsie).
female(freda).
female(greta).

married(alan, andrea).
married(clive, clarissa).
married(bruce, betty).
married(eddie, elsie).
married(fred, freda).
married(greg, greta).

mother(X, Y) :-
	female(X),
	parent(X, Y).

father(X, Y) :-
	male(X),
	parent(X, Y).

child(X, Y) :-
	parent(Y, X).

daughter(X, Y) :-
	female(X),
	parent(Y, X).

son(X, Y) :-
	male(X),
	parent(Y, X).

sibling(X, Y) :-
	X \= Y,
	mother(M, X),
	mother(M, Y),
	father(F, X),
	father(F, Y).

brother(X, Y) :-
	sibling(X, Y),
	male(X).

sister(X, Y) :-
	sibling(X, Y),
	female(X).

uncle(X, Y):-
	male(X),
	parent(N, Y),
	sibling(X, N).

aunt(X, Y):-
	female(X),
	parent(N, Y),
	sibling(X, N).

ancestor(X, Y) :-
	parent(X, Y).
ancestor(X, Y) :-
	parent(P, Y),
	ancestor(X, P).

descendant(X, Y) :-
	child(X, Y).
descendant(X, Y) :-
	child(P, Y),
	descendant(X, P).

related(X, Y) :-
	ancestor(X, Y).
related(X, Y) :-
	descendant(X, Y).

can_marry(X, Y) :-
	related(X, Y).



insertsort([], []).
insertsort([X|Tail], Sorted) :-
	insertsort(Tail, Sortedtail),
	insert(X, Sortedtail, Sorted).	
insert(X, [Y|Sorted1], [Y, Sorted2]) :-
	X > Y, !, insert(X, Sorted1, Sorted2).
insert(X, Sorted1, [X|Sorted1]).

insertsort([9,1,7,3,5], X).




% M monkey - where - door, middle, window
% B box - where - door, middle, window
% O monkey on box? (yes/no) - onflooor, onbox
% G monkey got banana? (yes/no) - has, hasnot

state(door, window, onfloor, hasnot).

perform(grasp,
	state(middle, middle, onbox, hasnot),
	state(middle, middle, onbox, has)).
perform(climb,
	state(MP, BP, onfloor, H),
	state(MP, BP, onbox, H)).
perform(push(P, PN),
	state(P, P, onfloor, H),
	state(PN, PN, onfloor, H)).
perform(walk(P1, P2),
	state(P1, BP, onfloor, H),
	state(P2, BP, onfloor, H)).

getfood(state(_, _, _, has)).
% getfood(state(door, window, onfloor, hasnot)).

getfood(S1) :-
	perform(ACT, S1, S2),
	nl, write('In'), write(S1),
	nl, write('Try'), write(ACT),
	getfood(S2).
