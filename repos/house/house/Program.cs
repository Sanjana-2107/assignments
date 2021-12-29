using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house
{
    class Program
    {
        static void Main(string[] args)
        {
            SmallApartment apartment = new SmallApartment();
            Person person = new Person("Jhon");
            apartment.door = new House.Door("black");
            person.house = apartment;
            person.ShowData();
        }
    }
}
