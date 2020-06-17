using Microsoft.EntityFrameworkCore.Migrations;

namespace MiPrimerApi.Migrations
{
    public partial class AddArtistas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Albunes",
                table: "Albunes");

            migrationBuilder.DropColumn(
                name: "Artista",
                table: "Albunes");

            migrationBuilder.RenameTable(
                name: "Albunes",
                newName: "AlbunesEnStock");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "AlbunesEnStock",
                newName: "NombreAlbum");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AlbunesEnStock",
                newName: "AlbunesEnStockId");

            migrationBuilder.AddColumn<int>(
                name: "ArtistaId",
                table: "AlbunesEnStock",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AlbunesEnStock",
                table: "AlbunesEnStock",
                column: "AlbunesEnStockId");

            migrationBuilder.CreateTable(
                name: "Artista",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnioNacimiento = table.Column<int>(nullable: false),
                    Nacionalidad = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artista", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlbunesEnStock_ArtistaId",
                table: "AlbunesEnStock",
                column: "ArtistaId");

            migrationBuilder.AddForeignKey(
                name: "FK_AlbunesEnStock_Artista_ArtistaId",
                table: "AlbunesEnStock",
                column: "ArtistaId",
                principalTable: "Artista",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlbunesEnStock_Artista_ArtistaId",
                table: "AlbunesEnStock");

            migrationBuilder.DropTable(
                name: "Artista");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AlbunesEnStock",
                table: "AlbunesEnStock");

            migrationBuilder.DropIndex(
                name: "IX_AlbunesEnStock_ArtistaId",
                table: "AlbunesEnStock");

            migrationBuilder.DropColumn(
                name: "ArtistaId",
                table: "AlbunesEnStock");

            migrationBuilder.RenameTable(
                name: "AlbunesEnStock",
                newName: "Albunes");

            migrationBuilder.RenameColumn(
                name: "NombreAlbum",
                table: "Albunes",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "AlbunesEnStockId",
                table: "Albunes",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Artista",
                table: "Albunes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Albunes",
                table: "Albunes",
                column: "Id");
        }
    }
}
