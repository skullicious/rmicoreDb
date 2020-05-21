using Microsoft.EntityFrameworkCore.Migrations;

namespace rmicore.Migrations
{
    public partial class UserIdRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Individual_Rider_RiderId",
                table: "Individual");

            migrationBuilder.DropIndex(
                name: "IX_Individual_RiderId",
                table: "Individual");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2040b98c-206c-43ae-8405-40035bd3c87c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d9e589a-abc5-4af9-ab53-21a72428c4f9");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Individual",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3f3c6bb5-cf15-45f2-9705-8209ae57b8e0", "eb8316bf-bbcf-498d-b5c7-71b1aa8e7d74", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ee9de740-35b6-4352-a8b0-52692cd725af", "daaf183b-2571-4f72-a256-b11bf2df00f1", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f3c6bb5-cf15-45f2-9705-8209ae57b8e0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee9de740-35b6-4352-a8b0-52692cd725af");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Individual");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5d9e589a-abc5-4af9-ab53-21a72428c4f9", "212be96e-4ac7-42f2-8925-e1cd3334a29f", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2040b98c-206c-43ae-8405-40035bd3c87c", "5038c455-9804-4ad8-97e1-a73bd72b938e", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.CreateIndex(
                name: "IX_Individual_RiderId",
                table: "Individual",
                column: "RiderId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Individual_Rider_RiderId",
                table: "Individual",
                column: "RiderId",
                principalTable: "Rider",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
