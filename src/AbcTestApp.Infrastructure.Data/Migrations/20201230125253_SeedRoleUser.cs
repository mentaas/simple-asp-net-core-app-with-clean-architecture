using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AbcTestApp.Infrastructure.Data.Migrations
{
    public partial class SeedRoleUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2301D884-221A-4E7D-B509-0113DCC043E1", "bbbcd8f5-1412-4588-8c1d-427eb2b9f4d6", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7D9B7113-A8F8-4035-99A7-A20DD400F6A3", "4cc3bd7f-4d50-4046-9cb4-db3b09d483fb", "Moderator", "MODERATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6B6867B8-3173-4AA8-A4F0-07D2DD931825",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash" },
                values: new object[] { "b388580b-7d36-4d36-9d04-574109460993", new DateTime(2020, 12, 30, 13, 52, 52, 308, DateTimeKind.Local).AddTicks(2656), "AQAAAAEAACcQAAAAEO3uAkVn7tEA6UXdiwwrd4WI7MIqM8c9jURr6XDPOZ1tvDu1ssWKP83WM/y2n9Zm5w==" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2301D884-221A-4E7D-B509-0113DCC043E1", "6B6867B8-3173-4AA8-A4F0-07D2DD931825" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7D9B7113-A8F8-4035-99A7-A20DD400F6A3");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2301D884-221A-4E7D-B509-0113DCC043E1", "6B6867B8-3173-4AA8-A4F0-07D2DD931825" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2301D884-221A-4E7D-B509-0113DCC043E1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6B6867B8-3173-4AA8-A4F0-07D2DD931825",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash" },
                values: new object[] { "139c0df2-fc1d-46e2-9dd5-d78fdbc07c0e", new DateTime(2020, 12, 30, 13, 49, 6, 106, DateTimeKind.Local).AddTicks(3095), "AQAAAAEAACcQAAAAEMugBxaRruMLkIdeilP4nTkBmuvt20cyD4xnB6KuNj6IuakB6ypv3nmdID+LoSQmBw==" });
        }
    }
}
