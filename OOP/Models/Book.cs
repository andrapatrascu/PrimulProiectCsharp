using System;


namespace OOP.Models
{
    internal class Book
    {
        public string? _Title;
        public string? _Author;
        public int _Pages;


        public Book(string aTitle, string aAuthor, int aPages)// public+name of the class
        {
            _Title = aTitle;
            _Author = aAuthor;
            _Pages = aPages;
        }

        public Book()
        {

        }
    }
}
