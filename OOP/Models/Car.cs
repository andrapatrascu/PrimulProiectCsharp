namespace OOP.Models;

internal class Car
{
    public string Color = "red";  
    public string? Model;
    public int MaxSpeed;
    public int Year;
    public CarType CarType;
    public int NumberOfDoors;
   

    public void fullThrottle()
    {
        Console.WriteLine("The car is going as fast as it can");
    }


}

public enum CarType
{
    Toyota,
    Renault,
    Mazda,
}
