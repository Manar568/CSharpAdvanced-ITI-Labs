using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public decimal Salary { get; set; }
        public int DeptId { get; set; }



        public override string ToString()
        {
            return $"EmpId: {EmpId}, Name: {EmpName}, Salary: {Salary}, DeptId: {DeptId}";
        }
    }
}
