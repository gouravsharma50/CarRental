using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7736bea9-f68d-4723-9a6b-a3ad2e43758e",
                column: "ConcurrencyStamp",
                value: "7a192897-0c20-4b0c-b772-b9592e067a7b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7736bea9-f68d-4723-9a6b-a3ad2e43768e",
                column: "ConcurrencyStamp",
                value: "a119119c-9428-4ecc-a378-bbf0bbe23ddf");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "67e6b3cf-5a98-4bf5-9abd-551aee9ae452", 0, "acd4e825-83ea-49dd-a6ee-f6d185ea5a6a", "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEIg3w6sPS40I/aL8iCTd3QzIgyEClHH9rYiX45zeKaeGEDcmb5bCsChEh1P80jNJaw==", null, false, "42cbadaa-217d-4e89-9636-42f6090f4997", false, "admin@localhost.com" },
                    { "67e6b3cf-5a98-4bf5-9abd-551aee9ae453", 0, "2a31d55a-3704-4941-9d19-aee36625f4b3", "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAELI1Y/4nNG3TKjVOSYtZobrbmiVYS8dFKEHqAG5SbMdi39kqbreT+r2b4xl8tX1Emw==", null, false, "86d5eb94-e9b1-4700-8b28-916dfb80652e", false, "user@localhost.com" }
                });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 6, 7, 18, 8, 20, 175, DateTimeKind.Local).AddTicks(6148), new DateTime(2023, 6, 7, 18, 8, 20, 175, DateTimeKind.Local).AddTicks(6163) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 6, 7, 18, 8, 20, 175, DateTimeKind.Local).AddTicks(6167), new DateTime(2023, 6, 7, 18, 8, 20, 175, DateTimeKind.Local).AddTicks(6168) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 6, 7, 18, 8, 20, 175, DateTimeKind.Local).AddTicks(6513), new DateTime(2023, 6, 7, 18, 8, 20, 175, DateTimeKind.Local).AddTicks(6515) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 6, 7, 18, 8, 20, 175, DateTimeKind.Local).AddTicks(6517), new DateTime(2023, 6, 7, 18, 8, 20, 175, DateTimeKind.Local).AddTicks(6518) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 6, 7, 18, 8, 20, 175, DateTimeKind.Local).AddTicks(6671), new DateTime(2023, 6, 7, 18, 8, 20, 175, DateTimeKind.Local).AddTicks(6673) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 6, 7, 18, 8, 20, 175, DateTimeKind.Local).AddTicks(6675), new DateTime(2023, 6, 7, 18, 8, 20, 175, DateTimeKind.Local).AddTicks(6676) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 6, 7, 18, 8, 20, 175, DateTimeKind.Local).AddTicks(6678), new DateTime(2023, 6, 7, 18, 8, 20, 175, DateTimeKind.Local).AddTicks(6679) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 6, 7, 18, 8, 20, 175, DateTimeKind.Local).AddTicks(6681), new DateTime(2023, 6, 7, 18, 8, 20, 175, DateTimeKind.Local).AddTicks(6682) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7736bea9-f68d-4723-9a6b-a3ad2e43758e", "67e6b3cf-5a98-4bf5-9abd-551aee9ae452" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7736bea9-f68d-4723-9a6b-a3ad2e43768e", "67e6b3cf-5a98-4bf5-9abd-551aee9ae453" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7736bea9-f68d-4723-9a6b-a3ad2e43758e", "67e6b3cf-5a98-4bf5-9abd-551aee9ae452" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7736bea9-f68d-4723-9a6b-a3ad2e43768e", "67e6b3cf-5a98-4bf5-9abd-551aee9ae453" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67e6b3cf-5a98-4bf5-9abd-551aee9ae452");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67e6b3cf-5a98-4bf5-9abd-551aee9ae453");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7736bea9-f68d-4723-9a6b-a3ad2e43758e",
                column: "ConcurrencyStamp",
                value: "19aa9083-c529-4421-aca9-0914644f3e55");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7736bea9-f68d-4723-9a6b-a3ad2e43768e",
                column: "ConcurrencyStamp",
                value: "c168cac3-4deb-486f-8077-b6ec922446b9");

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
    }
}
