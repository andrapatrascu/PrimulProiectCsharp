using System;

namespace OOP.Models
{
    internal class School
    {
        string? _Name;
        int _totalStudents;
        string[]? _Teachers; // Array containing the teacher's names
        int _TeachersAdded; // Number added teachers;
        static int NumberOfTeachers = 2; // A single instance of NumberOfTeachers exists.

        public School(string Name, int NumberOfStudents)
        {
            _Name = Name;
            _totalStudents = NumberOfStudents;
            _Teachers = new string[NumberOfTeachers]; // Alocatting array with NumberOfTeachers elements
            _TeachersAdded = 0;
        }

        public School(string Name)
        {
            _Name = Name;
            _Teachers = new string[NumberOfTeachers]; // Alocartting array with NumberOfTeachers elements
            _TeachersAdded = 0;
        }

        public bool AddTeacher(string TeacherName)
        {
            if (_TeachersAdded >= NumberOfTeachers) // Check if there is still room in the array(Verifica daca mai este loc in array)
            {
                return false;
            }
            // Add TeacherName in array, on the last position
            _Teachers[_TeachersAdded] = TeacherName;
            _TeachersAdded++;
            return true;
        }

        public void DisplayTeachers()
        {
            Console.WriteLine("Lista profesori ai scolii {0}", _Name);
            for (int i = 0; i < _TeachersAdded; i++)
            {
                Console.WriteLine(_Teachers[i]);
            }
        }

    }
}
