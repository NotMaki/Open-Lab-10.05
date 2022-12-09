using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_10._05
{
    internal class Book
    {
        private string title;
        private int pages;
        private string category;
        private string author;
        private int releaseDate;

        /// <summary>
        /// list s kategóriami
        /// </summary>
        public static List<string> categoryList = new List<string>()
        {
            "Detské",
            "Romantické",
            "Náučné",
            "Sci-Fi",
            "Dobrodružné"
        };

        /// <summary>
        /// get a set pre Title
        /// </summary>
        public string Title
        { get { return title; } set { title = value; } }
        
        /// <summary>
        /// get a set pre Pages
        /// </summary>
        public int Pages
        { get { return pages; } set { pages = value; } }

        /// <summary>
        /// set pre Category
        /// </summary>
        public string Category
        { set { category = value; } }


        /// <summary>
        /// get a set pre ReleaseDate
        /// </summary>
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


        /// <summary>
        /// get a set pre Author
        /// </summary>
        public string Author
        { get { return author; } set { author = value; } }

        /// <summary>
        /// constructor bez parametrov
        /// </summary>
     
        public Book()
        {
            title = "-1";
            pages = -1;
            category = "-1";
            author = "-1";
            releaseDate = -1;
        }


        /// <summary>
        /// constructor, ktorý nastaví hodnoty pre title a pages
        /// </summary>
        public Book(string mtitle, int mpages)
        {
            title = mtitle;
            pages = mpages;
            category = "-1";
            author = "-1";
            releaseDate = -1;
        }


        /// <summary>
        /// constructor, ktorý nastaví všetky hodnoty
        /// </summary>

        public Book(string mtitle, int mpages, string mcategory, string mauthor, int mreleaseDate)
        {
            title = mtitle;
            pages = mpages;
            category = mcategory;
            author = mauthor;
            releaseDate = mreleaseDate;
        }


        /// <summary>
        /// method, ktorá vracia upravné stringy
        /// </summary>

        public override string ToString()
        {
            return String.Format($"{title}\n{pages}\n{category}\n{author}\n{releaseDate}");
        }


        

    }
}
