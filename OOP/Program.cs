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
        Console.WriteLine("First child is {0), second child is {1}, third child is {2}: ", child2, child1, child3);
    }


    public static int Addition(int x)
    {
        return 5 + x;
    }

    public static int Addition(int d, int e)
    {
        return d + e;
    }

    public static int PlusMethod(int v, int k)
    {
        return v + k;
    }

    public static double PlusMethod(double v, double k)
    {
        return v + k;
    }


    public static void Greeting(string name)
    {
        Console.WriteLine("Hello {0}", name);
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
        var count = 0;

        for (var i = 0; i < text.Length; i++)
        {
            var letter = text.Substring(i, 1);

            if (letter == " ")
            {
                count++;
            }
        }

        return count;
    }

    public static void DisplayArray(int[] integerArray)
    {
        for (var i = 0; i < integerArray.Length; i++)
        {
            Console.WriteLine("array[{0}] = {1}", i, integerArray[i]);
        }
    }
    public static int Double(int number)
    {
        return number + number;
    }

    private static void Main(string[] args)
    {
        // Using class School

        var schoolTv = new School("Traian Vuia");
        var schoolLr = new School("Liviu Rebreanu", 400);

        var teacherName = "Klaus";
        var ok = schoolLr.AddTeacher(teacherName);
        Console.WriteLine(ok ? "{0} was added" : "{0} was NOT added", teacherName);

        teacherName = "Franz";
        ok = schoolLr.AddTeacher(teacherName);
        if (ok)
        {
            Console.WriteLine("{0} was added", teacherName);
        }
        else
        {
            Console.WriteLine("{0} was NOT added", teacherName);
        }

        teacherName = "Jules";
        ok = schoolLr.AddTeacher(teacherName);
        if (ok)

        {
            Console.WriteLine("{0} was added", teacherName);
        }
        else
        {
            Console.WriteLine("{0} was NOT added", teacherName);
        }

        schoolTv.AddTeacher("Michael Jackson");
        schoolTv.AddTeacher("Michael Payton");
        schoolTv.AddTeacher("Michael Jordan");

        schoolTv.DisplayTeachers();
        schoolLr.DisplayTeachers();


        //Using class Book

        var book1 = new Book("Harry Potter", "JK Rowling", 400, 3);

        var book2 = new Book("The rings of power", "Tolkien", 1000, 15)
        {
            TitleOfTheBook = "Lord of the rings"
        };

        Console.WriteLine(book1.HasRatings());
        Console.WriteLine(book2.HasRatings());
        Console.WriteLine(book1.TitleOfTheBook + " was written by " + book1.Author);
        Console.WriteLine("Book name is {0} and the author is {1}", book2.TitleOfTheBook, book2.Author);

        return; //if this is called the next lines will not be executed

        Greeting("Gigel");
        Farewell();

        Console.Write("Please enter the first number: ");
        var x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        var y = Convert.ToInt32(Console.ReadLine());

        var sum = Sum(x, y);
        Console.WriteLine("The sum is {0}", sum);

        Console.Write("Please enter the text: ");
        var text = Console.ReadLine();

        var countOfSpaces = CountSpaces(text);
        Console.WriteLine("The text contains {0} spaces.", countOfSpaces);


        var numbers = new int[5];

        for (var i = 0; i < 5; i++)
        {
            Console.Write("Please enter the number {0}: ", i);
            var k = Convert.ToInt32(Console.ReadLine());
            numbers[i] = k;
        }
        DisplayArray(numbers);

        DisplayName("Liam", 5);
        DisplayName("Jenny", 8);
        DisplayName("Anja", 31);

        DisplayCountry("Brazil");
        DisplayCountry();
        DisplayCountry("France");

        Console.WriteLine(Addition(4));
        // Console.WriteLine(Addition2(4,5));// sum between 2 parameters

        var t = Addition(25, 25);
        Console.WriteLine("The sum is {0}", t);

        DisplayChildren("Keanu", "Anna", "Oliver");


        var myNum1 = PlusMethod(30, 31);
        var myNum2 = PlusMethod(25.6, 36.7);
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


        var car2 = new Car();
        car2.MaxSpeed = 200;
        Console.WriteLine(car2.Color);
        Console.WriteLine(car2.MaxSpeed);

        var ford = new Car();
        ford.MaxSpeed = 300;
        ford.Color = "green";
        ford.Year = 1970;
        ford.Model = "Mustang";
        Console.WriteLine(ford.Color);
        Console.WriteLine(ford.Year);
        Console.WriteLine(ford.Model);
        ford.FullThrottle();//Call the method( accessed the method using . synthax)

        // Declare variable S1 of type Student and instantiate an object by calling the constructor(string, string)
        var s1 = new Student("Gigi", "Kent");
        var s2 = new Student();

        // Call(invoke) method SetClass().
        s1.SetClass(6, 'A');
        s1.SetGrades(3.75f, 2.5f, 5.0f);

        s2.SetClass(7, 'C');
        s2.SetGrades(6.0f, 7.5f, 10.0f);

        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.DarkRed;

        s1.Display();
        s2.Display();

        var grade = s1.GetGrade();
        s1.GetGrade();

        //S1.GetFullName
        // Console.Beep();

        // Call Average() method on Student object S1.
        var avg = s1.Average();
        Console.WriteLine("Average: {0}", avg);

        Console.Write("Favourites(from outside): ");
        foreach (var course in s1.FavoriteCourses)
        {
            Console.Write("{0} ", course);
        }

        Console.WriteLine();

        Employee.Age = 22;

        var employee1 = new Employee();//employee1 = is an object of Employee type
        employee1.Firstname = "Jane";//I assigned a value to the firstname field of the employee1 object

        employee1.SetLastName("Costache");
        employee1.SetOccupation(Occupation.SoftwareTester);

        var theMaid = new Employee();
        theMaid.SetName("Gugulina", "Aceausului");
        theMaid.SetOccupation(Occupation.ProjectManager);

        Employee.SetAge(43);

        employee1.Display();
        theMaid.Display();

        var employees = new Employee[5];
        for (var i = 0; i < employees.Length; ++i)
        {
            employees[i] = new Employee();
            employees[i].SetName("Ion", "Vasilon");
        }

        Console.WriteLine("The End");
    }
}

