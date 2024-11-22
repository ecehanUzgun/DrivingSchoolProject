﻿// <auto-generated />
using System;
using DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(ProjectContext))]
    [Migration("20241122100820_FakeDataAdded")]
    partial class FakeDataAdded
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            Address = "140 Keeling Place, Marksland, Bosnia and Herzegovina",
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 22, 13, 8, 20, 107, DateTimeKind.Local).AddTicks(5385),
                            Name = "Gleichner Group",
                            PhoneNumber = "3974257047",
                            Status = 0
                        },
                        new
                        {
                            ID = 2,
                            Address = "95330 White Turnpike, Beaufort, Lithuania",
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 22, 13, 8, 20, 107, DateTimeKind.Local).AddTicks(6543),
                            Name = "Nader, Schoen and Schoen",
                            PhoneNumber = "5281335441",
                            Status = 0
                        },
                        new
                        {
                            ID = 3,
                            Address = "874 Domenico Squares, Hyattview, Christmas Island",
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 22, 13, 8, 20, 107, DateTimeKind.Local).AddTicks(6898),
                            Name = "Franecki - Cummings",
                            PhoneNumber = "0520720262",
                            Status = 0
                        },
                        new
                        {
                            ID = 4,
                            Address = "60570 Terry Lock, Lake Annabelstad, Panama",
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 22, 13, 8, 20, 107, DateTimeKind.Local).AddTicks(7065),
                            Name = "Yost Inc",
                            PhoneNumber = "2391609022",
                            Status = 0
                        },
                        new
                        {
                            ID = 5,
                            Address = "86908 Howell Ridge, Botsfordbury, Austria",
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 22, 13, 8, 20, 107, DateTimeKind.Local).AddTicks(7261),
                            Name = "Heidenreich - Lowe",
                            PhoneNumber = "1200529621",
                            Status = 0
                        });
                });

            modelBuilder.Entity("MODEL.Entities.Schedule", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

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

                    b.Property<string>("UpdatedComputerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

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
                            BirthDate = new DateTime(2006, 4, 28, 18, 39, 2, 604, DateTimeKind.Local).AddTicks(7068),
                            BranchId = 5,
                            CourseHours = 6,
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 22, 13, 8, 20, 111, DateTimeKind.Local).AddTicks(9619),
                            Name = "Lelah",
                            Status = 0,
                            Surname = "Cronin",
                            Tckn = "36130438351"
                        },
                        new
                        {
                            ID = 2,
                            BirthDate = new DateTime(1999, 5, 31, 4, 6, 8, 378, DateTimeKind.Local).AddTicks(611),
                            BranchId = 4,
                            CourseHours = 6,
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 22, 13, 8, 20, 112, DateTimeKind.Local).AddTicks(1735),
                            Name = "Lucile",
                            Status = 0,
                            Surname = "Collins",
                            Tckn = "62030378524"
                        },
                        new
                        {
                            ID = 3,
                            BirthDate = new DateTime(1988, 2, 13, 0, 32, 40, 84, DateTimeKind.Local).AddTicks(1021),
                            BranchId = 3,
                            CourseHours = 6,
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 22, 13, 8, 20, 112, DateTimeKind.Local).AddTicks(1801),
                            Name = "Josephine",
                            Status = 0,
                            Surname = "Murray",
                            Tckn = "27521681535"
                        },
                        new
                        {
                            ID = 4,
                            BirthDate = new DateTime(1992, 10, 16, 23, 5, 11, 555, DateTimeKind.Local).AddTicks(9807),
                            BranchId = 1,
                            CourseHours = 6,
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 22, 13, 8, 20, 112, DateTimeKind.Local).AddTicks(1826),
                            Name = "Bertha",
                            Status = 0,
                            Surname = "Hermiston",
                            Tckn = "43161124998"
                        },
                        new
                        {
                            ID = 5,
                            BirthDate = new DateTime(1989, 8, 11, 15, 55, 47, 825, DateTimeKind.Local).AddTicks(1131),
                            BranchId = 1,
                            CourseHours = 6,
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 22, 13, 8, 20, 112, DateTimeKind.Local).AddTicks(1847),
                            Name = "Cecile",
                            Status = 0,
                            Surname = "Baumbach",
                            Tckn = "30983465946"
                        },
                        new
                        {
                            ID = 6,
                            BirthDate = new DateTime(1994, 4, 18, 11, 36, 11, 169, DateTimeKind.Local).AddTicks(3308),
                            BranchId = 4,
                            CourseHours = 6,
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 22, 13, 8, 20, 112, DateTimeKind.Local).AddTicks(1868),
                            Name = "Elisa",
                            Status = 0,
                            Surname = "Kuphal",
                            Tckn = "20030104492"
                        },
                        new
                        {
                            ID = 7,
                            BirthDate = new DateTime(1997, 11, 9, 8, 19, 45, 638, DateTimeKind.Local).AddTicks(1187),
                            BranchId = 1,
                            CourseHours = 6,
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 22, 13, 8, 20, 112, DateTimeKind.Local).AddTicks(1889),
                            Name = "Baron",
                            Status = 0,
                            Surname = "Hauck",
                            Tckn = "68568652922"
                        },
                        new
                        {
                            ID = 8,
                            BirthDate = new DateTime(1995, 4, 1, 20, 20, 38, 602, DateTimeKind.Local).AddTicks(1801),
                            BranchId = 4,
                            CourseHours = 6,
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 22, 13, 8, 20, 112, DateTimeKind.Local).AddTicks(1910),
                            Name = "Dasia",
                            Status = 0,
                            Surname = "West",
                            Tckn = "14814858983"
                        },
                        new
                        {
                            ID = 9,
                            BirthDate = new DateTime(2000, 1, 25, 4, 20, 51, 396, DateTimeKind.Local).AddTicks(1802),
                            BranchId = 2,
                            CourseHours = 6,
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 22, 13, 8, 20, 112, DateTimeKind.Local).AddTicks(1929),
                            Name = "Herman",
                            Status = 0,
                            Surname = "Weissnat",
                            Tckn = "00474187344"
                        },
                        new
                        {
                            ID = 10,
                            BirthDate = new DateTime(1993, 11, 18, 12, 20, 16, 370, DateTimeKind.Local).AddTicks(5198),
                            BranchId = 4,
                            CourseHours = 6,
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 22, 13, 8, 20, 112, DateTimeKind.Local).AddTicks(1948),
                            Name = "Tatum",
                            Status = 0,
                            Surname = "Littel",
                            Tckn = "14836509961"
                        },
                        new
                        {
                            ID = 11,
                            BirthDate = new DateTime(2000, 7, 27, 9, 41, 53, 529, DateTimeKind.Local).AddTicks(7009),
                            BranchId = 2,
                            CourseHours = 6,
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 22, 13, 8, 20, 112, DateTimeKind.Local).AddTicks(2022),
                            Name = "Anibal",
                            Status = 0,
                            Surname = "Klein",
                            Tckn = "63994231681"
                        },
                        new
                        {
                            ID = 12,
                            BirthDate = new DateTime(1991, 7, 9, 4, 57, 24, 827, DateTimeKind.Local).AddTicks(7542),
                            BranchId = 5,
                            CourseHours = 6,
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 22, 13, 8, 20, 112, DateTimeKind.Local).AddTicks(2041),
                            Name = "Rudy",
                            Status = 0,
                            Surname = "Fisher",
                            Tckn = "84943702950"
                        },
                        new
                        {
                            ID = 13,
                            BirthDate = new DateTime(1998, 7, 2, 20, 39, 0, 864, DateTimeKind.Local).AddTicks(1832),
                            BranchId = 3,
                            CourseHours = 6,
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 22, 13, 8, 20, 112, DateTimeKind.Local).AddTicks(2060),
                            Name = "Joel",
                            Status = 0,
                            Surname = "Bartoletti",
                            Tckn = "52710674769"
                        },
                        new
                        {
                            ID = 14,
                            BirthDate = new DateTime(1998, 12, 16, 8, 37, 8, 104, DateTimeKind.Local).AddTicks(8683),
                            BranchId = 1,
                            CourseHours = 6,
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 22, 13, 8, 20, 112, DateTimeKind.Local).AddTicks(2078),
                            Name = "Gerardo",
                            Status = 0,
                            Surname = "Vandervort",
                            Tckn = "72077660104"
                        },
                        new
                        {
                            ID = 15,
                            BirthDate = new DateTime(1989, 9, 5, 12, 7, 36, 41, DateTimeKind.Local).AddTicks(1000),
                            BranchId = 2,
                            CourseHours = 6,
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 22, 13, 8, 20, 112, DateTimeKind.Local).AddTicks(2097),
                            Name = "Parker",
                            Status = 0,
                            Surname = "Senger",
                            Tckn = "91786957621"
                        },
                        new
                        {
                            ID = 16,
                            BirthDate = new DateTime(2000, 6, 7, 21, 46, 57, 277, DateTimeKind.Local).AddTicks(6342),
                            BranchId = 5,
                            CourseHours = 6,
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 22, 13, 8, 20, 112, DateTimeKind.Local).AddTicks(2116),
                            Name = "Kaela",
                            Status = 0,
                            Surname = "Kerluke",
                            Tckn = "72522976260"
                        },
                        new
                        {
                            ID = 17,
                            BirthDate = new DateTime(1999, 9, 30, 22, 40, 36, 975, DateTimeKind.Local).AddTicks(1475),
                            BranchId = 2,
                            CourseHours = 6,
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 22, 13, 8, 20, 112, DateTimeKind.Local).AddTicks(2134),
                            Name = "Dana",
                            Status = 0,
                            Surname = "Roob",
                            Tckn = "07981873526"
                        },
                        new
                        {
                            ID = 18,
                            BirthDate = new DateTime(1997, 2, 27, 4, 49, 51, 546, DateTimeKind.Local).AddTicks(3168),
                            BranchId = 5,
                            CourseHours = 6,
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 22, 13, 8, 20, 112, DateTimeKind.Local).AddTicks(2153),
                            Name = "Sean",
                            Status = 0,
                            Surname = "Rempel",
                            Tckn = "87850591919"
                        },
                        new
                        {
                            ID = 19,
                            BirthDate = new DateTime(2003, 12, 5, 14, 9, 41, 785, DateTimeKind.Local).AddTicks(6424),
                            BranchId = 5,
                            CourseHours = 6,
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 22, 13, 8, 20, 112, DateTimeKind.Local).AddTicks(2171),
                            Name = "Ford",
                            Status = 0,
                            Surname = "Jacobi",
                            Tckn = "05606200463"
                        },
                        new
                        {
                            ID = 20,
                            BirthDate = new DateTime(2000, 7, 13, 15, 23, 16, 469, DateTimeKind.Local).AddTicks(8416),
                            BranchId = 3,
                            CourseHours = 6,
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 22, 13, 8, 20, 112, DateTimeKind.Local).AddTicks(2188),
                            Name = "Thea",
                            Status = 0,
                            Surname = "Schmeler",
                            Tckn = "66958063615"
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
                            BirthDate = new DateTime(1998, 11, 28, 21, 26, 42, 244, DateTimeKind.Local).AddTicks(628),
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 22, 13, 8, 20, 110, DateTimeKind.Local).AddTicks(1224),
                            Name = "Augustine",
                            Status = 0,
                            Surname = "Kihn",
                            Tckn = "03379850118"
                        },
                        new
                        {
                            ID = 2,
                            BirthDate = new DateTime(1999, 6, 5, 1, 29, 19, 587, DateTimeKind.Local).AddTicks(6211),
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 22, 13, 8, 20, 110, DateTimeKind.Local).AddTicks(3622),
                            Name = "Loy",
                            Status = 0,
                            Surname = "Jakubowski",
                            Tckn = "40511830604"
                        },
                        new
                        {
                            ID = 3,
                            BirthDate = new DateTime(1999, 8, 17, 12, 7, 19, 326, DateTimeKind.Local).AddTicks(1721),
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 22, 13, 8, 20, 110, DateTimeKind.Local).AddTicks(3683),
                            Name = "Dianna",
                            Status = 0,
                            Surname = "Kuhn",
                            Tckn = "01613945766"
                        },
                        new
                        {
                            ID = 4,
                            BirthDate = new DateTime(1986, 7, 7, 9, 25, 17, 44, DateTimeKind.Local).AddTicks(1793),
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 22, 13, 8, 20, 110, DateTimeKind.Local).AddTicks(3709),
                            Name = "Jaiden",
                            Status = 0,
                            Surname = "Pagac",
                            Tckn = "30397535704"
                        },
                        new
                        {
                            ID = 5,
                            BirthDate = new DateTime(1982, 11, 24, 15, 50, 47, 52, DateTimeKind.Local).AddTicks(8652),
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 22, 13, 8, 20, 110, DateTimeKind.Local).AddTicks(3728),
                            Name = "Major",
                            Status = 0,
                            Surname = "Howe",
                            Tckn = "57790097070"
                        },
                        new
                        {
                            ID = 6,
                            BirthDate = new DateTime(1976, 2, 25, 12, 12, 36, 508, DateTimeKind.Local).AddTicks(9917),
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 22, 13, 8, 20, 110, DateTimeKind.Local).AddTicks(3745),
                            Name = "Aiden",
                            Status = 0,
                            Surname = "Lind",
                            Tckn = "03915347710"
                        },
                        new
                        {
                            ID = 7,
                            BirthDate = new DateTime(1992, 6, 11, 5, 49, 15, 947, DateTimeKind.Local).AddTicks(502),
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 22, 13, 8, 20, 110, DateTimeKind.Local).AddTicks(3763),
                            Name = "Conrad",
                            Status = 0,
                            Surname = "Gutkowski",
                            Tckn = "92727663783"
                        },
                        new
                        {
                            ID = 8,
                            BirthDate = new DateTime(1988, 9, 22, 22, 47, 8, 77, DateTimeKind.Local).AddTicks(5834),
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 22, 13, 8, 20, 110, DateTimeKind.Local).AddTicks(3783),
                            Name = "Donald",
                            Status = 0,
                            Surname = "Hilll",
                            Tckn = "98658688880"
                        },
                        new
                        {
                            ID = 9,
                            BirthDate = new DateTime(1990, 5, 26, 5, 36, 46, 569, DateTimeKind.Local).AddTicks(688),
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 22, 13, 8, 20, 110, DateTimeKind.Local).AddTicks(3799),
                            Name = "Fredrick",
                            Status = 0,
                            Surname = "Ziemann",
                            Tckn = "32106590734"
                        },
                        new
                        {
                            ID = 10,
                            BirthDate = new DateTime(1993, 10, 6, 17, 54, 53, 541, DateTimeKind.Local).AddTicks(3709),
                            CreatedComputerName = "BILGIISLEM",
                            CreatedDate = new DateTime(2024, 11, 22, 13, 8, 20, 110, DateTimeKind.Local).AddTicks(3910),
                            Name = "Russ",
                            Status = 0,
                            Surname = "Mitchell",
                            Tckn = "10557233940"
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
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MODEL.Entities.Teacher", "Teacher")
                        .WithMany("Schedules")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
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