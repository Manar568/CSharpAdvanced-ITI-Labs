using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09
{
    public class Course
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int Hours { get; set; }
        public  virtual List<Student> Students { get; set; }

    }
}
