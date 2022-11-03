namespace OOP.Models;

internal class Car
{
    public string Color = "red";
    public int MaxSpeed;
    public CarType CarType;
    public int NumberOfDoors;

    }

    public enum CarType
    {
        Toyota,
        Dacia,
        Mazda,
    }
}

