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

                    b.Property<string>("CreatedComputerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedComputerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Branches");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Address = "4467 Leonie Greens, East Roy, Australia",
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 25, 10, 33, 17, 882, DateTimeKind.Local).AddTicks(6298),
                            Name = "Hickle Group",
                            PhoneNumber = "9228873651",
                            Status = 0
                        },
                        new
                        {
                            ID = 2,
                            Address = "19753 Nestor Creek, Otisburgh, Philippines",
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 25, 10, 33, 17, 882, DateTimeKind.Local).AddTicks(9267),
                            Name = "Champlin - Donnelly",
                            PhoneNumber = "6432546520",
                            Status = 0
                        },
                        new
                        {
                            ID = 3,
                            Address = "83950 Hilpert Common, East Madisonview, Martinique",
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 25, 10, 33, 17, 882, DateTimeKind.Local).AddTicks(9740),
                            Name = "Torp, Reichel and Cormier",
                            PhoneNumber = "0695450952",
                            Status = 0
                        },
                        new
                        {
                            ID = 4,
                            Address = "82973 Gleichner Expressway, Valentinburgh, Turkmenistan",
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 25, 10, 33, 17, 882, DateTimeKind.Local).AddTicks(9984),
                            Name = "Lueilwitz - Nikolaus",
                            PhoneNumber = "9250639381",
                            Status = 0
                        },
                        new
                        {
                            ID = 5,
                            Address = "08955 Olson Roads, New Jerald, Saint Martin",
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 25, 10, 33, 17, 883, DateTimeKind.Local).AddTicks(177),
                            Name = "Conroy - Christiansen",
                            PhoneNumber = "8775573571",
                            Status = 0
                        });
                });

            modelBuilder.Entity("MODEL.Entities.Schedule", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CreatedComputerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LessonDate")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedComputerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("StudentId");

                    b.HasIndex("TeacherId", "LessonDate", "StartTime")
                        .IsUnique();

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

                    b.Property<string>("CreatedComputerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("UpdatedComputerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("BranchId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            BirthDate = new DateTime(1994, 3, 11, 16, 56, 28, 262, DateTimeKind.Local).AddTicks(2688),
                            BranchId = 3,
                            CourseHours = 6,
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 25, 10, 33, 17, 887, DateTimeKind.Local).AddTicks(1665),
                            Name = "Vivianne",
                            Status = 0,
                            Surname = "Huel",
                            Tckn = "96643388934"
                        },
                        new
                        {
                            ID = 2,
                            BirthDate = new DateTime(1987, 9, 19, 23, 24, 17, 148, DateTimeKind.Local).AddTicks(8348),
                            BranchId = 4,
                            CourseHours = 6,
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 25, 10, 33, 17, 887, DateTimeKind.Local).AddTicks(4472),
                            Name = "Freeda",
                            Status = 0,
                            Surname = "Abernathy",
                            Tckn = "58076284168"
                        },
                        new
                        {
                            ID = 3,
                            BirthDate = new DateTime(2003, 6, 15, 5, 20, 15, 398, DateTimeKind.Local).AddTicks(6000),
                            BranchId = 2,
                            CourseHours = 6,
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 25, 10, 33, 17, 887, DateTimeKind.Local).AddTicks(4555),
                            Name = "Dariana",
                            Status = 0,
                            Surname = "Goodwin",
                            Tckn = "36035212771"
                        },
                        new
                        {
                            ID = 4,
                            BirthDate = new DateTime(1990, 3, 17, 16, 13, 2, 970, DateTimeKind.Local).AddTicks(9746),
                            BranchId = 2,
                            CourseHours = 6,
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 25, 10, 33, 17, 887, DateTimeKind.Local).AddTicks(4588),
                            Name = "Zita",
                            Status = 0,
                            Surname = "Pagac",
                            Tckn = "42277549959"
                        },
                        new
                        {
                            ID = 5,
                            BirthDate = new DateTime(1991, 5, 18, 14, 31, 56, 84, DateTimeKind.Local).AddTicks(2553),
                            BranchId = 3,
                            CourseHours = 6,
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 25, 10, 33, 17, 887, DateTimeKind.Local).AddTicks(4617),
                            Name = "Jeffery",
                            Status = 0,
                            Surname = "Leffler",
                            Tckn = "28325702368"
                        },
                        new
                        {
                            ID = 6,
                            BirthDate = new DateTime(1993, 10, 13, 9, 19, 7, 937, DateTimeKind.Local).AddTicks(6745),
                            BranchId = 2,
                            CourseHours = 6,
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 25, 10, 33, 17, 887, DateTimeKind.Local).AddTicks(4643),
                            Name = "Theodore",
                            Status = 0,
                            Surname = "Johns",
                            Tckn = "22445623835"
                        },
                        new
                        {
                            ID = 7,
                            BirthDate = new DateTime(2004, 12, 30, 6, 18, 34, 958, DateTimeKind.Local).AddTicks(1582),
                            BranchId = 4,
                            CourseHours = 6,
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 25, 10, 33, 17, 887, DateTimeKind.Local).AddTicks(4667),
                            Name = "Arthur",
                            Status = 0,
                            Surname = "Durgan",
                            Tckn = "03465726170"
                        },
                        new
                        {
                            ID = 8,
                            BirthDate = new DateTime(1993, 8, 4, 9, 16, 56, 918, DateTimeKind.Local).AddTicks(8272),
                            BranchId = 5,
                            CourseHours = 6,
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 25, 10, 33, 17, 887, DateTimeKind.Local).AddTicks(4692),
                            Name = "Toney",
                            Status = 0,
                            Surname = "Buckridge",
                            Tckn = "60755859590"
                        },
                        new
                        {
                            ID = 9,
                            BirthDate = new DateTime(1987, 11, 7, 12, 13, 52, 321, DateTimeKind.Local).AddTicks(2032),
                            BranchId = 4,
                            CourseHours = 6,
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 25, 10, 33, 17, 887, DateTimeKind.Local).AddTicks(4717),
                            Name = "Daren",
                            Status = 0,
                            Surname = "Green",
                            Tckn = "22295480320"
                        },
                        new
                        {
                            ID = 10,
                            BirthDate = new DateTime(1999, 8, 9, 8, 30, 37, 300, DateTimeKind.Local).AddTicks(6062),
                            BranchId = 4,
                            CourseHours = 6,
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 25, 10, 33, 17, 887, DateTimeKind.Local).AddTicks(4740),
                            Name = "Duncan",
                            Status = 0,
                            Surname = "Considine",
                            Tckn = "14227088071"
                        },
                        new
                        {
                            ID = 11,
                            BirthDate = new DateTime(1992, 8, 9, 6, 34, 31, 950, DateTimeKind.Local).AddTicks(3875),
                            BranchId = 2,
                            CourseHours = 6,
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 25, 10, 33, 17, 887, DateTimeKind.Local).AddTicks(4763),
                            Name = "Clark",
                            Status = 0,
                            Surname = "Lynch",
                            Tckn = "42593651809"
                        },
                        new
                        {
                            ID = 12,
                            BirthDate = new DateTime(2003, 10, 20, 19, 53, 18, 791, DateTimeKind.Local).AddTicks(6431),
                            BranchId = 3,
                            CourseHours = 6,
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 25, 10, 33, 17, 887, DateTimeKind.Local).AddTicks(4786),
                            Name = "Al",
                            Status = 0,
                            Surname = "Marquardt",
                            Tckn = "93810558261"
                        },
                        new
                        {
                            ID = 13,
                            BirthDate = new DateTime(1996, 2, 19, 11, 26, 41, 69, DateTimeKind.Local).AddTicks(9769),
                            BranchId = 1,
                            CourseHours = 6,
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 25, 10, 33, 17, 887, DateTimeKind.Local).AddTicks(4856),
                            Name = "Santa",
                            Status = 0,
                            Surname = "Rutherford",
                            Tckn = "86696630705"
                        },
                        new
                        {
                            ID = 14,
                            BirthDate = new DateTime(1995, 5, 24, 7, 57, 46, 476, DateTimeKind.Local).AddTicks(1248),
                            BranchId = 3,
                            CourseHours = 6,
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 25, 10, 33, 17, 887, DateTimeKind.Local).AddTicks(4886),
                            Name = "Wilhelm",
                            Status = 0,
                            Surname = "Rau",
                            Tckn = "97615018440"
                        },
                        new
                        {
                            ID = 15,
                            BirthDate = new DateTime(1991, 10, 5, 7, 29, 53, 334, DateTimeKind.Local).AddTicks(395),
                            BranchId = 3,
                            CourseHours = 6,
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 25, 10, 33, 17, 887, DateTimeKind.Local).AddTicks(4910),
                            Name = "Gerardo",
                            Status = 0,
                            Surname = "Emard",
                            Tckn = "97749836486"
                        },
                        new
                        {
                            ID = 16,
                            BirthDate = new DateTime(1992, 10, 23, 5, 51, 38, 778, DateTimeKind.Local).AddTicks(9906),
                            BranchId = 2,
                            CourseHours = 6,
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 25, 10, 33, 17, 887, DateTimeKind.Local).AddTicks(4935),
                            Name = "Elenor",
                            Status = 0,
                            Surname = "Nolan",
                            Tckn = "77228272987"
                        },
                        new
                        {
                            ID = 17,
                            BirthDate = new DateTime(1989, 9, 5, 23, 22, 21, 663, DateTimeKind.Local).AddTicks(6073),
                            BranchId = 2,
                            CourseHours = 6,
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 25, 10, 33, 17, 887, DateTimeKind.Local).AddTicks(4957),
                            Name = "Ethelyn",
                            Status = 0,
                            Surname = "Gusikowski",
                            Tckn = "43122344618"
                        },
                        new
                        {
                            ID = 18,
                            BirthDate = new DateTime(1999, 3, 10, 10, 33, 23, 831, DateTimeKind.Local).AddTicks(4201),
                            BranchId = 3,
                            CourseHours = 6,
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 25, 10, 33, 17, 887, DateTimeKind.Local).AddTicks(4982),
                            Name = "Joany",
                            Status = 0,
                            Surname = "Runolfsdottir",
                            Tckn = "99976576815"
                        },
                        new
                        {
                            ID = 19,
                            BirthDate = new DateTime(1991, 6, 3, 17, 21, 54, 912, DateTimeKind.Local).AddTicks(101),
                            BranchId = 3,
                            CourseHours = 6,
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 25, 10, 33, 17, 887, DateTimeKind.Local).AddTicks(5009),
                            Name = "Nelda",
                            Status = 0,
                            Surname = "Kilback",
                            Tckn = "79144889234"
                        },
                        new
                        {
                            ID = 20,
                            BirthDate = new DateTime(1990, 12, 29, 10, 25, 9, 517, DateTimeKind.Local).AddTicks(9235),
                            BranchId = 3,
                            CourseHours = 6,
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 25, 10, 33, 17, 887, DateTimeKind.Local).AddTicks(5031),
                            Name = "Micheal",
                            Status = 0,
                            Surname = "Kuhic",
                            Tckn = "00441738038"
                        });
                });

            modelBuilder.Entity("MODEL.Entities.Teacher", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedComputerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("UpdatedComputerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            BirthDate = new DateTime(1970, 2, 7, 13, 15, 28, 217, DateTimeKind.Local).AddTicks(4595),
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 25, 10, 33, 17, 884, DateTimeKind.Local).AddTicks(8869),
                            Name = "Larue",
                            Status = 0,
                            Surname = "Mraz",
                            Tckn = "51194371835"
                        },
                        new
                        {
                            ID = 2,
                            BirthDate = new DateTime(1984, 10, 9, 8, 43, 45, 492, DateTimeKind.Local).AddTicks(8279),
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 25, 10, 33, 17, 885, DateTimeKind.Local).AddTicks(1266),
                            Name = "Macey",
                            Status = 0,
                            Surname = "Gorczany",
                            Tckn = "21391359250"
                        },
                        new
                        {
                            ID = 3,
                            BirthDate = new DateTime(1979, 3, 3, 13, 6, 11, 574, DateTimeKind.Local).AddTicks(7701),
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 25, 10, 33, 17, 885, DateTimeKind.Local).AddTicks(1360),
                            Name = "Trevor",
                            Status = 0,
                            Surname = "Denesik",
                            Tckn = "52449073819"
                        },
                        new
                        {
                            ID = 4,
                            BirthDate = new DateTime(1994, 7, 9, 17, 50, 52, 726, DateTimeKind.Local).AddTicks(6848),
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 25, 10, 33, 17, 885, DateTimeKind.Local).AddTicks(1390),
                            Name = "Genevieve",
                            Status = 0,
                            Surname = "Stark",
                            Tckn = "85381286414"
                        },
                        new
                        {
                            ID = 5,
                            BirthDate = new DateTime(1982, 10, 7, 4, 39, 5, 479, DateTimeKind.Local).AddTicks(9149),
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 25, 10, 33, 17, 885, DateTimeKind.Local).AddTicks(1416),
                            Name = "Mekhi",
                            Status = 0,
                            Surname = "Wilderman",
                            Tckn = "15791183446"
                        },
                        new
                        {
                            ID = 6,
                            BirthDate = new DateTime(1985, 3, 15, 15, 31, 37, 380, DateTimeKind.Local).AddTicks(9732),
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 25, 10, 33, 17, 885, DateTimeKind.Local).AddTicks(1447),
                            Name = "Jarret",
                            Status = 0,
                            Surname = "Braun",
                            Tckn = "71376903319"
                        },
                        new
                        {
                            ID = 7,
                            BirthDate = new DateTime(1980, 11, 4, 6, 48, 56, 877, DateTimeKind.Local).AddTicks(6793),
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 25, 10, 33, 17, 885, DateTimeKind.Local).AddTicks(1475),
                            Name = "Maryse",
                            Status = 0,
                            Surname = "Zboncak",
                            Tckn = "28789450793"
                        },
                        new
                        {
                            ID = 8,
                            BirthDate = new DateTime(1988, 12, 26, 9, 2, 29, 305, DateTimeKind.Local).AddTicks(5119),
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 25, 10, 33, 17, 885, DateTimeKind.Local).AddTicks(1499),
                            Name = "Lindsay",
                            Status = 0,
                            Surname = "Luettgen",
                            Tckn = "73637253410"
                        },
                        new
                        {
                            ID = 9,
                            BirthDate = new DateTime(1980, 9, 14, 14, 8, 18, 160, DateTimeKind.Local).AddTicks(2071),
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 25, 10, 33, 17, 885, DateTimeKind.Local).AddTicks(1521),
                            Name = "Shirley",
                            Status = 0,
                            Surname = "Wunsch",
                            Tckn = "18555149241"
                        },
                        new
                        {
                            ID = 10,
                            BirthDate = new DateTime(1970, 8, 14, 5, 48, 6, 383, DateTimeKind.Local).AddTicks(8233),
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 25, 10, 33, 17, 885, DateTimeKind.Local).AddTicks(1543),
                            Name = "Dianna",
                            Status = 0,
                            Surname = "Boyer",
                            Tckn = "96283930144"
                        });
                });

            modelBuilder.Entity("MODEL.Entities.TeacherBranch", b =>
                {
                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedComputerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedComputerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("TeacherId", "BranchId");

                    b.HasIndex("BranchId");

                    b.ToTable("TeacherBranches");
                });

            modelBuilder.Entity("MODEL.Entities.Vehicle", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CreatedComputerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LicensePlate")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Transmission")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedComputerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("VehicleType")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("MODEL.Entities.VehicleBranch", b =>
                {
                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedComputerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedComputerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("BranchId", "VehicleId");

                    b.HasIndex("VehicleId");

                    b.ToTable("VehicleBranches");
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

            modelBuilder.Entity("MODEL.Entities.TeacherBranch", b =>
                {
                    b.HasOne("MODEL.Entities.Branch", "Branch")
                        .WithMany("TeacherBranches")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MODEL.Entities.Teacher", "Teacher")
                        .WithMany("TeacherBranches")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("MODEL.Entities.VehicleBranch", b =>
                {
                    b.HasOne("MODEL.Entities.Branch", "Branch")
                        .WithMany("VehicleBranches")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MODEL.Entities.Vehicle", "Vehicle")
                        .WithMany("VehicleBranches")
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("MODEL.Entities.Branch", b =>
                {
                    b.Navigation("Students");

                    b.Navigation("TeacherBranches");

                    b.Navigation("VehicleBranches");
                });

            modelBuilder.Entity("MODEL.Entities.Student", b =>
                {
                    b.Navigation("Schedules");
                });

            modelBuilder.Entity("MODEL.Entities.Teacher", b =>
                {
                    b.Navigation("Schedules");

                    b.Navigation("TeacherBranches");
                });

            modelBuilder.Entity("MODEL.Entities.Vehicle", b =>
                {
                    b.Navigation("VehicleBranches");
                });
#pragma warning restore 612, 618
        }
    }
}
