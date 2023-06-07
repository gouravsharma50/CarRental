using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 6, 7, 17, 46, 27, 324, DateTimeKind.Local).AddTicks(9135), new DateTime(2023, 6, 7, 17, 46, 27, 324, DateTimeKind.Local).AddTicks(9161) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 6, 7, 17, 46, 27, 324, DateTimeKind.Local).AddTicks(9174), new DateTime(2023, 6, 7, 17, 46, 27, 324, DateTimeKind.Local).AddTicks(9176) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 6, 7, 17, 46, 27, 325, DateTimeKind.Local).AddTicks(876), new DateTime(2023, 6, 7, 17, 46, 27, 325, DateTimeKind.Local).AddTicks(912) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 6, 7, 17, 46, 27, 325, DateTimeKind.Local).AddTicks(920), new DateTime(2023, 6, 7, 17, 46, 27, 325, DateTimeKind.Local).AddTicks(921) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 6, 7, 17, 46, 27, 325, DateTimeKind.Local).AddTicks(1596), new DateTime(2023, 6, 7, 17, 46, 27, 325, DateTimeKind.Local).AddTicks(1602) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 6, 7, 17, 46, 27, 325, DateTimeKind.Local).AddTicks(1628), new DateTime(2023, 6, 7, 17, 46, 27, 325, DateTimeKind.Local).AddTicks(1629) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 6, 7, 17, 46, 27, 325, DateTimeKind.Local).AddTicks(1642), new DateTime(2023, 6, 7, 17, 46, 27, 325, DateTimeKind.Local).AddTicks(1643) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 6, 7, 17, 46, 27, 325, DateTimeKind.Local).AddTicks(1650), new DateTime(2023, 6, 7, 17, 46, 27, 325, DateTimeKind.Local).AddTicks(1652) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 6, 7, 17, 36, 9, 115, DateTimeKind.Local).AddTicks(2950), new DateTime(2023, 6, 7, 17, 36, 9, 115, DateTimeKind.Local).AddTicks(2971) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 6, 7, 17, 36, 9, 115, DateTimeKind.Local).AddTicks(2983), new DateTime(2023, 6, 7, 17, 36, 9, 115, DateTimeKind.Local).AddTicks(2984) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 6, 7, 17, 36, 9, 115, DateTimeKind.Local).AddTicks(3745), new DateTime(2023, 6, 7, 17, 36, 9, 115, DateTimeKind.Local).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 6, 7, 17, 36, 9, 115, DateTimeKind.Local).AddTicks(3757), new DateTime(2023, 6, 7, 17, 36, 9, 115, DateTimeKind.Local).AddTicks(3759) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 6, 7, 17, 36, 9, 115, DateTimeKind.Local).AddTicks(3761), new DateTime(2023, 6, 7, 17, 36, 9, 115, DateTimeKind.Local).AddTicks(3763) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 6, 7, 17, 36, 9, 115, DateTimeKind.Local).AddTicks(3766), new DateTime(2023, 6, 7, 17, 36, 9, 115, DateTimeKind.Local).AddTicks(3767) });
        }
    }
}
