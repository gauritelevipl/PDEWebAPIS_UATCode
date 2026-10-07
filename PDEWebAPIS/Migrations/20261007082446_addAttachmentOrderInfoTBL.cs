using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PDEWebAPIS.Migrations
{
    /// <inheritdoc />
    public partial class addAttachmentOrderInfoTBL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "attachmentorderids",
                table: "applicationdtl",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "attachment_order_info",
                columns: table => new
                {
                    attachmentorderid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    userMasteruserid = table.Column<int>(type: "integer", nullable: true),
                    applicationDTLapplicationid = table.Column<string>(type: "text", nullable: true),
                    nabhu_no = table.Column<string>(type: "text", nullable: true),
                    mutation_srno = table.Column<string>(type: "text", nullable: true),
                    owner_number = table.Column<string>(type: "text", nullable: true),
                    owner_name = table.Column<string>(type: "text", nullable: true),
                    area = table.Column<string>(type: "text", nullable: true),
                    agencies_issuing_attachment_orders = table.Column<string>(type: "text", nullable: true),
                    name_of_the_agency_issuing_the_attachment_order = table.Column<string>(type: "text", nullable: true),
                    address_of_the_agency_issuing_the_attachment_order = table.Column<string>(type: "text", nullable: true),
                    attachment_order_number = table.Column<string>(type: "text", nullable: true),
                    date_of_the_attachment_order = table.Column<string>(type: "text", nullable: true),
                    is_the_attachment_order_issued_by_a_credit_society_or_a_bank = table.Column<string>(type: "text", nullable: true, defaultValue: "NO"),
                    recovery_cert_under_section_101_issued_by_the_cooperative_offi = table.Column<string>(name: "recovery_cert_under_section_101_issued_by_the_cooperative_offi~", type: "text", nullable: true, defaultValue: "NA"),
                    recovery_cert_issued_by_the_cooperative_officer_in_91 = table.Column<string>(type: "text", nullable: true, defaultValue: "NA"),
                    recovery_cert_for_105_issued_by_the_liquidator = table.Column<string>(type: "text", nullable: true, defaultValue: "NA"),
                    orbiter_order_no = table.Column<string>(type: "text", nullable: true, defaultValue: "NA"),
                    orbiter_order_date = table.Column<string>(type: "text", nullable: true, defaultValue: "NA"),
                    createddatetime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "current_timestamp"),
                    isDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    //deleteddate = table.Column<DateOnly>(type: "date", nullable: false, defaultValueSql: "1900-01-01")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_attachment_order_info", x => x.attachmentorderid);
                    table.ForeignKey(
                        name: "FK_attachment_order_info_applicationdtl_applicationDTLapplicat~",
                        column: x => x.applicationDTLapplicationid,
                        principalTable: "applicationdtl",
                        principalColumn: "applicationid");
                    table.ForeignKey(
                        name: "FK_attachment_order_info_usermaster_userMasteruserid",
                        column: x => x.userMasteruserid,
                        principalTable: "usermaster",
                        principalColumn: "userid");
                });

            migrationBuilder.CreateIndex(
                name: "IX_attachment_order_info_applicationDTLapplicationid",
                table: "attachment_order_info",
                column: "applicationDTLapplicationid");

            migrationBuilder.CreateIndex(
                name: "IX_attachment_order_info_userMasteruserid",
                table: "attachment_order_info",
                column: "userMasteruserid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "attachment_order_info");

            migrationBuilder.DropColumn(
                name: "attachmentorderids",
                table: "applicationdtl");
        }
    }
}
