using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AbcTestApp.Infrastructure.Data.Migrations
{
    public partial class SeedUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "Email", "EmailConfirmed", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedBy", "UpdatedOn", "UserName" },
                values: new object[] { "6B6867B8-3173-4AA8-A4F0-07D2DD931825", 0, "139c0df2-fc1d-46e2-9dd5-d78fdbc07c0e", null, new DateTime(2020, 12, 30, 13, 49, 6, 106, DateTimeKind.Local).AddTicks(3095), null, null, "Admin@Admin.com", true, false, "Admin", false, null, "Master", "ADMIN@ADMIN.COM", "MASTERADMIN", "AQAAAAEAACcQAAAAEMugBxaRruMLkIdeilP4nTkBmuvt20cyD4xnB6KuNj6IuakB6ypv3nmdID+LoSQmBw==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, null, null, "masteradmin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6B6867B8-3173-4AA8-A4F0-07D2DD931825");
        }
    }
}
