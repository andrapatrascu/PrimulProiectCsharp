namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //create Dog object
            Dog bullDog = new Dog();

            // access breed of the Dog 
            bullDog.Breed = "Bull Dog";
            Console.WriteLine(bullDog.Breed);// AFISEZ

            // access method of the Dog
            bullDog.Bark();
            Car myObj1 = new Car();
            Car myObj2 = new Car();
            Console.WriteLine(myObj1.Color);
            Console.WriteLine(myObj2.Color);

            Car myObj = new Car();
            myObj.MaxSpeed = 200;
            Console.WriteLine(myObj.Color);
            Console.WriteLine(myObj.MaxSpeed);

        }
    }
}

