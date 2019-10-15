using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "City", "Country", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Skopje", null, "martinp@iborn.net", "Martin", "Panovski" },
                    { 2, "Skopje", null, "petrep@iborn.net", "Petre", "Petrevski" },
                    { 3, "Ohrid", null, "martinp@iborn.net", "Mite", "Mitevski" },
                    { 4, "Strumica", null, "jovanj@iborn.net", "Jovan", "Jovanovski" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
