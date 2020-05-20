using Microsoft.EntityFrameworkCore.Migrations;

namespace rmicore.Migrations
{
    public partial class ForeignKeyTORider : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "704a2cc7-e01a-419e-acdc-28d0f094f426");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71418071-d2f7-449a-905a-27c45f9ab341");

            migrationBuilder.AddColumn<int>(
                name: "RiderId",
                table: "Rider",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2a2b4e2d-e1be-4e06-bb9a-79e575b370f0", "35f43187-842a-427f-b438-6415ece9f0b9", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7dcba3ff-6e55-40c0-a925-408452042651", "3e05a342-0eca-4c5a-8750-3497ed7448e1", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a2b4e2d-e1be-4e06-bb9a-79e575b370f0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7dcba3ff-6e55-40c0-a925-408452042651");

            migrationBuilder.DropColumn(
                name: "RiderId",
                table: "Rider");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "71418071-d2f7-449a-905a-27c45f9ab341", "5d7c8405-35e4-4b8a-93ed-9c4f551440ea", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "704a2cc7-e01a-419e-acdc-28d0f094f426", "c4ef9826-31aa-4cca-99e3-4fca2847f315", "Administrator", "ADMINISTRATOR" });
        }
    }
}
