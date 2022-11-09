using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public bool HasSteeringWheel { get; set; }
        public int HowManyWheels { get; set; }
        public bool HasStereo { get; set; }
        public bool HasSunRoof { get; set; }
        public string Name { get; set; }

        public void PrintStats();
    }
}
