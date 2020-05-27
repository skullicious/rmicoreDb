using Microsoft.EntityFrameworkCore.Migrations;

namespace rmicore.Migrations
{
    public partial class AddressModified2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Rider_RiderId",
                table: "Address");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "350fe5b8-d9b3-4b4d-9617-e3b710701324");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85836823-fab4-49bf-b222-7c930c5b8a41");

            migrationBuilder.AlterColumn<int>(
                name: "RiderId",
                table: "Address",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Address",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "83ec62f7-28f6-4097-9c5a-ab8a1fdea0c1", "4b57c768-54e5-42e9-b001-17264913ed62", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "46c72f8e-1ce2-4ad1-b4a4-81061b6dd761", "44244d74-7ae3-47c2-8aff-693a1a58c689", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.CreateIndex(
                name: "IX_Address_UserId",
                table: "Address",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Rider_RiderId",
                table: "Address",
                column: "RiderId",
                principalTable: "Rider",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Users_UserId",
                table: "Address",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Rider_RiderId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Address_Users_UserId",
                table: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Address_UserId",
                table: "Address");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46c72f8e-1ce2-4ad1-b4a4-81061b6dd761");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83ec62f7-28f6-4097-9c5a-ab8a1fdea0c1");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Address");

            migrationBuilder.AlterColumn<int>(
                name: "RiderId",
                table: "Address",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "85836823-fab4-49bf-b222-7c930c5b8a41", "4285a906-a511-4d78-b233-52e8a4dbefd7", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "350fe5b8-d9b3-4b4d-9617-e3b710701324", "69927ce8-e706-418c-bb0f-3731c7c2d435", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Rider_RiderId",
                table: "Address",
                column: "RiderId",
                principalTable: "Rider",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
