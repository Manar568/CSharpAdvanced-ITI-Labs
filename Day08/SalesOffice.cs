using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08
{
    public class SalesOffice
    {
        //OfficeNumber(PK), Location.10

        public int OfficeNumber { get; set; }
        public string Location { get; set; }
        public int MangerId { get; set; } 
        public Employee Employee { get; set; }
        public List<Employee> Employees { get; set; }   
        public List<Property> Properties { get; set; }

        public override string ToString()
        {
            return $"Office Number: {OfficeNumber}, Location: {Location}";
        }

    }
}
