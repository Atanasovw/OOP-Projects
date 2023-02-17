using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWinForm_3
{
    internal class Book
{
        private string author;
        private string title;
        private string publisher;
        private string genre;
        private string cover;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }
         public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Publisher
        { 
            get { return publisher; }
            set { publisher = value; }

        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }
        public string Cover 
        { 
            get { return cover;}
            set { cover = value; }
        }

        
    }

}

