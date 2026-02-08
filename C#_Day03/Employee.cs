using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day03
{
    internal class Employee
    {
       public string Name { get; set; }
        public float Salary { get; set; }
        // 1 publisher declare event
        public event Action<float> IncSalary;

        public void IncreaseSalary(float amount ) {

            Salary += amount;
            // 4 pub fire event
            IncSalary.Invoke( amount );
   
        
        }


    }
}
