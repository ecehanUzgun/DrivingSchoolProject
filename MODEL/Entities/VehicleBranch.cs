using MODEL.Concretes;

namespace MODEL.Entities
{
    public class VehicleBranch:BaseEntity
    {//ID gelmesini engelle Configuration işlemlerinde

        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
    }
}
