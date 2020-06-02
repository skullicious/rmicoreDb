using Microsoft.EntityFrameworkCore.Migrations;

namespace rmicore.Migrations
{
    public partial class licensetypechange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                values: new object[,]
                {
                    { "0a524a41-9a3b-4acb-9692-31304a18ef70", "5da42cab-2cac-467e-8c63-a47baa91c4a3", "Visitor", "VISITOR" },
                    { "9abd4a2a-f3d1-4c04-87d1-2b5fdb702cd6", "3eb099cf-d77d-431f-8c9b-f29f46247c8d", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "LicenseTypes",
                keyColumn: "LicenseTypeId",
                keyValue: 1,
                column: "Name",
                value: "Elite");

            migrationBuilder.UpdateData(
                table: "LicenseTypes",
                keyColumn: "LicenseTypeId",
                keyValue: 2,
                column: "Name",
                value: "1st Cat");

            migrationBuilder.UpdateData(
                table: "LicenseTypes",
                keyColumn: "LicenseTypeId",
                keyValue: 3,
                column: "Name",
                value: "2nd Cat");

            migrationBuilder.UpdateData(
                table: "LicenseTypes",
                keyColumn: "LicenseTypeId",
                keyValue: 4,
                column: "Name",
                value: "3rd Cat");

            migrationBuilder.InsertData(
                table: "LicenseTypes",
                columns: new[] { "LicenseTypeId", "Name" },
                values: new object[] { 5, "4th Cat" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a524a41-9a3b-4acb-9692-31304a18ef70");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9abd4a2a-f3d1-4c04-87d1-2b5fdb702cd6");

            migrationBuilder.DeleteData(
                table: "LicenseTypes",
                keyColumn: "LicenseTypeId",
                keyValue: 5);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d48a3c41-50bf-4f59-b956-d6cff8650473", "df77def7-1fe9-44bf-b849-f1bc6542a198", "Visitor", "VISITOR" },
                    { "297f796b-49b2-4b81-922f-e96cab5c0f3f", "469b7b50-a040-4c45-9a9e-04208e7949d5", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "LicenseTypes",
                keyColumn: "LicenseTypeId",
                keyValue: 1,
                column: "Name",
                value: "Provisional");

            migrationBuilder.UpdateData(
                table: "LicenseTypes",
                keyColumn: "LicenseTypeId",
                keyValue: 2,
                column: "Name",
                value: "Full UK");

            migrationBuilder.UpdateData(
                table: "LicenseTypes",
                keyColumn: "LicenseTypeId",
                keyValue: 3,
                column: "Name",
                value: "Full EU");

            migrationBuilder.UpdateData(
                table: "LicenseTypes",
                keyColumn: "LicenseTypeId",
                keyValue: 4,
                column: "Name",
                value: "Full Other");
        }
    }
}
