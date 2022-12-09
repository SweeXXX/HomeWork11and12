using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    class Library
    {
        public Book[] books = new Book[]{new Book{Name = "Idiot", Aut = "Dostoevskij", Publish = "Kniga"},
                new Book{Name = "Voina i mir", Aut = "Tolstoj", Publish = "Klassika"},
                new Book{Name = "Nyanya", Aut = "Pushkin", Publish = "Detskaya Literatura"}};
        public void SortingLibrary(DelegatSorted deleg, int i)
        {
            deleg.Invoke(i);
        }
        public void Sort(int kret)
        {
            if (kret == 1)
            {
                Console.Write("По названию ");
                books = books.OrderBy(e => e.Name).ToArray();
            }
            else if (kret == 2)
            {
                Console.Write("По автору ");
                books = books.OrderBy(e => e.Aut).ToArray();
            }
            else
            {
                Console.Write("По издательству ");
                books = books.OrderBy(e => e.Publish).ToArray();
            }
            Console.WriteLine("отсортированныи массив");
            foreach (var item in books)
            {
                Console.WriteLine("Название - {0}, автор - {1}, издательство - {2}", item.Name, item.Aut, item.Publish);
            }
        }
    }
}
