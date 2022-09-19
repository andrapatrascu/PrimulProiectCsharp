// See https://aka.ms/new-console-template for more information

using PrimulProiectCsharp;

Console.WriteLine("Hello");
Console.WriteLine("Andra");

int x = 5;      // declared variable of type int and initialized it with the value 5
int y = 101;
int sum = x + y;
string gigi = "Ana are mere";
Console.WriteLine("the sum of {0} and {1} is {2} and also {3}", x, y, sum, gigi);

double z = 5.4;
double t = 10100.56;
double the_second_sum = z + t;
Console.WriteLine(the_second_sum);

double c = 5.4;
double d = 2.1;
double division = c / d;
Console.WriteLine("The division between {0} and {1} is {2:0.000}", c, d, division);

int p = -5 + 8 * 6;     // declared variable of type int and initialized it with an expression


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

string priceAsString = Convert.ToString(productPrice);
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


Console.WriteLine("Sum of 3+4 is " + 3 + 4);
Console.WriteLine("10 divided by 4 is " + 10 / 4);
Console.WriteLine("25-7 is " + (25 - 7));