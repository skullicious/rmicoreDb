using Microsoft.EntityFrameworkCore.Migrations;

namespace rmicore.Migrations
{
    public partial class TitleInitial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Titles",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleId",
                keyValue: 1,
                column: "Name",
                value: "Mr");

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleId",
                keyValue: 2,
                column: "Name",
                value: "Mrs");

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleId",
                keyValue: 3,
                column: "Name",
                value: "Miss");

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleId",
                keyValue: 4,
                column: "Name",
                value: "Doctor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Titles");
        }
    }
}
