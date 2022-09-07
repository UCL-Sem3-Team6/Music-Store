using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Music_Store.Migrations
{
    public partial class Album : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlbumArtUrl",
                table: "Album");

            migrationBuilder.AddColumn<string>(
                name: "AlbumImage",
                table: "Album",
                type: "nvarchar (100)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlbumImage",
                table: "Album");

            migrationBuilder.AddColumn<string>(
                name: "AlbumArtUrl",
                table: "Album",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
