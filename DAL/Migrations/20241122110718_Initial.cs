using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Tckn = table.Column<string>(type: "nchar(11)", fixedLength: true, maxLength: 11, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LicensePlate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    VehicleType = table.Column<int>(type: "int", nullable: false),
                    Transmission = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Tckn = table.Column<string>(type: "nchar(11)", fixedLength: true, maxLength: 11, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CourseHours = table.Column<int>(type: "int", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Students_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeacherBranches",
                columns: table => new
                {
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherBranches", x => new { x.TeacherId, x.BranchId });
                    table.ForeignKey(
                        name: "FK_TeacherBranches_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherBranches_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VehicleBranches",
                columns: table => new
                {
                    VehicleId = table.Column<int>(type: "int", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleBranches", x => new { x.BranchId, x.VehicleId });
                    table.ForeignKey(
                        name: "FK_VehicleBranches_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VehicleBranches_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    LessonDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => new { x.StudentId, x.TeacherId });
                    table.ForeignKey(
                        name: "FK_Schedules_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Schedules_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "ID", "Address", "CreatedComputerName", "CreatedDate", "Name", "PhoneNumber", "Status", "UpdatedComputerName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "92998 Margarette Hollow, Bruenshire, Taiwan", "BILGIISLEM", new DateTime(2024, 11, 22, 14, 7, 18, 232, DateTimeKind.Local).AddTicks(701), "Lindgren, Welch and Funk", "3377609905", 0, null, null },
                    { 2, "8995 Wisoky Ranch, Lakinville, Colombia", "BILGIISLEM", new DateTime(2024, 11, 22, 14, 7, 18, 232, DateTimeKind.Local).AddTicks(1738), "Goyette, Batz and Schmitt", "0688446740", 0, null, null },
                    { 3, "552 Renner Plaza, Parisianton, Nigeria", "BILGIISLEM", new DateTime(2024, 11, 22, 14, 7, 18, 232, DateTimeKind.Local).AddTicks(2057), "Balistreri - Rodriguez", "3954950129", 0, null, null },
                    { 4, "6129 Ratke Skyway, Camylleville, New Zealand", "BILGIISLEM", new DateTime(2024, 11, 22, 14, 7, 18, 232, DateTimeKind.Local).AddTicks(2233), "Smith Inc", "4488277562", 0, null, null },
                    { 5, "26185 Mitchell Junction, Alexieberg, Saint Helena", "BILGIISLEM", new DateTime(2024, 11, 22, 14, 7, 18, 232, DateTimeKind.Local).AddTicks(6822), "Effertz Inc", "1829243946", 0, null, null }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "BirthDate", "CreatedComputerName", "CreatedDate", "Name", "Status", "Surname", "Tckn", "UpdatedComputerName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(1993, 11, 11, 6, 1, 47, 784, DateTimeKind.Local).AddTicks(335), "BILGIISLEM", new DateTime(2024, 11, 22, 14, 7, 18, 235, DateTimeKind.Local).AddTicks(501), "Jamil", 0, "Veum", "35251139674", null, null },
                    { 2, new DateTime(1999, 3, 26, 4, 4, 39, 318, DateTimeKind.Local).AddTicks(3951), "BILGIISLEM", new DateTime(2024, 11, 22, 14, 7, 18, 235, DateTimeKind.Local).AddTicks(2073), "Shad", 0, "Feeney", "47167362758", null, null },
                    { 3, new DateTime(1973, 10, 20, 23, 2, 17, 878, DateTimeKind.Local).AddTicks(7902), "BILGIISLEM", new DateTime(2024, 11, 22, 14, 7, 18, 235, DateTimeKind.Local).AddTicks(2137), "Randi", 0, "Dicki", "23176272794", null, null },
                    { 4, new DateTime(1987, 1, 18, 1, 3, 53, 98, DateTimeKind.Local).AddTicks(359), "BILGIISLEM", new DateTime(2024, 11, 22, 14, 7, 18, 235, DateTimeKind.Local).AddTicks(2159), "Jillian", 0, "Fisher", "73116014597", null, null },
                    { 5, new DateTime(1974, 5, 22, 20, 19, 21, 627, DateTimeKind.Local).AddTicks(2277), "BILGIISLEM", new DateTime(2024, 11, 22, 14, 7, 18, 235, DateTimeKind.Local).AddTicks(2178), "Jonatan", 0, "Blanda", "06361966448", null, null },
                    { 6, new DateTime(1997, 10, 5, 11, 25, 8, 328, DateTimeKind.Local).AddTicks(5975), "BILGIISLEM", new DateTime(2024, 11, 22, 14, 7, 18, 235, DateTimeKind.Local).AddTicks(2200), "Guiseppe", 0, "Lynch", "58174158764", null, null },
                    { 7, new DateTime(1998, 10, 14, 0, 26, 52, 647, DateTimeKind.Local).AddTicks(7683), "BILGIISLEM", new DateTime(2024, 11, 22, 14, 7, 18, 235, DateTimeKind.Local).AddTicks(2218), "Trudie", 0, "Brakus", "43306869133", null, null },
                    { 8, new DateTime(1987, 4, 5, 17, 38, 23, 58, DateTimeKind.Local).AddTicks(2903), "BILGIISLEM", new DateTime(2024, 11, 22, 14, 7, 18, 235, DateTimeKind.Local).AddTicks(2235), "Elias", 0, "Donnelly", "70527593908", null, null },
                    { 9, new DateTime(1972, 3, 10, 13, 31, 49, 639, DateTimeKind.Local).AddTicks(8188), "BILGIISLEM", new DateTime(2024, 11, 22, 14, 7, 18, 235, DateTimeKind.Local).AddTicks(2252), "Moshe", 0, "Roob", "86112110274", null, null },
                    { 10, new DateTime(1975, 12, 21, 11, 19, 57, 314, DateTimeKind.Local).AddTicks(1967), "BILGIISLEM", new DateTime(2024, 11, 22, 14, 7, 18, 235, DateTimeKind.Local).AddTicks(2269), "Cristal", 0, "Kreiger", "51589906127", null, null }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "ID", "BirthDate", "BranchId", "CourseHours", "CreatedComputerName", "CreatedDate", "Name", "Status", "Surname", "Tckn", "UpdatedComputerName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(1990, 1, 25, 5, 24, 3, 379, DateTimeKind.Local).AddTicks(3092), 1, 6, "BILGIISLEM", new DateTime(2024, 11, 22, 14, 7, 18, 236, DateTimeKind.Local).AddTicks(6252), "Andres", 0, "Kertzmann", "14958016265", null, null },
                    { 2, new DateTime(2005, 7, 5, 12, 25, 20, 784, DateTimeKind.Local).AddTicks(7814), 5, 6, "BILGIISLEM", new DateTime(2024, 11, 22, 14, 7, 18, 236, DateTimeKind.Local).AddTicks(8191), "Brielle", 0, "Labadie", "49018703379", null, null },
                    { 3, new DateTime(1999, 11, 15, 13, 30, 33, 366, DateTimeKind.Local).AddTicks(24), 2, 6, "BILGIISLEM", new DateTime(2024, 11, 22, 14, 7, 18, 236, DateTimeKind.Local).AddTicks(8257), "Lucienne", 0, "Erdman", "78327486296", null, null },
                    { 4, new DateTime(2005, 1, 7, 21, 34, 9, 27, DateTimeKind.Local).AddTicks(202), 4, 6, "BILGIISLEM", new DateTime(2024, 11, 22, 14, 7, 18, 236, DateTimeKind.Local).AddTicks(8328), "Bart", 0, "Emard", "98373204263", null, null },
                    { 5, new DateTime(2003, 4, 15, 21, 46, 44, 368, DateTimeKind.Local).AddTicks(8137), 3, 6, "BILGIISLEM", new DateTime(2024, 11, 22, 14, 7, 18, 236, DateTimeKind.Local).AddTicks(8347), "Robin", 0, "Romaguera", "05043513866", null, null },
                    { 6, new DateTime(2002, 5, 27, 18, 59, 37, 497, DateTimeKind.Local).AddTicks(1854), 2, 6, "BILGIISLEM", new DateTime(2024, 11, 22, 14, 7, 18, 236, DateTimeKind.Local).AddTicks(8367), "Hailee", 0, "Doyle", "37486985409", null, null },
                    { 7, new DateTime(1987, 6, 2, 17, 53, 3, 421, DateTimeKind.Local).AddTicks(8117), 1, 6, "BILGIISLEM", new DateTime(2024, 11, 22, 14, 7, 18, 236, DateTimeKind.Local).AddTicks(8390), "Tyrell", 0, "Gusikowski", "61622583823", null, null },
                    { 8, new DateTime(1997, 7, 2, 10, 33, 6, 409, DateTimeKind.Local).AddTicks(794), 2, 6, "BILGIISLEM", new DateTime(2024, 11, 22, 14, 7, 18, 236, DateTimeKind.Local).AddTicks(8411), "Alexa", 0, "Considine", "80951143787", null, null },
                    { 9, new DateTime(2003, 1, 13, 19, 46, 21, 631, DateTimeKind.Local).AddTicks(8227), 5, 6, "BILGIISLEM", new DateTime(2024, 11, 22, 14, 7, 18, 236, DateTimeKind.Local).AddTicks(8430), "Kevon", 0, "Gutmann", "02273223110", null, null },
                    { 10, new DateTime(1991, 7, 14, 22, 27, 44, 925, DateTimeKind.Local).AddTicks(3129), 1, 6, "BILGIISLEM", new DateTime(2024, 11, 22, 14, 7, 18, 236, DateTimeKind.Local).AddTicks(8447), "Jarrod", 0, "Rowe", "14596633767", null, null },
                    { 11, new DateTime(2005, 3, 31, 8, 23, 31, 975, DateTimeKind.Local).AddTicks(8449), 2, 6, "BILGIISLEM", new DateTime(2024, 11, 22, 14, 7, 18, 236, DateTimeKind.Local).AddTicks(8468), "Jadyn", 0, "Kessler", "51781916388", null, null },
                    { 12, new DateTime(1995, 10, 23, 19, 31, 52, 823, DateTimeKind.Local).AddTicks(244), 3, 6, "BILGIISLEM", new DateTime(2024, 11, 22, 14, 7, 18, 236, DateTimeKind.Local).AddTicks(8485), "Stewart", 0, "Weissnat", "36988494576", null, null },
                    { 13, new DateTime(1997, 12, 6, 10, 1, 20, 917, DateTimeKind.Local).AddTicks(6747), 1, 6, "BILGIISLEM", new DateTime(2024, 11, 22, 14, 7, 18, 236, DateTimeKind.Local).AddTicks(8503), "Ernestina", 0, "Stracke", "86314191474", null, null },
                    { 14, new DateTime(2001, 6, 19, 6, 20, 55, 26, DateTimeKind.Local).AddTicks(7856), 5, 6, "BILGIISLEM", new DateTime(2024, 11, 22, 14, 7, 18, 236, DateTimeKind.Local).AddTicks(8522), "Meggie", 0, "Bartell", "15988620503", null, null },
                    { 15, new DateTime(1996, 3, 11, 8, 14, 4, 550, DateTimeKind.Local).AddTicks(8526), 3, 6, "BILGIISLEM", new DateTime(2024, 11, 22, 14, 7, 18, 236, DateTimeKind.Local).AddTicks(8544), "Tiffany", 0, "Marquardt", "47213406818", null, null },
                    { 16, new DateTime(1996, 11, 8, 18, 55, 48, 846, DateTimeKind.Local).AddTicks(4634), 2, 6, "BILGIISLEM", new DateTime(2024, 11, 22, 14, 7, 18, 236, DateTimeKind.Local).AddTicks(8562), "Ernesto", 0, "Smitham", "18832562430", null, null },
                    { 17, new DateTime(1998, 11, 19, 18, 16, 4, 403, DateTimeKind.Local).AddTicks(4546), 1, 6, "BILGIISLEM", new DateTime(2024, 11, 22, 14, 7, 18, 236, DateTimeKind.Local).AddTicks(8578), "Arlene", 0, "Lind", "10339924593", null, null },
                    { 18, new DateTime(2006, 5, 12, 7, 14, 49, 333, DateTimeKind.Local).AddTicks(7465), 5, 6, "BILGIISLEM", new DateTime(2024, 11, 22, 14, 7, 18, 236, DateTimeKind.Local).AddTicks(8596), "Timmy", 0, "Murazik", "43371533126", null, null },
                    { 19, new DateTime(1992, 9, 8, 3, 1, 54, 742, DateTimeKind.Local).AddTicks(1495), 2, 6, "BILGIISLEM", new DateTime(2024, 11, 22, 14, 7, 18, 236, DateTimeKind.Local).AddTicks(8616), "Flo", 0, "Auer", "33423558776", null, null },
                    { 20, new DateTime(1991, 3, 16, 1, 48, 27, 241, DateTimeKind.Local).AddTicks(1984), 5, 6, "BILGIISLEM", new DateTime(2024, 11, 22, 14, 7, 18, 236, DateTimeKind.Local).AddTicks(8633), "Kobe", 0, "Lehner", "02250785013", null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_TeacherId",
                table: "Schedules",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_BranchId",
                table: "Students",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherBranches_BranchId",
                table: "TeacherBranches",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBranches_VehicleId",
                table: "VehicleBranches",
                column: "VehicleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "TeacherBranches");

            migrationBuilder.DropTable(
                name: "VehicleBranches");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Branches");
        }
    }
}
