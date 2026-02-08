using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day02
{
    internal class ContactNotFoundExcption :Exception

    {
        public ContactNotFoundExcption(string message) :base(message){ 



        }
    }
}
