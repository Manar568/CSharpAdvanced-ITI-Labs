using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string City { get; set; }
        public List<Order> Orders { get; set; }

        public override string ToString()
        {
            return $"CustomerId: {CustomerId}, Name: {CustomerName}, City: {City}";
        }
    }
}
