using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PDEWebAPIS.Migrations
{
    /// <inheritdoc />
    public partial class addingcolintoissuedatestable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<string>(
            //    name: "IssueReassignedtoUserId",
            //    table: "grievanceIssueDatesDetails",
            //    type: "text",
            //    nullable: true);

            //migrationBuilder.AddColumn<string>(
            //    name: "IssueResolvedbyUserId",
            //    table: "grievanceIssueDatesDetails",
            //    type: "text",
            //    nullable: true);

            //migrationBuilder.AddColumn<string>(
            //    name: "IssueSeenbyUserId",
            //    table: "grievanceIssueDatesDetails",
            //    type: "text",
            //    nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "IssueReassignedtoUserId",
            //    table: "grievanceIssueDatesDetails");

            //migrationBuilder.DropColumn(
            //    name: "IssueResolvedbyUserId",
            //    table: "grievanceIssueDatesDetails");

            //migrationBuilder.DropColumn(
            //    name: "IssueSeenbyUserId",
            //    table: "grievanceIssueDatesDetails");
        }
    }
}
