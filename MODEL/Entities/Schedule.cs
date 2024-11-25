using MODEL.Concretes;
using MODEL.Enums;

namespace MODEL.Entities
{
    public class Schedule:BaseEntity
    {
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public DateTime LessonDate { get; set; } 
        public TimeSpan StartTime { get; set; }     
    }
}
