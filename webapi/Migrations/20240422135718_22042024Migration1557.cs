using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapi.Migrations
{
    /// <inheritdoc />
    public partial class _22042024Migration1557 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumeroCategoria",
                table: "Categories");

            migrationBuilder.AddColumn<string>(
                name: "DescrizioneCategoria",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImmagineCategoria",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescrizioneCategoria",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ImmagineCategoria",
                table: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "NumeroCategoria",
                table: "Categories",
                type: "int",
                nullable: true);
        }
    }
}
