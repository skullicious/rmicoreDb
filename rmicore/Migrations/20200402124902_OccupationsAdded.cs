using Microsoft.EntityFrameworkCore.Migrations;

namespace rmicore.Migrations
{
    public partial class OccupationsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Occupations",
                columns: table => new
                {
                    OccupationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Occupations", x => x.OccupationId);
                });

            migrationBuilder.InsertData(
                table: "Occupations",
                columns: new[] { "OccupationId", "Name" },
                values: new object[,]
                {
                    { 1, "Abbatoir Worker" },
                    { 2, "Bartender" },
                    { 3, "Chef" },
                    { 4, "Lawyer" },
                    { 5, "Mechanic" },
                    { 6, "Occupational Therapist" },
                    { 7, "Police Officer" },
                    { 8, "Train Driver" },
                    { 9, "Soldier" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Occupations");
        }
    }
}
