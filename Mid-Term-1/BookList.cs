using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Term_1
{
    class BookList
    {
        private LinkedList<Book> books = new LinkedList<Book>();

        public void AddBook(Book book)
        {
            if (!books.Any(b => b.ISBN == book.ISBN))
            {
                book.Id = books.Count + 1;
                books.AddLast(book);
                Console.WriteLine("Book added successfully!");
            }
            else
            {
                Console.WriteLine("Book already exists in the list!");
            }
        }

        public void RemoveBook(string ISBN)
        {
            bool removed = false;
            foreach (var book in books)
            {
                if (book.ISBN == ISBN)
                {
                    books.Remove(book);
                    removed = true;
                    Console.WriteLine("Book removed successfully!");
                    break;
                }
            }

            if (!removed)
            {
                Console.WriteLine("Book not found in the list!");
            }
        }

        public void FindBook(string title)
        {
            bool found = false;
            foreach (var book in books)
            {
                if (book.Title == title)
                {
                    Console.WriteLine($"Book found: {book.Title} by {book.Author}, ISBN: {book.ISBN}, ID: {book.Id}");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Book not found in the list!");
            }
        }

        public void ListBooksSorted()
        {
            var bookList = books.ToList();
            bookList.Sort();

            Console.WriteLine("Books sorted by ISBN:");
            foreach (var book in bookList)
            {
                Console.WriteLine($"ID: {book.Id}, Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}");
            }
        }

        public void ListBooksUnsorted()
        {
            Console.WriteLine("All books in the list:");
            foreach (var book in books)
            {
                Console.WriteLine($"ID: {book.Id}, Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}");
            }
        }
    }

    public class Book : IComparable<Book>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        public int CompareTo(Book other)
        {
            return ISBN.CompareTo(other.ISBN);
        }
    }
}
