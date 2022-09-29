int Var1 = 19, Var2 = 8, Var3 = 11;
int sum10 = Var1 + Var3;
int difference = Var1 - Var3;

// if var1 > var2, calculate the sum betwen var1 and var3 else the difference
bool comparisonResult2 = Var1 > Var2;

int rezultatFinal = comparisonResult2 ? sum10 : difference;
string AnotherMessageText = comparisonResult2 ? "sum" : "difference";
string ComparisonMessage = comparisonResult2 ? "greater" : "smaller";

Console.WriteLine("Var1 that has value {0} is {1} than Var2 that has value {2} and the {3} is {4}",
    Var1, ComparisonMessage, Var2, AnotherMessageText, rezultatFinal);

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
    Console.WriteLine("The sum between Var1 and Var3 " + (Var1 + Var3));
}
else
{
    Console.WriteLine("The difference between Var1 and Var3 " + (Var1 - Var3));
}
// if-then statement statement


int CompoundNumber = 10;
CompoundNumber += 5;
Console.WriteLine(CompoundNumber);
Console.WriteLine("The number is {0}", CompoundNumber);
Console.WriteLine($"The number = {CompoundNumber}");
Console.WriteLine("The number is " + CompoundNumber);


if (Var1 < 5)
{
    Var1 += 5;
}
Console.WriteLine(Var1);


int Number50 = 14;
if (Number50 < 5)
{
    Console.WriteLine("{0} is less than 5", Number50);
}

Console.WriteLine("This statement is always executed.");

if (20 > 18)
{
    Console.WriteLine("20 is greater than 18");
}

int X1 = 20;
int Y1 = 18;
if (X1 > Y1)
{
    Console.WriteLine("X1 is greater than Y1");
}



//if..else ( if-then-else)  statment

if (Var2 < 5)
{
    Var2 += 5;
}
else
{
    Var2 -= 5;
}
Console.WriteLine(Var2);


int Number41 = 3;
if (Number41 < 5)
    Console.WriteLine("{0} is less than 5", Number41);
else
    Console.WriteLine("{0} is greater than or equal to 5", Number41);
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

int Number42 = 12;

if (Number42 < 5)
{
    Console.WriteLine("{0} is less than 5", Number42);
}
else if (Number42 > 5)
{
    Console.WriteLine("{0} is greater than 5", Number42);
}
else
{
    Console.WriteLine("{0} is equal to 5");

}

int Time1 = 22;

if (Time1 < 10)
{
    Console.WriteLine("Good morning.", Time1);
}
else if (Time1 < 20)
{
    Console.WriteLine("Good day.", Time1);
}
else
{
    Console.WriteLine("Good evening");

}

int Time2 = 20;
string Result30 = (Time2 < 18) ? "Good day." : "Good evening.";
Console.WriteLine(Result30);


//Nested if...else Statement

int NestedNumber1 = 7, NestedNumber2 = -23, NestedNumber3 = 13;
if (NestedNumber1 > NestedNumber2)
{
    if (NestedNumber1 > NestedNumber3)
    {
        Console.WriteLine("{0} is the largest", NestedNumber1);
    }
    else
    {
        Console.WriteLine("{0} is the largest", NestedNumber3);
    }
}
else
{
    if (NestedNumber2 > NestedNumber3)
    {
        Console.WriteLine("{0} is the largest", NestedNumber2);
    }
    else
    {
        Console.WriteLine("{0} is the largest", NestedNumber3);
    }
}

//Write a C# Sharp program to accept two integers and check whether they are equal or not

int Number35 = 5;
int Number36 = 5;
if (Number35 != Number36)
{
    Console.WriteLine("{0} and {1} are not equal.", Number35, Number36);
}
else
{
    Console.WriteLine("{0} and {0} are equal.", Number35, Number36);
}

int Number37 = 5;
int Number38 = 5;
if (Number37 == Number38)
{
    Console.WriteLine("{0} and {1} are  equal.", Number37, Number38);
}
else
{
    Console.WriteLine("{0} and {0} are not equal.", Number37, Number38);
}