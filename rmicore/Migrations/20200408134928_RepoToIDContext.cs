using Microsoft.EntityFrameworkCore.Migrations;

namespace rmicore.Migrations
{
    public partial class RepoToIDContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "3f0eb3bf-e8ba-48eb-a9ce-10dbcbaed2cc");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "eeb37834-75f7-4648-8f80-02493f6c719a");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c2762244-bdd8-4e2b-a926-edec7bfebdaa", "f2f4fe07-9bb2-4bdd-b959-25bc05478195", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f6be9d2e-365b-4b6e-8c95-bd5fad8b9d62", "48f2d3aa-155c-48a1-970f-afa984c63095", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c2762244-bdd8-4e2b-a926-edec7bfebdaa");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f6be9d2e-365b-4b6e-8c95-bd5fad8b9d62");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "eeb37834-75f7-4648-8f80-02493f6c719a", "f2ecf442-d51c-4975-93a1-f491780dfed5", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3f0eb3bf-e8ba-48eb-a9ce-10dbcbaed2cc", "44dcec42-0121-4bbb-ad53-556b584008c2", "Administrator", "ADMINISTRATOR" });
        }
    }
}
