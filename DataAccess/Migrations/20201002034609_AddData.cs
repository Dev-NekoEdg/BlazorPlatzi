using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { "ASH", "Aseo Hogar" },
                    { "ASP", "Aseo Personal" }
                });

            migrationBuilder.InsertData(
                table: "Werehouses",
                columns: new[] { "WerehouseId", "WerehouseAddress", "WerehouseName" },
                values: new object[,]
                {
                    { "89cdc7ed-5050-47c9-ac9b-4ed42efb6801", "Av evergreen No. 704", "Bodega Celtral" },
                    { "3dcaddd1-2417-464e-bfaf-e6ad8e7ad7b9", "Calle falsa 123", "Bodega Norte" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "ASH");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "ASP");

            migrationBuilder.DeleteData(
                table: "Werehouses",
                keyColumn: "WerehouseId",
                keyValue: "3dcaddd1-2417-464e-bfaf-e6ad8e7ad7b9");

            migrationBuilder.DeleteData(
                table: "Werehouses",
                keyColumn: "WerehouseId",
                keyValue: "89cdc7ed-5050-47c9-ac9b-4ed42efb6801");
        }
    }
}
