using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MODEL.Entities;

namespace DAL.Configurations
{
    public class VehicleBranchConfiguration : IEntityTypeConfiguration<VehicleBranch>
    {
        public void Configure(EntityTypeBuilder<VehicleBranch> builder)
        {
            //Id veritabanına gönderilirken engellenecek.
            builder.Ignore(x => x.ID);

            builder.HasKey(x => new {x.BranchId, x.VehicleId});

            //builder.HasOne(x => x.Vehicle).WithMany(x => x.VehicleBranches).HasForeignKey(x => x.VehicleId);

            //builder.HasOne(x => x.Branch).WithMany(x => x.VehicleBranches).HasForeignKey(x => x.BranchId);
        }
    }
}
