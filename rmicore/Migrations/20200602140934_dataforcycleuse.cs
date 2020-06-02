using Microsoft.EntityFrameworkCore.Migrations;

namespace rmicore.Migrations
{
    public partial class dataforcycleuse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c8df5f7-21d3-4547-aac5-54d7614c5afc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72604063-400b-4101-8abc-ae5e49db21f9");

            migrationBuilder.CreateTable(
                name: "CycleUses",
                columns: table => new
                {
                    CycleUseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CycleUses", x => x.CycleUseId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d48a3c41-50bf-4f59-b956-d6cff8650473", "df77def7-1fe9-44bf-b849-f1bc6542a198", "Visitor", "VISITOR" },
                    { "297f796b-49b2-4b81-922f-e96cab5c0f3f", "469b7b50-a040-4c45-9a9e-04208e7949d5", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "CycleUses",
                columns: new[] { "CycleUseId", "Name" },
                values: new object[,]
                {
                    { 1, "Sportives" },
                    { 2, "Time Trials" },
                    { 3, "Road Racing" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CycleUses");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "297f796b-49b2-4b81-922f-e96cab5c0f3f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d48a3c41-50bf-4f59-b956-d6cff8650473");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4c8df5f7-21d3-4547-aac5-54d7614c5afc", "8ea6e853-5bb6-458e-8397-76054f99f53f", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "72604063-400b-4101-8abc-ae5e49db21f9", "2ecd3004-d5e4-4d65-822f-374526595f7c", "Administrator", "ADMINISTRATOR" });
        }
    }
}
