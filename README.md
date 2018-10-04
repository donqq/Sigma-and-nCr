Basic Algebra Library
---------
This library can be used to solve factorial numbers, sigma numbers 
The library is developed in VB.NET, and thus can be used across all .NET languages. 
 
Factorial number is n!, for instance 5! means 5x4x3x2x1. 
Sigma number is  n∑r, for instance 5∑1 means 1 + 2 + 3 + 4 + 5
Additionally, this allows to solve nCr as well, which means n! / (r! (n-r)!)

Parameters 
---------
The library has two functions, Factorial and Sigma. 

* Factorial function takes two parameters. Even though the second parameter is mandatory, it's not required; hence a blank string can be used. However, as the first parameter a value should be used. This value is the n of n!. 
* Second function takes three parameters. First value, second value, and the symbol to distinguish one from others. First sigma segment is for calculating n to p, for instance 5 to 1. second sigma segment is for calculating n to 1. The last nCr is for n! / (r! (n-r)!), where n is the first value and r is the second value. 

Returned value
---------
* a floating point value

How to Compile and Use
---------

1. Download, and install visual studio 2015
2. open the source code with .sln file
3. compile/build the library file
4. Use the binary library file in your application 
