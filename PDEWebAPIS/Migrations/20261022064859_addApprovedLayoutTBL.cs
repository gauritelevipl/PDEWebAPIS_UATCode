using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PDEWebAPIS.Migrations
{
    /// <inheritdoc />
    public partial class addApprovedLayoutTBL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.RenameColumn(
            //    name: "recovery_cert_under_section_101_issued_by_the_cooperative_offi~",
            //    table: "attachment_order_info",
            //    newName: "recovery_cert_under_section_101_issued_by_cooperative_officer");

            //migrationBuilder.RenameColumn(
            //    name: "by_order_recording_entries_that_were_missed_during_computeriza~",
            //    table: "attachment_order_info",
            //    newName: "by_order_recording_entries_were_missed_during_computerization");

            migrationBuilder.AddColumn<string>(
                name: "approvedlayoutids",
                table: "applicationdtl",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "approved_layout_info",
                columns: table => new
                {
                    approvedlayoutid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    userMasteruserid = table.Column<int>(type: "integer", nullable: true),
                    applicationDTLapplicationid = table.Column<string>(type: "text", nullable: true),
                    competent_authority_approving_the_layout = table.Column<string>(type: "text", nullable: true),
                    name_of_the_office = table.Column<string>(type: "text", nullable: true),
                    order_no = table.Column<string>(type: "text", nullable: true),
                    order_date = table.Column<string>(type: "text", nullable: true),
                    approved_layout_drawing_no = table.Column<string>(type: "text", nullable: true),
                    approved_layout_drawing_date = table.Column<string>(type: "text", nullable: true),
                    measurement_no = table.Column<string>(type: "text", nullable: true),
                    measurement_date = table.Column<string>(type: "text", nullable: true),
                    is_it_attached_to_the_approved_layout_case = table.Column<string>(type: "text", nullable: true),
                    createddatetime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "current_timestamp"),
                    isdeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    //deleteddate = table.Column<DateOnly>(type: "date", nullable: false, defaultValueSql: "1900-01-01")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_approved_layout_info", x => x.approvedlayoutid);
                    table.ForeignKey(
                        name: "FK_approved_layout_info_applicationdtl_applicationDTLapplicati~",
                        column: x => x.applicationDTLapplicationid,
                        principalTable: "applicationdtl",
                        principalColumn: "applicationid");
                    table.ForeignKey(
                        name: "FK_approved_layout_info_usermaster_userMasteruserid",
                        column: x => x.userMasteruserid,
                        principalTable: "usermaster",
                        principalColumn: "userid");
                });

            migrationBuilder.CreateIndex(
                name: "IX_approved_layout_info_applicationDTLapplicationid",
                table: "approved_layout_info",
                column: "applicationDTLapplicationid");

            migrationBuilder.CreateIndex(
                name: "IX_approved_layout_info_userMasteruserid",
                table: "approved_layout_info",
                column: "userMasteruserid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "approved_layout_info");

            migrationBuilder.DropColumn(
                name: "approvedlayoutids",
                table: "applicationdtl");

            //migrationBuilder.RenameColumn(
            //    name: "recovery_cert_under_section_101_issued_by_cooperative_officer",
            //    table: "attachment_order_info",
            //    newName: "recovery_cert_under_section_101_issued_by_the_cooperative_offi~");

            //migrationBuilder.RenameColumn(
            //    name: "by_order_recording_entries_were_missed_during_computerization",
            //    table: "attachment_order_info",
            //    newName: "by_order_recording_entries_that_were_missed_during_computeriza~");
        }
    }
}
