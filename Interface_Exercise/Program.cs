using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            var sedan1 = new Car()
            {
                Name = "Honda Accord",
                CorpName = "BrandX",
                Motto = "Best Brand X Ever",
                HasLeatherSeats = true,
                HasSteeringWheel = true,
                HasStereo = true,
                HasSunRoof = true,
                HasTrunk = true,
                HowManyWheels = 4
            };
            var pickup1 = new Truck()
            {
                Name = "Dodge Ram",
                CorpName = "Lanscrapers Inc",
                HasSteeringWheel = true,
                HasStereo = false,
                HasSunRoof = false,
                HasTowHook = true,
                HasTruckBed = true,
                HowManyWheels = 4,
                Motto = "Cuttin Grass"
            };
            var suv1 = new SUV()
            {
                Name = "Jeep Wrangler Unlimited",
                CorpName = "Jeeps",
                Motto = "Cool Jeeps",
                HowManyWheels = 4,
                FourWheelDrive = true,
                HasCargo = true,
                HasSteeringWheel = true,
                HasStereo = true,
                HasSunRoof = true
            };
            var vehicles = new List<IVehicle>();
            vehicles.Add(sedan1);
            vehicles.Add(pickup1);
            vehicles.Add(suv1);

            foreach (var veh in vehicles)
            {
                Console.WriteLine($"Name: {veh.Name}, steering wheel: {veh.HasSteeringWheel}, stereo:{veh.HasStereo}, # of wheels: {veh.HowManyWheels},Sunroof: {veh.HasSunRoof}");

                veh.PrintStats();
            }
        }
    }
}
