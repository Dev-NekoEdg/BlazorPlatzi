using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class updateInOut : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InputOutputs_Storages_StorageEntityStoregeId",
                table: "InputOutputs");

            migrationBuilder.DropIndex(
                name: "IX_InputOutputs_StorageEntityStoregeId",
                table: "InputOutputs");

            migrationBuilder.DeleteData(
                table: "Werehouses",
                keyColumn: "WerehouseId",
                keyValue: "3dcaddd1-2417-464e-bfaf-e6ad8e7ad7b9");

            migrationBuilder.DeleteData(
                table: "Werehouses",
                keyColumn: "WerehouseId",
                keyValue: "89cdc7ed-5050-47c9-ac9b-4ed42efb6801");

            migrationBuilder.DropColumn(
                name: "StorageEntityStoregeId",
                table: "InputOutputs");

            migrationBuilder.AddColumn<string>(
                name: "StorageId",
                table: "InputOutputs",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Werehouses",
                columns: new[] { "WerehouseId", "WerehouseAddress", "WerehouseName" },
                values: new object[] { "9ccdbaf9-1005-4228-92b1-0960eecd0f5a", "Av evergreen No. 704", "Bodega Celtral" });

            migrationBuilder.InsertData(
                table: "Werehouses",
                columns: new[] { "WerehouseId", "WerehouseAddress", "WerehouseName" },
                values: new object[] { "9cac0f54-61db-479f-8eef-7417ef7ff194", "Calle falsa 123", "Bodega Norte" });

            migrationBuilder.CreateIndex(
                name: "IX_InputOutputs_StorageId",
                table: "InputOutputs",
                column: "StorageId");

            migrationBuilder.AddForeignKey(
                name: "FK_InputOutputs_Storages_StorageId",
                table: "InputOutputs",
                column: "StorageId",
                principalTable: "Storages",
                principalColumn: "StoregeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InputOutputs_Storages_StorageId",
                table: "InputOutputs");

            migrationBuilder.DropIndex(
                name: "IX_InputOutputs_StorageId",
                table: "InputOutputs");

            migrationBuilder.DeleteData(
                table: "Werehouses",
                keyColumn: "WerehouseId",
                keyValue: "9cac0f54-61db-479f-8eef-7417ef7ff194");

            migrationBuilder.DeleteData(
                table: "Werehouses",
                keyColumn: "WerehouseId",
                keyValue: "9ccdbaf9-1005-4228-92b1-0960eecd0f5a");

            migrationBuilder.DropColumn(
                name: "StorageId",
                table: "InputOutputs");

            migrationBuilder.AddColumn<string>(
                name: "StorageEntityStoregeId",
                table: "InputOutputs",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Werehouses",
                columns: new[] { "WerehouseId", "WerehouseAddress", "WerehouseName" },
                values: new object[] { "89cdc7ed-5050-47c9-ac9b-4ed42efb6801", "Av evergreen No. 704", "Bodega Celtral" });

            migrationBuilder.InsertData(
                table: "Werehouses",
                columns: new[] { "WerehouseId", "WerehouseAddress", "WerehouseName" },
                values: new object[] { "3dcaddd1-2417-464e-bfaf-e6ad8e7ad7b9", "Calle falsa 123", "Bodega Norte" });

            migrationBuilder.CreateIndex(
                name: "IX_InputOutputs_StorageEntityStoregeId",
                table: "InputOutputs",
                column: "StorageEntityStoregeId");

            migrationBuilder.AddForeignKey(
                name: "FK_InputOutputs_Storages_StorageEntityStoregeId",
                table: "InputOutputs",
                column: "StorageEntityStoregeId",
                principalTable: "Storages",
                principalColumn: "StoregeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
