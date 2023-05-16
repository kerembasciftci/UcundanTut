using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UcundanTut.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class miglogo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DernekLogo",
                table: "Etkinlikler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DernekLogo",
                table: "Etkinlikler");
        }
    }
}
