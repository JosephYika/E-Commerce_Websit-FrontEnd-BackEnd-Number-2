using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Commerce_Website.Migrations
{
    public partial class addedColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrederItems_Orders_OrderId",
                table: "OrederItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrederItems_OrederItems_OrderItemId",
                table: "OrederItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrederItems_PianoCourses_PianoCourseId",
                table: "OrederItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrederItems",
                table: "OrederItems");

            migrationBuilder.RenameTable(
                name: "OrederItems",
                newName: "OrderItems");

            migrationBuilder.RenameIndex(
                name: "IX_OrederItems_PianoCourseId",
                table: "OrderItems",
                newName: "IX_OrderItems_PianoCourseId");

            migrationBuilder.RenameIndex(
                name: "IX_OrederItems_OrderItemId",
                table: "OrderItems",
                newName: "IX_OrderItems_OrderItemId");

            migrationBuilder.RenameIndex(
                name: "IX_OrederItems_OrderId",
                table: "OrderItems",
                newName: "IX_OrderItems_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_OrderItems_OrderItemId",
                table: "OrderItems",
                column: "OrderItemId",
                principalTable: "OrderItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_PianoCourses_PianoCourseId",
                table: "OrderItems",
                column: "PianoCourseId",
                principalTable: "PianoCourses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_OrderItems_OrderItemId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_PianoCourses_PianoCourseId",
                table: "OrderItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems");

            migrationBuilder.RenameTable(
                name: "OrderItems",
                newName: "OrederItems");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_PianoCourseId",
                table: "OrederItems",
                newName: "IX_OrederItems_PianoCourseId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_OrderItemId",
                table: "OrederItems",
                newName: "IX_OrederItems_OrderItemId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrederItems",
                newName: "IX_OrederItems_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrederItems",
                table: "OrederItems",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrederItems_Orders_OrderId",
                table: "OrederItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrederItems_OrederItems_OrderItemId",
                table: "OrederItems",
                column: "OrderItemId",
                principalTable: "OrederItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrederItems_PianoCourses_PianoCourseId",
                table: "OrederItems",
                column: "PianoCourseId",
                principalTable: "PianoCourses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
