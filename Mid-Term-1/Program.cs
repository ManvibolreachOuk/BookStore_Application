using System;

namespace Mid_Term_1
{
    class Program
    {
        static void Main(string[] args)
        {
            BookList bookList = new BookList();

            while (true)
            {
                Console.WriteLine("+---------------------Welcome------------------------+");
                Console.WriteLine("|         Enter 1 to add a book                      |");
                Console.WriteLine("|         Enter 2 to remove a book                   |");
                Console.WriteLine("|         Enter 3 to find a book                     |");
                Console.WriteLine("|         Enter 4 to list all books sorted by ISBN   |");
                Console.WriteLine("|         Enter 5 to list all books unsorted         |");
                Console.WriteLine("|         Enter 0 to exit                            |");
                Console.WriteLine("+----------------------------------------------------+");
                Console.Write("Press the letter corresponding to your choice-> ");
                string input = Console.ReadLine();
                int choice;
                if (int.TryParse(input, out choice))
                {
                    switch (choice)
                    {
                        case 0:
                            Console.WriteLine("Exiting program...");
                            return;
                        case 1:
                            // Add a book
                            Console.WriteLine("Enter book title:");
                            string title = Console.ReadLine();
                            Console.WriteLine("Enter book author:");
                            string author = Console.ReadLine();
                            Console.WriteLine("Enter book ISBN:");
                            string isbn = Console.ReadLine();

                            Book book = new Book
                            {
                                Title = title,
                                Author = author,
                                ISBN = isbn
                            };

                            bookList.AddBook(book);
                            break;
                        case 2:
                            // Remove a book
                            Console.WriteLine("Enter book ISBN:");
                            string isbnToRemove = Console.ReadLine();
                            bookList.RemoveBook(isbnToRemove);
                            break;
                        case 3:
                            // Find a book
                            Console.WriteLine("Enter book title:");
                            string titleToFind = Console.ReadLine();
                            bookList.FindBook(titleToFind);
                            break;
                        case 4:
                            // List all books sorted by ISBN
                            bookList.ListBooksSorted();
                            break;
                        case 5:
                            // List all books unsorted
                            bookList.ListBooksUnsorted();
                            break;
                        default:
                            Console.WriteLine("Invalid input!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                Console.WriteLine();
            }
        }

    }
}
