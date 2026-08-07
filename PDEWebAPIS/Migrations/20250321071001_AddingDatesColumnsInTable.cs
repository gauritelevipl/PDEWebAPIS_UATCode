using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PDEWebAPIS.Migrations
{
    /// <inheritdoc />
    public partial class AddingDatesColumnsInTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "registerdatetime",
            //    table: "GrievanceUserMaster",
            //    type: "timestamp with time zone",
            //    nullable: false,
            //    defaultValueSql: "current_timestamp",
            //    oldClrType: typeof(DateTime),
            //    oldType: "timestamp with time zone");

            //migrationBuilder.AddColumn<DateTime>(
            //    name: "IssueAssignDateTime",
            //    table: "grievancetbl",
            //    type: "timestamp with time zone",
            //    nullable: false,
            //    defaultValueSql: "'1900-01-01 00:00:00'::timestamp");

            //migrationBuilder.AddColumn<string>(
            //    name: "IssueClosedBy",
            //    table: "grievancetbl",
            //    type: "text",
            //    nullable: false,
            //    defaultValue: "");

            //migrationBuilder.AddColumn<DateTime>(
            //    name: "IssueReassignedDateTime",
            //    table: "grievancetbl",
            //    type: "timestamp with time zone",
            //    nullable: false,
            //    defaultValueSql: "'1900-01-01 00:00:00'::timestamp");

            //migrationBuilder.AddColumn<DateTime>(
            //    name: "IssueResolvedDateTime",
            //    table: "grievancetbl",
            //    type: "timestamp with time zone",
            //    nullable: false,
            //    defaultValueSql: "'1900-01-01 00:00:00'::timestamp");

           

            //migrationBuilder.DropColumn(
            //   name: "SeenDateTime",
            //   table: "grievancetbl");

            //migrationBuilder.AddColumn<string>(
            //    name: "district_code",
            //    table: "grievancetbl",
            //    type: "text",
            //    nullable: false,
            //    defaultValue: "");

            //migrationBuilder.AddColumn<string>(
            //    name: "district_name_in_marathi",
            //    table: "grievancetbl",
            //    type: "text",
            //    nullable: false,
            //    defaultValue: "");

            //migrationBuilder.AddColumn<string>(
            //    name: "taluka_code",
            //    table: "grievancetbl",
            //    type: "text",
            //    nullable: false,
            //    defaultValue: "");

            //migrationBuilder.AddColumn<string>(
            //    name: "taluka_name",
            //    table: "grievancetbl",
            //    type: "text",
            //    nullable: false,
            //    defaultValue: "");

            //migrationBuilder.CreateTable(
            //    name: "blacklisttokenforgrievance",
            //    columns: table => new
            //    {
            //        blacklistId = table.Column<int>(type: "integer", nullable: false)
            //            .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            //        Token = table.Column<string>(type: "text", nullable: false),
            //        ExpirationTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
            //        createdDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "current_timestamp")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_blacklisttokenforgrievance", x => x.blacklistId);
            //    });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "blacklisttokenforgrievance");

            //migrationBuilder.DropColumn(
            //    name: "IssueAssignDateTime",
            //    table: "grievancetbl");

            //migrationBuilder.DropColumn(
            //    name: "IssueClosedBy",
            //    table: "grievancetbl");

            //migrationBuilder.DropColumn(
            //    name: "IssueReassignedDateTime",
            //    table: "grievancetbl");

            //migrationBuilder.DropColumn(
            //    name: "IssueResolvedDateTime",
            //    table: "grievancetbl");

            //migrationBuilder.AddColumn<DateTime>(
            //    name: "IssueSeenDateTime",
            //    table: "grievancetbl",
            //    type: "timestamp with time zone",
            //    nullable: false,
            //    defaultValueSql: "'1900-01-01 00:00:00'::timestamp");

            //migrationBuilder.DropColumn(
            //    name: "district_code",
            //    table: "grievancetbl");

            //migrationBuilder.DropColumn(
            //    name: "district_name_in_marathi",
            //    table: "grievancetbl");

            //migrationBuilder.DropColumn(
            //    name: "taluka_code",
            //    table: "grievancetbl");

            //migrationBuilder.DropColumn(
            //    name: "taluka_name",
            //    table: "grievancetbl");

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "registerdatetime",
            //    table: "GrievanceUserMaster",
            //    type: "timestamp with time zone",
            //    nullable: false,
            //    oldClrType: typeof(DateTime),
            //    oldType: "timestamp with time zone",
            //    oldDefaultValueSql: "current_timestamp");
        }
    }
}
