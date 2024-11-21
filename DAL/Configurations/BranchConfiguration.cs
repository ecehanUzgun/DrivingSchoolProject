using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MODEL.Entities;

namespace DAL.Configurations
{
    public class BranchConfiguration : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            //Name
            builder.Property(x => x.Name).HasMaxLength(255).IsRequired();

            //Address
            builder.Property(x => x.Address).HasMaxLength(500);

            //PhoneNumber
            builder.Property(x => x.PhoneNumber).HasMaxLength(10).IsFixedLength().IsRequired();
            //[RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Telefon numarası 10 haneli olmalıdır.")]


        }
    }
}
