using OOP.Models;

namespace OOP;

internal class Program
{
    private static void Main(string[] args)
    {
        //create Dog object
        var bullDog = new Dog
        {
            //set breed value
            Breed = true
        };

        Console.WriteLine(bullDog.Breed);// AFISEZ

        // access method of the Dog
        bullDog.Bark();


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
    }
}