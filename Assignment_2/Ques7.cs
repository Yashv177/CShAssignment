using System;
using System.Collections.Generic;

namespace Assignment_2
{
    internal class Ques7
    {
        class Book
        {
            public string Title { get; set; }
            public bool IsAvailable { get; set; } = true;
        }

        class Member
        {
            public string Name { get; set; }
            public List<Book> BorrowedBooks { get; set; } = new List<Book>();
        }

        class Library
        {
            public List<Book> Books { get; set; } = new List<Book>();
            public List<Member> Members { get; set; } = new List<Member>();

            public void RegisterMember(Member member) => Members.Add(member);

            public void LendBook(Member member, Book book)
            {
                if (book.IsAvailable)
                {
                    book.IsAvailable = false;
                    member.BorrowedBooks.Add(book);
                    Console.WriteLine($"{member.Name} borrowed {book.Title}");
                }
                else
                {
                    Console.WriteLine($"{book.Title} is not available.");
                }
            }

            public void ShowAvailableBooks()
            {
                Console.WriteLine("Available Books:");
                foreach (var book in Books)
                {
                    if (book.IsAvailable)
                        Console.WriteLine(book.Title);
                }
            }
        }

        static void Main(string[] args)
        {
            Library lib = new Library();
            Book b1 = new Book { Title = "C# Basics" };
            Book b2 = new Book { Title = "OOP Concepts" };
            lib.Books.Add(b1);
            lib.Books.Add(b2);

            Member m1 = new Member { Name = "Yash" };
            lib.RegisterMember(m1);

            lib.ShowAvailableBooks();
            lib.LendBook(m1, b1);
            lib.ShowAvailableBooks();
            Console.WriteLine("Developed By Yash Kumar Varshney");
        }
    }
}
