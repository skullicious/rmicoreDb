using Microsoft.EntityFrameworkCore.Migrations;

namespace rmicore.Migrations
{
    public partial class addsFirstnameToIndi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7099ff45-8587-4150-856f-cb67e509ca29");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e01dee48-fbb6-4a87-9bdb-e064eefdcaa6");

            migrationBuilder.AddColumn<string>(
                name: "firstName",
                table: "Individual",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3027d67f-288e-47a2-8309-d2111e9ce4a9", "a12367e0-187e-4667-b389-1fdc62a89c83", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2c89cc7b-29ff-4efa-82b5-deab9637ba0d", "73f5b403-68d1-44a5-93ef-7343f38775a1", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "firstName",
                table: "Individual");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7099ff45-8587-4150-856f-cb67e509ca29", "07d2bf31-397c-4aae-97ff-46ae0b51b04c", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e01dee48-fbb6-4a87-9bdb-e064eefdcaa6", "47e08a2a-72d4-41b2-9f82-a076ead934d6", "Administrator", "ADMINISTRATOR" });
        }
    }
}
