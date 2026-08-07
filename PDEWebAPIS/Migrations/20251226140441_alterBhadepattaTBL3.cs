using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PDEWebAPIS.Migrations
{
    /// <inheritdoc />
    public partial class alterBhadepattaTBL3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "leaseperiod",
                table: "bhadepattaInfoDtl",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true,
                oldDefaultValue: "YES");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "leaseperiod",
                table: "bhadepattaInfoDtl",
                type: "text",
                nullable: true,
                defaultValue: "YES",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }
    }
}
