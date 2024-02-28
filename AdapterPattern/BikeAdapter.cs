using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class BikeAdapter:IVehicule
    {
        Bike bike = new Bike();

        public void Accelerate()
        {
            bike.Pedal();
        }

        public void PressHorn()
        {
            bike.RingBell();
        }

        public void PushBreak()
        {
            bike.Stop();
        }
    }
}
