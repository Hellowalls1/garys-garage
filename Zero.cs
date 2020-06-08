using System;

namespace Garys_Garage {
    public class Zero : Vehicle, IElectric // Electric motorcycle
    {
        public double BatteryKWh { get; set; }
        public int CurrentChargePercentage { get; set; } = 0;
        public void ChargeBattery () {
            CurrentChargePercentage = 100;
        }
        public override void Drive () {
            Console.WriteLine ($"The {MainColor} scooter scoots by. PPPPYEEEEEEERRRRR!");
        }

        public override void Stop () {
            Console.WriteLine ($"The {MainColor} scooter refused to stop and flew off of a trailer ramp into a construction site.");
        }
    }
}