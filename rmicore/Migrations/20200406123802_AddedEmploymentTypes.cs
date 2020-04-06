using Microsoft.EntityFrameworkCore.Migrations;

namespace rmicore.Migrations
{
    public partial class AddedEmploymentTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmploymentTypes",
                columns: table => new
                {
                    EmploymentTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmploymentTypes", x => x.EmploymentTypeId);
                });

            migrationBuilder.InsertData(
                table: "EmploymentTypes",
                columns: new[] { "EmploymentTypeId", "Name" },
                values: new object[,]
                {
                    { 1, "Insurance" },
                    { 2, "Retail" },
                    { 3, "Technology" },
                    { 4, "Construction" },
                    { 5, "Finance" },
                    { 6, "Local Government" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmploymentTypes");
        }
    }
}
