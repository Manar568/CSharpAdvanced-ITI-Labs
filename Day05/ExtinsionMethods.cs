using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Day05
{
    internal static class ExtinsionMethods
    {
      

        public static bool IsValidEmail(this string email)
        {
            string reg = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$";

            return Regex.IsMatch(email, reg);

          

        }


        public static IEnumerable<int> GetAboveAverage(this IEnumerable<int> numbers)
        {
            List<int> res = new List<int>();


            if (numbers != null)
            {
                int avg = (int)numbers.Average();



                foreach (int item in numbers)
                {

                    if (item > avg)
                        res.Add(item);
                    //Console.WriteLine(item);

                }
            }

            return res;

        }



        public static string ToFriendlyDate(this DateTime date) {


            DateTime time = DateTime.Today;

            if (date==time)
                return "Today";
            else if (date.Year == time.Year && date.Month == time.Month && date.Day == (time.Day +1)) 
                return "YesterDay";
            else if (date.Year == time.Year && date.Month == time.Month && date.Day == (time.Day - 1))
                return "Tomorrow";
            else
                return date.ToString("dd/MM/yyyy");





        
        
        
        
        
        }








    }
}
