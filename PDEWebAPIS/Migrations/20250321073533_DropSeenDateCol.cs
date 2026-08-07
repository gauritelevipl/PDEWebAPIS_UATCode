using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PDEWebAPIS.Migrations
{
    /// <inheritdoc />
    public partial class DropSeenDateCol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            //migrationBuilder.DropColumn(
            //   name: "SeenDateTime",
            //   table: "grievancetbl");

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "IssueSeenDateTime",
            //    table: "grievancetbl",
            //    type: "timestamp with time zone",
            //    nullable: false,
            //    defaultValueSql: "'1900-01-01 00:00:00'::timestamp",
            //    oldClrType: typeof(DateTime),
            //    oldType: "timestamp with time zone",
            //    oldDefaultValueSql: "1900-01-01");

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "IssueResolvedDateTime",
            //    table: "grievancetbl",
            //    type: "timestamp with time zone",
            //    nullable: false,
            //    defaultValueSql: "'1900-01-01 00:00:00'::timestamp",
            //    oldClrType: typeof(DateTime),
            //    oldType: "timestamp with time zone",
            //    oldDefaultValueSql: "1900-01-01");

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "IssueReassignedDateTime",
            //    table: "grievancetbl",
            //    type: "timestamp with time zone",
            //    nullable: false,
            //    defaultValueSql: "'1900-01-01 00:00:00'::timestamp",
            //    oldClrType: typeof(DateTime),
            //    oldType: "timestamp with time zone",
            //    oldDefaultValueSql: "1900-01-01");

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "IssueAssignDateTime",
            //    table: "grievancetbl",
            //    type: "timestamp with time zone",
            //    nullable: false,
            //    defaultValueSql: "'1900-01-01 00:00:00'::timestamp",
            //    oldClrType: typeof(DateTime),
            //    oldType: "timestamp with time zone",
            //    oldDefaultValueSql: "1900-01-01");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "IssueSeenDateTime",
            //    table: "grievancetbl",
            //    type: "timestamp with time zone",
            //    nullable: false,
            //    defaultValueSql: "1900-01-01",
            //    oldClrType: typeof(DateTime),
            //    oldType: "timestamp with time zone",
            //    oldDefaultValueSql: "'1900-01-01 00:00:00'::timestamp");

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "IssueResolvedDateTime",
            //    table: "grievancetbl",
            //    type: "timestamp with time zone",
            //    nullable: false,
            //    defaultValueSql: "1900-01-01",
            //    oldClrType: typeof(DateTime),
            //    oldType: "timestamp with time zone",
            //    oldDefaultValueSql: "'1900-01-01 00:00:00'::timestamp");

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "IssueReassignedDateTime",
            //    table: "grievancetbl",
            //    type: "timestamp with time zone",
            //    nullable: false,
            //    defaultValueSql: "1900-01-01",
            //    oldClrType: typeof(DateTime),
            //    oldType: "timestamp with time zone",
            //    oldDefaultValueSql: "'1900-01-01 00:00:00'::timestamp");

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "IssueAssignDateTime",
            //    table: "grievancetbl",
            //    type: "timestamp with time zone",
            //    nullable: false,
            //    defaultValueSql: "1900-01-01",
            //    oldClrType: typeof(DateTime),
            //    oldType: "timestamp with time zone",
            //    oldDefaultValueSql: "'1900-01-01 00:00:00'::timestamp");
        }
    }
}
