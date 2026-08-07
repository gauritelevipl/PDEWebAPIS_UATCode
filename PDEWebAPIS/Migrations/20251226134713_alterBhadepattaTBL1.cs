using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PDEWebAPIS.Migrations
{
    /// <inheritdoc />
    public partial class alterBhadepattaTBL1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.RenameColumn(
            //    name: "leasePeriod",
            //    table: "bhadepattaInfoDtl",
            //    newName: "leaseperiod");

            migrationBuilder.AlterColumn<string>(
                name: "bhadepattaToDate",
                table: "bhadepattaInfoDtl",
                type: "text",
                nullable: true,
                defaultValue: "NA",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "bhadepattaFromDate",
                table: "bhadepattaInfoDtl",
                type: "text",
                nullable: true,
                defaultValue: "NA",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "leaseperiod",
                table: "bhadepattaInfoDtl",
                newName: "leasePeriod");

            migrationBuilder.AlterColumn<DateTime>(
                name: "bhadepattaToDate",
                table: "bhadepattaInfoDtl",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true,
                oldDefaultValue: "NA");

            migrationBuilder.AlterColumn<DateTime>(
                name: "bhadepattaFromDate",
                table: "bhadepattaInfoDtl",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true,
                oldDefaultValue: "NA");
        }
    }
}
