using Microsoft.EntityFrameworkCore.Migrations;

namespace rmicore.Migrations
{
    public partial class removeRiderIdfromIndi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c89cc7b-29ff-4efa-82b5-deab9637ba0d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3027d67f-288e-47a2-8309-d2111e9ce4a9");

            migrationBuilder.DropColumn(
                name: "RiderId",
                table: "Individual");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "717ed474-2f18-4b2e-9200-1195d1515ce4", "1da95452-8b03-43f3-a177-ff663d7f58cc", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "019df47e-27f8-40b5-83ba-50ef3839206f", "85309296-48b6-432f-b5a1-87f6c04ec300", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "019df47e-27f8-40b5-83ba-50ef3839206f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "717ed474-2f18-4b2e-9200-1195d1515ce4");

            migrationBuilder.AddColumn<int>(
                name: "RiderId",
                table: "Individual",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3027d67f-288e-47a2-8309-d2111e9ce4a9", "a12367e0-187e-4667-b389-1fdc62a89c83", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2c89cc7b-29ff-4efa-82b5-deab9637ba0d", "73f5b403-68d1-44a5-93ef-7343f38775a1", "Administrator", "ADMINISTRATOR" });
        }
    }
}
