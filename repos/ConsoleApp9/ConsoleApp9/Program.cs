using System;
using System.Collections.Generic;
namespace genericdist
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> marksobtained = new Dictionary<string, int>();
            marksobtained.Add("sanju", 72);
            marksobtained.Add("ram", 83);
            marksobtained.Add("prakash", 92);
            marksobtained.Add("saji", 89);
            Console.WriteLine(marksobtained["prakash"]);
            foreach (var item in marksobtained)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}




