using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PDEWebAPIS.Migrations
{
    /// <inheritdoc />
    public partial class addingDatewiseGrievancetbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "grievanceIssueDatesDetails",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "integer", nullable: false)
            //            .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            //        grievancetblGid = table.Column<int>(type: "integer", nullable: false),
            //        IssueSeenDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "'1900-01-01 00:00:00 UTC'::timestamptz"),
            //        IssueAssignDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "'1900-01-01 00:00:00 UTC'::timestamptz"),
            //        IssueResolvedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "'1900-01-01 00:00:00 UTC'::timestamptz"),
            //        IssueReassignedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "'1900-01-01 00:00:00 UTC'::timestamptz"),
            //        Datetime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "current_timestamp")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_grievanceIssueDatesDetails", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_grievanceIssueDatesDetails_grievancetbl_grievancetblGid",
            //            column: x => x.grievancetblGid,
            //            principalTable: "grievancetbl",
            //            principalColumn: "Gid",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_grievanceIssueDatesDetails_grievancetblGid",
            //    table: "grievanceIssueDatesDetails",
            //    column: "grievancetblGid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "grievanceIssueDatesDetails");
        }
    }
}
