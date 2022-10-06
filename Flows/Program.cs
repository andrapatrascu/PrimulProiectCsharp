int var1 = 19, var2 = 8, var3 = 11;
int sum10 = var1 + var3;
int difference = var1 - var3;

// if var1 > var2, calculate the sum betwen var1 and var3 else the difference
bool comparisonResult2 = var1 > var2;

int rezultatFinal = comparisonResult2 ? sum10 : difference;
string anotherMessageText = comparisonResult2 ? "sum" : "difference";
string comparisonMessage = comparisonResult2 ? "greater" : "smaller";

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


int compoundNumber = 10;
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


int number50 = 14;
if (number50 < 5)
{
    Console.WriteLine("{0} is less than 5", number50);
}

Console.WriteLine("This statement is always executed.");


if (20 > 18)
{
    Console.WriteLine("20 is greater than 18");
}

int x1 = 20;
int y1 = 18;
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


var2 = (var2 < 5) ? var2 += 5 : var2 -= 5 ;
Console.WriteLine(var2);
Console.WriteLine("The result is {0}", var2);
Console.WriteLine($"The result = {var2}");
Console.WriteLine("The result is " + var2);


Console.WriteLine("Another line to check");

int number41 = 3;
if (number41 < 5)
    Console.WriteLine("{0} is less than 5", number41);
else
    Console.WriteLine("{0} is greater than or equal to 5", number41);
Console.WriteLine("This statement is always executed.");


string result60 ;
result60 = (number41 < 5) ? " less than 5" : "greater than or equal to 5";
Console.WriteLine("{0} is {1}", number41, result60);
Console.WriteLine($"The result is = {number41},{result60}");
Console.WriteLine("The number is" + result60);


int time = 02;
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
Console.WriteLine("The greeting formula is "  + result63);


//if...else if (if-then -else if) Statement

int number42 = 12;

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



int time1 = 22;

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
int time2 = 20;
string result30 = (time2 < 18) ? "Good day." : "Good evening.";
Console.WriteLine(result30);

Console.WriteLine((time2 < 18) ? "Good day." : "Good evening.");

result30 = time2 < 02 ? "Good moning." : time2 < 12 ? "Good day." : "Good evening";
Console.WriteLine(result30);


//Nested if...else Statement

int nestedNumber1 = 7, nestedNumber2 = -23, nestedNumber3 = 13;
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

int number35 = 5;
int number36 = 5;
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




int number37 = 5;
int number38 = 5;
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

int number60 = 12;

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



int day = 4;
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
ch = Convert.ToChar(Console.ReadLine());

switch (Char.ToLower(ch))
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

switch (Char.ToLower(ch))
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


int dayoftheweek = 4;
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

int x = Convert.ToInt32(Console.ReadLine());

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

switch (Char.ToLower(ch))
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

string statementType = "switch";

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

int number77 = 210;
bool isEven;

isEven = (number77 % 2 == 0) ? true : false;
Console.WriteLine(isEven);

int number78 = 10, number79 = 100;
var result80 = number78 > number79 ? "First number is greater than the second one" : "Second number is greater than first number";
Console.WriteLine(result80);
