using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PDEWebAPIS.Migrations
{
    /// <inheritdoc />
    public partial class alterDatesTableagain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //    migrationBuilder.DropForeignKey(
            //        name: "FK_grievanceIssueDatesDetails_grievancetbl_grievancetblGid",
            //        table: "grievanceIssueDatesDetails");

            //    migrationBuilder.DropIndex(
            //        name: "IX_grievanceIssueDatesDetails_grievancetblGid",
            //        table: "grievanceIssueDatesDetails");

            //    migrationBuilder.DropColumn(
            //        name: "grievancetblGid",
            //        table: "grievanceIssueDatesDetails");

            //    migrationBuilder.AddColumn<string>(
            //        name: "applicationId",
            //        table: "grievanceIssueDatesDetails",
            //        type: "text",
            //        nullable: false,
            //        defaultValue: "");

            //    migrationBuilder.AddColumn<string>(
            //        name: "tickitid",
            //        table: "grievanceIssueDatesDetails",
            //        type: "text",
            //        nullable: false,
            //        defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "applicationId",
            //    table: "grievanceIssueDatesDetails");

            //migrationBuilder.DropColumn(
            //    name: "tickitid",
            //    table: "grievanceIssueDatesDetails");

            //migrationBuilder.AddColumn<int>(
            //    name: "grievancetblGid",
            //    table: "grievanceIssueDatesDetails",
            //    type: "integer",
            //    nullable: false,
            //    defaultValue: 0);

            //migrationBuilder.CreateIndex(
            //    name: "IX_grievanceIssueDatesDetails_grievancetblGid",
            //    table: "grievanceIssueDatesDetails",
            //    column: "grievancetblGid");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_grievanceIssueDatesDetails_grievancetbl_grievancetblGid",
            //    table: "grievanceIssueDatesDetails",
            //    column: "grievancetblGid",
            //    principalTable: "grievancetbl",
            //    principalColumn: "Gid",
            //    onDelete: ReferentialAction.Cascade);
        }
    }
}
