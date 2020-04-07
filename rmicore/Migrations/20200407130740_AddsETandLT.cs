using Microsoft.EntityFrameworkCore.Migrations;

namespace rmicore.Migrations
{
    public partial class AddsETandLT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LicenseTypes",
                columns: table => new
                {
                    LicenseTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LicenseTypes", x => x.LicenseTypeId);
                });

            migrationBuilder.CreateTable(
                name: "VehicleUses",
                columns: table => new
                {
                    VehicleUseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleUses", x => x.VehicleUseId);
                });

            migrationBuilder.InsertData(
                table: "LicenseTypes",
                columns: new[] { "LicenseTypeId", "Name" },
                values: new object[,]
                {
                    { 1, "Provisional" },
                    { 2, "Full UK" },
                    { 3, "Full EU" },
                    { 4, "Full Other" }
                });

            migrationBuilder.InsertData(
                table: "VehicleUses",
                columns: new[] { "VehicleUseId", "Name" },
                values: new object[,]
                {
                    { 1, "Commuting" },
                    { 2, "Personal Business Use" },
                    { 3, "Social, Domestic or Pleasure" },
                    { 4, "Deliveroo, Uber or similar" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LicenseTypes");

            migrationBuilder.DropTable(
                name: "VehicleUses");
        }
    }
}
