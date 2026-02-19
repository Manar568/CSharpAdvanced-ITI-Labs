using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
   public class Author :BaseEntity
    {
    //    public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Phone]
        public string Phone {  get; set; }
        public List<Book> Books { get; set; }
    }
}
