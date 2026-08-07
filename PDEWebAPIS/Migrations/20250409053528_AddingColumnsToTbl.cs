using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PDEWebAPIS.Migrations
{
    /// <inheritdoc />
    public partial class AddingColumnsToTbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "IssueResolvedbyID",
            //    table: "grievancetbl");

            //migrationBuilder.DropColumn(
            //    name: "IssueResolvedbyName",
            //    table: "grievancetbl");

            //migrationBuilder.AddColumn<string>(
            //    name: "IssueResolvedbyID",
            //    table: "grievancetbl",
            //    type: "text",
            //    nullable: true);

            //migrationBuilder.AddColumn<string>(
            //    name: "IssueResolvedbyName",
            //    table: "grievancetbl",
            //    type: "text",
            //    nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn( 
              
            //    name: "IssueResolvedbyID",
            //    table: "grievancetbl");

            //migrationBuilder.DropColumn(
            //    name: "IssueResolvedbyName",
            //    table: "grievancetbl");

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
    }
}
