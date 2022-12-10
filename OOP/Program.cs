using OOP.Models;

namespace OOP;

internal class Program
{
    
    public static void DisplayName(string firstName, int age)
    {
        Console.WriteLine(firstName + " is " + age);
    }

    public static void DisplayCountry(string country = "Norway")
    {
        Console.WriteLine(country);
    }

    public static void DisplayChildren(string child1, string child2, string child3)
    {
        Console.WriteLine("First child is {0), second child is {1}, third child is {2}: " , child2, child1, child3);
    }


    public static int Addition (int x)
    {
        return 5 + x;
    }

    public static int Addition(int d, int e)
    {
        return d + e;
    }

    public static int PlusMethod( int v, int k)
    {
        return v + k;
    }

    public static double PlusMethod(double v, double k)
    {
        return v + k;
    }


    public static void Greeting(string Name)
    {
        Console.WriteLine("Hello {0}", Name);
    }


    public static void Farewell()
    {
        Console.WriteLine("Good Bye!");
    }


    public static int Sum(int x, int y)
    {
        return x + y;
    }

    public static int CountSpaces(string text)
    {
        int count = 0;
        string letter;

        for (int i = 0; i < text.Length; i++)
        {
            letter = text.Substring(i, 1);

            if (letter == " ")
            {
                count++;
            }
        }

        return count;
    }

    public static void DisplayArray(int[] IntegerArray)
    {
        for (int i = 0; i < IntegerArray.Length; i++)
        {
            Console.WriteLine("array[{0}] = {1}", i, IntegerArray[i]);
        }
    }
    public static int Double(int number)
    {
        return number + number;
    }

