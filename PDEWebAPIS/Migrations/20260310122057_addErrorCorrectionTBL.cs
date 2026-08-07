using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PDEWebAPIS.Migrations
{
    /// <inheritdoc />
    public partial class addErrorCorrectionTBL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "errorcorrectiondtls",
            //    columns: table => new
            //    {
            //        error_correction_id = table.Column<int>(type: "integer", nullable: false)
            //            .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            //        userMasteruserid = table.Column<int>(type: "integer", nullable: true),
            //        applicationDTLapplicationid = table.Column<string>(type: "text", nullable: true),
            //        village_code = table.Column<string>(type: "text", nullable: true),
            //        sub_property_no = table.Column<string>(type: "text", nullable: true),
            //        city_servey_no = table.Column<string>(type: "text", nullable: true),
            //        lr_property_id = table.Column<string>(type: "text", nullable: true),
            //        milkat = table.Column<string>(type: "text", nullable: true),
            //        namud = table.Column<string>(type: "text", nullable: true),
            //        var_village_code = table.Column<string>(type: "text", nullable: true),
            //        var_cts_number = table.Column<string>(type: "text", nullable: true),
            //        var_cts_puid = table.Column<string>(type: "text", nullable: true),
            //        var_mutation_srno = table.Column<string>(type: "text", nullable: true),
            //        var_entry_date = table.Column<string>(type: "text", nullable: true),
            //        var_mutation_number = table.Column<string>(type: "text", nullable: true),
            //        var_mutation_date = table.Column<string>(type: "text", nullable: true),
            //        var_sro_office_name_marathi = table.Column<string>(type: "text", nullable: true),
            //        var_sro_office_name_english = table.Column<string>(type: "text", nullable: true),
            //        var_document_number = table.Column<string>(type: "text", nullable: true),
            //        var_document_year = table.Column<string>(type: "text", nullable: true),
            //        var_document_date = table.Column<string>(type: "text", nullable: true),
            //        var_entry_details = table.Column<string>(type: "text", nullable: true),
            //        var_owner_details = table.Column<string>(type: "text", nullable: true),
            //        reason = table.Column<string>(type: "text", nullable: true),
            //        address_type = table.Column<string>(type: "text", nullable: true),
            //        emailid = table.Column<string>(type: "text", nullable: true),
            //        mobileno = table.Column<string>(type: "text", nullable: true),
            //        mobilenoverified = table.Column<string>(type: "text", nullable: true),
            //        address = table.Column<string>(type: "text", nullable: true),
            //        state = table.Column<string>(type: "text", nullable: true),
            //        district = table.Column<string>(type: "text", nullable: true),
            //        taluka = table.Column<string>(type: "text", nullable: true),
            //        city = table.Column<string>(type: "text", nullable: true),
            //        flatno_plotno = table.Column<string>(type: "text", nullable: true),
            //        societyname = table.Column<string>(type: "text", nullable: true),
            //        mainstreet = table.Column<string>(type: "text", nullable: true),
            //        landmark = table.Column<string>(type: "text", nullable: true),
            //        locality = table.Column<string>(type: "text", nullable: true),
            //        pincode = table.Column<string>(type: "text", nullable: true),
            //        post_office_name = table.Column<string>(type: "text", nullable: true),
            //        address_proof_document_name = table.Column<string>(type: "text", nullable: true),
            //        address_proof_document_path = table.Column<string>(type: "text", nullable: true),
            //        createddatetime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "current_timestamp"),
            //        isDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
            //        //deleteddate = table.Column<DateOnly>(type: "date", nullable: false, defaultValueSql: "1900-01-01")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_errorcorrectiondtls", x => x.error_correction_id);
            //        table.ForeignKey(
            //            name: "FK_errorcorrectiondtls_applicationdtl_applicationDTLapplicatio~",
            //            column: x => x.applicationDTLapplicationid,
            //            principalTable: "applicationdtl",
            //            principalColumn: "applicationid");
            //        table.ForeignKey(
            //            name: "FK_errorcorrectiondtls_usermaster_userMasteruserid",
            //            column: x => x.userMasteruserid,
            //            principalTable: "usermaster",
            //            principalColumn: "userid");
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_errorcorrectiondtls_applicationDTLapplicationid",
            //    table: "errorcorrectiondtls",
            //    column: "applicationDTLapplicationid");

            //migrationBuilder.CreateIndex(
            //    name: "IX_errorcorrectiondtls_userMasteruserid",
            //    table: "errorcorrectiondtls",
            //    column: "userMasteruserid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "errorcorrectiondtls");
        }
    }
}
