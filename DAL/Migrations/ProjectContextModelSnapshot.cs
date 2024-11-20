﻿// <auto-generated />
using System;
using DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(ProjectContext))]
    partial class ProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MODEL.Entities.Branch", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Address")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.HasKey("ID");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("MODEL.Entities.Schedule", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.Property<DateTime>("LessonDate")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "TeacherId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("MODEL.Entities.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<int>("CourseHours")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tckn")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nchar(11)")
                        .IsFixedLength();

                    b.HasKey("ID");

                    b.HasIndex("BranchId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("MODEL.Entities.Teacher", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tckn")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nchar(11)")
                        .IsFixedLength();

                    b.HasKey("ID");

                    b.HasIndex("BranchId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("MODEL.Entities.Vehicle", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<string>("LicensePlate")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("Transmission")
                        .HasColumnType("int");

                    b.Property<int>("VehicleType")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("BranchId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("MODEL.Entities.Schedule", b =>
                {
                    b.HasOne("MODEL.Entities.Student", "Student")
                        .WithMany("Schedules")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MODEL.Entities.Teacher", "Teacher")
                        .WithMany("Schedules")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("MODEL.Entities.Student", b =>
                {
                    b.HasOne("MODEL.Entities.Branch", "Branch")
                        .WithMany("Students")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("MODEL.Entities.Teacher", b =>
                {
                    b.HasOne("MODEL.Entities.Branch", "Branch")
                        .WithMany("Teachers")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("MODEL.Entities.Vehicle", b =>
                {
                    b.HasOne("MODEL.Entities.Branch", "Branch")
                        .WithMany("Vehicles")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("MODEL.Entities.Branch", b =>
                {
                    b.Navigation("Students");

                    b.Navigation("Teachers");

                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("MODEL.Entities.Student", b =>
                {
                    b.Navigation("Schedules");
                });

            modelBuilder.Entity("MODEL.Entities.Teacher", b =>
                {
                    b.Navigation("Schedules");
                });
#pragma warning restore 612, 618
        }
    }
}
