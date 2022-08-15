using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrencyVSParallelism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task.Factory.StartNew(NewMethod1);
            Task.Factory.StartNew(NewMethod2);
            NewMethod3();
        }

        private static void NewMethod3()
        {
            Console.WriteLine("Start data input, enter your name");
            string str = Console.ReadLine();
            Console.WriteLine(str);
            Console.ReadLine();
        }

        private async static void NewMethod1()
        {
            await Task.Delay(10000); //downloading file 1
            Console.WriteLine("Downloaded File 1");
        }

        private async static void NewMethod2()
        {
            await Task.Delay(10000); //downloading file 2
            Console.WriteLine("Downloaded File 2");
        }
    }
}
