﻿using Flows.Enum;
/*
int var1 = 19, var2 = 8, var3 = 11;
var sum10 = var1 + var3;
var difference = var1 - var3;

// if var1 > var2, calculate the sum betwen var1 and var3 else the difference
var comparisonResult2 = var1 > var2;

var rezultatFinal = comparisonResult2 ? sum10 : difference;
var anotherMessageText = comparisonResult2 ? "sum" : "difference";
var comparisonMessage = comparisonResult2 ? "greater" : "smaller";

Console.WriteLine("Var1 that has value {0} is {1} than Var2 that has value {2} and the {3} is {4}",
    var1, comparisonMessage, var2, anotherMessageText, rezultatFinal);

if (comparisonResult2)
{
    Console.WriteLine("The sum between Var1 and Var3 is {0}", sum10);
}
else
{
    Console.WriteLine("The difference between Var1 and Var3 " + difference);
}



if (comparisonResult2)
{
    Console.WriteLine("The sum between Var1 and Var3 " + (var1 + var3));
}
else
{
    Console.WriteLine("The difference between Var1 and Var3 " + (var1 - var3));
}





// if-then statement statement


var compoundNumber = 10;
compoundNumber += 5;
Console.WriteLine(compoundNumber);
Console.WriteLine("The number is {0}", compoundNumber);
Console.WriteLine($"The number = {compoundNumber}");
Console.WriteLine("The number is " + compoundNumber);


if (var1 < 5)
{
    var1 += 5;
}
Console.WriteLine(var1);


var number50 = 14;
if (number50 < 5)
{
    Console.WriteLine("{0} is less than 5", number50);
}

Console.WriteLine("This statement is always executed.");


if (20 > 18)
{
    Console.WriteLine("20 is greater than 18");
}

var x1 = 20;
var y1 = 18;
if (x1 > y1)
{
    Console.WriteLine("X1 is greater than Y1");
}




//if..else ( if-then-else)  statment + ternary operator
Console.WriteLine("Here it is");
if (var2 < 5)
{
    var2 += 5;
}
else
{
    var2 -= 5;
}
Console.WriteLine(var2);

var var4 = 10;
var4 = (var4 < 5) ? var4 += 5 : var4 -= 5;
Console.WriteLine(var4);
Console.WriteLine("The result is {0}", var4);
Console.WriteLine($"The result = {var4}");
Console.WriteLine("The result is " + var4);


Console.WriteLine("Another line to check");

var number41 = 3;
if (number41 < 5)
    Console.WriteLine("{0} is less than 5", number41);
else
    Console.WriteLine("{0} is greater than or equal to 5", number41);
Console.WriteLine("This statement is always executed.");


string result60;
result60 = (number41 < 5) ? " less than 5" : "greater than or equal to 5";
Console.WriteLine("{0} is {1}", number41, result60);
Console.WriteLine($"The result is = {number41},{result60}");
Console.WriteLine("The number is" + result60);


var time = 02;
if (time < 18)
{
    Console.WriteLine("Good day.");
}
else
{
    Console.WriteLine("Good evening.");
}

string result63;
result63 = (time < 18) ? "Good day." : "Good evening.";
Console.WriteLine(result63);
Console.WriteLine("If time is {0} then the greeting is {1}", time, result63);
Console.WriteLine($"Time is = {time} and the greeting is {result63}");
Console.WriteLine("The greeting formula is " + result63);


//if...else if (if-then -else if) Statement

var number42 = 12;

if (number42 < 5)
{
    Console.WriteLine("{0} is less than 5", number42);
}
else if (number42 > 5)
{
    Console.WriteLine("{0} is greater than 5", number42);
}
else
{
    Console.WriteLine("{0} is equal to 5");

}

Console.WriteLine("Another if statement");

string result61;
result61 = (number42 > 5) ? "Number is greater than 5" : "Number is less than 5";
Console.WriteLine(result61);


result61 = number42 < 5 ? "Number is less than 5" : number42 > 5 ? "Number is greater than 5" : "Number is equal to 5";
Console.WriteLine(result61);



var time1 = 22;

if (time1 < 10)
{
    Console.WriteLine("Good morning.", time1);
}
else if (time1 < 20)
{
    Console.WriteLine("Good day.", time1);
}
else
{
    Console.WriteLine("Good evening");

}

Console.WriteLine("Different code for ternary operator");
var time2 = 20;
var result30 = (time2 < 18) ? "Good day." : "Good evening.";
Console.WriteLine(result30);

Console.WriteLine((time2 < 18) ? "Good day." : "Good evening.");

result30 = time2 < 02 ? "Good moning." : time2 < 12 ? "Good day." : "Good evening";
Console.WriteLine(result30);


//Nested if...else Statement

const int nestedNumber1 = 7;
const int nestedNumber2 = -23;
const int nestedNumber3 = 13;
if (nestedNumber1 > nestedNumber2)
{
    if (nestedNumber1 > nestedNumber3)
    {
        Console.WriteLine("{0} is the largest", nestedNumber1);
    }
    else
    {
        Console.WriteLine("{0} is the largest", nestedNumber3);
    }
}
else
{
    if (nestedNumber2 > nestedNumber3)
    {
        Console.WriteLine("{0} is the largest", nestedNumber2);
    }
    else
    {
        Console.WriteLine("{0} is the largest", nestedNumber3);
    }
}



//Write a C# Sharp program to accept two integers and check whether they are equal or not

var number35 = 5;
var number36 = 5;
if (number35 != number36)
{
    Console.WriteLine("{0} and {1} are not equal.", number35, number36);
}
else
{
    Console.WriteLine("{0} and {0} are equal.", number35, number36);
}

string result67;
result67 = (number35 != number36) ? "The numbers are different" : "The numbers are equal";
Console.WriteLine(result67);
Console.WriteLine((number35 != number36) ? "The numbers are different" : "The numbers are equal");




var number37 = 5;
var number38 = 5;
if (number37 == number38)
{
    Console.WriteLine("{0} and {1} are  equal.", number37, number38);
}
else
{
    Console.WriteLine("{0} and {0} are not equal.", number37, number38);
}

string result68;
result68 = (number37 == number38) ? "The numbers are different" : "The numbers are equal";
Console.WriteLine(result68);
Console.WriteLine((number37 == number38) ? "The numbers are equal" : "The numbers are different");

//switch statement
//replace if-then-else if statement

var number60 = 12;

if (number60 < 5)
{
    Console.WriteLine("{0} is less than 5", number60);
}
else if (number60 > 5)
{
    Console.WriteLine("{0} is greater than 5", number60);
}
else
{
    Console.WriteLine("{0} is equal to 5");

}


//remember conversion

//Convert myDBL to int and print it.



var day = 4;
switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
}

char ch;
Console.WriteLine("Enter an alphabet");
ch = Convert.ToChar(Console.ReadLine() ?? string.Empty);

switch (ToLower(ch))
{
    case 'a':
        Console.WriteLine("Vowel");
        break;
    case 'e':
        Console.WriteLine("Vowel");
        break;
    case 'i':
        Console.WriteLine("Vowel");
        break;
    case 'o':
        Console.WriteLine("Vowel");
        break;
    case 'u':
        Console.WriteLine("Vowel");
        break;
    default:
        Console.WriteLine("Not a vowel");
        break;
}

Console.WriteLine("Enter an alphabet");
ch = Convert.ToChar(Console.ReadLine() ?? string.Empty);

switch (ToLower(ch))
{
    case 'a':
    case 'e':
    case 'i':
    case 'o':
    case 'u':
        Console.WriteLine("Vowel");
        break;
    default:
        Console.WriteLine("Not a vowel");
        break;
}


var dayoftheweek = 4;
switch (dayoftheweek)
{
    case 6:
        Console.WriteLine("Today is Saturday.");
        break;
    case 7:
        Console.WriteLine("Today is Sunday.");
        break;
    default:
        Console.WriteLine("Looking forward to the Weekend.");
        break;
}

//Create a C# program that calculates a student's grade from an integer. Ask the user for a number (x) and answer the following:
//10-A+, 9-A, 7.8-B,6-C,5-E,0.4-F

var x = Convert.ToInt32(Console.ReadLine());

switch (x)
{
    case 10:
        Console.WriteLine("The grade is A+");
        break;
    case 9:
        Console.WriteLine("The grade is A-");
        break;
    case 8:
    case 7:
        Console.WriteLine("The grade is B");
        break;
    case 6:
        Console.WriteLine("The grade is C");
        break;
    case 5:
        Console.WriteLine("The grade is E");
        break;
    default:
        Console.WriteLine("The grade is F");
        break;
}


Console.WriteLine("Enter an alphabet");
ch = Convert.ToChar(Console.ReadLine() ?? string.Empty);

switch (ToLower(ch))
{
    case 'a':
    case 'e':
    case 'i':
    case 'o':
    case 'u':
        Console.WriteLine("Vowel");
        break;
    default:
        Console.WriteLine("Not a vowel");
        break;
}


int z;
Console.Write("Enter a number: ");
z = Convert.ToInt32(Console.ReadLine());
if (z > 0)
    Console.WriteLine("is positive");

if (z < 0)
    Console.WriteLine("is negative");


char op;
double first, second, result;

Console.Write("Enter first number: ");
first = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter second number: ");
second = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter operator (+, -, *, /): ");
op = (char)Console.Read();

switch (op)
{
    case '+':
        result = first + second;
        Console.WriteLine("{0} + {1} = {2}", first, second, result);
        break;

    case '-':
        result = first - second;
        Console.WriteLine("{0} - {1} = {2}", first, second, result);
        break;

    case '*':
        result = first * second;
        Console.WriteLine("{0} * {1} = {2}", first, second, result);
        break;

    case '/':
        result = first / second;
        Console.WriteLine("{0} / {1} = {2}", first, second, result);
        break;

    default:
        Console.WriteLine("Invalid Operator");
        break;
}

var statementType = "switch";

switch (statementType)
{
    case "if.else":
        Console.WriteLine("if...else statement");
        break;
    case "ternary":
        Console.WriteLine("Ternary operator");
        break;
    case "switch":
        Console.WriteLine("switch statement");
        break;
}

//Ternary exercises

const int number77 = 210;

const bool isEven = number77 % 2 == 0;
Console.WriteLine(isEven);

const int number78 = 10;
const int number79 = 100;
const string result80 = number78 > number79 ? "First number is greater than the second one" : "Second number is greater than first number";
Console.WriteLine(result80);


*/

