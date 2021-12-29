using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace remotecars
{
    class Program
    {
       
      
            interface IRemoteControlCar
        {

           
            int distance
            {
                get;
                set;
            }
        
        }
       class ProdcutionRemoteControlCar : IRemoteControlCar
        {
            public int distance { get; set; } = 10;
        }
      /*  {
            public static int d;
            public int dis
            {
                get => disatnce;
                set => disatnce = value;

            }
           
        } */

       class ExperimentalRemoteControlCar : IRemoteControlCar
        {
            public int distance { get; set; } = 20;
           /* public void Drive()
            {
                ExperimentalRemoteControlCar exe = new ExperimentalRemoteControlCar();
                exe.Drive();
                Console.ReadLine();
            } */
        } 

    /*  public  class program
    {
            static void Main(string[] args)
        {
                var prod = new ProdcutionRemoteControlCar();
                prod.ToString();
                


               // TestTrack.Race(prod);
               // prod.DistanceTravelled

              // var exp = new ExperimentalRemoteControlCar();

              //  TestTrack.Race(exp);
               // exp.DistanceTravelled
             /*   /* ProdcutionRemoteControlCar pte = new ProdcutionRemoteControlCar();
                 pte.Drive();
                 Console.ReadLine();
                 ExperimentalRemoteControlCar exe = new ExperimentalRemoteControlCar();
                 exe.Drive();
                 Console.ReadLine(); */
                // var prod = new ProdcutionRemoteControlCar();

                //TestTrack.Race(prod);
                // prod.DistanceTravelled

                //  var exp = new ExperimentalRemoteControlCar();
                // TestTrack.Race(exp);
                // exp.Drive(); */

            
    }
       
    
}
