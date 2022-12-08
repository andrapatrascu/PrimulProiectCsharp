using System;


namespace OOP.Models
{
    internal class Book
    {
        public string? TitleOfTheBook;
        public string? _Author;
        public int _Pages;
        public int _Reviews;


        public Book(string aTitle, string aAuthor, int aPages, int aReviews)// public+name of the class
        {
            TitleOfTheBook = aTitle;
            _Author = aAuthor;
            _Pages = aPages;
            _Reviews = aReviews;
        }

        public Book()
        {
            Console.WriteLine("From book contructor");
            HasRatings();
        }

        public bool HasRatings()
        {
            if (_Reviews > 5)
            {
                return true;
            }
            return false;
        }
    }
}
