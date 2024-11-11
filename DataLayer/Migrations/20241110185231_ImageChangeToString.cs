using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class ImageChangeToString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BoardGames_Images_imageId",
                table: "BoardGames");

            migrationBuilder.DropIndex(
                name: "IX_BoardGames_imageId",
                table: "BoardGames");

            migrationBuilder.DropColumn(
                name: "imageId",
                table: "BoardGames");

            migrationBuilder.RenameColumn(
                name: "tags",
                table: "BoardGames",
                newName: "Tags");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "BoardGames",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "minPlayers",
                table: "BoardGames",
                newName: "MinPlayers");

            migrationBuilder.RenameColumn(
                name: "maxPlayers",
                table: "BoardGames",
                newName: "MaxPlayers");

            migrationBuilder.RenameColumn(
                name: "difficulty",
                table: "BoardGames",
                newName: "Difficulty");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "BoardGames",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "BoardGames",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "ImageLocation",
                table: "BoardGames",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageLocation",
                table: "BoardGames");

            migrationBuilder.RenameColumn(
                name: "Tags",
                table: "BoardGames",
                newName: "tags");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "BoardGames",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "MinPlayers",
                table: "BoardGames",
                newName: "minPlayers");

            migrationBuilder.RenameColumn(
                name: "MaxPlayers",
                table: "BoardGames",
                newName: "maxPlayers");

            migrationBuilder.RenameColumn(
                name: "Difficulty",
                table: "BoardGames",
                newName: "difficulty");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "BoardGames",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "BoardGames",
                newName: "id");

            migrationBuilder.AddColumn<int>(
                name: "imageId",
                table: "BoardGames",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BoardGames_imageId",
                table: "BoardGames",
                column: "imageId");

            migrationBuilder.AddForeignKey(
                name: "FK_BoardGames_Images_imageId",
                table: "BoardGames",
                column: "imageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
