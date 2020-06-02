using Microsoft.EntityFrameworkCore.Migrations;

namespace rmicore.Migrations
{
    public partial class ridercycleuseadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a524a41-9a3b-4acb-9692-31304a18ef70");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9abd4a2a-f3d1-4c04-87d1-2b5fdb702cd6");

            migrationBuilder.CreateTable(
                name: "RiderCycleUse",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    cycleUse = table.Column<string>(nullable: true),
                    isCommuting = table.Column<string>(nullable: true),
                    motoringQualification = table.Column<string>(nullable: true),
                    licenseType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiderCycleUse", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c726dbc5-ad21-4487-946e-646c72d9b75d", "023895fc-5abf-41bc-90f0-3fe7f50e8b1a", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d89115e1-e142-4ee3-9389-d95af71c9b28", "3b200060-bf0a-4e68-a388-51a1cd28fecb", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RiderCycleUse");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c726dbc5-ad21-4487-946e-646c72d9b75d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d89115e1-e142-4ee3-9389-d95af71c9b28");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0a524a41-9a3b-4acb-9692-31304a18ef70", "5da42cab-2cac-467e-8c63-a47baa91c4a3", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9abd4a2a-f3d1-4c04-87d1-2b5fdb702cd6", "3eb099cf-d77d-431f-8c9b-f29f46247c8d", "Administrator", "ADMINISTRATOR" });
        }
    }
}
