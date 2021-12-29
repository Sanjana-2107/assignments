using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace queue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Queue queue = new Queue();
            person c1 = new person();
            c1.Name = "Juan";
            c1.Age = 26;
            Console.WriteLine(c1.ToString());

            person c2 = new person();


            c2.Name = "Sara";
            c2.Age = 31;
            Console.WriteLine(c2.ToString());

            person c3 = new person();

            c3.Name = "Carlos";
            c3.Age = 26;
            Console.WriteLine(c3.ToString());
        }
    }
}
