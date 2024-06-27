using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiGroupProject.Migrations
{
    /// <inheritdoc />
    public partial class ReaddedOrderlinesandOrdersController : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Order",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Items",
                newName: "Price");

            migrationBuilder.AlterColumn<decimal>(
                name: "Total",
                table: "Order",
                type: "decimal(9,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Order",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Items",
                newName: "Price");

            migrationBuilder.AlterColumn<decimal>(
                name: "Total",
                table: "Order",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(9,2)");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Order",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                defaultValue: "");
        }
    }
}
