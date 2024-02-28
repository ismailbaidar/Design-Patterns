using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class Bike
    {
        public void Pedal()
        {
            Console.WriteLine("Bike Start Moving");
        }
        public void Stop()
        {
            
                Console.WriteLine("Bike Stopped");
            

        }

        public void RingBell()
        {
            Console.WriteLine("Ring Ring");
        }
    }
}
