using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle("Blue", 2);
            Vehicle vehicle2 = new Vehicle("Red", 16);
            Vehicle[] vehicles = new Vehicle[2] { vehicle, vehicle2 };
            vehicle.Start();
            vehicle2.Start();
            vehicle2.DeAccelerate(-5);
            vehicle.Accelerate(25);
             foreach(var item in vehicles)
            {
                Console.WriteLine(item.GetVehicleInfo());
            }

            Console.ReadLine();


        }
    }
}
