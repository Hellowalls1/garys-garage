namespace Garys_Garage {
    public class Tesla : Vehicle // Electric car
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery () {
            // Console.WriteLine ($"Your Tesla now charged to {this.BatteryKWh}KWh. ")
        }
    }
}