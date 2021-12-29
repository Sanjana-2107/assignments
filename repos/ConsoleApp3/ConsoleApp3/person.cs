using System;

namespace ConsoleApp3
{
    public class person
    {
       public string Firstname;
        public string lastname;

        public void Introduce ()
        {
            Console.WriteLine("My name is" + Firstname + lastname);
        }
    }
}
