using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excersie

{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mylist = new List<string>(new string[] { "1", "2", "3", "4" });
            foreach (var item in mylist)
            {
                Console.Write(item.ToString() + " ");
            }

        }

    }
    
}

