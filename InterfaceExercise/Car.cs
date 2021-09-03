using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Car : Vehicle
    {
         
        public enum TrunkSizes { Small, Medium, Large }
        public bool IsFourDoor { get; set; }
        public TrunkSizes TrunkSize { get; set; }

        public Car(string name, int numberOfWheels, string logo, string motto, bool isFourDoor, TrunkSizes trunkSize) : base(name, numberOfWheels, logo, motto)
        {
            IsFourDoor = isFourDoor;
            TrunkSize = trunkSize;
            InterpolateVehicleInfo();
        }

        public override void InterpolateVehicleInfo()
        {
            base.InterpolateVehicleInfo();
            Console.WriteLine($" • Trunk Size: {TrunkSize}");
            string doors = " • Number of Doors: " + (IsFourDoor ? "4" : "2");
            Console.WriteLine(doors);
        }

    }
}
