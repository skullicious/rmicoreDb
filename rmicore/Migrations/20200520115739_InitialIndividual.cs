using Microsoft.EntityFrameworkCore.Migrations;

namespace rmicore.Migrations
{
    public partial class InitialIndividual : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ad095f0-7e4e-4852-9c61-f2675e45c37c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "828bee30-8405-4be4-a766-011833b1b2ea");

            migrationBuilder.CreateTable(
                name: "Individual",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RiderId = table.Column<int>(nullable: false),
                    individual_title = table.Column<string>(nullable: true),
                    individual_firstName = table.Column<string>(nullable: true),
                    individual_lastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Individual", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Individual_Rider_RiderId",
                        column: x => x.RiderId,
                        principalTable: "Rider",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "71418071-d2f7-449a-905a-27c45f9ab341", "5d7c8405-35e4-4b8a-93ed-9c4f551440ea", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "704a2cc7-e01a-419e-acdc-28d0f094f426", "c4ef9826-31aa-4cca-99e3-4fca2847f315", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.CreateIndex(
                name: "IX_Individual_RiderId",
                table: "Individual",
                column: "RiderId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Individual");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "704a2cc7-e01a-419e-acdc-28d0f094f426");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71418071-d2f7-449a-905a-27c45f9ab341");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "828bee30-8405-4be4-a766-011833b1b2ea", "730bc1ad-e64c-432f-8bd5-0a793237fb13", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4ad095f0-7e4e-4852-9c61-f2675e45c37c", "448b2f04-f648-4364-832b-661bcfa0af81", "Administrator", "ADMINISTRATOR" });
        }
    }
}
