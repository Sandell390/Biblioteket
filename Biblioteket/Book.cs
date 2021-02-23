using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteket
{
    class Book
    {
        private string _Title { get; }

        private string _Auther { get; set; }


        public string Title 
        {
            get => _Title;
        }

        public string Auther
        {
            get => _Auther;
        }


        public Book(string title, string auther) 
        {
            _Title = title;
            _Auther = auther;
        }


    }
}
