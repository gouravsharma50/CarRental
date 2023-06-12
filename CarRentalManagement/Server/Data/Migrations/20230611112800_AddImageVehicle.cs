using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddImageVehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Models",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Models",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Makes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Makes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Colors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Colors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7736bea9-f68d-4723-9a6b-a3ad2e43758e",
                column: "ConcurrencyStamp",
                value: "05215868-982c-4ae9-8fc8-5a60f471cd84");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7736bea9-f68d-4723-9a6b-a3ad2e43768e",
                column: "ConcurrencyStamp",
                value: "7daa7b08-df81-4659-aa2f-4275bfe98bd8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67e6b3cf-5a98-4bf5-9abd-551aee9ae452",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3807e9d0-2c84-4f26-b160-fd0cf8cbca61", "AQAAAAEAACcQAAAAEMsNYS1SP81tX7E6FFD/DYJ3VLjNLC/KKfawIQbCuoKsRuzVVx3TYqHcRIvNUNI9FQ==", "843164e1-8fb0-422c-9d55-7e54bfce31b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67e6b3cf-5a98-4bf5-9abd-551aee9ae453",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ac95cab-d933-4e1b-8921-c407d22f9d9f", "AQAAAAEAACcQAAAAEL1ypY+ibcs9igb1FFV/LUeSJJTUSL28DKPi3tHTx6dyAGELo2vc0zABhtA1/NSS2Q==", "49e1bf43-5dcc-40ee-976b-e8e8cfe7e3a1" });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 6, 11, 16, 57, 59, 793, DateTimeKind.Local).AddTicks(2946), new DateTime(2023, 6, 11, 16, 57, 59, 793, DateTimeKind.Local).AddTicks(2961) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 6, 11, 16, 57, 59, 793, DateTimeKind.Local).AddTicks(2967), new DateTime(2023, 6, 11, 16, 57, 59, 793, DateTimeKind.Local).AddTicks(2968) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 6, 11, 16, 57, 59, 793, DateTimeKind.Local).AddTicks(3370), new DateTime(2023, 6, 11, 16, 57, 59, 793, DateTimeKind.Local).AddTicks(3373) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 6, 11, 16, 57, 59, 793, DateTimeKind.Local).AddTicks(3376), new DateTime(2023, 6, 11, 16, 57, 59, 793, DateTimeKind.Local).AddTicks(3377) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 6, 11, 16, 57, 59, 793, DateTimeKind.Local).AddTicks(3524), new DateTime(2023, 6, 11, 16, 57, 59, 793, DateTimeKind.Local).AddTicks(3526) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 6, 11, 16, 57, 59, 793, DateTimeKind.Local).AddTicks(3529), new DateTime(2023, 6, 11, 16, 57, 59, 793, DateTimeKind.Local).AddTicks(3530) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 6, 11, 16, 57, 59, 793, DateTimeKind.Local).AddTicks(3532), new DateTime(2023, 6, 11, 16, 57, 59, 793, DateTimeKind.Local).AddTicks(3533) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 6, 11, 16, 57, 59, 793, DateTimeKind.Local).AddTicks(3535), new DateTime(2023, 6, 11, 16, 57, 59, 793, DateTimeKind.Local).AddTicks(3536) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Vehicles");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Models",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Models",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Makes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Makes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Colors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Colors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67e6b3cf-5a98-4bf5-9abd-551aee9ae452",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "acd4e825-83ea-49dd-a6ee-f6d185ea5a6a", "AQAAAAEAACcQAAAAEIg3w6sPS40I/aL8iCTd3QzIgyEClHH9rYiX45zeKaeGEDcmb5bCsChEh1P80jNJaw==", "42cbadaa-217d-4e89-9636-42f6090f4997" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67e6b3cf-5a98-4bf5-9abd-551aee9ae453",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a31d55a-3704-4941-9d19-aee36625f4b3", "AQAAAAEAACcQAAAAELI1Y/4nNG3TKjVOSYtZobrbmiVYS8dFKEHqAG5SbMdi39kqbreT+r2b4xl8tX1Emw==", "86d5eb94-e9b1-4700-8b28-916dfb80652e" });

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
        }
    }
}
