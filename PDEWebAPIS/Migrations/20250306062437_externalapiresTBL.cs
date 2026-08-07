using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PDEWebAPIS.Migrations
{
    /// <inheritdoc />
    public partial class externalapiresTBL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "issueReportDate",
            //    table: "grievancetbl",
            //    type: "timestamp with time zone",
            //    nullable: false,
            //    defaultValueSql: "current_timestamp",
            //    oldClrType: typeof(DateTime),
            //    oldType: "timestamp with time zone");

        //    migrationBuilder.CreateTable(
        //        name: "external_api_response",
        //        columns: table => new
        //        {
        //            ex_response_id = table.Column<int>(type: "integer", nullable: false)
        //                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
        //            applicationid = table.Column<string>(type: "text", nullable: true),
        //            vendorname = table.Column<string>(type: "text", nullable: true),
        //            api = table.Column<string>(type: "text", nullable: true),
        //            statuscode = table.Column<string>(type: "text", nullable: true),
        //            response = table.Column<string>(type: "text", nullable: true),
        //            createddatetime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "current_timestamp")
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_external_api_response", x => x.ex_response_id);
        //        });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "external_api_response");

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "issueReportDate",
            //    table: "grievancetbl",
            //    type: "timestamp with time zone",
            //    nullable: false,
            //    oldClrType: typeof(DateTime),
            //    oldType: "timestamp with time zone",
            //    oldDefaultValueSql: "current_timestamp");
        }
    }
}
