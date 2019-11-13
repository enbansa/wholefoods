using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    class Vehicle
    {
        private string Color { get; set; }

        private int Speed { get; set; }

        private int WheelCount { get; set; }

        //Constructor

        public Vehicle(string color,int wheelCount)
        {
            Color = color;
            WheelCount = wheelCount;
        }

        public string GetVehicleInfo()
        {
            var info = string.Format("Color : {0},Speed {1}," + " WheelCount : {2} ", Color, Speed, WheelCount); 
            return info;
        }

        public void Start()
        {
            Speed = 20;
        }

        public void Stop()
        {
            Speed = 0;
        }

        public void Accelerate(int value)
        {
            Speed += value;
        }

        public void DeAccelerate(int value)
        {
            Speed = Speed - value;
        }
    }
}
