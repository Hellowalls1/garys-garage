namespace Garys_Garage {

    public interface IElectric {
        void ChargeBattery ();
        int CurrentChargePercentage { get; set; }
    }

}