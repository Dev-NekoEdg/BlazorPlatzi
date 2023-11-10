using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class newDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Werehouses",
                keyColumn: "WerehouseId",
                keyValue: "9cac0f54-61db-479f-8eef-7417ef7ff194");

            migrationBuilder.DeleteData(
                table: "Werehouses",
                keyColumn: "WerehouseId",
                keyValue: "9ccdbaf9-1005-4228-92b1-0960eecd0f5a");

            migrationBuilder.InsertData(
                table: "Werehouses",
                columns: new[] { "WerehouseId", "WerehouseAddress", "WerehouseName" },
                values: new object[] { "ed312f4f-82c1-4734-a483-614c3f675bb6", "Av evergreen No. 704", "Bodega Celtral" });

            migrationBuilder.InsertData(
                table: "Werehouses",
                columns: new[] { "WerehouseId", "WerehouseAddress", "WerehouseName" },
                values: new object[] { "8923077a-adda-45ff-9b5b-7de300dacd91", "Calle falsa 123", "Bodega Norte" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Werehouses",
                keyColumn: "WerehouseId",
                keyValue: "8923077a-adda-45ff-9b5b-7de300dacd91");

            migrationBuilder.DeleteData(
                table: "Werehouses",
                keyColumn: "WerehouseId",
                keyValue: "ed312f4f-82c1-4734-a483-614c3f675bb6");

            migrationBuilder.InsertData(
                table: "Werehouses",
                columns: new[] { "WerehouseId", "WerehouseAddress", "WerehouseName" },
                values: new object[] { "9ccdbaf9-1005-4228-92b1-0960eecd0f5a", "Av evergreen No. 704", "Bodega Celtral" });

            migrationBuilder.InsertData(
                table: "Werehouses",
                columns: new[] { "WerehouseId", "WerehouseAddress", "WerehouseName" },
                values: new object[] { "9cac0f54-61db-479f-8eef-7417ef7ff194", "Calle falsa 123", "Bodega Norte" });
        }
    }
}
