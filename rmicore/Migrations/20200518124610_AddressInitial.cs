using Microsoft.EntityFrameworkCore.Migrations;

namespace rmicore.Migrations
{
    public partial class AddressInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b5eeacd-60f4-486d-9d69-037865330505");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4fef525-9020-439c-9712-ab9f0676f2f5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "90f596a6-f491-41ec-be2b-6fba2ae12273", "1a731b04-b50e-4e89-92e8-3dad5634d0dd", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7bef5775-8a9b-4397-aefe-85141d45141f", "e48a69fe-f380-4142-bb1f-b13229f1de6a", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7bef5775-8a9b-4397-aefe-85141d45141f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "90f596a6-f491-41ec-be2b-6fba2ae12273");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b4fef525-9020-439c-9712-ab9f0676f2f5", "95b09f09-f483-4cc9-a6dd-b56ed8e672f4", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2b5eeacd-60f4-486d-9d69-037865330505", "7d0d460e-4bf8-4ccd-ae98-77a1a2a368ad", "Administrator", "ADMINISTRATOR" });
        }
    }
}
