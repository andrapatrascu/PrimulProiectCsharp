namespace OOP.Models
{
    internal class Student
    {
        public Student()
        {
            FirstName = "Ion";
            LastName = "Roata";
        }

        public Student(string First, string Last)
        {
            FirstName = First;
            LastName = Last;
        }

        private string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        // Displays student's details.
        public void Display()
        {
            Console.WriteLine("Full name: {0}", GetFullName());
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Class: {0}-{1}", Grade, Rank);
            Console.WriteLine("Average grade: {0}", Average());
            Console.WriteLine("Repetent: {0}", IsRepeating ? "YES" : "NO");

            Console.Write("Favourites: ");
            foreach (Courses Course in FavouriteCourses) {
                Console.Write("{0} ", Course);
            }
            Console.WriteLine();
        }

        public void SetClass(int WhatGrade, char WhatRank)
        {
            Grade = WhatGrade;
            Rank = WhatRank;
        }

        // Set the student's grades for English, Maths and Biology
        public void SetGrades(float Eng, float Math, float Bio)
        {
            EnglishGrade = Eng;
            MathsGrade = Math;
            BioGrade = Bio;
        }

        // Computes the average of the student's grades.
        public float Average()
        {
            float Avg = (MathsGrade + EnglishGrade + BioGrade) / 3;
            IsRepeating = Avg < 5.0f ? true : false;
            return Avg;
        }

        private string FirstName;
        private string LastName;

        private double Age = 10;
        private int Grade;  // the grade the student is in
        private char Rank; 
        private float MathsGrade = 4; //Maths examination grade
        private float EnglishGrade = 4; // English examination grade
        private float BioGrade = 4; // Bio examination grade

        private bool IsRepeating;
        public Courses[] FavouriteCourses = { Courses.Biology, Courses.Maths };
    }
}
public enum Courses
{
    English,
    Maths,
    Biology,
}

