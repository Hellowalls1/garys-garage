using System;

namespace Garys_Garage {
    public class Cessna : Vehicle // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank () {
            // method definition omitted
        }

        //ovverides the Drive method that is inherited from Vehicle
        public override void Drive () {
            Console.WriteLine ("Zoooooom!");
        }
    }

}