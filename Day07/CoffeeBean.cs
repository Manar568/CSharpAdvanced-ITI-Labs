using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07
{
   public  class CoffeeBean
    {
        /*
          - Id (Primary key) 
• - Name (Required, max length 100) 
•  OriginCountry (Required, max length 50) 
• - RoastLevel (Integer from 1 to 5) 
•    PricePerKg (Decimal with 2 decimal places) 
• - SupplierId (Foreign key to Supplier)
         */


        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [Required, MaxLength(50)]
        public string OriginCountry { get; set; }
        [Range(1,5)]
        public int RoastLevel { get; set; }
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public decimal PricePerKg { get; set; }
        public int SupplierID { get; set; }

        public Supplier Supplier { get; set; }
        List<Batch>Batches {  get; set; }

        public override string ToString()
        {
            return $"Name: {Name},Country : {OriginCountry}";
        }


    }
}
