//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.CompilerServices;
//using System.Text;
//using System.Threading.Tasks;

//namespace Day10
//{
//    internal class ParellelTask
//    {
//        public  static string MakeCoffee()
//        {
//            //await Task.Delay(2000);
//            return "Making coffee... ";
//        }
//        public  static string ToastBread()
//        {
//            //await Task.Delay(3000);
//            return "Toasting bread... ";
//        }  



//        public  static string FryEgg()
//        {
//           // await Task.Delay(4000);
//            return "Frying eggs... ";
//        }





//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hellloworld");

//            Task<string> ts1 = Task.Run(() =>MakeCoffee());
//            TaskAwaiter<string> awaiter1=ts1.GetAwaiter();
//            awaiter1.OnCompleted(()=>{

//            Console.WriteLine($"{ts1.Result}");
            
//            });

//            Task<string> ts2 = Task.Run(() =>ToastBread());
//            TaskAwaiter<string> awaiter2=ts2.GetAwaiter();
//            awaiter2.OnCompleted(()=>{

//            Console.WriteLine($"{ts2.Result}");
            
//            });

//            Task<string> ts3 = Task.Run(() =>FryEgg());
//            TaskAwaiter<string> awaiter3=ts3.GetAwaiter();
//            awaiter3.OnCompleted(()=>{

//            Console.WriteLine($"{ts3.Result}");
            
//            });

//            Task.WhenAll(ts1,ts2,ts3);
//            Console.WriteLine("All done at the same time!");



//        }
//    }
//}
