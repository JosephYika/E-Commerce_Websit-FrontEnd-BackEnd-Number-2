using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Commerce_Website.Migrations
{
    public partial class AddedLevelColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Level",
                table: "PianoCourses",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Level",
                table: "PianoCourses");
        }
    }
}
