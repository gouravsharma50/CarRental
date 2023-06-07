using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeedDefaultRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7736bea9-f68d-4723-9a6b-a3ad2e43758e", "19aa9083-c529-4421-aca9-0914644f3e55", "Adminstrator", "ADMINSTRATOR" },
                    { "7736bea9-f68d-4723-9a6b-a3ad2e43768e", "c168cac3-4deb-486f-8077-b6ec922446b9", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 6, 7, 17, 48, 26, 558, DateTimeKind.Local).AddTicks(1945), new DateTime(2023, 6, 7, 17, 48, 26, 558, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 6, 7, 17, 48, 26, 558, DateTimeKind.Local).AddTicks(1995), new DateTime(2023, 6, 7, 17, 48, 26, 558, DateTimeKind.Local).AddTicks(1999) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 6, 7, 17, 48, 26, 558, DateTimeKind.Local).AddTicks(3334), new DateTime(2023, 6, 7, 17, 48, 26, 558, DateTimeKind.Local).AddTicks(3350) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 6, 7, 17, 48, 26, 558, DateTimeKind.Local).AddTicks(3375), new DateTime(2023, 6, 7, 17, 48, 26, 558, DateTimeKind.Local).AddTicks(3380) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 6, 7, 17, 48, 26, 558, DateTimeKind.Local).AddTicks(4223), new DateTime(2023, 6, 7, 17, 48, 26, 558, DateTimeKind.Local).AddTicks(4234) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 6, 7, 17, 48, 26, 558, DateTimeKind.Local).AddTicks(4274), new DateTime(2023, 6, 7, 17, 48, 26, 558, DateTimeKind.Local).AddTicks(4279) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 6, 7, 17, 48, 26, 558, DateTimeKind.Local).AddTicks(4287), new DateTime(2023, 6, 7, 17, 48, 26, 558, DateTimeKind.Local).AddTicks(4291) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 6, 7, 17, 48, 26, 558, DateTimeKind.Local).AddTicks(4298), new DateTime(2023, 6, 7, 17, 48, 26, 558, DateTimeKind.Local).AddTicks(4302) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7736bea9-f68d-4723-9a6b-a3ad2e43758e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7736bea9-f68d-4723-9a6b-a3ad2e43768e");

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
    }
}
