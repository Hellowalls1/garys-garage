using System;

namespace Garys_Garage {
    public class Tesla : Vehicle, IElectric // Electric car
    {
        public double BatteryKWh { get; set; }
        public int CurrentChargePercentage { get; set; } = 0;
        public void ChargeBattery () {
            CurrentChargePercentage = 100;
        }

        //MainColor comes from vehicle
        public override void Drive () {
            Console.WriteLine ($"The {MainColor} Tesla moves along. WEEEEEEEE!");

        }
    }
}