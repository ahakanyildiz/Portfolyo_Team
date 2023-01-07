using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolyo.Migrations
{
    public partial class add_subject_columns_in_ContactForms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Subject",
                table: "ContactForms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Subject",
                table: "ContactForms");
        }
    }
}
