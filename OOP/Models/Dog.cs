namespace OOP.Models;

internal class Dog
{
    public int Age = 10;
    public bool Breed;
    public string TypeOfDog;


    public void Bark()
    {
        Console.WriteLine("Bark Bark !!");

        }

    public string SetTypeOfDog(string typeOfDog)
    {
        TypeOfDog = typeOfDog;
        Console.WriteLine(typeOfDog);
        return typeOfDog;
    }
}