using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeedConfigurationData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdate", "Name", "UpdatedBy" },
                values: new object[] { 1, "System", new DateTime(2023, 6, 7, 17, 33, 47, 848, DateTimeKind.Local).AddTicks(4310), new DateTime(2023, 6, 7, 17, 33, 47, 848, DateTimeKind.Local).AddTicks(4338), "Black", "System" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdate", "Name", "UpdatedBy" },
                values: new object[] { 2, "System", new DateTime(2023, 6, 7, 17, 33, 47, 848, DateTimeKind.Local).AddTicks(4343), new DateTime(2023, 6, 7, 17, 33, 47, 848, DateTimeKind.Local).AddTicks(4344), "Blue", "System" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
