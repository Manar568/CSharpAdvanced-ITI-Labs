using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int Hours { get; set; }
        public int DeptId { get; set; }
        public int SubjectId { get; set; }
     //   public Subject Subject { get; set; }



        public override string ToString()
        {
            return $"CourseId: {CourseId}, Name: {CourseName}, Hours: {Hours}, DeptId: {DeptId}, SubjectId: {SubjectId}";
        }
    }
}
