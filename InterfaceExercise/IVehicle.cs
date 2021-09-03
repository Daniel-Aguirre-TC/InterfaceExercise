using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    interface IVehicle
    {
        public string VehicleName { get; set; }
        public string VehicleClass { get; set; }
        public int NumberOfWheels { get; set; }

        public void Drive();
        public void ReplaceTire();

        public static void StateUsingIVehicle()
        {
            Console.WriteLine("This object is using IVehicle.");
        }


    }
}
