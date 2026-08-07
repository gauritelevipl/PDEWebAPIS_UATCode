using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PDEWebAPIS.Migrations
{
    /// <inheritdoc />
    public partial class GrievanceTBLS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "grievanceReasonMaster",
            //    columns: table => new
            //    {
            //        rid = table.Column<int>(type: "integer", nullable: false)
            //            .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            //        reasonName = table.Column<string>(type: "text", nullable: false),
            //        reasonCode = table.Column<int>(type: "integer", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_grievanceReasonMaster", x => x.rid);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "grievanceStatusMaster",
            //    columns: table => new
            //    {
            //        statusId = table.Column<int>(type: "integer", nullable: false)
            //            .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            //        status = table.Column<string>(type: "text", nullable: false),
            //        statusCode = table.Column<int>(type: "integer", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_grievanceStatusMaster", x => x.statusId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "grievancetbl",
            //    columns: table => new
            //    {
            //        Gid = table.Column<int>(type: "integer", nullable: false)
            //            .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            //        userId = table.Column<int>(type: "integer", nullable: false),
            //        applicationId = table.Column<string>(type: "text", nullable: false),
            //        mutationName = table.Column<string>(type: "text", nullable: false),
            //        mutationCode = table.Column<int>(type: "integer", nullable: false),
            //        issueCategory = table.Column<string>(type: "text", nullable: false),
            //        grivanceStatus = table.Column<string>(type: "text", nullable: false),
            //        issueReportDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
            //        issueDesc = table.Column<string>(type: "text", nullable: false),
            //        docPath = table.Column<string>(type: "text", nullable: false),
            //        docTitle = table.Column<string>(type: "text", nullable: false),
            //        tickitId = table.Column<string>(type: "text", nullable: false),
            //        AssignIssueTo = table.Column<string>(type: "text", nullable: false),
            //        priority = table.Column<string>(type: "text", nullable: false),
            //        IsDeleted = table.Column<string>(type: "text", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_grievancetbl", x => x.Gid);
            //    });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "grievanceReasonMaster");

            //migrationBuilder.DropTable(
            //    name: "grievanceStatusMaster");

            //migrationBuilder.DropTable(
            //    name: "grievancetbl");
        }
    }
}
