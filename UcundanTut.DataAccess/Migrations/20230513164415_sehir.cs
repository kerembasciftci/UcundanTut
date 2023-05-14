using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UcundanTut.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class sehir : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EtkinlikSehri",
                table: "Etkinlikler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "AktifMi",
                table: "Etkinlikler",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AktifMi",
                table: "Etkinlikler");

            migrationBuilder.AlterColumn<int>(
                name: "EtkinlikSehri",
                table: "Etkinlikler",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
