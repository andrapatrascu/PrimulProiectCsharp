// See https://aka.ms/new-console-template for more information

using System.Globalization;
using PrimulProiectCsharp.Models;

Console.WriteLine("Hello");
Console.WriteLine("Andra");

int x = 5;      // declared variable of type int and initialized it with the value 5
int y = 101;
int sum = x + y;
string gigi = "Ana are mere";
Console.WriteLine("the sum of {0} and {1} is {2} and also {3}", x, y, sum, gigi);

double z = 5.4;
double t = 10100.56;
double secondSum = z + t;
Console.WriteLine(secondSum);

double c = 5.4;
double d = 2.1;
double division = c / d;
Console.WriteLine("The division between {0} and {1} is {2:0.000}", c, d, division);

x = -5;     // assigned value -5 to variable x
y = 8;
int tx = 6;
int result = x + y * tx;
Console.WriteLine(result);


int l = (55 + 9) % 9;
Console.WriteLine("Result is = {0}", l);      //display the value of variable l

int h = 20 + -3 * 5 / 8;
Console.WriteLine("Result is = {0}", h);

int gt = 5 + 15 / 3 * 2 - 8 % 3;
Console.WriteLine("Result is = {0}", gt);

string name = "John";
Console.WriteLine("The name is {0} and his age is {1}", name, gt);


string productName = "TV";
Console.WriteLine("The productName is {0} ", productName);


int productYear = 2012;
Console.WriteLine("The productYear value is {0} ", productYear);

float productPrice = 279.99f;
Console.WriteLine("The productPrice value is {0} ", productPrice);
Console.WriteLine(productPrice);

string priceAsString = Convert.ToString(productPrice, CultureInfo.InvariantCulture);
Console.WriteLine("The productPrice value is {0} ", priceAsString);
Console.WriteLine(priceAsString);

double varDouble = 99.10;
int varInt = Convert.ToInt32(varDouble);
Console.WriteLine("varDouble = {0}, varInt = {1}", varDouble, varInt);

CarType carType = CarType.Ford;
Console.WriteLine($"cart type is {carType}");

Console.WriteLine(CarType.Honda);

Console.WriteLine(Vegetables.Onion);
Console.WriteLine(Vegetables.AsianGreens);

string FirstName = "John";
Console.WriteLine("The FirstName is {0}", FirstName);
Console.WriteLine(FirstName);

string LastName = "Turturo";
Console.WriteLine("Hello" + " " + LastName);

string Name1 = "Clark";
string Name2 = "Pall";
string fullName = Name1 + " " + Name2;
Console.WriteLine(fullName);
Console.WriteLine("The fullName is {0} {1}", Name1, Name2);

var MyNumber = 20;
Console.WriteLine(MyNumber);
Console.WriteLine("The MyNum is {0}", MyNumber);

double MyDoubleNumber = -19.99;
Console.WriteLine(MyDoubleNumber);
Console.WriteLine($"The MyDoubleNumber is {MyDoubleNumber}");

bool yay = true;
bool nay = false;
Console.WriteLine(yay);

int xza = 5;
int ytd = 6;
Console.WriteLine(xza + ytd);


//"Operators" chapter

// Basic assignment operator

double ty;
ty = 100.20; // 100.20 is assign to ty
Console.WriteLine(ty);
Console.WriteLine("The number is {0}", ty);

int Number1, Number2;
Number1 = 25;
Number2 = 30;
Console.WriteLine(Number1);
Console.WriteLine("Number1 is {0} and Number2 is {1}", Number1, Number2);

double Number3, Number4;
Number3 = 50.50;
Number4 = Number3;
Console.WriteLine("Number4 is {0}", Number4);

//Arithmetic operators

double Number5 = 10.20D, Number6 = 45.87D, Result;
Result = Number5 + Number6; // addition operation
Console.WriteLine("{0} + {1} = {2}", Number5, Number6, Result);

double Number7 = 10.20, Number8 = 0.5, Result1;
Result1 = Number7 - Number8; // substraction operation
Console.WriteLine("{0} - {1} = {2}", Number7, Number8, Result1);

