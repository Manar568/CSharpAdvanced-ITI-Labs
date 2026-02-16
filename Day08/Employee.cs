using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08
{
    public class Employee
    {
      //  EmployeeId(PK), EmployeeName, SalesOfficeId(FK)

        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; }
        public int? SalesOfficeId { get; set; }
        public SalesOffice SalesOffice { get; set; }

        public override string ToString()
        {
            return $"Employee Id: {EmployeeId}, Name: {EmployeeName}, SalesOfficeId: {SalesOfficeId}";
        }
    }
}
