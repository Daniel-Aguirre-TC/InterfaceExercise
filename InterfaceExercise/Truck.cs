using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Truck : Vehicle
    {
        public int TruckBedLength { get; set; }
        public int DoorCount { get; set; }

        public Truck(string name, int numberOfWheels, string logo, string motto, int truckBedLength, int doorCount) : base(name, numberOfWheels, logo, motto)
        {
            TruckBedLength = truckBedLength;
            DoorCount = doorCount;
            InterpolateVehicleInfo();

        }


        public override void InterpolateVehicleInfo()
        {
            base.InterpolateVehicleInfo();
            Console.WriteLine($" • Truck Bed Length: {TruckBedLength}\"\n • Number of Doors: {DoorCount}");
        }

    }
}
