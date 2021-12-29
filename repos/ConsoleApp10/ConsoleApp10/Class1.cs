using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threadingsleep
{
    class Program
    {
        static void Main(string[]args)
        {
            for (int i=1;i<=20;i++)
            {
                Console.WriteLine(i);
                System.Threading.Thread.Sleep(1000);
            }
            Console.ReadKey();
        }
    }
}