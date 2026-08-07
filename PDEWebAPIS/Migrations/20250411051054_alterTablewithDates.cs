using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PDEWebAPIS.Migrations
{
    /// <inheritdoc />
    public partial class alterTablewithDates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //    migrationBuilder.AddColumn<string>(
            //        name: "IssueAssignToUserId",
            //        table: "grievanceIssueDatesDetails",
            //        type: "text",
            //        nullable: true);

            //    migrationBuilder.AddColumn<string>(
            //        name: "IssueReassignToUserId",
            //        table: "grievanceIssueDatesDetails",
            //        type: "text",
            //        nullable: true);

            //    migrationBuilder.AddColumn<string>(
            //        name: "IssueSeenByUserId",
            //        table: "grievanceIssueDatesDetails",
            //        type: "text",
            //        nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "IssueAssignToUserId",
            //    table: "grievanceIssueDatesDetails");

            //migrationBuilder.DropColumn(
            //    name: "IssueReassignToUserId",
            //    table: "grievanceIssueDatesDetails");

            //migrationBuilder.DropColumn(
            //    name: "IssueSeenByUserId",
            //    table: "grievanceIssueDatesDetails");
        }
    }
}
