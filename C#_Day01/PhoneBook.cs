using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day01
{
    internal class PhoneBook
    {
        public int[] PhoneNum = new int[5];
        public string[] ContactName = new string[5];


        public int this[string name]
        {
            get
            {
                for (int i = 0; i < ContactName.Length; i++)
                {
                    if (ContactName[i] == name)
                        return PhoneNum[i];
                }
                return -1;

            }
            set
            {
                for (int i = 0; i < ContactName.Length; i++)
                {
                    if (ContactName[i] == name)
                    {
                        if(value>0 )
                        PhoneNum[i] = value;
                        else
                            Console.WriteLine("the number must be greater than 0");
                    }

                    
                }

                for (int i = 0; i < ContactName.Length; i++)
                {
                    if (ContactName[i] == null)
                    {
                        ContactName[i] = name;
                        PhoneNum[i] = value;
                        return;
                        
                    }


                }




            }

        }


        public string this[int num]
        {
            get
            {
                for (int i = 0; i < PhoneNum.Length; i++)
                {
                    if (PhoneNum[i] == num)
                        return ContactName[i];
                }
                return "Contact not fount";

            }
            set
            {

                for (int i = 0; i < PhoneNum.Length; i++)
                {
                    if (PhoneNum[i] == num)
                    {
                        if (value != " " && value != null)
                            ContactName[i] = value;
                        else 
                            Console.WriteLine("the name can not be emptt or null");

                    }
               

                }



                for (int i = 0; i < PhoneNum.Length; i++)
                {
                    if (PhoneNum[i] == 0)
                    {
                        PhoneNum[i]=num;
                        ContactName[i] = value;
                        return;
                    }


                }



            }


        }
    }
}
