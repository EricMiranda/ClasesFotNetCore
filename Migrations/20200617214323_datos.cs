using Microsoft.EntityFrameworkCore.Migrations;

namespace MiPrimerApi.Migrations
{
    public partial class datos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlbunesEnStock_Artista_ArtistaId",
                table: "AlbunesEnStock");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Artista",
                table: "Artista");

            migrationBuilder.RenameTable(
                name: "Artista",
                newName: "Artistas");

            migrationBuilder.RenameColumn(
                name: "ArtistaId",
                table: "AlbunesEnStock",
                newName: "artistaId");

            migrationBuilder.RenameIndex(
                name: "IX_AlbunesEnStock_ArtistaId",
                table: "AlbunesEnStock",
                newName: "IX_AlbunesEnStock_artistaId");

            migrationBuilder.AlterColumn<int>(
                name: "artistaId",
                table: "AlbunesEnStock",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Artistas",
                table: "Artistas",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Artistas",
                columns: new[] { "Id", "AnioNacimiento", "Nacionalidad" },
                values: new object[] { 1, 1950, "Argentina" });

            migrationBuilder.InsertData(
                table: "AlbunesEnStock",
                columns: new[] { "AlbunesEnStockId", "AnioPublicacion", "NombreAlbum", "artistaId" },
                values: new object[] { 1, 1990, "El Salmon", 1 });

            migrationBuilder.AddForeignKey(
                name: "FK_AlbunesEnStock_Artistas_artistaId",
                table: "AlbunesEnStock",
                column: "artistaId",
                principalTable: "Artistas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlbunesEnStock_Artistas_artistaId",
                table: "AlbunesEnStock");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Artistas",
                table: "Artistas");

            migrationBuilder.DeleteData(
                table: "AlbunesEnStock",
                keyColumn: "AlbunesEnStockId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameTable(
                name: "Artistas",
                newName: "Artista");

            migrationBuilder.RenameColumn(
                name: "artistaId",
                table: "AlbunesEnStock",
                newName: "ArtistaId");

            migrationBuilder.RenameIndex(
                name: "IX_AlbunesEnStock_artistaId",
                table: "AlbunesEnStock",
                newName: "IX_AlbunesEnStock_ArtistaId");

            migrationBuilder.AlterColumn<int>(
                name: "ArtistaId",
                table: "AlbunesEnStock",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Artista",
                table: "Artista",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AlbunesEnStock_Artista_ArtistaId",
                table: "AlbunesEnStock",
                column: "ArtistaId",
                principalTable: "Artista",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
