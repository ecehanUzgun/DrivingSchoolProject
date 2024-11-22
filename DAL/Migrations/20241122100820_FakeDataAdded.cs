using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class FakeDataAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "ID", "Address", "CreatedComputerName", "CreatedDate", "Name", "PhoneNumber", "Status", "UpdatedComputerName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "140 Keeling Place, Marksland, Bosnia and Herzegovina", "BILGIISLEM", new DateTime(2024, 11, 22, 13, 8, 20, 107, DateTimeKind.Local).AddTicks(5385), "Gleichner Group", "3974257047", 0, null, null },
                    { 2, "95330 White Turnpike, Beaufort, Lithuania", "BILGIISLEM", new DateTime(2024, 11, 22, 13, 8, 20, 107, DateTimeKind.Local).AddTicks(6543), "Nader, Schoen and Schoen", "5281335441", 0, null, null },
                    { 3, "874 Domenico Squares, Hyattview, Christmas Island", "BILGIISLEM", new DateTime(2024, 11, 22, 13, 8, 20, 107, DateTimeKind.Local).AddTicks(6898), "Franecki - Cummings", "0520720262", 0, null, null },
                    { 4, "60570 Terry Lock, Lake Annabelstad, Panama", "BILGIISLEM", new DateTime(2024, 11, 22, 13, 8, 20, 107, DateTimeKind.Local).AddTicks(7065), "Yost Inc", "2391609022", 0, null, null },
                    { 5, "86908 Howell Ridge, Botsfordbury, Austria", "BILGIISLEM", new DateTime(2024, 11, 22, 13, 8, 20, 107, DateTimeKind.Local).AddTicks(7261), "Heidenreich - Lowe", "1200529621", 0, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "BirthDate", "BranchId", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(2006, 4, 28, 18, 39, 2, 604, DateTimeKind.Local).AddTicks(7068), 5, new DateTime(2024, 11, 22, 13, 8, 20, 111, DateTimeKind.Local).AddTicks(9619), "Lelah", "Cronin", "36130438351" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "BirthDate", "BranchId", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(1999, 5, 31, 4, 6, 8, 378, DateTimeKind.Local).AddTicks(611), 4, new DateTime(2024, 11, 22, 13, 8, 20, 112, DateTimeKind.Local).AddTicks(1735), "Lucile", "Collins", "62030378524" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "BirthDate", "BranchId", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(1988, 2, 13, 0, 32, 40, 84, DateTimeKind.Local).AddTicks(1021), 3, new DateTime(2024, 11, 22, 13, 8, 20, 112, DateTimeKind.Local).AddTicks(1801), "Josephine", "Murray", "27521681535" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "BirthDate", "BranchId", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(1992, 10, 16, 23, 5, 11, 555, DateTimeKind.Local).AddTicks(9807), 1, new DateTime(2024, 11, 22, 13, 8, 20, 112, DateTimeKind.Local).AddTicks(1826), "Bertha", "Hermiston", "43161124998" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "BirthDate", "BranchId", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(1989, 8, 11, 15, 55, 47, 825, DateTimeKind.Local).AddTicks(1131), 1, new DateTime(2024, 11, 22, 13, 8, 20, 112, DateTimeKind.Local).AddTicks(1847), "Cecile", "Baumbach", "30983465946" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "BirthDate", "BranchId", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(1994, 4, 18, 11, 36, 11, 169, DateTimeKind.Local).AddTicks(3308), 4, new DateTime(2024, 11, 22, 13, 8, 20, 112, DateTimeKind.Local).AddTicks(1868), "Elisa", "Kuphal", "20030104492" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "BirthDate", "BranchId", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(1997, 11, 9, 8, 19, 45, 638, DateTimeKind.Local).AddTicks(1187), 1, new DateTime(2024, 11, 22, 13, 8, 20, 112, DateTimeKind.Local).AddTicks(1889), "Baron", "Hauck", "68568652922" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "BirthDate", "BranchId", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(1995, 4, 1, 20, 20, 38, 602, DateTimeKind.Local).AddTicks(1801), 4, new DateTime(2024, 11, 22, 13, 8, 20, 112, DateTimeKind.Local).AddTicks(1910), "Dasia", "West", "14814858983" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "BirthDate", "BranchId", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(2000, 1, 25, 4, 20, 51, 396, DateTimeKind.Local).AddTicks(1802), 2, new DateTime(2024, 11, 22, 13, 8, 20, 112, DateTimeKind.Local).AddTicks(1929), "Herman", "Weissnat", "00474187344" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "BirthDate", "BranchId", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(1993, 11, 18, 12, 20, 16, 370, DateTimeKind.Local).AddTicks(5198), 4, new DateTime(2024, 11, 22, 13, 8, 20, 112, DateTimeKind.Local).AddTicks(1948), "Tatum", "Littel", "14836509961" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "BirthDate", "BranchId", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(2000, 7, 27, 9, 41, 53, 529, DateTimeKind.Local).AddTicks(7009), 2, new DateTime(2024, 11, 22, 13, 8, 20, 112, DateTimeKind.Local).AddTicks(2022), "Anibal", "Klein", "63994231681" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "BirthDate", "BranchId", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(1991, 7, 9, 4, 57, 24, 827, DateTimeKind.Local).AddTicks(7542), 5, new DateTime(2024, 11, 22, 13, 8, 20, 112, DateTimeKind.Local).AddTicks(2041), "Rudy", "Fisher", "84943702950" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "BirthDate", "BranchId", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(1998, 7, 2, 20, 39, 0, 864, DateTimeKind.Local).AddTicks(1832), 3, new DateTime(2024, 11, 22, 13, 8, 20, 112, DateTimeKind.Local).AddTicks(2060), "Joel", "Bartoletti", "52710674769" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "BirthDate", "BranchId", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(1998, 12, 16, 8, 37, 8, 104, DateTimeKind.Local).AddTicks(8683), 1, new DateTime(2024, 11, 22, 13, 8, 20, 112, DateTimeKind.Local).AddTicks(2078), "Gerardo", "Vandervort", "72077660104" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "BirthDate", "BranchId", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(1989, 9, 5, 12, 7, 36, 41, DateTimeKind.Local).AddTicks(1000), 2, new DateTime(2024, 11, 22, 13, 8, 20, 112, DateTimeKind.Local).AddTicks(2097), "Parker", "Senger", "91786957621" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "BirthDate", "BranchId", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(2000, 6, 7, 21, 46, 57, 277, DateTimeKind.Local).AddTicks(6342), 5, new DateTime(2024, 11, 22, 13, 8, 20, 112, DateTimeKind.Local).AddTicks(2116), "Kaela", "Kerluke", "72522976260" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "BirthDate", "BranchId", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(1999, 9, 30, 22, 40, 36, 975, DateTimeKind.Local).AddTicks(1475), 2, new DateTime(2024, 11, 22, 13, 8, 20, 112, DateTimeKind.Local).AddTicks(2134), "Dana", "Roob", "07981873526" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "BirthDate", "BranchId", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(1997, 2, 27, 4, 49, 51, 546, DateTimeKind.Local).AddTicks(3168), 5, new DateTime(2024, 11, 22, 13, 8, 20, 112, DateTimeKind.Local).AddTicks(2153), "Sean", "Rempel", "87850591919" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "BirthDate", "BranchId", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(2003, 12, 5, 14, 9, 41, 785, DateTimeKind.Local).AddTicks(6424), 5, new DateTime(2024, 11, 22, 13, 8, 20, 112, DateTimeKind.Local).AddTicks(2171), "Ford", "Jacobi", "05606200463" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "BirthDate", "BranchId", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(2000, 7, 13, 15, 23, 16, 469, DateTimeKind.Local).AddTicks(8416), 3, new DateTime(2024, 11, 22, 13, 8, 20, 112, DateTimeKind.Local).AddTicks(2188), "Thea", "Schmeler", "66958063615" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(1998, 11, 28, 21, 26, 42, 244, DateTimeKind.Local).AddTicks(628), new DateTime(2024, 11, 22, 13, 8, 20, 110, DateTimeKind.Local).AddTicks(1224), "Augustine", "Kihn", "03379850118" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "BirthDate", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(1999, 6, 5, 1, 29, 19, 587, DateTimeKind.Local).AddTicks(6211), new DateTime(2024, 11, 22, 13, 8, 20, 110, DateTimeKind.Local).AddTicks(3622), "Loy", "Jakubowski", "40511830604" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "BirthDate", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(1999, 8, 17, 12, 7, 19, 326, DateTimeKind.Local).AddTicks(1721), new DateTime(2024, 11, 22, 13, 8, 20, 110, DateTimeKind.Local).AddTicks(3683), "Dianna", "Kuhn", "01613945766" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "BirthDate", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(1986, 7, 7, 9, 25, 17, 44, DateTimeKind.Local).AddTicks(1793), new DateTime(2024, 11, 22, 13, 8, 20, 110, DateTimeKind.Local).AddTicks(3709), "Jaiden", "Pagac", "30397535704" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "BirthDate", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(1982, 11, 24, 15, 50, 47, 52, DateTimeKind.Local).AddTicks(8652), new DateTime(2024, 11, 22, 13, 8, 20, 110, DateTimeKind.Local).AddTicks(3728), "Major", "Howe", "57790097070" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "BirthDate", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(1976, 2, 25, 12, 12, 36, 508, DateTimeKind.Local).AddTicks(9917), new DateTime(2024, 11, 22, 13, 8, 20, 110, DateTimeKind.Local).AddTicks(3745), "Aiden", "Lind", "03915347710" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "BirthDate", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(1992, 6, 11, 5, 49, 15, 947, DateTimeKind.Local).AddTicks(502), new DateTime(2024, 11, 22, 13, 8, 20, 110, DateTimeKind.Local).AddTicks(3763), "Conrad", "Gutkowski", "92727663783" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "BirthDate", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(1988, 9, 22, 22, 47, 8, 77, DateTimeKind.Local).AddTicks(5834), new DateTime(2024, 11, 22, 13, 8, 20, 110, DateTimeKind.Local).AddTicks(3783), "Donald", "Hilll", "98658688880" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "BirthDate", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(1990, 5, 26, 5, 36, 46, 569, DateTimeKind.Local).AddTicks(688), new DateTime(2024, 11, 22, 13, 8, 20, 110, DateTimeKind.Local).AddTicks(3799), "Fredrick", "Ziemann", "32106590734" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "BirthDate", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(1993, 10, 6, 17, 54, 53, 541, DateTimeKind.Local).AddTicks(3709), new DateTime(2024, 11, 22, 13, 8, 20, 110, DateTimeKind.Local).AddTicks(3910), "Russ", "Mitchell", "10557233940" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "BirthDate", "BranchId", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(1990, 5, 11, 22, 8, 7, 592, DateTimeKind.Local).AddTicks(4262), 0, new DateTime(2024, 11, 22, 12, 53, 55, 35, DateTimeKind.Local).AddTicks(4899), "Janelle", "Monahan", "65889062971" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "BirthDate", "BranchId", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(1995, 4, 9, 6, 30, 43, 653, DateTimeKind.Local).AddTicks(2127), 0, new DateTime(2024, 11, 22, 12, 53, 55, 35, DateTimeKind.Local).AddTicks(7297), "Henry", "Bauch", "68103921205" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "BirthDate", "BranchId", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(1992, 5, 6, 7, 16, 6, 377, DateTimeKind.Local).AddTicks(4136), 0, new DateTime(2024, 11, 22, 12, 53, 55, 35, DateTimeKind.Local).AddTicks(7378), "Korbin", "Runolfsson", "54036735280" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "BirthDate", "BranchId", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(1993, 5, 10, 4, 24, 53, 380, DateTimeKind.Local).AddTicks(5222), 0, new DateTime(2024, 11, 22, 12, 53, 55, 35, DateTimeKind.Local).AddTicks(7407), "Jerad", "Hegmann", "22799057241" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "BirthDate", "BranchId", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(2004, 2, 15, 10, 15, 24, 148, DateTimeKind.Local).AddTicks(3842), 0, new DateTime(2024, 11, 22, 12, 53, 55, 35, DateTimeKind.Local).AddTicks(7429), "Kaylin", "Rowe", "33209689585" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "BirthDate", "BranchId", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(1997, 6, 23, 21, 30, 7, 654, DateTimeKind.Local).AddTicks(2498), 0, new DateTime(2024, 11, 22, 12, 53, 55, 35, DateTimeKind.Local).AddTicks(7447), "Adriana", "Ratke", "97796045420" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "BirthDate", "BranchId", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(2005, 7, 15, 12, 17, 48, 819, DateTimeKind.Local).AddTicks(1800), 0, new DateTime(2024, 11, 22, 12, 53, 55, 35, DateTimeKind.Local).AddTicks(7465), "Shanny", "Ferry", "33691575290" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "BirthDate", "BranchId", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(2006, 7, 12, 22, 51, 59, 800, DateTimeKind.Local).AddTicks(9235), 0, new DateTime(2024, 11, 22, 12, 53, 55, 35, DateTimeKind.Local).AddTicks(7495), "Frieda", "VonRueden", "31040256389" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "BirthDate", "BranchId", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(2003, 10, 18, 5, 6, 59, 138, DateTimeKind.Local).AddTicks(783), 0, new DateTime(2024, 11, 22, 12, 53, 55, 35, DateTimeKind.Local).AddTicks(7514), "Myrtie", "Wolf", "42377455253" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "BirthDate", "BranchId", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(1995, 8, 31, 2, 16, 39, 488, DateTimeKind.Local).AddTicks(2186), 0, new DateTime(2024, 11, 22, 12, 53, 55, 35, DateTimeKind.Local).AddTicks(7530), "Tobin", "Macejkovic", "33138233575" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "BirthDate", "BranchId", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(1989, 10, 12, 2, 27, 21, 328, DateTimeKind.Local).AddTicks(240), 0, new DateTime(2024, 11, 22, 12, 53, 55, 35, DateTimeKind.Local).AddTicks(7547), "Zella", "Kuhn", "22749791015" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "BirthDate", "BranchId", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(1989, 4, 13, 16, 16, 55, 665, DateTimeKind.Local).AddTicks(3005), 0, new DateTime(2024, 11, 22, 12, 53, 55, 35, DateTimeKind.Local).AddTicks(7567), "Destin", "Friesen", "57186760647" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "BirthDate", "BranchId", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(2003, 9, 29, 0, 47, 45, 183, DateTimeKind.Local).AddTicks(5361), 0, new DateTime(2024, 11, 22, 12, 53, 55, 35, DateTimeKind.Local).AddTicks(7583), "Winona", "Harris", "86490741121" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "BirthDate", "BranchId", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(2002, 1, 30, 16, 28, 32, 250, DateTimeKind.Local).AddTicks(187), 0, new DateTime(2024, 11, 22, 12, 53, 55, 35, DateTimeKind.Local).AddTicks(7599), "Elisa", "Metz", "40912113559" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "BirthDate", "BranchId", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(1989, 4, 16, 7, 34, 47, 858, DateTimeKind.Local).AddTicks(1808), 0, new DateTime(2024, 11, 22, 12, 53, 55, 35, DateTimeKind.Local).AddTicks(7615), "Brooklyn", "Barrows", "43925193499" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "BirthDate", "BranchId", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(2004, 9, 18, 17, 2, 13, 482, DateTimeKind.Local).AddTicks(8915), 0, new DateTime(2024, 11, 22, 12, 53, 55, 35, DateTimeKind.Local).AddTicks(7631), "Darren", "Marquardt", "58843775878" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "BirthDate", "BranchId", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(2001, 2, 7, 22, 41, 26, 513, DateTimeKind.Local).AddTicks(6353), 0, new DateTime(2024, 11, 22, 12, 53, 55, 35, DateTimeKind.Local).AddTicks(7647), "Richie", "Hane", "80569425747" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "BirthDate", "BranchId", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(1998, 11, 12, 14, 37, 23, 502, DateTimeKind.Local).AddTicks(9333), 0, new DateTime(2024, 11, 22, 12, 53, 55, 35, DateTimeKind.Local).AddTicks(7665), "Lane", "Oberbrunner", "36987135656" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "BirthDate", "BranchId", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(1994, 7, 11, 18, 26, 59, 492, DateTimeKind.Local).AddTicks(6807), 0, new DateTime(2024, 11, 22, 12, 53, 55, 35, DateTimeKind.Local).AddTicks(7682), "Jayce", "Ankunding", "61063906844" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "BirthDate", "BranchId", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(1993, 4, 26, 7, 12, 2, 167, DateTimeKind.Local).AddTicks(3540), 0, new DateTime(2024, 11, 22, 12, 53, 55, 35, DateTimeKind.Local).AddTicks(7698), "Jacinto", "Koelpin", "28163949212" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(1973, 2, 10, 19, 24, 54, 204, DateTimeKind.Local).AddTicks(1365), new DateTime(2024, 11, 22, 12, 53, 55, 33, DateTimeKind.Local).AddTicks(9636), "Angela", "Marquardt", "72373051207" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "BirthDate", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(1988, 12, 14, 13, 51, 49, 771, DateTimeKind.Local).AddTicks(7179), new DateTime(2024, 11, 22, 12, 53, 55, 34, DateTimeKind.Local).AddTicks(1846), "Justine", "Abernathy", "04295821255" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "BirthDate", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(1994, 7, 18, 23, 2, 9, 942, DateTimeKind.Local).AddTicks(8704), new DateTime(2024, 11, 22, 12, 53, 55, 34, DateTimeKind.Local).AddTicks(1939), "Cornell", "Hyatt", "60963216038" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "BirthDate", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(1987, 11, 7, 0, 4, 2, 254, DateTimeKind.Local).AddTicks(4698), new DateTime(2024, 11, 22, 12, 53, 55, 34, DateTimeKind.Local).AddTicks(1964), "Nakia", "Hickle", "87194189964" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "BirthDate", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(1976, 9, 27, 15, 29, 50, 246, DateTimeKind.Local).AddTicks(9560), new DateTime(2024, 11, 22, 12, 53, 55, 34, DateTimeKind.Local).AddTicks(1994), "Juanita", "Schneider", "47854043651" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "BirthDate", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(1977, 7, 21, 13, 53, 42, 988, DateTimeKind.Local).AddTicks(4747), new DateTime(2024, 11, 22, 12, 53, 55, 34, DateTimeKind.Local).AddTicks(2014), "Bethany", "West", "42972692152" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "BirthDate", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(1996, 12, 1, 23, 46, 51, 911, DateTimeKind.Local).AddTicks(8893), new DateTime(2024, 11, 22, 12, 53, 55, 34, DateTimeKind.Local).AddTicks(2033), "Sibyl", "Miller", "73809579590" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "BirthDate", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(1988, 4, 26, 20, 21, 15, 744, DateTimeKind.Local).AddTicks(3476), new DateTime(2024, 11, 22, 12, 53, 55, 34, DateTimeKind.Local).AddTicks(2051), "Gavin", "Goodwin", "66465501270" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "BirthDate", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(1985, 3, 13, 23, 36, 3, 374, DateTimeKind.Local).AddTicks(2028), new DateTime(2024, 11, 22, 12, 53, 55, 34, DateTimeKind.Local).AddTicks(2070), "Sofia", "Bahringer", "52543997091" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "BirthDate", "CreatedDate", "Name", "Surname", "Tckn" },
                values: new object[] { new DateTime(1999, 7, 3, 2, 16, 29, 176, DateTimeKind.Local).AddTicks(5975), new DateTime(2024, 11, 22, 12, 53, 55, 34, DateTimeKind.Local).AddTicks(2085), "Gina", "Balistreri", "78206179201" });
        }
    }
}
