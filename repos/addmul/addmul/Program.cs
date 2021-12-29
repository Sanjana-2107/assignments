
using System;
using System.Collections.Generic;
//using System.Linq;
namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> mylist = new List<int>();
            mylist.Add((1+2)*5);
            mylist.Add((2+2)*5);
            mylist.Add((3+2)*5);
            mylist.Add((4+2)*5);

            foreach (var item in mylist)
            {


                Console.Write(item.ToString() + "   ");
            }
            
                
            



            /*  public static List<int> test
                  (List<int> nums)
              {
                  IEnumerable<int> e = nums.Select(x => 5 * (x + 2));
                  return e.ToList();
              } */
        }
    }
}

/*{
    public class program
    {
        static void Main(string[] args)
        {
            List<int> mylist = new List<int>();
            mylist.Add(1);
            mylist.Add(2);
            mylist.Add(3);
            mylist.Add(4);

            foreach (var item in mylist)
            {

                Console.Write(item.ToString() + "   ");

               
            }
            
        }

        public static List<int> test(List<int> nums)
        {
            IEnumerable<int> e = nums.Select(x => 5 * (x + 2));
            return e.ToString();
        }

    }
} */



/*{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> mylist = (new List<int>(new int[] { 1, 2, 3, 4 }));
            foreach (var i in mylist)
            {
                Console.Write(i.ToString() + " ");
            }
        }
        public static List<int> test(List<int> nums)
        {
            IEnumerable<int> e = nums.Select(x => 5 * (x + 2));
            return e.ToString();
        }
    }
} */
