using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day02
{
    internal class ToDoList
    {
        private Queue<string> toDoMssg;
        private int Counter = 0;

        public ToDoList() { 
        
        toDoMssg= new Queue<string>();
        }
        public void NewTask(string task)
        {
            toDoMssg.Enqueue(task);
            Counter++;
            Console.WriteLine($"{task} add as new task.");

        }
        public void CompletedTask()
        {
            string complete =toDoMssg.Dequeue();
            Counter--;
            Console.WriteLine($"{complete} Marks as Completed.");

        }
        public void AllTasks()
        {
            Console.WriteLine($"You have {Counter} tasks");
            foreach(var mssg in toDoMssg)
            {
                Console.WriteLine($"{mssg}");
            }
        }



    }
}
