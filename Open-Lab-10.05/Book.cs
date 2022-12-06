using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_10._03
{
    internal class Book
    {
        private string title;
        private int pages;
        private string category;
        private string author;
        private int releaseDate;

        public string Title
        { get { return title; } set { title = value; } }

        public int Pages
        { get { return pages; } set { pages = value; } }

        public string Category
        { get { return category; } set { category = value; } }

        public int ReleaseDate
        {
            get => releaseDate;
            set
            {
                if ((value >= 2021) || (value <= 1450))
                {
                    releaseDate = -1;
                }
                else
                {
                    releaseDate = value;
                }
            }

        }

        public string Author
        { get { return author; } set { author = value; } }


        public Book()
        {
            title = "-1";
            pages = -1;
            category = "-1";
            author = "-1";
            releaseDate = -1;
        }

        public Book(string mtitle, int mpages)
        {
            title = mtitle;
            pages = mpages;
            category = "-1";
            author = "-1";
            releaseDate = -1;
        }

        public Book(string mtitle, int mpages, string mcategory, string mauthor, int mreleaseDate)
        {
            title = mtitle;
            pages = mpages;
            category = mcategory;
            author = mauthor;
            releaseDate = mreleaseDate;
        }

        public override string ToString()
        {
            return String.Format($"{title}\n{pages}\n{category}\n{author}\n{releaseDate}");
        }

    }
}
