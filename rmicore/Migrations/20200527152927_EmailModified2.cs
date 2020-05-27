using Microsoft.EntityFrameworkCore.Migrations;

namespace rmicore.Migrations
{
    public partial class EmailModified2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46c72f8e-1ce2-4ad1-b4a4-81061b6dd761");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83ec62f7-28f6-4097-9c5a-ab8a1fdea0c1");

            migrationBuilder.CreateTable(
                name: "Email",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmailAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Email", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "31439a11-a7da-4696-b004-c1aad6f09552", "e9f24d56-6ad8-4e80-ad4e-567b9aa4ba6c", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b4da576b-fcf4-416b-8301-8f4738fc4392", "e73c9176-dc7b-48b6-875c-12539a21a312", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Email");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31439a11-a7da-4696-b004-c1aad6f09552");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4da576b-fcf4-416b-8301-8f4738fc4392");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "83ec62f7-28f6-4097-9c5a-ab8a1fdea0c1", "4b57c768-54e5-42e9-b001-17264913ed62", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "46c72f8e-1ce2-4ad1-b4a4-81061b6dd761", "44244d74-7ae3-47c2-8aff-693a1a58c689", "Administrator", "ADMINISTRATOR" });
        }
    }
}
