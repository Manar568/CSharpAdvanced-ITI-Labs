using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day02
{
    internal class Cage<T> where T : Animal,new()
    {
        public List<T> list { get;  private set; } = new List<T>();
        public void Arrive(T resident)
        {
            if (resident.Age > 8)
            {
               throw new InvalidAgeException("The age must be less than 8");
            }
            else
            {
                list.Add(resident);
            
                Console.WriteLine($"{list[0].Name} added to cage");
               
            }

        }
    }
}
