using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteket
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            Stack<Book> customer = new Stack<Book>();

            books.Add(new Book("The future of programming", "Nerd"));
            books.Add(new Book("The future of programming 2", "Nerd"));
            books.Add(new Book("The future of programming 3", "Nerd"));
            books.Add(new Book("Gaming", "Gamer"));
            books.Add(new Book("Gaming 2", "Gamer"));
            books.Add(new Book("Gaming 3", "Gamer"));

            bool power = true;
            while (power)
            {

                Console.Clear();
                

                foreach (Book book in books)
                {
                    Console.WriteLine($"{book.Title}, {book.Auther} ");

                }

                Console.WriteLine("Choice a book: ");
                string input = Console.ReadLine();

                Book choicingBook = new Book("","");
                foreach (Book book in books)
                {
                    if(book.Title.ToLower() == input.ToLower())
                    {
                        choicingBook = book;
                    }

                }

                customer.Push(choicingBook);
                books.Remove(choicingBook);
                Console.WriteLine();
                Console.WriteLine("Do you want to get more books? N/Y");
                input = Console.ReadLine();

                if (input.ToLower() == "n" || books.Count == 0) 
                {
                    power = false;
                }

            }

            for (int i = 0; i < customer.Count; i++)
            {
                Book deletingBook = customer.Peek();

                Console.WriteLine($"Now getting {deletingBook.Title}.....");

                customer.Pop();

            }

            Console.ReadLine();
        }
    }
}
