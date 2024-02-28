using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class Car:IVehicule
    {
        public void Accelerate()
        {
            Console.WriteLine("Car Start Accelerating");
        }
        public void PushBreak()
        {
            Console.WriteLine("Car pushes Break");

        }

        public void PressHorn()
        {
            Console.WriteLine("Beep Beep");
        }
    }
}
