using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day03
{

    public delegate string CheckBookfptr(Book book);
    public delegate DateTime CheckBookfptrDate(Book book);

    internal class LibraryEngine
    {
        public static void ProcessBooks(List<Book> bList, CheckBookfptr fptr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fptr(B));
            }
        }
        public static void ProcessBooksBCL(List<Book> bList, Func<Book,String> func)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(func(B));
            }
        }

        //public static void ProcessBooksDate(List<Book> bList, CheckBookfptrDate Dfptr)
        //{
        //    foreach (Book B in bList)
        //    {
        //        Console.WriteLine(Dfptr(B));
        //    }
        //}
    }
}
