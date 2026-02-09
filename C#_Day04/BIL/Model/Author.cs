using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIL.Model
{
    public class Author
    {
        public  string Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
         public string State { get; set; }
            public string Zip { get; set; }
        public bool Contract { get; set; }


        public override string ToString()
        {
            
            return $"Id: {Id}, FName: {FName}, LName: {LName}, Phone: {Phone}";
        }







    }
}
