Homework: Console Input / Output
================================

### Problem 1.	Sum of 3 Numbers
*	Write a program that reads 3 real numbers from the console and prints their sum.

_Examples:_

|      a      |   b  |   c  |  sum |
|:-----------:|:----:|:----:|:----:|
| 3           | 4    | 11   | 18   |
| -2          | 0    | 3    | 1    |
| 5.5         | 4.5  | 20.1 | 30.1 |

### Problem 2.	Print Company Information
*	A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
*	Write a program that reads the information about a company and its manager and prints it back on the console.

_Example input:_

|       program       |            user            |
|---------------------|----------------------------|
| Company name:       | Freelancer                 |
| Company address:    | 03 St. Karadja, Gabrovo    |
| Phone number:       | +359 87 893 33 63          |
| Fax number:         | 2                          |
| Web site:           | http://denislav.com        |
| Manager first name: | Denislav                   |
| Manager last name:  | Radoslavov                 |
| Manager age:        | 35                         |
| Manager phone:      | +359 87 893 33 63          |

_Example output:_

	Freelancer
	Address: 03 St. Karadja, Gabrovo
	Tel. +359 87 893 33 63 
	Fax: (no fax)
	Web site: http://denislav.com 
	Manager: Denislav Radoslavov (age: 35, tel. +359 87 893 33 63 )	

### Problem 3.	Circle Perimeter and Area
*	Write a program that reads the radius `r` of a circle and prints its perimeter and area formatted with `2` digits after the decimal point.

_Examples:_

|          r          |          perimeter         |  area |
|:-------------------:|:--------------------------:|:-----:|
| 2                   | 12.57                      | 12.57 |
| 3.5                 | 21.99                      | 38.48 |

### Problem 4.	Number Comparer
*	Write a program that gets two numbers from the console and prints the greater of them.
*	Try to implement this without if statements.

_Examples:_

|  a  |  b  | greater |
|:---:|:---:|:-------:|
| 5   | 6   | 6       |
| 10  | 5   | 10      |
| 0   | 0   | 0       |
| -5  | -2  | -2      |
| 1.5 | 1.6 | 1.6     |

### Problem 5.	Formatting Numbers
*	Write a program that reads 3 numbers:
	*	integer `a` (0 <= a <= 500)
	*	floating-point `b`
	*	floating-point `c` 
*	The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.	
	*	The number `a` should be printed in hexadecimal, left aligned
	*	Then the number `a` should be printed in binary form, padded with zeroes
	*	The number `b` should be printed with 2 digits after the decimal point, right aligned
	*	The number c should be printed with 3 digits after the decimal point, left aligned. 
	
_Examples:_

|  a  |    b    |    c    |                      result                    |
|:---:|:-------:|:-------:|------------------------------------------------|
| 254 | 11.6    | 0.5     | `FE        |0011111110|     11.60|0.500     |` |
| 499 | -0.5559 | 10000   | `1F3       |0111110011|     -0.56|10000     |` |
| 0   | 3       | -0.1234 | `0         |0000000000|         3|-0.123    |` |

### Problem 6.	Quadratic Equation
*	Write a program that reads the coefficients `a`, `b` and `c` of a quadratic equation ax<sup>2</sup> + bx + c = 0 and solves it (prints its real roots).

_Examples:_

|   a  |  b  |  c  |     roots     |
|:----:|:---:|:---:|---------------|
| 2    | 5   | -3  | x1=-3; x2=0.5 |
| -1   | 3   | 0   | x1=3; x2=0    |
| -0.5 | 4   | -8  | x1=x2=4       |
| 5    | 2   | 8   | no real roots |

### Problem 7.	Sum of 5 Numbers
*	Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

_Examples:_

|      numbers      |  sum  |
|-------------------|-------|
| 1 2 3 4 5         | 15    |
| 10 10 10 10 10    | 50    |
| 1.5 3.14 8.2 -1 0 | 11.84 |

### Problem 8.	Numbers from 1 to n
*	Write a program that reads an integer number `n` from the console and prints all the numbers in the interval `[1..n]`, each on a single line.

_Note: You may need to use a for-loop._

_Examples:_

| input | output |
|-------|--------|
| 3     | 1      |
|       | 2      |
|       | 3      |
| 5     | 1      |
|       | 2      |
|       | 3      |
|       | 4      |
|       | 5      |
| 1     | 1      |

### Problem 9.	Sum of n Numbers
*	Write a program that enters a number `n` and after that enters more `n` numbers and calculates and prints their `sum`.
_Note: You may need to use a for-loop._

_Examples:_

| numbers | sum |
|---------|-----|
| 3       | 90  |
| 20      |     |
| 60      |     |
| 10      |     |
| 5       | 6.5 |
| 2       |     |
| -1      |     |
| -0.5    |     |
| 4       |     |
| 2       |     |
| 1       | 1   |
| 1       |     |

### Problem 10.	Fibonacci Numbers
*	Write a program that reads a number `n` and prints on the console the first `n` members of the Fibonacci sequence (at a single line, separated by comma and space - `, `) : `0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …`.

_Note: You may need to learn how to use loops._

_Examples:_

|   n  |        comments        |
|:----:|------------------------|
| 1    | 0                      |
| 3    | 0 1 1                  |
| 10   | 0 1 1 2 3 5 8 13 21 34 |

