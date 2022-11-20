namespace OOP.Models
{
    public enum Occupation
    {
        Developer,
        ProjectManager,
        SoftwareTester
    }
    internal class Employee
    {
        public string? _firstname;
        private string? _lastname;
        public static int _age;
        public Occupation? _occupation;


        public void SetLastName(string CevaNume)
        {
            _lastname = CevaNume;
        }

        public static void SetAge(int Age)
        {
            _age = Age;
        }
        public void SetName(string FirstName, string LastName)
        {
            _firstname = FirstName;
            _lastname = LastName;
        }

        public void SetOccupation(Occupation Job) 
        {
            _occupation = Job;
        }

        public void Display()
        {
            Console.WriteLine("Nume: {0} {1}, occupation {2}", _firstname, _lastname, _occupation.ToString());
        }
    }
}


