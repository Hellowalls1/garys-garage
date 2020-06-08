using System;

namespace Garys_Garage {

    public class Ram : Vehicle, IGas // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public int CurrentTankPercentage { get; set; } = 0;
        public void RefuelTank () {
            CurrentTankPercentage = 100;
        }

        public override void Drive () {
            Console.WriteLine ($"The {MainColor} Ram drives by. Roooom!");

        }
    }
}