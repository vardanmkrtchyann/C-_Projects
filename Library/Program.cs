using ConsoleApp1;
using System;
class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();

        Book book1 = new Book("1984", "George Orwell", "123456789");
        Book book2 = new Book("To Kill a Mockingbird", "Harper Lee", "987654321");
        EBook ebook1 = new EBook("Digital Fortress", "Dan Brown", "1122334455", "http://example.com/download");

        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(ebook1);

        Member member1 = new Member("Alice", "M001");
        PremiumMember member2 = new PremiumMember("Bob", "M002");

        library.AddMember(member1);
        library.AddMember(member2);

        library.BorrowBook("123456789", "M001");
        library.ReturnBook("123456789");

        library.DisplayBooks();
    }
}
