using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolyo.Migrations
{
    public partial class add_ImgUrl_Column_Reference : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "References",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "References");
        }
    }
}
