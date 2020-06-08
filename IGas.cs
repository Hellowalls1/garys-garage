namespace Garys_Garage {

    public interface IGas {
        void RefuelTank ();

        int CurrentTankPercentage { get; set; }
    }

}