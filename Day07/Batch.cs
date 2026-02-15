using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07
{
    public class Batch
    {
        /* - Id (Primary key) 
• - RoastDate (Required) 
• - QuantityKg (Required) 
• - CoffeeBeanId (Foreign key to CoffeeBean) */
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime RoastDate { get; set; }

        [Required]
        public int QuantityKg { get; set; }
        public int CoffeeBeanId { get; set; }
        CoffeeBean CoffeeBean { get; set; }



    }
}