double Number9 = 10.20, Number10 = 0.5, Result2;
Result2 = Number9 * Number10; // mutiplication operation
Console.WriteLine("{0} * {1} = {2}", Number9, Number10, Result2);

double Number11 = 10.20, Number12 = 0.5, Result3;
Result3 = Number11 / Number12; // division operation
Console.WriteLine("{0} / {1} = {2}", Number11, Number12, Result3);

//Relational operators

bool Result4;
int FirstNumber1 = 10, SecondNumber1 = 20;
Result4 = FirstNumber1 == SecondNumber1;// equal to
Console.WriteLine("{0} == {1} returns {2}", FirstNumber1, SecondNumber1, Result4);

bool Result5;
int FirstNumber2 = 10, SecondNumber2 = 20;
Result5 = FirstNumber2 > SecondNumber2;// greater than
Console.WriteLine("{0} > {1} returns {2}", FirstNumber2, SecondNumber2, Result5);

bool Result6;
int FirstNumber3 = 10, SecondNumber3 = 20;
Result6 = FirstNumber3 < SecondNumber3;// less than
Console.WriteLine("{0} < {1} returns {2}", FirstNumber3, SecondNumber3, Result6);

bool Result7;
int FirstNumber4 = 10, SecondNumber4 = 20;
Result7 = FirstNumber4 >= SecondNumber4;// greater than
Console.WriteLine("{0} >= {1} returns {2}", FirstNumber4, SecondNumber4, Result7);

bool Result8;
int FirstNumber5 = 10, SecondNumber5 = 20;
Result8 = FirstNumber5 <= SecondNumber5;// less than
Console.WriteLine("{0} <= {1} returns {2}", FirstNumber5, SecondNumber5, Result8);

bool Result9;
int FirstNumber6 = 10, SecondNumber6 = 20;
Result9 = FirstNumber5 != SecondNumber5;// not equal to
Console.WriteLine("{0} != {1} returns {2}", FirstNumber6, SecondNumber6, Result9);

// Logical operators

const int number13 = 10;
int Number14 = 20;
var result10 = number13 == Number14 || number13 > 5;
Console.WriteLine(result10);

int Number15 = 10, Number16 = 20;
var Result11 = Number15 == Number16 && Number15 > 5;
Console.WriteLine(Result11);

//Unary operators

int Number17 = 10, Result12;

Result12 = +Number17; // unary plus
Console.WriteLine("+Number17 = " + Result12);

int Number18 = 10, Result13;
Result13 = -Number18; // unary minus
Console.WriteLine("-Number18 = " + Result13);

int Number19 = 10, Result14;
Result14 = ++Number19; // increment
Console.WriteLine("++Number18 = " + Result14);

int Number20 = 10, Result15;
Result15 = --Number20; // decrement
Console.WriteLine("--Number18 = " + Result15);

var flag = false;
Console.WriteLine("Inverts the value of a boolean = {0}  ", !flag);


int Number21 = 10;
Console.WriteLine("Number is {0}", Number21++); // postfix
//Console.WriteLine((Number21)); 

int Number22 = 20;
Console.WriteLine("Number is {0}", ++Number22); // prefix
//Console.WriteLine((Number22));

//Ternary operator

int Number23 = 10;
int Number30 = 2;
string Result16;
Result16 = Number23 / Number30 == 0 ? "Even Number23" : "Odd Number"; // the result is "Odd Number"
Console.WriteLine(" The result is {0}, because {1} divide by is not 0 ", Result16, Number23, Number30);

int Number24 = 10;
string Result17;
Result17 = Number24 / 2 >= 0 ? "Even Number24" : "Odd Number"; // the result is "Even Number24"
Console.WriteLine("{0} is {1}", Number24, Result17);

//Compound Assignment Operators

int Number25 = 10;
Number25 += 5;
Console.WriteLine(Number25);

int Number26 = 10;
Number26 -= 3;
Console.WriteLine(Number26);

