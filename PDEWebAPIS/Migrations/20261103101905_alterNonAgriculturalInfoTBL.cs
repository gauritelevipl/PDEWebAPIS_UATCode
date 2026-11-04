using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PDEWebAPIS.Migrations
{
    /// <inheritdoc />
    public partial class alterNonAgriculturalInfoTBL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "isdeleted",
                table: "non_agricultural_info",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean");

            //migrationBuilder.AlterColumn<DateOnly>(
            //    name: "deleteddate",
            //    table: "non_agricultural_info",
            //    type: "date",
            //    nullable: false,
            //    defaultValueSql: "1900-01-01",
            //    oldClrType: typeof(DateOnly),
            //    oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "createddatetime",
                table: "non_agricultural_info",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "current_timestamp",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "isdeleted",
                table: "non_agricultural_info",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldDefaultValue: false);

            //migrationBuilder.AlterColumn<DateOnly>(
            //    name: "deleteddate",
            //    table: "non_agricultural_info",
            //    type: "date",
            //    nullable: false,
            //    oldClrType: typeof(DateOnly),
            //    oldType: "date",
            //    oldDefaultValueSql: "1900-01-01");

            migrationBuilder.AlterColumn<DateTime>(
                name: "createddatetime",
                table: "non_agricultural_info",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "current_timestamp");
        }
    }
}
