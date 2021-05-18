using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.Class_Objects.Models
{
    class Book
    {
        //Data Fields: 
        private int bookNumber;
        private string bookTitle;
        private string bookAuthor;

        public Book()
        {
        }

        public Book(int bookNumber, string bookTitle, string bookAuthor)
        {
            this.BookNumber = bookNumber;
            this.BookTitle = bookTitle;
            this.BookAuthor = bookAuthor;
        }

        public int BookNumber { get => bookNumber; set => bookNumber = value; }
        public string BookTitle { get => bookTitle; set => bookTitle = value; }
        public string BookAuthor { get => bookAuthor; set => bookAuthor = value; }

        public override string ToString()
        {
            return 
                "\n| Number: " + this.bookNumber + 
                "\n| Title: " + this.bookTitle +
                "\n| Author: " + this.bookAuthor +
                "\n----------------------------------"
                ;
        }

       


    }
}
