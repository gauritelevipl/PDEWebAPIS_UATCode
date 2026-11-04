using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PDEWebAPIS.Migrations
{
    /// <inheritdoc />
    public partial class createNonAgriculturalInfoTBL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "nonagriculturalids",
                table: "applicationdtl",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "non_agricultural_info",
                columns: table => new
                {
                    nonagriculturalid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    userMasteruserid = table.Column<int>(type: "integer", nullable: true),
                    applicationDTLapplicationid = table.Column<string>(type: "text", nullable: true),
                    competentauthority = table.Column<string>(type: "text", nullable: true),
                    office_name = table.Column<string>(type: "text", nullable: true),
                    orderno = table.Column<string>(type: "text", nullable: true, defaultValue: "NA"),
                    orderdate = table.Column<string>(type: "text", nullable: true, defaultValue: "NA"),
                    approved_drawing_plan = table.Column<string>(type: "text", nullable: true, defaultValue: "NA"),
                    approved_drawing_no = table.Column<string>(type: "text", nullable: true, defaultValue: "NA"),
                    approved_drawing_date = table.Column<string>(type: "text", nullable: true, defaultValue: "NA"),
                    receipt_no_for_non_agricultural_assessment = table.Column<string>(type: "text", nullable: true, defaultValue: "NA"),
                    receipt_date_for_non_agricultural_assessment = table.Column<string>(type: "text", nullable: true, defaultValue: "NA"),
                    amount_of_non_agricultural_assessment = table.Column<string>(type: "text", nullable: true, defaultValue: "0"),
                    area_as_per_the_latest_report = table.Column<string>(type: "text", nullable: true, defaultValue: "NA"),
                    area_as_per_non_agricultural_assessment = table.Column<string>(type: "text", nullable: true, defaultValue: "NA"),
                    plot_no = table.Column<string>(type: "text", nullable: true, defaultValue: "NA"),
                    createddatetime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    isdeleted = table.Column<bool>(type: "boolean", nullable: false),
                    deleteddate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_non_agricultural_info", x => x.nonagriculturalid);
                    table.ForeignKey(
                        name: "FK_non_agricultural_info_applicationdtl_applicationDTLapplicat~",
                        column: x => x.applicationDTLapplicationid,
                        principalTable: "applicationdtl",
                        principalColumn: "applicationid");
                    table.ForeignKey(
                        name: "FK_non_agricultural_info_usermaster_userMasteruserid",
                        column: x => x.userMasteruserid,
                        principalTable: "usermaster",
                        principalColumn: "userid");
                });

            migrationBuilder.CreateIndex(
                name: "IX_non_agricultural_info_applicationDTLapplicationid",
                table: "non_agricultural_info",
                column: "applicationDTLapplicationid");

            migrationBuilder.CreateIndex(
                name: "IX_non_agricultural_info_userMasteruserid",
                table: "non_agricultural_info",
                column: "userMasteruserid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "non_agricultural_info");

            migrationBuilder.DropColumn(
                name: "nonagriculturalids",
                table: "applicationdtl");
        }
    }
}
