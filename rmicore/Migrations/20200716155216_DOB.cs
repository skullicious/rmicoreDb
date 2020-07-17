using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace rmicore.Migrations
{
    public partial class DOB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c726dbc5-ad21-4487-946e-646c72d9b75d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d89115e1-e142-4ee3-9389-d95af71c9b28");

            migrationBuilder.AddColumn<DateTime>(
                name: "dateOfBirth",
                table: "Individual",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "18ddce76-b52c-48bf-8321-fb760234a79f", "fdc2caa8-a223-42d8-bf56-2e1de0fc7176", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "db0811e0-59f4-42fc-9c45-8419ffc1a9bc", "d25c81c2-08b5-411a-a35d-518b555ba101", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18ddce76-b52c-48bf-8321-fb760234a79f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db0811e0-59f4-42fc-9c45-8419ffc1a9bc");

            migrationBuilder.DropColumn(
                name: "dateOfBirth",
                table: "Individual");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c726dbc5-ad21-4487-946e-646c72d9b75d", "023895fc-5abf-41bc-90f0-3fe7f50e8b1a", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d89115e1-e142-4ee3-9389-d95af71c9b28", "3b200060-bf0a-4e68-a388-51a1cd28fecb", "Administrator", "ADMINISTRATOR" });
        }
    }
}
