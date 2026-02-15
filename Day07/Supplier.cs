using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07
{
    public class Supplier
    { /* Id (Primary key) 
• - Name (Required, max length 150) 
• - ContactNumber (Phone format) 
• - Email (Email format) */
        [Key]
        public int Id { get; set; }
        [Required,MaxLength(150)]
        public string Name { get; set; }
        [Phone]
        public string ContactNumber { get; set;}
        [EmailAddress]
        public string Email { get; set;}
        public List<CoffeeBean> coffeeBeans { get; set; }

        public override string ToString()
        {
            return $"Name : {Name},ContctNumber: {ContactNumber}";
        }


    }
}
