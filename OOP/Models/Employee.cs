namespace OOP.Models;

internal class Employee
{
    public string? Firstname;
    private string? _lastname;
    public static int Age;
    public Occupation? Occupation;


    public void SetLastName(string cevaNume)
    {
        _lastname = cevaNume;
    }

    public static void SetAge(int age)
    {
        Age = age;
    }
    public void SetName(string firstName, string lastName)
    {
        Firstname = firstName;
        _lastname = lastName;
    }

    public void SetOccupation(Occupation job)
    {
        Occupation = job;
    }

    public void Display()
    {
        Console.WriteLine("Nume: {0} {1}, occupation {2}", Firstname, _lastname, Occupation.ToString());
    }

}

public enum Occupation
{
    Developer,
    ProjectManager,
    SoftwareTester
}