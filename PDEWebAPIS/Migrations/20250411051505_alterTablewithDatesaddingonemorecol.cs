using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PDEWebAPIS.Migrations
{
    /// <inheritdoc />
    public partial class alterTablewithDatesaddingonemorecol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<string>(
            //    name: "IssueResolvedByUserid",
            //    table: "grievanceIssueDatesDetails",
            //    type: "text",
            //    nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "IssueResolvedByUserid",
            //    table: "grievanceIssueDatesDetails");
        }
    }
}
