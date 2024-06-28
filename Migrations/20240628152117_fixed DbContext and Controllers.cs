using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiGroupProject.Migrations
{
    /// <inheritdoc />
    public partial class fixedDbContextandControllers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Customers_CustomerId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Orderline_Items_ItemId",
                table: "Orderline");

            migrationBuilder.DropForeignKey(
                name: "FK_Orderline_Order_OrderId",
                table: "Orderline");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orderline",
                table: "Orderline");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.RenameTable(
                name: "Orderline",
                newName: "Orderlines");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.RenameIndex(
                name: "IX_Orderline_OrderId",
                table: "Orderlines",
                newName: "IX_Orderlines_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Orderline_ItemId",
                table: "Orderlines",
                newName: "IX_Orderlines_ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_CustomerId",
                table: "Orders",
                newName: "IX_Orders_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orderlines",
                table: "Orderlines",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orderlines_Items_ItemId",
                table: "Orderlines",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orderlines_Orders_OrderId",
                table: "Orderlines",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orderlines_Items_ItemId",
                table: "Orderlines");

            migrationBuilder.DropForeignKey(
                name: "FK_Orderlines_Orders_OrderId",
                table: "Orderlines");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orderlines",
                table: "Orderlines");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.RenameTable(
                name: "Orderlines",
                newName: "Orderline");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_CustomerId",
                table: "Order",
                newName: "IX_Order_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Orderlines_OrderId",
                table: "Orderline",
                newName: "IX_Orderline_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Orderlines_ItemId",
                table: "Orderline",
                newName: "IX_Orderline_ItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orderline",
                table: "Orderline",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Customers_CustomerId",
                table: "Order",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orderline_Items_ItemId",
                table: "Orderline",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orderline_Order_OrderId",
                table: "Orderline",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
