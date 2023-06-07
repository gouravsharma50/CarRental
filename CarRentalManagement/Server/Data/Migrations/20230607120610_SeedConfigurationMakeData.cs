using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeedConfigurationMakeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 6, 7, 17, 36, 9, 115, DateTimeKind.Local).AddTicks(1196), new DateTime(2023, 6, 7, 17, 36, 9, 115, DateTimeKind.Local).AddTicks(1243) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 6, 7, 17, 36, 9, 115, DateTimeKind.Local).AddTicks(1252), new DateTime(2023, 6, 7, 17, 36, 9, 115, DateTimeKind.Local).AddTicks(1253) });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdate", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 6, 7, 17, 36, 9, 115, DateTimeKind.Local).AddTicks(2950), new DateTime(2023, 6, 7, 17, 36, 9, 115, DateTimeKind.Local).AddTicks(2971), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 6, 7, 17, 36, 9, 115, DateTimeKind.Local).AddTicks(2983), new DateTime(2023, 6, 7, 17, 36, 9, 115, DateTimeKind.Local).AddTicks(2984), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdate", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 6, 7, 17, 36, 9, 115, DateTimeKind.Local).AddTicks(3745), new DateTime(2023, 6, 7, 17, 36, 9, 115, DateTimeKind.Local).AddTicks(3754), "3 series", "System" },
                    { 2, "System", new DateTime(2023, 6, 7, 17, 36, 9, 115, DateTimeKind.Local).AddTicks(3757), new DateTime(2023, 6, 7, 17, 36, 9, 115, DateTimeKind.Local).AddTicks(3759), "Vitz", "System" },
                    { 3, "System", new DateTime(2023, 6, 7, 17, 36, 9, 115, DateTimeKind.Local).AddTicks(3761), new DateTime(2023, 6, 7, 17, 36, 9, 115, DateTimeKind.Local).AddTicks(3763), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 6, 7, 17, 36, 9, 115, DateTimeKind.Local).AddTicks(3766), new DateTime(2023, 6, 7, 17, 36, 9, 115, DateTimeKind.Local).AddTicks(3767), "X5", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 6, 7, 17, 33, 47, 848, DateTimeKind.Local).AddTicks(4310), new DateTime(2023, 6, 7, 17, 33, 47, 848, DateTimeKind.Local).AddTicks(4338) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 6, 7, 17, 33, 47, 848, DateTimeKind.Local).AddTicks(4343), new DateTime(2023, 6, 7, 17, 33, 47, 848, DateTimeKind.Local).AddTicks(4344) });
        }
    }
}
