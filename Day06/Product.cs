using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }


        public override string ToString()
        {
            return $"ProductId: {ProductId}, Name: {ProductName}, Category: {Category}, Price: {UnitPrice}, Stock: {UnitsInStock}";
        }
    }
}

