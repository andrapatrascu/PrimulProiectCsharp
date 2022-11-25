namespace OOP.Models;

internal class Dog
{
    public int Age = 10;
    public bool Breed;
    public string? TypeOfDog = "Chuahua";
    public string? Name;


    public void Bark()
    {
        Console.WriteLine("Bark Bark !!");
    }

    public void LastName(string name)// name=parameter
    {
        Console.WriteLine(name + " Refnes");
    }
    public string SetTypeOfDog(string typeOfDog)
    {
        TypeOfDog = typeOfDog;
        Console.WriteLine(typeOfDog);
        return typeOfDog;
    }
}