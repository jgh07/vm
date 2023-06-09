; This small program allows you to enter a number.
; It then counts up from 1 to that number.

str ra, 2
int

str ra, 3
int

str rh, rb
add rh, 1

str ra, 1

str ra, 1 
str rb, "---\n", 1
int

str rb, 1
str rc, 1

loop:
	int
	
	str rf, rb
	str rb, "\n", 1
	int
	
	swp rf, rb
	
	add rb, rc
	
	str rd, rb
	
	clt rb, rh
	swp rb, rd
	beq rd, rc, loop
