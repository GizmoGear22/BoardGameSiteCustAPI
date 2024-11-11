using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class FixedNumPlayers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "numberOfPlayers",
                table: "BoardGames");

            migrationBuilder.AddColumn<int>(
                name: "maxPlayers",
                table: "BoardGames",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "minPlayers",
                table: "BoardGames",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "maxPlayers",
                table: "BoardGames");

            migrationBuilder.DropColumn(
                name: "minPlayers",
                table: "BoardGames");

            migrationBuilder.AddColumn<string>(
                name: "numberOfPlayers",
                table: "BoardGames",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");
        }
    }
}
