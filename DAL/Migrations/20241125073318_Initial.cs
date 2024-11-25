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
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    table.PrimaryKey("PK_Schedules", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Schedules_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Schedules_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "ID", "Address", "CreatedComputerName", "CreatedDate", "Name", "PhoneNumber", "Status", "UpdatedComputerName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "4467 Leonie Greens, East Roy, Australia", "BILGIISLEM", new DateTime(2024, 11, 25, 10, 33, 17, 882, DateTimeKind.Local).AddTicks(6298), "Hickle Group", "9228873651", 0, null, null },
                    { 2, "19753 Nestor Creek, Otisburgh, Philippines", "BILGIISLEM", new DateTime(2024, 11, 25, 10, 33, 17, 882, DateTimeKind.Local).AddTicks(9267), "Champlin - Donnelly", "6432546520", 0, null, null },
                    { 3, "83950 Hilpert Common, East Madisonview, Martinique", "BILGIISLEM", new DateTime(2024, 11, 25, 10, 33, 17, 882, DateTimeKind.Local).AddTicks(9740), "Torp, Reichel and Cormier", "0695450952", 0, null, null },
                    { 4, "82973 Gleichner Expressway, Valentinburgh, Turkmenistan", "BILGIISLEM", new DateTime(2024, 11, 25, 10, 33, 17, 882, DateTimeKind.Local).AddTicks(9984), "Lueilwitz - Nikolaus", "9250639381", 0, null, null },
                    { 5, "08955 Olson Roads, New Jerald, Saint Martin", "BILGIISLEM", new DateTime(2024, 11, 25, 10, 33, 17, 883, DateTimeKind.Local).AddTicks(177), "Conroy - Christiansen", "8775573571", 0, null, null }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "BirthDate", "CreatedComputerName", "CreatedDate", "Name", "Status", "Surname", "Tckn", "UpdatedComputerName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(1970, 2, 7, 13, 15, 28, 217, DateTimeKind.Local).AddTicks(4595), "BILGIISLEM", new DateTime(2024, 11, 25, 10, 33, 17, 884, DateTimeKind.Local).AddTicks(8869), "Larue", 0, "Mraz", "51194371835", null, null },
                    { 2, new DateTime(1984, 10, 9, 8, 43, 45, 492, DateTimeKind.Local).AddTicks(8279), "BILGIISLEM", new DateTime(2024, 11, 25, 10, 33, 17, 885, DateTimeKind.Local).AddTicks(1266), "Macey", 0, "Gorczany", "21391359250", null, null },
                    { 3, new DateTime(1979, 3, 3, 13, 6, 11, 574, DateTimeKind.Local).AddTicks(7701), "BILGIISLEM", new DateTime(2024, 11, 25, 10, 33, 17, 885, DateTimeKind.Local).AddTicks(1360), "Trevor", 0, "Denesik", "52449073819", null, null },
                    { 4, new DateTime(1994, 7, 9, 17, 50, 52, 726, DateTimeKind.Local).AddTicks(6848), "BILGIISLEM", new DateTime(2024, 11, 25, 10, 33, 17, 885, DateTimeKind.Local).AddTicks(1390), "Genevieve", 0, "Stark", "85381286414", null, null },
                    { 5, new DateTime(1982, 10, 7, 4, 39, 5, 479, DateTimeKind.Local).AddTicks(9149), "BILGIISLEM", new DateTime(2024, 11, 25, 10, 33, 17, 885, DateTimeKind.Local).AddTicks(1416), "Mekhi", 0, "Wilderman", "15791183446", null, null },
                    { 6, new DateTime(1985, 3, 15, 15, 31, 37, 380, DateTimeKind.Local).AddTicks(9732), "BILGIISLEM", new DateTime(2024, 11, 25, 10, 33, 17, 885, DateTimeKind.Local).AddTicks(1447), "Jarret", 0, "Braun", "71376903319", null, null },
                    { 7, new DateTime(1980, 11, 4, 6, 48, 56, 877, DateTimeKind.Local).AddTicks(6793), "BILGIISLEM", new DateTime(2024, 11, 25, 10, 33, 17, 885, DateTimeKind.Local).AddTicks(1475), "Maryse", 0, "Zboncak", "28789450793", null, null },
                    { 8, new DateTime(1988, 12, 26, 9, 2, 29, 305, DateTimeKind.Local).AddTicks(5119), "BILGIISLEM", new DateTime(2024, 11, 25, 10, 33, 17, 885, DateTimeKind.Local).AddTicks(1499), "Lindsay", 0, "Luettgen", "73637253410", null, null },
                    { 9, new DateTime(1980, 9, 14, 14, 8, 18, 160, DateTimeKind.Local).AddTicks(2071), "BILGIISLEM", new DateTime(2024, 11, 25, 10, 33, 17, 885, DateTimeKind.Local).AddTicks(1521), "Shirley", 0, "Wunsch", "18555149241", null, null },
                    { 10, new DateTime(1970, 8, 14, 5, 48, 6, 383, DateTimeKind.Local).AddTicks(8233), "BILGIISLEM", new DateTime(2024, 11, 25, 10, 33, 17, 885, DateTimeKind.Local).AddTicks(1543), "Dianna", 0, "Boyer", "96283930144", null, null }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "ID", "BirthDate", "BranchId", "CourseHours", "CreatedComputerName", "CreatedDate", "Name", "Status", "Surname", "Tckn", "UpdatedComputerName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(1994, 3, 11, 16, 56, 28, 262, DateTimeKind.Local).AddTicks(2688), 3, 6, "BILGIISLEM", new DateTime(2024, 11, 25, 10, 33, 17, 887, DateTimeKind.Local).AddTicks(1665), "Vivianne", 0, "Huel", "96643388934", null, null },
                    { 2, new DateTime(1987, 9, 19, 23, 24, 17, 148, DateTimeKind.Local).AddTicks(8348), 4, 6, "BILGIISLEM", new DateTime(2024, 11, 25, 10, 33, 17, 887, DateTimeKind.Local).AddTicks(4472), "Freeda", 0, "Abernathy", "58076284168", null, null },
                    { 3, new DateTime(2003, 6, 15, 5, 20, 15, 398, DateTimeKind.Local).AddTicks(6000), 2, 6, "BILGIISLEM", new DateTime(2024, 11, 25, 10, 33, 17, 887, DateTimeKind.Local).AddTicks(4555), "Dariana", 0, "Goodwin", "36035212771", null, null },
                    { 4, new DateTime(1990, 3, 17, 16, 13, 2, 970, DateTimeKind.Local).AddTicks(9746), 2, 6, "BILGIISLEM", new DateTime(2024, 11, 25, 10, 33, 17, 887, DateTimeKind.Local).AddTicks(4588), "Zita", 0, "Pagac", "42277549959", null, null },
                    { 5, new DateTime(1991, 5, 18, 14, 31, 56, 84, DateTimeKind.Local).AddTicks(2553), 3, 6, "BILGIISLEM", new DateTime(2024, 11, 25, 10, 33, 17, 887, DateTimeKind.Local).AddTicks(4617), "Jeffery", 0, "Leffler", "28325702368", null, null },
                    { 6, new DateTime(1993, 10, 13, 9, 19, 7, 937, DateTimeKind.Local).AddTicks(6745), 2, 6, "BILGIISLEM", new DateTime(2024, 11, 25, 10, 33, 17, 887, DateTimeKind.Local).AddTicks(4643), "Theodore", 0, "Johns", "22445623835", null, null },
                    { 7, new DateTime(2004, 12, 30, 6, 18, 34, 958, DateTimeKind.Local).AddTicks(1582), 4, 6, "BILGIISLEM", new DateTime(2024, 11, 25, 10, 33, 17, 887, DateTimeKind.Local).AddTicks(4667), "Arthur", 0, "Durgan", "03465726170", null, null },
                    { 8, new DateTime(1993, 8, 4, 9, 16, 56, 918, DateTimeKind.Local).AddTicks(8272), 5, 6, "BILGIISLEM", new DateTime(2024, 11, 25, 10, 33, 17, 887, DateTimeKind.Local).AddTicks(4692), "Toney", 0, "Buckridge", "60755859590", null, null },
                    { 9, new DateTime(1987, 11, 7, 12, 13, 52, 321, DateTimeKind.Local).AddTicks(2032), 4, 6, "BILGIISLEM", new DateTime(2024, 11, 25, 10, 33, 17, 887, DateTimeKind.Local).AddTicks(4717), "Daren", 0, "Green", "22295480320", null, null },
                    { 10, new DateTime(1999, 8, 9, 8, 30, 37, 300, DateTimeKind.Local).AddTicks(6062), 4, 6, "BILGIISLEM", new DateTime(2024, 11, 25, 10, 33, 17, 887, DateTimeKind.Local).AddTicks(4740), "Duncan", 0, "Considine", "14227088071", null, null },
                    { 11, new DateTime(1992, 8, 9, 6, 34, 31, 950, DateTimeKind.Local).AddTicks(3875), 2, 6, "BILGIISLEM", new DateTime(2024, 11, 25, 10, 33, 17, 887, DateTimeKind.Local).AddTicks(4763), "Clark", 0, "Lynch", "42593651809", null, null },
                    { 12, new DateTime(2003, 10, 20, 19, 53, 18, 791, DateTimeKind.Local).AddTicks(6431), 3, 6, "BILGIISLEM", new DateTime(2024, 11, 25, 10, 33, 17, 887, DateTimeKind.Local).AddTicks(4786), "Al", 0, "Marquardt", "93810558261", null, null },
                    { 13, new DateTime(1996, 2, 19, 11, 26, 41, 69, DateTimeKind.Local).AddTicks(9769), 1, 6, "BILGIISLEM", new DateTime(2024, 11, 25, 10, 33, 17, 887, DateTimeKind.Local).AddTicks(4856), "Santa", 0, "Rutherford", "86696630705", null, null },
                    { 14, new DateTime(1995, 5, 24, 7, 57, 46, 476, DateTimeKind.Local).AddTicks(1248), 3, 6, "BILGIISLEM", new DateTime(2024, 11, 25, 10, 33, 17, 887, DateTimeKind.Local).AddTicks(4886), "Wilhelm", 0, "Rau", "97615018440", null, null },
                    { 15, new DateTime(1991, 10, 5, 7, 29, 53, 334, DateTimeKind.Local).AddTicks(395), 3, 6, "BILGIISLEM", new DateTime(2024, 11, 25, 10, 33, 17, 887, DateTimeKind.Local).AddTicks(4910), "Gerardo", 0, "Emard", "97749836486", null, null },
                    { 16, new DateTime(1992, 10, 23, 5, 51, 38, 778, DateTimeKind.Local).AddTicks(9906), 2, 6, "BILGIISLEM", new DateTime(2024, 11, 25, 10, 33, 17, 887, DateTimeKind.Local).AddTicks(4935), "Elenor", 0, "Nolan", "77228272987", null, null },
                    { 17, new DateTime(1989, 9, 5, 23, 22, 21, 663, DateTimeKind.Local).AddTicks(6073), 2, 6, "BILGIISLEM", new DateTime(2024, 11, 25, 10, 33, 17, 887, DateTimeKind.Local).AddTicks(4957), "Ethelyn", 0, "Gusikowski", "43122344618", null, null },
                    { 18, new DateTime(1999, 3, 10, 10, 33, 23, 831, DateTimeKind.Local).AddTicks(4201), 3, 6, "BILGIISLEM", new DateTime(2024, 11, 25, 10, 33, 17, 887, DateTimeKind.Local).AddTicks(4982), "Joany", 0, "Runolfsdottir", "99976576815", null, null },
                    { 19, new DateTime(1991, 6, 3, 17, 21, 54, 912, DateTimeKind.Local).AddTicks(101), 3, 6, "BILGIISLEM", new DateTime(2024, 11, 25, 10, 33, 17, 887, DateTimeKind.Local).AddTicks(5009), "Nelda", 0, "Kilback", "79144889234", null, null },
                    { 20, new DateTime(1990, 12, 29, 10, 25, 9, 517, DateTimeKind.Local).AddTicks(9235), 3, 6, "BILGIISLEM", new DateTime(2024, 11, 25, 10, 33, 17, 887, DateTimeKind.Local).AddTicks(5031), "Micheal", 0, "Kuhic", "00441738038", null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_StudentId",
                table: "Schedules",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_TeacherId_LessonDate_StartTime",
                table: "Schedules",
                columns: new[] { "TeacherId", "LessonDate", "StartTime" },
                unique: true);

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
