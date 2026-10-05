using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PDEWebAPIS.Migrations
{
    /// <inheritdoc />
    public partial class declarationentryinfoTBL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "declarationentryids",
                table: "applicationdtl",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "declaration_entry_info",
                columns: table => new
                {
                    declarationid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    userMasteruserid = table.Column<int>(type: "integer", nullable: true),
                    applicationDTLapplicationid = table.Column<string>(type: "text", nullable: true),
                    type_of_authority_approving_the_construction_plan_code = table.Column<int>(type: "integer", nullable: false),
                    type_of_authority_approving_the_construction_plan = table.Column<string>(type: "text", nullable: true),
                    company_name = table.Column<string>(type: "text", nullable: true, defaultValue: "NA"),
                    map_approval_order_no = table.Column<string>(type: "text", nullable: true),
                    map_approval_order_date = table.Column<string>(type: "text", nullable: true),
                    construction_start_cert_no = table.Column<string>(type: "text", nullable: true),
                    construction_start_cert_date = table.Column<string>(type: "text", nullable: true),
                    occupancy_certificate_file_name = table.Column<string>(type: "text", nullable: true),
                    occupancy_certificate_file_path = table.Column<string>(type: "text", nullable: true),
                    occupancy_certificate_date = table.Column<string>(type: "text", nullable: true),
                    createddatetime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "current_timestamp"),
                    isDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    //deleteddate = table.Column<DateOnly>(type: "date", nullable: false, defaultValueSql: "1900-01-01")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_declaration_entry_info", x => x.declarationid);
                    table.ForeignKey(
                        name: "FK_declaration_entry_info_applicationdtl_applicationDTLapplica~",
                        column: x => x.applicationDTLapplicationid,
                        principalTable: "applicationdtl",
                        principalColumn: "applicationid");
                    table.ForeignKey(
                        name: "FK_declaration_entry_info_usermaster_userMasteruserid",
                        column: x => x.userMasteruserid,
                        principalTable: "usermaster",
                        principalColumn: "userid");
                });

            migrationBuilder.CreateIndex(
                name: "IX_declaration_entry_info_applicationDTLapplicationid",
                table: "declaration_entry_info",
                column: "applicationDTLapplicationid");

            migrationBuilder.CreateIndex(
                name: "IX_declaration_entry_info_userMasteruserid",
                table: "declaration_entry_info",
                column: "userMasteruserid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "declaration_entry_info");

            migrationBuilder.DropColumn(
                name: "declarationentryids",
                table: "applicationdtl");
        }
    }
}
