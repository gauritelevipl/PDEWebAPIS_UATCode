using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PDEWebAPIS.Migrations
{
    /// <inheritdoc />
    public partial class addTransactionTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "grievanceIssueTransactionDtl",
            //    columns: table => new
            //    {
            //        transactionId = table.Column<int>(type: "integer", nullable: false)
            //            .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            //        applicationId = table.Column<string>(type: "text", nullable: false),
            //        tickitId = table.Column<string>(type: "text", nullable: false),
            //        issueDescByUser = table.Column<string>(type: "text", nullable: false),
            //        reply = table.Column<string>(type: "text", nullable: false),
            //        replyUserid = table.Column<string>(type: "text", nullable: false),
            //        datetime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "current_timestamp")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_grievanceIssueTransactionDtl", x => x.transactionId);
            //    });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "grievanceIssueTransactionDtl");
        }
    }
}
