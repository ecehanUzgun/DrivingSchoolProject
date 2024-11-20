using MODEL.Enums;

namespace MODEL.Entities
{
    public class Schedule
    {
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public DateTime LessonDate { get; set; } 
        public TimeSpan StartTime { get; set; }     
        public DataStatus Status { get; set; }
        //Active planlanan ve henüz gerçekleşmemiş dersler
        //Passive planlanmamış dersler
        //Completed gerçekleşmiş dersler
    }
}
