using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    internal class Program
    {
        static void Main(string[] args) {


            var oobj = new { Id = 1, name = "manar" };


            List<Dictionary<string, object>> test1 = VarTask.Test();
            var test2 = VarTask.Test();



            string s = "maanar@gmail.com";

            string s2 = "@gmail.com";

            string s3 = "ma@gmail.c";

            string s4 = "ma@gmailcom";




            Console.WriteLine(s.IsValidEmail());
            Console.WriteLine(s2.IsValidEmail());
            Console.WriteLine(s3.IsValidEmail());
            Console.WriteLine(s4.IsValidEmail());






            IEnumerable<int> lis = [5, 15, 20, 5];

           IEnumerable<int> lis2 = lis.GetAboveAverage();

            foreach (int i in lis2)
            {
                Console.WriteLine(i);

            }

        }
    }
}
