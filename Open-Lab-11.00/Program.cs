using System;
using System.Collections.Generic;

namespace Open_Lab_11._00
{
    class Program
    {
        static void Main(string[] args)
        {
            Book fyzika = new Book("Fyzika pre mladych",58,Book.CategoryList[2],"Michal Sladecek", 2004);
            Book telesna = new Book("Ako cvicit",38, Book.CategoryList[2],"Michal Sladecek", 2018);

            List<Book> books = new List<Book>() { fyzika,telesna};
            List<string> students = new List<string>() { "Matej", "Jakub",};

            Library schoolLibrary = new Library(2, 2, students, books);
            schoolLibrary.Discribe();
      
        }
    }
}
