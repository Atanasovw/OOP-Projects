using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Book
    {
        private string title;
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
            }
        }
        private int year;
        public int Year
        {
            get { return year; } set
            {
                    
                year = value;
            }
        }
        public IReadOnlyList<string> Authors { get; set; }
        
        public Book(string title, int year, params string[] authors)
        {
            this.title = title;
            this.year = year;
            this.Authors = authors;
            
        }


    }
}
