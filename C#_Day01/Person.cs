using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day01
{
    internal class Person
    {

        public string FName { get; set; }
        public string LName { get; set; }
        public string FullName => $"{FName} {LName}";
        public int Age { get; set; }

        private string _password;
        public string Password
        {
            private get => _password;
            set
            {
                _password = value;
            }
        }

    }
}
