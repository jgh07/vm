; This program displays the first 30 numbers of the fibonacci sequence.

str ra, 1

; Current number
str rc, 1

; Previous number
str rd, 1

; Current count
str re, 0

; Print first two fibonacci numbers
str rb, "   \b\b"
int
str rb, rc
int
str rb, "\n   \b\b"
int
str rb, rc
int
str rb, "\n   \b\b"
int

fib:
	beq re, 27, end
	add re, 1
	
	str rg, rc
	add rc, rd
	str rd, rg
	
	str rb, rc
	int
	str rb, "\n   \b\b"
	int
	jmp fib
	
end:
	ret
	
