using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day03
{
   public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        public Book( string _Title, string _ISBN, string[] _Authors, DateTime _PublicationDate, decimal _Price)
        {
            ISBN=_ISBN;
            Title=_Title;
            Authors=_Authors;
           PublicationDate=_PublicationDate;
            Price=_Price;
            
        }
        public Book(string _ISBN, string _Title, decimal _Price)
        {
            ISBN=_ISBN;
            Title=_Title;
          
            Price=_Price;
            
        }

        public override string ToString()
        {
            return $"Title:{Title} ,ISBN:{ISBN},Price:{Price}";
        }
    }
}
