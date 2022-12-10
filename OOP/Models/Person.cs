
namespace OOP.Models
{
    internal class Person
    {
       private string _Name;

        public Person(string Name)
        {
            _Name = Name;
        }
        public string GetName()
        {
            return _Name;
        }
    }
}
