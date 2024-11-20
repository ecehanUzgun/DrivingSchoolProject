using MODEL.Enums;

namespace MODEL.Entities
{
    public class Vehicle
    {
        public int ID { get; set; }
        public string LicensePlate { get; set; } // Plaka
        public VehicleType VehicleType { get; set; } // Araç tipi (Otomobil, Motosiklet vb.)
        public TransmissionType Transmission { get; set; } // Vites 
        //Relational Properties
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
    }
}
