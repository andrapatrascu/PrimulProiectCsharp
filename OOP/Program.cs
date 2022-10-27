using OOP.Modals;

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

        }
    }
}

