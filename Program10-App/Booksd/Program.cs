using System;
using System.Collections.Generic;

namespace Books
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }
    class Program
    {
        static List<Book> books=new List<Book>();
        static void Main(string[] args)
        {
            bool exit=false;
            while (!exit)
            {
                Console.WriteLine("BookStore Application");
                Console.WriteLine("1.Add Book");
                Console.WriteLine("2.Update Book");
                Console.WriteLine("3. View Book Inventory");
                Console.WriteLine("4.Exit");
                Console.WriteLine("Enter your choice");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddBook();
                        break;
                    case "2":
                        UpdateBook();
                        break;
                    case "3":
                        ViewInventory();
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again");
                        break;
                }
                Console.WriteLine();
            }


        }

        static void AddBook()
        {
            Console.WriteLine("Add Book");
            Console.WriteLine("Enter the title:");
            string title=Console.ReadLine();
            Console.WriteLine("Enter the author");
            string author = Console.ReadLine();

            Book book = new Book { Title = title, Author = author };
            books.Add(book);

            Console.WriteLine("Book added successfully");
        }
        static void UpdateBook()
        {
            Console.WriteLine("Update Book");
            Console.WriteLine("Enter the index of the book to update");
            if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < books.Count)
            {
                Console.Write("Enter the new title");
                string newTitle= Console.ReadLine();
                Console.Write("Enter the new author:");
                string newAuthor=Console.ReadLine();

                books[index].Title = newTitle;
                books[index].Author = newAuthor;

                Console.WriteLine("Book updated successfully");

            }
            else
            {
                Console.WriteLine("Invalid Index");
            }

        }
        static void ViewInventory()
        {
            Console.WriteLine("Book Inventory");
            if (books.Count==0)
            {
                Console.WriteLine("No books in inventory");

            }
            else
            {
                for (int i=0; i<books.Count; i++)
                {
                    Console.WriteLine($"Index:{i}, Title:{books[i].Title}, Author:{books[i].Author}");
                }
            }
        }
    }
}
