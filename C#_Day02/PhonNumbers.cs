using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day02
{
    internal class PhonNumbers
    {
        Dictionary<string , int> phoneNumbers = new Dictionary<string , int>();

        public void AddContact(string name , int number)
        {
            //how to handle exiting keys

            if(phoneNumbers.ContainsKey(name))
            {
                Console.WriteLine("this key already exists");
                return;

            }

            phoneNumbers.Add( name,number);

        }
        public int Search(string name)
        {

            int num = -1;
              foreach (var phone in phoneNumbers) {
                if (phone.Key == name)
                {
                    num = phone.Value;
                 

                }
            
            }
              if (num > 0) 
              return num;
            else
                throw new ContactNotFoundExcption($"Contact '{name}' not found.");
        }

    }
      





    }

