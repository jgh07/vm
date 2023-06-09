str ra, 1
str rb, "Enter a number: ", 1
int

str ra, 2
int

str ra, 3
int

str re, rb

str ra, 1

loop:
	sub re, 1
	mul rb, re
	
	str rg, re
	cgt rg, 1
	beq rg, ra, loop
	
swp rb, rh

str rb, "Factorial: ", 1
int

swp rb, rh

str rc, rb
ceq rc, 0
add rb, rc

int
