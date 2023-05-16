using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UcundanTut.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class sd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DernekLogo",
                table: "Etkinlikler");

            migrationBuilder.AddColumn<string>(
                name: "DernekLogo",
                table: "Dernekler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DernekLogo",
                table: "Dernekler");

            migrationBuilder.AddColumn<string>(
                name: "DernekLogo",
                table: "Etkinlikler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
