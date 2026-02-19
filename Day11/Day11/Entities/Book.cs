using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public  class Book :BaseEntity
    {
     //   public int BookId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public DateTime? PublishDate { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }

    }
}
