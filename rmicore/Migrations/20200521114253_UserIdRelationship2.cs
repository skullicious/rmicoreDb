using Microsoft.EntityFrameworkCore.Migrations;

namespace rmicore.Migrations
{
    public partial class UserIdRelationship2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f3c6bb5-cf15-45f2-9705-8209ae57b8e0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee9de740-35b6-4352-a8b0-52692cd725af");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7099ff45-8587-4150-856f-cb67e509ca29", "07d2bf31-397c-4aae-97ff-46ae0b51b04c", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e01dee48-fbb6-4a87-9bdb-e064eefdcaa6", "47e08a2a-72d4-41b2-9f82-a076ead934d6", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.CreateIndex(
                name: "IX_Individual_UserId",
                table: "Individual",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Individual_Users_UserId",
                table: "Individual",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Individual_Users_UserId",
                table: "Individual");

            migrationBuilder.DropIndex(
                name: "IX_Individual_UserId",
                table: "Individual");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7099ff45-8587-4150-856f-cb67e509ca29");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e01dee48-fbb6-4a87-9bdb-e064eefdcaa6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3f3c6bb5-cf15-45f2-9705-8209ae57b8e0", "eb8316bf-bbcf-498d-b5c7-71b1aa8e7d74", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ee9de740-35b6-4352-a8b0-52692cd725af", "daaf183b-2571-4f72-a256-b11bf2df00f1", "Administrator", "ADMINISTRATOR" });
        }
    }
}
