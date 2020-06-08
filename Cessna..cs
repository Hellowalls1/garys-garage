using System;

namespace Garys_Garage {
    public class Cessna : Vehicle, IGas // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }

        public int CurrentTankPercentage { get; set; } = 0;

        public void RefuelTank () {
            CurrentTankPercentage = 100;
        }

        //ovverides the Drive method that is inherited from Vehicle
        public override void Drive () {
            Console.WriteLine ($"The {MainColor} Cessna flew by you! Zoooooom!");
        }

        public override void Stop () {
            Console.WriteLine ($"The {MainColor} Cessna dissapeared into the sky");
        }

        public override void Turn (string direction) {
            Console.WriteLine ($"The {MainColor} Cessna banked {direction} and flew up into the clouds.");
        }
    }

}