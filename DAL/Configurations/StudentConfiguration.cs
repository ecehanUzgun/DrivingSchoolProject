﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MODEL.Entities;

namespace DAL.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            //Name
            builder.Property(x => x.Name).HasMaxLength(50).IsRequired();

            //Surname
            builder.Property(x => x.Surname).HasMaxLength(50).IsRequired();

            //Tckn
            builder.Property(x => x.Tckn).HasMaxLength(11).IsFixedLength().IsRequired();
        }
    }
}