using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var lp = new LaptopBase ();

            Console.WriteLine("Name :" + LaptopBase.Lenove);
            Console.WriteLine(LaptopBase.Price1000);
            Console.WriteLine(LaptopBase.i3);
            Console.WriteLine(LaptopBase.Ram2GB);
            Console.WriteLine(LaptopBase.HD500GB);
            Console.WriteLine("\n\n*************************************\n");

            Console.WriteLine(LaptopBase.Dell);
            Console.WriteLine(LaptopBase.Price1500);
            Console.WriteLine(LaptopBase.i5);
            Console.WriteLine(LaptopBase.Ram4GB);
            Console.WriteLine(LaptopBase.HD1TB);
            Console.WriteLine("\n\n*************************************\n");


            Console.WriteLine(LaptopBase.Sony);
            Console.WriteLine(LaptopBase.Price2000);
            Console.WriteLine(LaptopBase.i9);
            Console.WriteLine(LaptopBase.Ram8GB);
            Console.WriteLine(LaptopBase.HD1TB);
            Console.WriteLine("\n\n*************************************\n");
           

            Console.ReadKey();
        }
    }
}
