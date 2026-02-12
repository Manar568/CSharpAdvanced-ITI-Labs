using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }

        public override string ToString()
        {
            return $"SubjectId: {SubjectId}, SubjectName: {SubjectName}";
        }
    }
}
