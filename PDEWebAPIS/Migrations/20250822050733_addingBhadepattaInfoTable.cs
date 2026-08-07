using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PDEWebAPIS.Migrations
{
    /// <inheritdoc />
    public partial class addingBhadepattaInfoTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AlterColumn<string>(
            //    name: "region_name",
            //    table: "GrievanceUserMaster",
            //    type: "text",
            //    nullable: true,
            //    defaultValue: "NA",
            //    oldClrType: typeof(string),
            //    oldType: "text",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "region_english_name",
            //    table: "GrievanceUserMaster",
            //    type: "text",
            //    nullable: true,
            //    defaultValue: "NA",
            //    oldClrType: typeof(string),
            //    oldType: "text",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "region_code",
            //    table: "GrievanceUserMaster",
            //    type: "text",
            //    nullable: true,
            //    defaultValue: "0",
            //    oldClrType: typeof(string),
            //    oldType: "text",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "district_name",
            //    table: "GrievanceUserMaster",
            //    type: "text",
            //    nullable: true,
            //    defaultValue: "NA",
            //    oldClrType: typeof(string),
            //    oldType: "text",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "district_english_name",
            //    table: "GrievanceUserMaster",
            //    type: "text",
            //    nullable: true,
            //    defaultValue: "NA",
            //    oldClrType: typeof(string),
            //    oldType: "text",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "district_code",
            //    table: "GrievanceUserMaster",
            //    type: "text",
            //    nullable: true,
            //    defaultValue: "0",
            //    oldClrType: typeof(string),
            //    oldType: "text",
            //    oldNullable: true);

            //migrationBuilder.CreateTable(
            //    name: "application_data_submitted_history",
            //    columns: table => new
            //    {
            //        application_data_submitted_history_id = table.Column<int>(type: "integer", nullable: false)
            //            .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            //        applicationid = table.Column<string>(type: "text", nullable: true),
            //        application_submitted_form_name = table.Column<string>(type: "text", nullable: true),
            //        mutation_type_code = table.Column<string>(type: "text", nullable: true),
            //        mutation_type_name = table.Column<string>(type: "text", nullable: true),
            //        application_submitted_type = table.Column<string>(type: "text", nullable: true),
            //        createddatetime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "current_timestamp")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_application_data_submitted_history", x => x.application_data_submitted_history_id);
            //        table.CheckConstraint("CK_application_submitted_type", "(application_submitted_type='WEB' OR application_submitted_type='MOBILE')");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "bhadepattaInfoDtl",
            //    columns: table => new
            //    {
            //        Info_id = table.Column<int>(type: "integer", nullable: false)
            //            .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            //        userid = table.Column<int>(type: "integer", nullable: false),
            //        village_code = table.Column<string>(type: "text", nullable: true),
            //        ctsNo = table.Column<string>(type: "text", nullable: true),
            //        mutationSroNo = table.Column<string>(type: "text", nullable: true),
            //        ownerNo = table.Column<string>(type: "text", nullable: true),
            //        applicationid = table.Column<string>(type: "text", nullable: true),
            //        bhadepattaTenureYear = table.Column<string>(type: "text", nullable: true),
            //        bhadepattaTenureMonth = table.Column<string>(type: "text", nullable: true),
            //        bhadepattaFromDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
            //        bhadepattaToDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
            //        bhadepattaAmount = table.Column<string>(type: "text", nullable: true),
            //        createdDateTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true, defaultValueSql: "current_timestamp"),
            //        isDeleted = table.Column<bool>(type: "boolean", nullable: true, defaultValueSql: "false"),
            //        deletedDateTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true, defaultValueSql: "'1900-01-01 00:00:00 UTC'::timestamptz")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_bhadepattaInfoDtl", x => x.Info_id);
            //    });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "application_data_submitted_history");

            //migrationBuilder.DropTable(
            //    name: "bhadepattaInfoDtl");

            //migrationBuilder.AlterColumn<string>(
            //    name: "region_name",
            //    table: "GrievanceUserMaster",
            //    type: "text",
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "text",
            //    oldNullable: true,
            //    oldDefaultValue: "NA");

            //migrationBuilder.AlterColumn<string>(
            //    name: "region_english_name",
            //    table: "GrievanceUserMaster",
            //    type: "text",
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "text",
            //    oldNullable: true,
            //    oldDefaultValue: "NA");

            //migrationBuilder.AlterColumn<string>(
            //    name: "region_code",
            //    table: "GrievanceUserMaster",
            //    type: "text",
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "text",
            //    oldNullable: true,
            //    oldDefaultValue: "0");

            //migrationBuilder.AlterColumn<string>(
            //    name: "district_name",
            //    table: "GrievanceUserMaster",
            //    type: "text",
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "text",
            //    oldNullable: true,
            //    oldDefaultValue: "NA");

            //migrationBuilder.AlterColumn<string>(
            //    name: "district_english_name",
            //    table: "GrievanceUserMaster",
            //    type: "text",
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "text",
            //    oldNullable: true,
            //    oldDefaultValue: "NA");

            //migrationBuilder.AlterColumn<string>(
            //    name: "district_code",
            //    table: "GrievanceUserMaster",
            //    type: "text",
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "text",
            //    oldNullable: true,
            //    oldDefaultValue: "0");
        }
    }
}
