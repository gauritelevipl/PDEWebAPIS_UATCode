using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PDEWebAPIS.Migrations
{
    /// <inheritdoc />
    public partial class addSecondaryMobNoCol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<string>(
            //    name: "secondaryMoNo",
            //    table: "grievancetbl",
            //    type: "text",
            //    nullable: false,
            //    defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "secondaryMoNo",
            //    table: "grievancetbl");
        }
    }
}
