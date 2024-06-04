using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Library
    {
        private List<Book> books;
        private List<Member> members;
        

        public Library() { 
            books = new List<Book>();
            members = new List<Member>();
        }
        public Library(List<Book> books, List<Member> members)
        {
            for (int i = 0; i < books.Count; i++)
            {
                books.Add(books[i]);
            }
            for (int i = 0; i < members.Count; i++)
            {
                members.Add(members[i]);
            }
        }
        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void AddMember(Member member)
        {
            if (!members.Contains(member))
            {
                members.Add(member);
            }
        }

        public void BorrowBook(string isbn, string memberID)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].ISBN.Equals(isbn))
                {
                    if (!books[i].IsBorrowed)
                    {
                        var member = members.FirstOrDefault(m => m.MemberID == memberID);
                        if (member != null)
                        {
                            member.Notify($"You have borrowed {books[i].Title}");
                            books[i].Borrow();
                        }
                    }
                    else {
                        books[i].DisplayInfo();
                    }
                    break;
                }
            }
        }
        public void ReturnBook(string isbn)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].ISBN.Equals (isbn))
                {
                    books[i].Return();
                    break;
                }
            }
        }

        public void DisplayBooks()
        {
            foreach (Book book in books)
            {
                book.DisplayInfo();
            }
        }
    }
}
