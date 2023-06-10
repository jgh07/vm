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

loop:
	str rd, 0
	str rg, rb

	str rc, rb
	rem rc, 15
	beq rc, rd, fizzbuzz

	str rc, rb
	rem rc, 5
	beq rc, rd, buzz

	str rc, rb
	rem rc, 3
	beq rc, rd, fizz

	int
	str rb, "\n", 1
	int
	swp rb, rg

	inner:
		str rf, rb
		str rc, 1
		swp rf, rb
		add rb, rc
		str rd, rb
		clt rb, rh
		swp rb, rd
		beq rd, rc, loop
		ret

fizz:
	str rb, "Fizz\n"
	jmp print

buzz:
	str rb, "Buzz\n"
	jmp print

fizzbuzz:
	str rb, "FizzBuzz\n"
	jmp print
	
print:
	int
	swp rb, rg
	jmp inner
