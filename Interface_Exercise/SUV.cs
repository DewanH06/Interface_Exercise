using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public SUV()
        {
        }
        public bool HasCargo { get; set; }
        public bool FourWheelDrive { get; set; }
        public bool HasSteeringWheel { get; set; }
        public int HowManyWheels { get; set; }
        public bool HasStereo { get; set; }
        public bool HasSunRoof { get; set; }
        public string Name { get; set; }
        public string CorpName { get; set; }
        public string Motto { get; set; }

        public void PrintStats()
        {
            Console.WriteLine($"Corp Name: {CorpName}, Motto: {Motto}, Has Cargo:{HasCargo},4x4: {FourWheelDrive}" );
        }
    }
}
