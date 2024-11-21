using MODEL.Concretes;

namespace MODEL.Entities
{
    public class TeacherBranch:BaseEntity
    {//ID gelmesini engelle Configuration işlemlerinde
        public int TeacherId { get; set; }  
        public Teacher Teacher { get; set; }
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
    }
}
