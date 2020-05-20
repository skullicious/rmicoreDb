using Microsoft.EntityFrameworkCore.Migrations;

namespace rmicore.Migrations
{
    public partial class RemoveRiderIdFromRider : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "5d9e589a-abc5-4af9-ab53-21a72428c4f9", "212be96e-4ac7-42f2-8925-e1cd3334a29f", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2040b98c-206c-43ae-8405-40035bd3c87c", "5038c455-9804-4ad8-97e1-a73bd72b938e", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2040b98c-206c-43ae-8405-40035bd3c87c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d9e589a-abc5-4af9-ab53-21a72428c4f9");

            migrationBuilder.AddColumn<int>(
                name: "RiderId",
                table: "Rider",
                type: "int",
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
    }
}
