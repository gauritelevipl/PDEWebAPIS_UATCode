using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PDEWebAPIS.Migrations
{
    /// <inheritdoc />
    public partial class alterTableDatesDetails : Migration
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

            //migrationBuilder.DropColumn(
            //    name: "IssueAssignDateTime",
            //    table: "grievanceIssueDatesDetails");

            //migrationBuilder.DropColumn(
            //    name: "IssueReassignedDateTime",
            //    table: "grievanceIssueDatesDetails");

            //migrationBuilder.DropColumn(
            //    name: "IssueReassignedtoUserId",
            //    table: "grievanceIssueDatesDetails");

            //migrationBuilder.DropColumn(
            //    name: "IssueResolvedDateTime",
            //    table: "grievanceIssueDatesDetails");

            //migrationBuilder.DropColumn(
            //    name: "IssueResolvedbyUserId",
            //    table: "grievanceIssueDatesDetails");

            //migrationBuilder.DropColumn(
            //    name: "IssueSeenbyUserId",
            //    table: "grievanceIssueDatesDetails");

            //migrationBuilder.RenameColumn(
            //    name: "LoginUserId",
            //    table: "grievanceIssueDatesDetails",
            //    newName: "PerformByUserId");

            //migrationBuilder.RenameColumn(
            //    name: "IssueSeenDateTime",
            //    table: "grievanceIssueDatesDetails",
            //    newName: "StatusDatetime");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.RenameColumn(
            //    name: "StatusDatetime",
            //    table: "grievanceIssueDatesDetails",
            //    newName: "IssueSeenDateTime");

            //migrationBuilder.RenameColumn(
            //    name: "PerformByUserId",
            //    table: "grievanceIssueDatesDetails",
            //    newName: "LoginUserId");

            ////migrationBuilder.AddColumn<string>(
            ////    name: "IssueResolvedbyID",
            ////    table: "grievancetbl",
            ////    type: "text",
            ////    nullable: true);

            ////migrationBuilder.AddColumn<string>(
            ////    name: "IssueResolvedbyName",
            ////    table: "grievancetbl",
            ////    type: "text",
            ////    nullable: true);

            //migrationBuilder.AddColumn<DateTime>(
            //    name: "IssueAssignDateTime",
            //    table: "grievanceIssueDatesDetails",
            //    type: "timestamp with time zone",
            //    nullable: false,
            //    defaultValueSql: "'1900-01-01 00:00:00 UTC'::timestamptz");

            //migrationBuilder.AddColumn<DateTime>(
            //    name: "IssueReassignedDateTime",
            //    table: "grievanceIssueDatesDetails",
            //    type: "timestamp with time zone",
            //    nullable: false,
            //    defaultValueSql: "'1900-01-01 00:00:00 UTC'::timestamptz");

            //migrationBuilder.AddColumn<string>(
            //    name: "IssueReassignedtoUserId",
            //    table: "grievanceIssueDatesDetails",
            //    type: "text",
            //    nullable: true);

            //migrationBuilder.AddColumn<DateTime>(
            //    name: "IssueResolvedDateTime",
            //    table: "grievanceIssueDatesDetails",
            //    type: "timestamp with time zone",
            //    nullable: false,
            //    defaultValueSql: "'1900-01-01 00:00:00 UTC'::timestamptz");

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
    }
}
