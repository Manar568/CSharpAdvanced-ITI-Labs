using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    public  class Department
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"DeptId: {DeptId}, DeptName: {DeptName}, Address: {Address}";
        }
    }
}
