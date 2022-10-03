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




//if..else ( if-then-else)  statment

if (var2 < 5)
{
    var2 += 5;
}
else
{
    var2 -= 5;
}
Console.WriteLine(var2);


int number41 = 3;
if (number41 < 5)
    Console.WriteLine("{0} is less than 5", number41);
else
    Console.WriteLine("{0} is greater than or equal to 5", number41);
Console.WriteLine("This statement is always executed.");

int time = 02;
if (time < 18)
{
    Console.WriteLine("Good day.");
}
else
{
    Console.WriteLine("Good evening.");
}





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

int time2 = 20;
string result30 = (time2 < 18) ? "Good day." : "Good evening.";
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