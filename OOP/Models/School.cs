namespace OOP.Models;

internal class School
{
    private readonly string? _name;
    private int _totalStudents;
    private readonly string[] _teachers; // Array containing the teacher's names
    private int _teachersAdded; // Number added teachers;
    private const int NumberOfTeachers = 2; // A single instance of NumberOfTeachers exists.

    public School(string name, int numberOfStudents)
    {
        _name = name;
        _totalStudents = numberOfStudents;
        _teachers = new string[NumberOfTeachers]; // Alocatting array with NumberOfTeachers elements
        _teachersAdded = 0;
    }

    public School(string name)
    {
        _name = name;
        _teachers = new string[NumberOfTeachers]; // Alocartting array with NumberOfTeachers elements
        _teachersAdded = 0;
    }

    public bool AddTeacher(string teacherName)
    {
        if (_teachersAdded >= NumberOfTeachers) // Check if there is still room in the array(Verifica daca mai este loc in array)
        {
            return false;
        }
        // Add TeacherName in array, on the last position
        _teachers[_teachersAdded] = teacherName;
        _teachersAdded++;
        return true;
    }

    public void DisplayTeachers()
    {
        Console.WriteLine("Lista profesori ai scolii {0}", _name);
        for (var i = 0; i < _teachersAdded; i++)
        {
            Console.WriteLine(_teachers[i]);
        }
    }

}