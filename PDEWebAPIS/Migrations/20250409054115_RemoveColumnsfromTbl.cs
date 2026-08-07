using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PDEWebAPIS.Migrations
{
    /// <inheritdoc />
    public partial class RemoveColumnsfromTbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //   name: "IssueResolvedbyID",
            //   table: "grievancetbl");

            //migrationBuilder.DropColumn(
            //    name: "IssueResolvedbyName",
            //    table: "grievancetbl");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
