using OOP.Modals;
using OOP.Models;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //create Dog object
            Dog bullDog = new Dog();

            // access breed of the Dog 
            bullDog.Breed = true;
            Console.WriteLine(bullDog.Breed);// AFISEZ

            // access method of the Dog
            bullDog.Bark();

            Car car = new Car ();
            
            Console.WriteLine(car.Color);
            Console.WriteLine(car.MaxSpeed);
            Console.WriteLine(car.CarType);


            car.Color = "blue";
            car.MaxSpeed = 250;
            car.CarType = CarType.Toyota;
            Console.WriteLine(car.Color);
            Console.WriteLine(car.MaxSpeed);
            Console.WriteLine(car.CarType);



            Car myObj = new Car();
            myObj.MaxSpeed = 200;
            Console.WriteLine(myObj.Color);
            Console.WriteLine(myObj.MaxSpeed);

            // Declare variable S1 of type Student and instantiate an object by calling the constructor(string, string)
            Student S1 = new Student("Gigi", "Kent");
            Student S2 = new Student();

            // Call(invoke) method SetClass().
            S1.SetClass(6, 'A');
            S1.SetGrades(3.75f, 2.5f, 5.0f);

            S2.SetClass(7, 'C');
            S2.SetGrades(6.0f, 7.5f, 10.0f);

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;

            S1.Display();
            S2.Display();

            // Console.Beep();

            // Call Average() method on Student object S1.
            float Avg = S1.Average();
            Console.WriteLine("Average: {0}", Avg);

            Console.Write("Favourites(from outside): ");
            foreach (Courses Course in S1.FavouriteCourses)
            {
	            Console.Write("{0} ", Course);
            }
        }
    }
}
