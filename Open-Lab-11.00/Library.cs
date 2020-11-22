﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_11._00
{
    class Library : Book
    {
        public int NumberOfBooks { get; set; }
        public int NumberOfStudents { get; set; }
        public List<string> StudentsList { get; set; }
        public List<Book> BooksList { get; set; }

        public Library(int numberOfBooks, int numberOfStudents, List<string> studentsList, List<Book> booksList)
        {
            NumberOfBooks = numberOfBooks;
            NumberOfStudents = numberOfStudents;
            StudentsList = studentsList;
            BooksList = booksList;
        }
        public Library()
        {
            Book book = new Book();          
            NumberOfBooks = -1;
            NumberOfStudents = -1;
            StudentsList = new List<string>();
            BooksList = new List<Book>();
        }

        public override string ToString()
        {
            return $"{NumberOfBooks}\n{NumberOfStudents}\n{StudentsList}\n{BooksList}";
        }
        public void Discribe()
        {
            Console.WriteLine($"Pocet studentov:{NumberOfStudents}\nPocet knih:{NumberOfBooks}");

            Console.WriteLine("----------");
            Console.WriteLine("Vypis studentov:");

            foreach(string Pupil in StudentsList)
            {
                Console.WriteLine(Pupil);
             
            }

            Console.WriteLine("----------");
            Console.WriteLine("Vypis knih:");

            foreach (Book book in BooksList)
            {
                Console.WriteLine(book.ToString());
                Console.WriteLine();
            }

        }
    }
}
