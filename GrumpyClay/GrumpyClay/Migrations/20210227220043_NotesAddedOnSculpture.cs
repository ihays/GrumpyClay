using Microsoft.EntityFrameworkCore.Migrations;

namespace GrumpyClay.Migrations
{
    public partial class NotesAddedOnSculpture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Sculptures",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Sculptures");
        }
    }
}
