using OOP.Models;

namespace OOP;

internal class Program
{
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

