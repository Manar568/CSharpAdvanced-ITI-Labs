using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day02
{
    internal class Student
    {
        public string Name { get; set; }
        public List<int> Grades { get; set; }
        private int sum = 0;
        private int counter;
        public Student()
        {
            Grades = new List<int>();

        }

        public void AddGrade(int grade)
        {
            Grades.Add(grade);
            sum += grade;
            counter++;

        
        }
        public int Average()
        {
            return sum/counter;
        }

        //public static void HighAvg()
        //{
        //    int high = 0;
        //    if (Ave)

        //}

    }
}
