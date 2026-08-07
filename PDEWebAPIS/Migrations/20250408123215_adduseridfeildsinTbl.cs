using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PDEWebAPIS.Migrations
{
    /// <inheritdoc />
    public partial class adduseridfeildsinTbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<string>(
            //    name: "IssueReassignedUserId",
            //    table: "grievanceIssueDatesDetails",
            //    type: "text",
            //    nullable: true);

            //migrationBuilder.AddColumn<string>(
            //    name: "IssueResolvedUserId",
            //    table: "grievanceIssueDatesDetails",
            //    type: "text",
            //    nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "IssueReassignedUserId",
            //    table: "grievanceIssueDatesDetails");

            //migrationBuilder.DropColumn(
            //    name: "IssueResolvedUserId",
            //    table: "grievanceIssueDatesDetails");
        }
    }
}
