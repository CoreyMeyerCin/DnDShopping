using Microsoft.EntityFrameworkCore.Migrations;

namespace DungeonsAndDragons.Migrations
{
    public partial class updatedgeneralstore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Shops_GeneralStoreId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_GeneralStoreId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Shops");

            migrationBuilder.DropColumn(
                name: "StockId",
                table: "Shops");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "GeneralStoreId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Items");

            migrationBuilder.CreateTable(
                name: "GeneralStores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gold = table.Column<int>(type: "int", nullable: false),
                    NPCharacterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralStores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GeneralStores_NPCharacter_NPCharacterId",
                        column: x => x.NPCharacterId,
                        principalTable: "NPCharacter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GeneralStoresItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RarityValue = table.Column<int>(type: "int", nullable: false),
                    RarityString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    GeneralStoreId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralStoresItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GeneralStoresItems_GeneralStores_GeneralStoreId",
                        column: x => x.GeneralStoreId,
                        principalTable: "GeneralStores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GeneralStores_Id",
                table: "GeneralStores",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GeneralStores_NPCharacterId",
                table: "GeneralStores",
                column: "NPCharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralStoresItems_GeneralStoreId",
                table: "GeneralStoresItems",
                column: "GeneralStoreId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralStoresItems_Id",
                table: "GeneralStoresItems",
                column: "Id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GeneralStoresItems");

            migrationBuilder.DropTable(
                name: "GeneralStores");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Shops",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "StockId",
                table: "Shops",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "GeneralStoreId",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_GeneralStoreId",
                table: "Items",
                column: "GeneralStoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Shops_GeneralStoreId",
                table: "Items",
                column: "GeneralStoreId",
                principalTable: "Shops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