    private static void Main(string[] args)
    {
        // Using class Person

        int NumberOfPerson = 3;
        Person[] persons = new Person[NumberOfPerson]; // Create Person array

        for (int i = 0; i < NumberOfPerson; i++)
        {
            Console.Write("Enter name[{0}]: ", i);
            string? Name = Console.ReadLine();
            if (String.IsNullOrEmpty(Name))
            {
                i--;
                continue;
            }

            persons[i] = new Person(Name);
        }

        for (int i = 0; i < NumberOfPerson; i++)
        {
            Console.WriteLine("Hello! My name is {0}", persons[i].GetName());
        }

        return;

        // Using class Calculator


        Console.Write("Enter 1st number: ");// read and convert to int
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter 2nd number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter 3rd number: ");
        int num3 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter 4th number: ");
        int num4 = Convert.ToInt32(Console.ReadLine());

        Calculator Calc = new Calculator(num1, num2, num3, num4);

        int OperationResult = 0;      
        Calc.Add(out OperationResult);
        Console.WriteLine("The result of the addition is: {0}", OperationResult);
        Calc.Subtract(out OperationResult);
        Console.WriteLine("The result of the substraction is: {0}", OperationResult);
        Calc.Multiply(out OperationResult);
        Console.WriteLine("The result of the multiplication is: {0}", OperationResult);
        if (Calc.Division(out OperationResult))
        {
            Console.WriteLine("The result of the division is: {0}", OperationResult);
        }
        else
        {
            Console.WriteLine("Undefined operation, division by zero.");
        }

        // Using class School

        School SchoolTV = new School("Traian Vuia");
        School SchoolLR = new School("Liviu Rebreanu", 400);

        string TeacherName = "Klaus";
        bool Ok = SchoolLR.AddTeacher(TeacherName);
        if (Ok)
        {
            Console.WriteLine("{0} was added", TeacherName);
        }
        else
        {
            Console.WriteLine("{0} was NOT added", TeacherName);
        }

        TeacherName = "Franz";
        Ok = SchoolLR.AddTeacher(TeacherName);
        if (Ok)
        {
            Console.WriteLine("{0} was added", TeacherName);
        }
        else
        {
            Console.WriteLine("{0} was NOT added", TeacherName);
        }

        TeacherName = "Jules";
        Ok = SchoolLR.AddTeacher(TeacherName);
        if (Ok)

        {
            Console.WriteLine("{0} was added", TeacherName);
        }
        else
        {
            Console.WriteLine("{0} was NOT added", TeacherName);
        }

        SchoolTV.AddTeacher("Michael Jackson");
        SchoolTV.AddTeacher("Michael Payton");
        SchoolTV.AddTeacher("Michael Jordan");

        SchoolTV.DisplayTeachers();
        SchoolLR.DisplayTeachers();

        
        //Using class Book

        Book book1 = new Book("Harry Potter", "JK Rowling", 400, 3);      
       
        Book book2 = new Book("The rings of power", "Tolkien", 1000, 15);
        book2.TitleOfTheBook = "Lord of the rings";

        Book book3 = new Book();

        Console.WriteLine(book1.HasRatings());
        Console.WriteLine(book2.HasRatings());
        Console.WriteLine(book1.TitleOfTheBook + " was written by " + book1._Author);
        Console.WriteLine("Book name is {0} and the author is {1}", book2.TitleOfTheBook,book2._Author);

        return;
       
        Greeting("Gigel");
        Farewell();

        Console.Write("Please enter the first number: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        int y = Convert.ToInt32(Console.ReadLine());

        int sum = Sum(x, y);
        Console.WriteLine("The sum is {0}", sum);

        Console.Write("Please enter the text: ");
        string text = Console.ReadLine();

        int countOfSpaces = CountSpaces(text);
        Console.WriteLine("The text contains {0} spaces.", countOfSpaces);


        int[] Numbers = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Please enter the number {0}: ", i);
            int K = Convert.ToInt32(Console.ReadLine());
            Numbers[i] = K;
        }
        DisplayArray(Numbers);

        DisplayName("Liam", 5);
        DisplayName("Jenny", 8);
        DisplayName("Anja", 31);

        DisplayCountry("Brazil");
        DisplayCountry();
        DisplayCountry("France");

        Console.WriteLine(Addition(4));
        // Console.WriteLine(Addition2(4,5));// sum between 2 parameters

        int t = Addition(25, 25);
        Console.WriteLine("The sum is {0}",t);

        DisplayChildren("Keanu", "Anna", "Oliver");


        int myNum1 = PlusMethod(30, 31);
        double myNum2 = PlusMethod(25.6, 36.7);
        Console.WriteLine("The sum is {0}", myNum1);
        Console.WriteLine("Int: " + myNum1);
        Console.WriteLine("The sum is {0}", myNum2);
        Console.WriteLine("Double: " + myNum1);

        //create Dog object
        var bullDog = new Dog
        {
            //set breed value
            Breed = true,
            Age = 12,
            TypeOfDog = "Pechinez",
        };

        Console.WriteLine(bullDog.Breed);// AFISEZ

        // access method of the Dog
        bullDog.Bark();
        bullDog.SetTypeOfDog("Labrador");
        Console.WriteLine(bullDog.TypeOfDog);
        bullDog.LastName("Liam");//Liam=argument; the method LastName is called


        var car = new Car();
        Console.WriteLine(car.Color);
        Console.WriteLine(car.MaxSpeed);
        Console.WriteLine(car.CarType);

        car.Color = "blue";
        car.MaxSpeed = 250;
        car.CarType = CarType.Toyota;
        Console.WriteLine(car.Color);
        Console.WriteLine(car.MaxSpeed);
        Console.WriteLine(car.CarType);


        Car car2 = new Car();
        car2.MaxSpeed = 200;
        Console.WriteLine(car2.Color);
        Console.WriteLine(car2.MaxSpeed);

        Car Ford = new Car();
        Ford.MaxSpeed = 300;
        Ford.Color = "green";
        Ford.Year = 1970;
        Ford.Model = "Mustang";
        Console.WriteLine(Ford.Color);
        Console.WriteLine(Ford.Year);
        Console.WriteLine(Ford.Model);
        Ford.fullThrottle();//Call the method( accessed the method using . synthax)

        // Declare variable S1 of type Student and instantiate an object by calling the constructor(string, string)
        Student s1 = new Student("Gigi", "Kent");
        Student s2 = new Student();

        // Call(invoke) method SetClass().
        s1.SetClass(6, 'A');
        s1.SetGrades(3.75f, 2.5f, 5.0f);

        s2.SetClass(7, 'C');
        s2.SetGrades(6.0f, 7.5f, 10.0f);

        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.DarkRed;

        s1.Display();
        s2.Display();

        int grade = s1.GetGrade();
        s1.GetGrade();

        //S1.GetFullName
        // Console.Beep();

        // Call Average() method on Student object S1.
        float avg = s1.Average();
        Console.WriteLine("Average: {0}", avg);

        Console.Write("Favourites(from outside): ");
        foreach (var course in s1.FavoriteCourses)
        {
            Console.Write("{0} ", course);
        }

        Console.WriteLine();

        Employee._age = 22;

        Employee employee1 = new Employee();//employee1 = is an object of Employee type
        employee1._firstname = "Jane";//I assigned a value to the firstname field of the employee1 object

        employee1.SetLastName("Costache");
        employee1.SetOccupation(Occupation.SoftwareTester);

        Employee TheMaid = new Employee();
        TheMaid.SetName("Gugulina", "Aceausului");
        TheMaid.SetOccupation(Occupation.ProjectManager);

        Employee.SetAge(43);

        employee1.Display();
        TheMaid.Display();

        Employee[] Employees = new Employee[5];
        for (int i = 0; i < Employees.Length; ++i)
        {
            Employees[i] = new Employee();
            Employees[i].SetName("Ion", "Vasilon");
        }

        Console.WriteLine("The End");








    }
}

