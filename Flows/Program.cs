using Flows.Enum;
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
ch = Convert.ToChar(Console.ReadLine());

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
ch = Convert.ToChar(Console.ReadLine());

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

const int myNum = (int)Months.April;
Console.WriteLine(myNum);

//For loop

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("C# For Loop: Iteration {0}", i);
}

Console.WriteLine("First line after the for loop");

for (int i = 100; i <= 110; i += 2)
{
    Console.WriteLine(i);
    Console.WriteLine("testing");
    if (i > 105)
    {
        Console.WriteLine(i);
    }
}

int n = 5;
int sum = 0;

for (int i = 1; i <= n; i++)
{
    sum += i;
}
Console.WriteLine("The sum of the first {0} natural numbers is {1}", n, sum);

// Display every even number between 20 and 37

for ( int z = 20; z <= 37; z += 1 )
{
    if (z % 2 == 0)
    {
        Console.WriteLine("The number {0} is even", z);
    }
    else
    {
        Console.WriteLine("The number {0} is odd", z);
    }

}

//Use a for loop to print "Yes" 5 times

for ( int d = 0; d < 5; d++)
{
    Console.WriteLine("Yes");
}

//Display the sum of all the even numbers between 20 and 37

int sumeven = 0;
int rest = 0;
for (int z = 20; z <= 37; z += 1)
{
    rest = z % 2;

    if (rest == 0)
    {
        sumeven += z;
    }
}

Console.WriteLine("The sum is {0}", sumeven);


for (int i = 0, j = 0; i + j < 5; i++, j++)
{
    Console.WriteLine("Value of i: {0}, J: {1} ", i, j);
}

//for loop without initialization and iterator statement

int g = 1;
for ( ; g <= 5; )
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

for (int z = 0; z <= 5; z ++ )
{
    if (z % 2 == 1)
    {
        Console.WriteLine("The number {0} is odd", z);
    }
   
}
 //Create a for loop that prints out 10 numbers horizontal

for (int i = 0; i < 10; i++)
{
    Console.Write("{0} ",i);
}