const int myNum = (int)YearMonths.April;
Console.WriteLine(myNum);




//For loop

for (var i = 1; i <= 5; i++)
{
    Console.WriteLine("C# For Loop: Iteration {0}", i);
}

Console.WriteLine("First line after the for loop");

for (var i = 100; i <= 110; i += 2)
{
    Console.WriteLine(i);
    Console.WriteLine("testing");
    if (i > 105)
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine("sum");

var sum = 0;
for (var i = 1; i <= 5; i++)

{
    sum += i;

}
Console.WriteLine("The sum of the first 5 natural numbers is {0}", sum);

// Display every even number between 20 and 37

for (var z = 20; z <= 37; z += 1)
{
    Console.WriteLine(z % 2 == 0 ? "The number {0} is even" : "The number {0} is odd", z);
}

//Use a for loop to print "Yes" 5 times

for (var d = 0; d < 5; d++)
{
    Console.WriteLine("Yes");
}

//Display the sum of all the even numbers between 20 and 37

var sumEven = 0;
for (var z = 20; z <= 37; z += 1)
{
    var rest = z % 2;

    if (rest == 0)
    {
        sumEven += z;
    }
}

Console.WriteLine("The sum is {0}", sumEven);


for (int i = 0, j = 0; i + j < 5; i++, j++)
{
    Console.WriteLine("Value of i: {0}, J: {1} ", i, j);
}

//for loop without initialization and iterator statement

var g = 1;
for (; g <= 5;)
{
    Console.WriteLine("C# For Loop: Iteration {0}", g);
    g++;
}




// Infinite for loop

/*
g = 1;
for (; g <= 5;)
{
    Console.WriteLine("C# For Loop: Iteration {0}", g);
    g++;
    if (g == 3)
    {
        g = 0;
    }
}

*/

// Display every odd number between 0 and 5

for (var z = 0; z <= 5; z++)
{
    if (z % 2 == 1)
    {
        Console.WriteLine("The number {0} is odd", z);
    }

}
//Create a for loop that prints out 10 numbers horizontal

for (var i = 0; i < 10; i++)
{
    Console.Write("{0} ", i);
}




//while and do...while loop

var y = 1;
while (y < 10)
{
    Console.WriteLine("C# For Loop: Iteration {0}", y);
    y++;
}



//while loop to compute sum of first 5 natural numbers

int u = 1, sum78 = 0;

while (u <= 5)
{
    sum78 += u;
    u++;
}
Console.WriteLine("Sum = {0}", sum78);

int ii = 1, sum79 = 0;

while (ii <= 10)
{
    sum79 += ii;
    ii++;
}
Console.WriteLine("Sum = {0}", sum79);




//do...while loop

var xy = 0;
do
{
    Console.WriteLine(xy);
    xy++;
}
while (xy < 5);


int ij = 1, nj = 5, product;

do
{
    product = nj * ij;
    Console.WriteLine("{0} * {1} = {2}", nj, ij, product);
    ij++;
} while (ij <= 10);




// break Statement

//C# break statement with for loop
//This example jumps out of the loop when i is equal to 3:

for (var i = 0; i < 10; i++)
{
    if (i == 3)
    {
        break;
    }
    Console.WriteLine(i);
}

for (var i = 1; i < 10; i++)
{
    if (i == 4)
    {
        break;
    }
    Console.WriteLine(i);
}



//C# break statement with while loop

var oi = 1;
while (oi <= 5)
{
    Console.WriteLine(oi);
    oi++;
    if (oi == 4)
    {
        break;
    }
}



// continue Statement

//C# continue with for loop

Console.WriteLine("continue");

for (var i = 1; i <= 5; ++i)
{

    if (i == 3) // skip the condition
    {
        Console.WriteLine(i);
        continue;
    }

    Console.WriteLine(i);
}


// C# continue with while loop
var yu = 0;
while (yu < 5)
{
    yu++;

    if (yu == 3)
    {
        continue;
    }

    Console.WriteLine(yu);
}

Console.WriteLine("exercises");




//for loop exercises

for (var i = 0; i < 7; i++)
{
    Console.WriteLine("i= " + i);
}

//This example will only print even values between 0 and 10

for (var i = 0; i < 10; i = i + 2)
{
    Console.WriteLine("i = " + i);
}

//This example will only print odd values between 0 and 10


for (var i = 1; i < 10; i++)
{
    if (i % i == 10)
    {
        Console.WriteLine("The number is " + i);
    }
}

//for examples

for (var i = 1; i < 5; i++)
{
    Console.WriteLine("The number is " + i);
}

//Stop the loop if i is 5.
for (var i = 0; i < 10; i++)
{
    if (i == 5)
    {
        break;
    }
    Console.WriteLine(i);
}

//In the following loop, when the value is "4", jump directly to the next value.
for (var i = 0; i < 10; i++)
{
    if (i == 4)
    {
        continue;
    }
    Console.WriteLine(i);
}

//Print i as long as i is less than 6.
var ik = 1;
while (ik < 6)
{
    Console.WriteLine(ik);
    ik++;
}

//Arrays


// Declare an array

// allocate memory for array
var age = new int[5];
                 //We can also say the size/length of the array is 5

var age1 = new int[5];

//Array initialization
age1 = new[] { 2, 5, 7, 80, 0, 5, 33 };
string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
int[] myNumber = { 1, 2, 3, 4, 5 };

// Access Array Elements

int[] numbers = { 1, 2, 3 };

//access first element
Console.WriteLine("Element in first index : " + numbers[0]);

//access second element
Console.WriteLine("Element in second index : " + numbers[1]);

//access third element
Console.WriteLine("Element in third index : " + numbers[2]);

string[] cars1 = { "Volvo", "BMW", "Ford", "Mazda" };
Console.WriteLine(cars1[0]);
Console.WriteLine($"The name of the car = {cars1[0]}");

/*
Console.WriteLine(compoundNumber);
Console.WriteLine("The number is {0}", compoundNumber);
Console.WriteLine($"The number = {compoundNumber}");
Console.WriteLine("The number is " + compoundNumber);
*/

//Change Array Elements

// create an array
int[] numbers1 = { 1, 2, 3 };

Console.WriteLine("Old Value at index 0: " + numbers1[0]);

// change the value at index 0
numbers1[0] = 11;

//print new value
Console.WriteLine("New Value at index 0: " + numbers1[0]);

// Iterating C# Array using Loops

int[] numbers2 = { 1, 2, 3 };

for (var i = 0; i < numbers2.Length; i++)
{
    Console.WriteLine("Element in index " + i + ": " + numbers2[i]);
}

string[] cars2 = { "Volvo", "BMW", "Ford", "Mazda" };
foreach (var car in cars2)
{
    Console.WriteLine(car);
}

//for recap

//Display the sum of numbers between 7 and 17 

int sum80 = 7;

for (int i = 8; i <= 17; i++)
{
    sum80 = sum80 + i;
}
Console.WriteLine("Sum is {0}", sum80);


//Display the sum of odd numbers between 7 and 17
sum80 = 7;

for (int i = 8; i <= 17; i++)
{
    if (i % 2 == 1)
    {
        sum80 = sum80 + i;
    }
}
Console.WriteLine("Sum is {0}", sum80);


// Another solution
sum80 = 0;

for (int i = 7; i <= 17; i += 2)
{
    sum80 = sum80 + i;
}
Console.WriteLine("Sum is {0}", sum80);

//Display the sum of even numbers between 7 and 17

sum80 = 0;

for (int i = 7; i <= 17; i++)

    if (i % 2 == 0)
    {
        sum80 = sum80 + i;
    }
Console.WriteLine("Sum is {0}", sum80);

//Another solution

sum80 = 0;

for (int i = 8; i <= 17; i += 2)
{
    sum80 = sum80 + i;
}
Console.WriteLine("Sum is {0}", sum80);

//Array exercises

int[] numbers14 = { 23, 14, 19, -12, 3, 57 };
int sum15 = 0;
int element = 0;
for (int i = 0; i < numbers14.Length; i++)
{
    element = numbers14[i];
    sum15 = sum15 + element;
}
Console.WriteLine(sum15);

// Array elements multiplied by 10 so that each element is 10 times larger
for (int i = 0; i < numbers14.Length; ++i)
{
    numbers14[i] = numbers14[i] * 10;
}

Console.Write("The new array values are: ");
for (int i = 0; i < numbers14.Length; ++i)
{
    Console.Write(numbers14[i]);
    if (i < numbers14.Length - 1)
    {
        Console.Write(", ");
    }
}
//Using foreach loop

Console.WriteLine();
Console.WriteLine("Array Elements: ");

foreach (int num in numbers14)
{
    Console.WriteLine(num);
}

// Sum of the arrays elements using foreach and compute average

Console.WriteLine("Average result");
// Reset array values

for (int i = 0; i < numbers14.Length; i++)
{
    numbers14[i] = i;
}

double sumd = 0;

foreach (int num in numbers14)
{
    sumd = sumd + num;
}

double average = sumd / numbers14.Length;
Console.WriteLine("Average is {0}", average);



string[] Vegetables = { "Apple", "Pear", "Onion" };



foreach (string Veggie in Vegetables)
{
    Console.WriteLine("Veggie = {0}", Veggie);
}
