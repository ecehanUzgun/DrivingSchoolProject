﻿using MODEL.Concretes;

namespace MODEL.Entities
{
    public class Teacher:BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Tckn { get; set; } //11 hane
        public DateTime BirthDate { get; set; }

        //Relational Properties
        public List<Schedule> Schedules { get; set; }
        public List<TeacherBranch> TeacherBranches { get; set; }
    }
}
