namespace OOP.Models;

internal class Book
{
    public string? TitleOfTheBook;
    public string? Author;
    public int Pages;
    public int Reviews;


    public Book(string title, string author, int pages, int reviews)// public+name of the class
    {
        TitleOfTheBook = title;
        Author = author;
        Pages = pages;
        Reviews = reviews;
    }

    public Book()
    {
        Console.WriteLine("From book contructor");
        HasRatings();
    }

    public bool HasRatings()
    {
        return Reviews > 5;
    }
}