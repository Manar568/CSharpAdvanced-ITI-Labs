using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day03
{
    internal class Company
    {
        public string Name { get; set; }
        public float Budget { get; set; }
        List<Employee> employees { get; set; } =new List<Employee>();


        public void AddEmployee(Employee emp)
        {
            employees.Add(emp);
            // 3 sub subscribe callback method to event
            emp.IncSalary += UpdatBudget;
        }



        //2 sub create callback method
        public void UpdatBudget(float amount)
        {
            Budget-=amount;
        

        }

        public List<Employee> FilterEmployee(Predicate<float>fptr)
        {
            List<Employee> result = new List<Employee>();

            for(int i=0;i<employees.Count; i++)
            {
                if (fptr.Invoke(employees[i].Salary))
                    result.Add(employees[i]);

            }
           
            return result;
        }

       
    }
}
