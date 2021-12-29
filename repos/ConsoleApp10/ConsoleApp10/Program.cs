using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create John and Jane Student Detail Objects
            StudentDetails sanjuStudentDetails = new StudentDetails(1001, "sanju", "c#");
            StudentDetails prakashStudentDetails = new StudentDetails(1002, "prakash", "ASP.NET");

            // Call Payment method
            sanjuStudentDetails.Payment(200);
            prakashStudentDetails.Payment(100);

            // Print out student details
            sanjuStudentDetails.Print();

            Console.WriteLine("\n");
           


            prakashStudentDetails.Print();

        }
    }
}
