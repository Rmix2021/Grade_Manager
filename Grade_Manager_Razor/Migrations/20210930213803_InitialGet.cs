using Microsoft.EntityFrameworkCore.Migrations;

namespace Grade_Manager_Razor.Migrations
{
    public partial class InitialGet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ClassRooms",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ClassRooms");
        }
    }
}
