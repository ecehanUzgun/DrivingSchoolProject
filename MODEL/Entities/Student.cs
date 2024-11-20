using MODEL.Enums;

namespace MODEL.Entities
{
    public class Student
    {
        public Student()
        {
            CourseHours = 6;
            CreatedDate = DateTime.Now;
            Status = DataStatus.Active;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Tckn { get; set; } //todo: 11 hane olmak zorunda
        public DateTime BirthDate { get; set; }
        public int CourseHours { get; set; } //Her kayıt olan öğrencinin 6 saat ders hakkı var
        public DateTime CreatedDate { get; set; }
        public DataStatus Status { get; set; }

        //Relational Properties
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
        public List<Schedule> Schedules { get; set; }
    }
}
