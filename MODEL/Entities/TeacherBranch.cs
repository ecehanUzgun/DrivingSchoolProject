namespace MODEL.Entities
{
    public class TeacherBranch
    {
        public int TeacherId { get; set; }  
        public Teacher Teacher { get; set; }
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
    }
}
