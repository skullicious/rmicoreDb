using Microsoft.EntityFrameworkCore.Migrations;

namespace rmicore.Migrations
{
    public partial class riderOcc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3697c0c5-a7a4-40f5-b177-a33b28f800cc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b911a6bf-eaa0-4299-8de1-b624c973b9cd");

            migrationBuilder.CreateTable(
                name: "RiderOccupations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    occupation = table.Column<string>(nullable: true),
                    partTime = table.Column<string>(nullable: true),
                    employmentType = table.Column<string>(nullable: true),
                    occupationStatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiderOccupations", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4c8df5f7-21d3-4547-aac5-54d7614c5afc", "8ea6e853-5bb6-458e-8397-76054f99f53f", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "72604063-400b-4101-8abc-ae5e49db21f9", "2ecd3004-d5e4-4d65-822f-374526595f7c", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RiderOccupations");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c8df5f7-21d3-4547-aac5-54d7614c5afc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72604063-400b-4101-8abc-ae5e49db21f9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b911a6bf-eaa0-4299-8de1-b624c973b9cd", "c8a8fc9d-cec6-45ed-9fd3-b2b82e470555", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3697c0c5-a7a4-40f5-b177-a33b28f800cc", "fa5d87a0-d7fb-4b91-a22d-82b9d6ccf726", "Administrator", "ADMINISTRATOR" });
        }
    }
}
