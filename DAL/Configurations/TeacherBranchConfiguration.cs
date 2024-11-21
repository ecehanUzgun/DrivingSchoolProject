using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MODEL.Entities;

namespace DAL.Configurations
{
    public class TeacherBranchConfiguration : IEntityTypeConfiguration<TeacherBranch>
    {
        public void Configure(EntityTypeBuilder<TeacherBranch> builder)
        {
            //Id veritabanına gönderilirken engellenecek.
            builder.Ignore(x => x.ID);

            builder.HasKey(x => new { x.TeacherId, x.BranchId }); //Composite Key
            //builder.HasOne(x => x.Teacher).WithMany(x => x.TeacherBranches).HasForeignKey(x => x.TeacherId);
            //builder.HasOne(x => x.Branch).WithMany(x => x.TeacherBranches).HasForeignKey(x => x.BranchId);
        }
    }
}
