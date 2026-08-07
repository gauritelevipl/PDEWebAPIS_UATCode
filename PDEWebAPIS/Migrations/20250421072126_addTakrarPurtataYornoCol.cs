using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PDEWebAPIS.Migrations
{
    /// <inheritdoc />
    public partial class addTakrarPurtataYornoCol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<string>(
            //    name: "takrarPurtataStatusInYOrN",
            //    table: "grievancetbl",
            //    type: "text",
            //    nullable: true,
            //    defaultValue: "NA");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "takrarPurtataStatusInYOrN",
            //    table: "grievancetbl");
        }
    }
}
