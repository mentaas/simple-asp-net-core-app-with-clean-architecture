using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AbcTestApp.Infrastructure.Data.Migrations
{
    public partial class addedLongitudeAndLatitudeToLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "Locations",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "Locations",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2301D884-221A-4E7D-B509-0113DCC043E1",
                column: "ConcurrencyStamp",
                value: "ebb699f0-abe9-43ec-a761-73b719229e88");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7D9B7113-A8F8-4035-99A7-A20DD400F6A3",
                column: "ConcurrencyStamp",
                value: "fea053e9-66fa-4593-9e16-38eac52f0a5d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6B6867B8-3173-4AA8-A4F0-07D2DD931825",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash" },
                values: new object[] { "1a6cd3e5-0e4e-467d-a13d-71bd106f5929", new DateTime(2020, 12, 31, 5, 45, 27, 542, DateTimeKind.Local).AddTicks(6703), "AQAAAAEAACcQAAAAEK+rUp2RawB2uaI6ZWjkONW5tDKO1yxx+qrqeCKp5A7lrmrxGXx5JCTVnG2itUG5GQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Locations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2301D884-221A-4E7D-B509-0113DCC043E1",
                column: "ConcurrencyStamp",
                value: "5cdd5855-2ae4-4be0-978b-6966dfe2ef90");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7D9B7113-A8F8-4035-99A7-A20DD400F6A3",
                column: "ConcurrencyStamp",
                value: "ca49c235-d8fc-4a96-8604-d02c7fbb79aa");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6B6867B8-3173-4AA8-A4F0-07D2DD931825",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash" },
                values: new object[] { "a013ae94-4754-4998-9dd1-b592f647cbe7", new DateTime(2020, 12, 31, 2, 47, 29, 259, DateTimeKind.Local).AddTicks(8752), "AQAAAAEAACcQAAAAEIHkByksBIZk5MXgO3BW21gYB0b+oDyDQmYoTxN5N43jJnXdPsPKrBrppx1Nhs/HaQ==" });
        }
    }
}
