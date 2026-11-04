using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PDEWebAPIS.Migrations
{
    /// <inheritdoc />
    public partial class alterNonAgriculturalInfoTBLForFlag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "non_agricultural_flag",
                table: "non_agricultural_info",
                type: "text",
                nullable: true,
                defaultValue: "NONAGRICULTURALORDER");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "non_agricultural_flag",
                table: "non_agricultural_info");
        }
    }
}
