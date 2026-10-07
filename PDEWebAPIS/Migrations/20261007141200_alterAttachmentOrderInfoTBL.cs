using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PDEWebAPIS.Migrations
{
    /// <inheritdoc />
    public partial class alterAttachmentOrderInfoTBL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "by_order_recording_entries_that_were_missed_during_computeriza~",
                table: "attachment_order_info",
                type: "text",
                nullable: true,
                defaultValue: "NA");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "by_order_recording_entries_that_were_missed_during_computeriza~",
                table: "attachment_order_info");
        }
    }
}
