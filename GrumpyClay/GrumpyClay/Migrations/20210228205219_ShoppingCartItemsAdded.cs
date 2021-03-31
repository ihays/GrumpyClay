using Microsoft.EntityFrameworkCore.Migrations;

namespace GrumpyClay.Migrations
{
    public partial class ShoppingCartItemsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItem_Sculptures_SculptureId",
                table: "ShoppingCartItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCartItem",
                table: "ShoppingCartItem");

            migrationBuilder.RenameTable(
                name: "ShoppingCartItem",
                newName: "ShoppingCartItems");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCartItem_SculptureId",
                table: "ShoppingCartItems",
                newName: "IX_ShoppingCartItems_SculptureId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCartItems",
                table: "ShoppingCartItems",
                column: "ShoppingCartItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Sculptures_SculptureId",
                table: "ShoppingCartItems",
                column: "SculptureId",
                principalTable: "Sculptures",
                principalColumn: "SculptureId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Sculptures_SculptureId",
                table: "ShoppingCartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCartItems",
                table: "ShoppingCartItems");

            migrationBuilder.RenameTable(
                name: "ShoppingCartItems",
                newName: "ShoppingCartItem");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCartItems_SculptureId",
                table: "ShoppingCartItem",
                newName: "IX_ShoppingCartItem_SculptureId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCartItem",
                table: "ShoppingCartItem",
                column: "ShoppingCartItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItem_Sculptures_SculptureId",
                table: "ShoppingCartItem",
                column: "SculptureId",
                principalTable: "Sculptures",
                principalColumn: "SculptureId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
