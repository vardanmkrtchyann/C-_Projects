using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public bool IsBorrowed { get; set; }

    public Book(string title, string author, string ISBN) { 
        Title = title;
        Author = author;
        this.ISBN = ISBN;
        IsBorrowed = false;
    }

    public void Borrow()
    {
        IsBorrowed = true;
    }

    public void Return()
    {
        IsBorrowed = false;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, ISBN: {ISBN}, IsBorrowed: {IsBorrowed}");
    }
}

