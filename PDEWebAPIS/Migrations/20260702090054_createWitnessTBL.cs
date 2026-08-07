using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PDEWebAPIS.Migrations
{
    /// <inheritdoc />
    public partial class createWitnessTBL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "witnessids",
                table: "applicationdtl",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "witness_info",
                columns: table => new
                {
                    witness_info_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    userMasteruserid = table.Column<int>(type: "integer", nullable: true),
                    applicationDTLapplicationid = table.Column<string>(type: "text", nullable: true),
                    permission_no = table.Column<string>(type: "text", nullable: true, defaultValue: "NA"),
                    permission_date = table.Column<string>(type: "text", nullable: true, defaultValue: "NA"),
                    prefixcode_marathi = table.Column<string>(type: "text", nullable: true),
                    prefix_in_marathi = table.Column<string>(type: "text", nullable: true),
                    fname_in_marathi = table.Column<string>(type: "text", nullable: true),
                    mname_in_marathi = table.Column<string>(type: "text", nullable: true),
                    lname_in_marathi = table.Column<string>(type: "text", nullable: true),
                    prefixcode_eng = table.Column<string>(type: "text", nullable: true),
                    prefix_in_eng = table.Column<string>(type: "text", nullable: true),
                    fname_in_eng = table.Column<string>(type: "text", nullable: true),
                    mname_in_eng = table.Column<string>(type: "text", nullable: true),
                    lname_in_eng = table.Column<string>(type: "text", nullable: true),
                    alias_name = table.Column<string>(type: "text", nullable: true),
                    address_type = table.Column<string>(type: "text", nullable: true, defaultValue: "NA"),
                    address = table.Column<string>(type: "text", nullable: true),
                    state = table.Column<string>(type: "text", nullable: true),
                    district = table.Column<string>(type: "text", nullable: true),
                    taluka = table.Column<string>(type: "text", nullable: true),
                    city = table.Column<string>(type: "text", nullable: true),
                    flatno_plotno = table.Column<string>(type: "text", nullable: true),
                    societyname = table.Column<string>(type: "text", nullable: true),
                    mainstreet = table.Column<string>(type: "text", nullable: true),
                    landmark = table.Column<string>(type: "text", nullable: true),
                    locality = table.Column<string>(type: "text", nullable: true),
                    pincode = table.Column<string>(type: "text", nullable: true),
                    post_office_name = table.Column<string>(type: "text", nullable: true),
                    address_proof_document_name = table.Column<string>(type: "text", nullable: true),
                    address_proof_document_path = table.Column<string>(type: "text", nullable: true),
                    mobileno = table.Column<string>(type: "text", nullable: true),
                    mobilenoverified = table.Column<string>(type: "text", nullable: true),
                    emailid = table.Column<string>(type: "text", nullable: true),
                    emailidverified = table.Column<string>(type: "text", nullable: true),
                    createddatetime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "current_timestamp"),
                    isDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    deleteddate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_witness_info", x => x.witness_info_id);
                    table.ForeignKey(
                        name: "FK_witness_info_applicationdtl_applicationDTLapplicationid",
                        column: x => x.applicationDTLapplicationid,
                        principalTable: "applicationdtl",
                        principalColumn: "applicationid");
                    table.ForeignKey(
                        name: "FK_witness_info_usermaster_userMasteruserid",
                        column: x => x.userMasteruserid,
                        principalTable: "usermaster",
                        principalColumn: "userid");
                });

            migrationBuilder.CreateIndex(
                name: "IX_witness_info_applicationDTLapplicationid",
                table: "witness_info",
                column: "applicationDTLapplicationid");

            migrationBuilder.CreateIndex(
                name: "IX_witness_info_userMasteruserid",
                table: "witness_info",
                column: "userMasteruserid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "witness_info");

            migrationBuilder.DropColumn(
                name: "witnessids",
                table: "applicationdtl");
        }
    }
}
