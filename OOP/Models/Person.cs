
namespace OOP.Models
{
    internal class Person
    {
       private string _name;

        public Person(string Name)
        {
            _name = Name;
        }
        public string GetName()
        {
            return _name;
        }
    }
}
