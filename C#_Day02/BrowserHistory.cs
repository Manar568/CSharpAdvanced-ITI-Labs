using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day02
{
    internal class BrowserHistory
    {
        private Stack<string> History = new Stack<string>();
        public void VisitedPage(string pageName)
        {
            History.Push(pageName);
        }
        public void ExitPage()
        {
            History.Pop();
            Console.WriteLine(History.Peek());   
        }
        public void AllPages()
        {
            foreach (var page in History)
            {
                Console.WriteLine(page);

            }

        }
    }
}
