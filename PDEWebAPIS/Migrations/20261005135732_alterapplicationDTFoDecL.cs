using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PDEWebAPIS.Migrations
{
    /// <inheritdoc />
    public partial class alterapplicationDTFoDecL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "declarationentryids",
                table: "applicationdtl",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "declarationentryids",
                table: "applicationdtl");
        }
    }
}