int Number27 = 10;
Number27 *= 2;
Console.WriteLine(Number27);

int Number28 = 10;
Number28 /= 3;
Console.WriteLine(Number28);


//Operator precedence-if two operators with different precedence are used, the operator with higher precedence is evaluated first.

int xX = 4 + 3 * 5;
Console.WriteLine("Result is {0}", xX);

int Result18;
int A = 5, B = 6, C = 4;
Result18 = --A * B - ++C;
Console.WriteLine(Result18);

bool Result19;
Result19 = B >= C + A;
Console.WriteLine(Result19);

//Associativity of Operators-if both the operators have same precedence,the expression is evaluated based on the associativity of operator (left to right or right to left).

int D = 5, E = 6, F = 3;
int Result20 = D * E / F;
Console.WriteLine(Result20);

int G = 5, H = 6, I = 3;
int Result21 = G = H = I; //The associativity of = operator is from right to left
Console.WriteLine(Result21);

int J = 5, K = 6, L = 3;
int Result23 = J = K = L;
Console.WriteLine("J = {0}, K = {1}, L = {2}", J, K, L);


//Operators recap
H = 7364;
bool comparisonResult = H > 9;
string MessageText = comparisonResult ? "greater" : "smaller";
Console.WriteLine(MessageText);

int Operand1 = 299;
int Operand2 = 9;
comparisonResult = Operand1 > Operand2;
MessageText = comparisonResult ? "greater" : "smaller";
Console.WriteLine("The value {0} is {1} than {2}", Operand1, MessageText, Operand2);

Console.WriteLine(Result23);
Console.WriteLine("The result is {0}", Result23);
Console.WriteLine($"The result is { Result23 }");

string test = Result23.ToString();
Console.WriteLine("The result is {0}", test);

int Var1 = 19, Var2 = 11, Var3 = 13;
int sum10 = Var1 + Var3;
int difference = Var1 - Var3;

// if var1 > var2, calculate the sum betwen var1 and var3 else the difference
bool comparisonResult2 = Var1 > Var2;

int rezultatFinal = comparisonResult2 ? sum10 : difference;
string AnotherMessageText = comparisonResult2 ? "sum" : "difference";
string ComparisonMessage = comparisonResult2 ? "greater" : "smaller";

Console.WriteLine("Var1 that has value {0} is {1} than Var2 that has value {2} and the {3} is {4}",
    Var1, ComparisonMessage, Var2,AnotherMessageText, rezultatFinal);

//Write a program to calculate (A+B)^2
int Alpha = 2;
int Beta = 10;
int SumOfAlphaAndBeta = Alpha + Beta;
Console.WriteLine("The result of raisind at the second power is {0}", SumOfAlphaAndBeta * SumOfAlphaAndBeta);

int Teta = Beta;
Console.WriteLine("Teta = {0}, Beta = {1}", Teta, Beta);
Console.WriteLine($"Teta = {Teta}, Beta = {Beta}");
Console.WriteLine($" {Teta}, {Beta}");

//There are 100 boxes.Calculate how much( in percentage) do 37 boxes represent out of the total number of boxes.

double TotalAmountOfBoxes = 6311;
double PartialAmountOfBoxes = 379;
double PercentageResult = (PartialAmountOfBoxes * 100) / TotalAmountOfBoxes;
Console.WriteLine("Percentage is {0}",PercentageResult);

// calculate the area of the circle (a = pi * radius^2)


// if-then statement statement


int CompoundNumber = 10;
CompoundNumber += 5;
Console.WriteLine(CompoundNumber);
Console.WriteLine("The number is {0}",CompoundNumber);
Console.WriteLine($"The number = {CompoundNumber}");

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
int Y1= 18;
if (X1 > Y1);
{
    Console.WriteLine("X1 is greater than Y1");
}



//if..else ( if-then-else)  statment

if (Var2 < 5 )
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
{
	Console.WriteLine("{0} is less than 5", Number41);
}
else
{
	Console.WriteLine("{0} is greater than or equal to 5", Number41);
}

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
