using Microsoft.EntityFrameworkCore.Migrations;

namespace rmicore.Migrations
{
    public partial class ReworkIndi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "019df47e-27f8-40b5-83ba-50ef3839206f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "717ed474-2f18-4b2e-9200-1195d1515ce4");

            migrationBuilder.DropColumn(
                name: "individual_firstName",
                table: "Individual");

            migrationBuilder.DropColumn(
                name: "individual_lastName",
                table: "Individual");

            migrationBuilder.DropColumn(
                name: "individual_title",
                table: "Individual");

            migrationBuilder.AddColumn<string>(
                name: "lastName",
                table: "Individual",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "title",
                table: "Individual",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "85836823-fab4-49bf-b222-7c930c5b8a41", "4285a906-a511-4d78-b233-52e8a4dbefd7", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "350fe5b8-d9b3-4b4d-9617-e3b710701324", "69927ce8-e706-418c-bb0f-3731c7c2d435", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "350fe5b8-d9b3-4b4d-9617-e3b710701324");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85836823-fab4-49bf-b222-7c930c5b8a41");

            migrationBuilder.DropColumn(
                name: "lastName",
                table: "Individual");

            migrationBuilder.DropColumn(
                name: "title",
                table: "Individual");

            migrationBuilder.AddColumn<string>(
                name: "individual_firstName",
                table: "Individual",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "individual_lastName",
                table: "Individual",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "individual_title",
                table: "Individual",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "717ed474-2f18-4b2e-9200-1195d1515ce4", "1da95452-8b03-43f3-a177-ff663d7f58cc", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "019df47e-27f8-40b5-83ba-50ef3839206f", "85309296-48b6-432f-b5a1-87f6c04ec300", "Administrator", "ADMINISTRATOR" });
        }
    }
}
