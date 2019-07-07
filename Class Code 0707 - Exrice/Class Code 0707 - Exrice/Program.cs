using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Class_Code_0707___Exrice
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t1 = PrintMeAndNext(1);
            Task t2 = PrintMeAndNext(2);
            Task t3 = PrintMeAndNext(3);
            Task.WaitAll(t1,t2,t3);
            Console.WriteLine("All Are Done");
        }
        static public async Task PrintMeAndNext(int number)
        {
            //Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            await Task.Run(() => { Console.WriteLine(number); Thread.Sleep(1000); });
            await Task.Run(() => { Console.WriteLine(++number); Thread.Sleep(1000); });
            Console.WriteLine("I Finished............................................");

        }
    }
}
