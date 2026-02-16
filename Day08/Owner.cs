using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08
{
   public class Owner
    {
        //OwnerId (PK), OwnerName.

        public int OwnerId { get; set; }
        public string OwnerName { get; set; }
        public override string ToString()
        {
            return $"Owner Id: {OwnerId}, Name: {OwnerName}";
        }


    }
}
