using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PDEWebAPIS.Migrations
{
    /// <inheritdoc />
    public partial class removecolsFromBhadepattaInfoTbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "ctsNo",
            //    table: "bhadepattaInfoDtl");

            //migrationBuilder.DropColumn(
            //    name: "mutationSroNo",
            //    table: "bhadepattaInfoDtl");

            //migrationBuilder.DropColumn(
            //    name: "ownerNo",
            //    table: "bhadepattaInfoDtl");

            //migrationBuilder.DropColumn(
            //    name: "village_code",
            //    table: "bhadepattaInfoDtl");

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "deletedDateTime",
            //    table: "bhadepattaInfoDtl",
            //    type: "timestamp with time zone",
            //    nullable: true,
            //    defaultValueSql: "'1900-01-01 00:00:00 UTC'::timestamptz",
            //    oldClrType: typeof(bool),
            //    oldType: "boolean",
            //    oldNullable: true,
            //    oldDefaultValueSql: "'1900-01-01 00:00:00 UTC'::timestamptz");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
        //    migrationBuilder.AlterColumn<bool>(
        //        name: "deletedDateTime",
        //        table: "bhadepattaInfoDtl",
        //        type: "boolean",
        //        nullable: true,
        //        defaultValueSql: "'1900-01-01 00:00:00 UTC'::timestamptz",
        //        oldClrType: typeof(DateTime),
        //        oldType: "timestamp with time zone",
        //        oldNullable: true,
        //        oldDefaultValueSql: "'1900-01-01 00:00:00 UTC'::timestamptz");

        //    migrationBuilder.AddColumn<string>(
        //        name: "ctsNo",
        //        table: "bhadepattaInfoDtl",
        //        type: "text",
        //        nullable: true);

        //    migrationBuilder.AddColumn<string>(
        //        name: "mutationSroNo",
        //        table: "bhadepattaInfoDtl",
        //        type: "text",
        //        nullable: true);

        //    migrationBuilder.AddColumn<string>(
        //        name: "ownerNo",
        //        table: "bhadepattaInfoDtl",
        //        type: "text",
        //        nullable: true);

        //    migrationBuilder.AddColumn<string>(
        //        name: "village_code",
        //        table: "bhadepattaInfoDtl",
        //        type: "text",
        //        nullable: true);
        }
    }
}
