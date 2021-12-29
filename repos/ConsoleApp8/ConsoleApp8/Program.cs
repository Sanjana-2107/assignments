using System;
using System.Collections;



namespace stack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Stack mystack = new Stack();
            Person c1 = new Person();
            c1.Name = "Juan";
            c1.Age = 26;
            Console.WriteLine(c1.ToString());
            Person  c2 = new Person();


            c2.Name = "Sara";
            c2.Age = 31;
            Console.WriteLine(c2.ToString());
            Person  c3 = new Person();

            c3.Name = "Carlos";
            c3.Age = 26;
            Console.WriteLine(c3.ToString());





        }
    }
}
           /* mystack.Push("26");
            mystack.Push("31");
            mystack.Push("26");
            mystack.Push("Carlos");
            mystack.Push("Sara");
            mystack.Push("Juan");


           /* foreach (var stackitem in mystack)
            {
                Console.WriteLine(stackitem);
            }
             /*   string name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());
               
                Console.WriteLine(mystack.ToString());


            }

           /* for (int i = 0; i < total; i++)
            {
                 
            
          /*  for (int i = 0; i < total; i++)
            {
                Person p = (Person)stack.mystack();
                Console.WriteLine(p.ToString());
            } */
    /*    }
    }
}*/
