using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MODEL.Entities;

namespace DAL.Configurations
{
    public class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.Property(x => x.LicensePlate).HasMaxLength(10).IsRequired().HasConversion(x => x.ToUpper(), x => x);

            //todo: [RegularExpression("^[0-9]{2}[A-Z]{1,3}[0-9]{1,4}$", ErrorMessage = "Geçersiz plaka formatı.")]
        }
    }
}
