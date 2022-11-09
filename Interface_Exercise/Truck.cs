using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {
        }

        public bool HasTruckBed { get; set; }
        public bool HasTowHook { get; set; }
        public bool HasSteeringWheel { get; set; }
        public int HowManyWheels { get; set; }
        public bool HasStereo { get; set; }
        public bool HasSunRoof { get; set; }
        public string Name { get; set; }
        public string CorpName { get; set; }
        public string Motto { get; set; }

        public void PrintStats()
        {
            Console.WriteLine($"Corp Name: {CorpName}, Motto {Motto}, Has TowHook: {HasTowHook}, Trunk Bed: {HasTruckBed}");
        }
    }
}
