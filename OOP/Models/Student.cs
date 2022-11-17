namespace OOP.Models
{
    internal class Student

    {
        private readonly string _firstName;
        private readonly string _lastName;

        private readonly double _age = 10;
        private int _grade;  // the grade the student is in
        private char _rank;
        private float _mathsGrade = 4; //Maths examination grade
        private float _englishGrade = 4; // English examination grade
        private float _bioGrade = 4; // Bio examination grade

        private bool _isRepeating;
        public Courses[] FavoriteCourses = { Courses.Biology, Courses.Maths };

        public Student()
        {
            _firstName = "Ion";
            _lastName = "Roata";
        }

        public Student(string first, string last)
        {
            _firstName = first;
            _lastName = last;
        }

        private string GetFullName()
        {
            return _firstName + " " + _lastName;
        }

        public int GetGrade()
        {
            _grade = _mathsGrade > 4.5 ? 5 : 4;
            Console.WriteLine("MathsGrade is {0}", _grade);
            return _grade;
        }

        // Displays student's details.
        public void Display()
        {
            Console.WriteLine("Full name: {0}", GetFullName());
            Console.WriteLine("Age: {0}", _age);
            Console.WriteLine("Class: {0}-{1}", _grade, _rank);
            Console.WriteLine("Average grade: {0}", Average());
            Console.WriteLine("Repetent: {0}", _isRepeating ? "YES" : "NO");
            Console.WriteLine("Grade is {0}", _grade);


            Console.Write("Favourites: ");
            foreach (var course in FavoriteCourses)
            {
                Console.Write("{0} ", course);
            }
            Console.WriteLine();
        }

        public void SetClass(int whatGrade, char whatRank)
        {
            _grade = whatGrade;
            _rank = whatRank;
        }

        // Set the student's grades for English, Maths and Biology
        public void SetGrades(float eng, float math, float bio)
        {
            _englishGrade = eng;
            _mathsGrade = math;
            _bioGrade = bio;
        }

        // Computes the average of the student's grades.
        public float Average()
        {
            var avg = (_mathsGrade + _englishGrade + _bioGrade) / 3;
            _isRepeating = avg < 5.0f ? true : false;
            return avg;
        }


    }
}


public enum Courses
{
    English,
    Maths,
    Biology,
}

