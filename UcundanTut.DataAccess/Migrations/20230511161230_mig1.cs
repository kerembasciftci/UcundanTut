using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UcundanTut.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dernekler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DernekAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DernekAciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DernekMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DernekTelefon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dernekler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Etkinlikler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DernekId = table.Column<int>(type: "int", nullable: false),
                    EtkinlikAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EtkinlikAciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BaslangicZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BitisZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EtkinlikMekan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EtkinlikSehri = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etkinlikler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Etkinlikler_Dernekler_DernekId",
                        column: x => x.DernekId,
                        principalTable: "Dernekler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Etkinlikler_DernekId",
                table: "Etkinlikler",
                column: "DernekId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Etkinlikler");

            migrationBuilder.DropTable(
                name: "Dernekler");
        }
    }
}
