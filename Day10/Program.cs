using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Day10
{
    internal class Program
    {
        public static void SumOdd(params List<int> nums)
        {
            int sum = 0;
            foreach (int i in nums)
            {
                if (i % 2 != 0)
                { sum += i; }
            }
            Console.WriteLine($" Thread  {Thread.CurrentThread.ManagedThreadId} : Calculating odd numbers...");
            Console.WriteLine($"Odd Sum: {sum}");
        }

        public static void SumEven(params List<int> nums)
        {
            int sum = 0;
            foreach (int i in nums)
            {
                if (i % 2 == 0)
                { sum += i; }
            }
            Console.WriteLine($" Thread  {Thread.CurrentThread.ManagedThreadId} : Calculating Even numbers...");

            Console.WriteLine($"Even Sum: {sum}");
        }



        public static long CalcFactorial(int n) {

            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;


        }
        /////////////////////////////////
        ///////
   public async  static Task<string> MakeCoffeeAsync()
        {
            await Task.Delay(2000);
            return "Making coffee... ";
        }
   public async static Task<string> ToastBreadAsync()
        {
            await Task.Delay(3000);
            return "Toasting bread... ";
        }
   public async static Task<string> FryEggAsync()
        {
            await Task.Delay(4000);
            return "Frying eggs... ";
        }

        public async static  Task ProcessFileAsync(string fileName)
        {
            Console.WriteLine($"Processing {fileName}...");
           // Console.WriteLine(Directory.GetCurrentDirectory());
            string content = await File.ReadAllTextAsync(fileName);
          content=  content.ToUpper();

            await File.WriteAllTextAsync(fileName, content);
            Console.WriteLine($"doneeeeee :{fileName}");

        }





        //static async Task Main(string[] args)
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //ParameterizedThreadStart ptr = SumOdd;
            #region Part1
            Thread thread = new Thread(() => { SumOdd(2, 3, 4, 5, 6, 7, 9); });
            thread.Start();

            Thread threadEven = new Thread(() => { SumEven(2, 3, 4, 5, 6, 7, 9); });
            threadEven.Start();

            #endregion

            Console.WriteLine("======================22=====================================");


            #region Part2
            Task<long> ts1 = Task.Run(() => CalcFactorial(5));
            TaskAwaiter<long> awaiter1 = ts1.GetAwaiter();
            awaiter1.OnCompleted(() =>
            {

                Console.WriteLine($"ts1 Result={ts1.Result}");
            });



            Task<long> ts2 = Task.Run(() => CalcFactorial(10));
            TaskAwaiter<long> awaiter2 = ts2.GetAwaiter();
            awaiter1.OnCompleted(() =>
            {

                Console.WriteLine($"ts2 Result={ts2.Result}");
            });


            Task<long> ts3 = Task.Run(() => CalcFactorial(12));
            TaskAwaiter<long> awaiter3 = ts3.GetAwaiter();
            awaiter1.OnCompleted(() =>
            {

                Console.WriteLine($"ts3 Result={ts3.Result}");
            });
            Task<long> ts4 = Task.Run(() => CalcFactorial(15));


            TaskAwaiter<long> awaiter4 = ts4.GetAwaiter();
            awaiter1.OnCompleted(() =>
            {

                Console.WriteLine($"ts4 Result={ts4.Result}");
            });

            Task.WaitAll(ts1, ts2, ts3, ts4);
            #endregion



            Console.WriteLine("======================333333333333333333333333====================================");
            #region part3Sequential
            //Stopwatch totalSW=Stopwatch.StartNew();
            //totalSW.Start();

            //Stopwatch sw1= Stopwatch.StartNew();
            //sw1.Start();
            //string res1 = await MakeCoffeeAsync();
            //sw1.Stop();
            //Console.WriteLine($" {res1}    ({sw1.ElapsedMilliseconds/1000} seconds)");



            //Stopwatch sw2= Stopwatch.StartNew();
            //sw2.Start();
            //string res2 = await ToastBreadAsync();
            //sw2.Stop();
            //Console.WriteLine($" {res2}    ({sw2.ElapsedMilliseconds/1000} seconds)");



            //Stopwatch sw3= Stopwatch.StartNew();
            //sw3.Start();
            //string res3 = await FryEggAsync();
            //sw3.Stop();
            //Console.WriteLine($" {res3}    ({sw3.ElapsedMilliseconds/1000} seconds)");


            //totalSW.Stop();

            //Console.WriteLine($"Total Time :{totalSW.ElapsedMilliseconds/1000}");

            ////var toatal = sw1.Elapsed;
            ////cw



            //// string res2 = await ToastBreadAsync();

            //// Console.WriteLine(res2);


            // string res3 = await FryEggAsync();

            // Console.WriteLine(res3);

            // Console.WriteLine("Breakfast ready!");
            //// Task.Delay();
            ///

            #endregion 

            Console.WriteLine("==========files task0==============");

            #region Part4

            //string[] files = { "file1.txt", "file2.txt", "file3.txt" };

            //var task= files.Select(f=>ProcessFileAsync(f));

            //await Task.WhenAll(task);
            #endregion





        }
    }
}
