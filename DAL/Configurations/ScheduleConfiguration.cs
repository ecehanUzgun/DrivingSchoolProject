using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MODEL.Entities;
namespace DAL.Configurations
{
    public class ScheduleConfiguration : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            //Bu kısıtlama, aynı öğretmenin aynı tarihte ve saatte birden fazla ders yapmasını önler.
            builder.HasIndex(s => new { s.TeacherId, s.LessonDate, s.StartTime }).IsUnique();

            //Foreign Key -Student
            builder.HasOne(x => x.Student)
                   .WithMany(x => x.Schedules)
                   .HasForeignKey(x => x.StudentId)
                   .OnDelete(DeleteBehavior.Restrict);

            //Foreign Key -Teacher
            builder.HasOne(x => x.Teacher)
                   .WithMany(x => x.Schedules)
                   .HasForeignKey(x => x.TeacherId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
