using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PDEWebAPIS.Migrations
{
    /// <inheritdoc />
    public partial class alterMutationGiverTakerTBL1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<string>(
            //    name: "entry_bracketed",
            //    table: "mutationgivertakerDtls",
            //    type: "text",
            //    nullable: true,
            //    defaultValue: "NA");

            //migrationBuilder.AddColumn<string>(
            //    name: "entry_date",
            //    table: "mutationgivertakerDtls",
            //    type: "text",
            //    nullable: true,
            //    defaultValue: "NA");

            //migrationBuilder.AddColumn<string>(
            //    name: "owner_bracketed",
            //    table: "mutationgivertakerDtls",
            //    type: "text",
            //    nullable: true,
            //    defaultValue: "NA");

            //migrationBuilder.AddColumn<string>(
            //    name: "owner_name",
            //    table: "mutationgivertakerDtls",
            //    type: "text",
            //    nullable: true,
            //    defaultValue: "NA");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "entry_bracketed",
                table: "mutationgivertakerDtls");

            migrationBuilder.DropColumn(
                name: "entry_date",
                table: "mutationgivertakerDtls");

            migrationBuilder.DropColumn(
                name: "owner_bracketed",
                table: "mutationgivertakerDtls");

            migrationBuilder.DropColumn(
                name: "owner_name",
                table: "mutationgivertakerDtls");
        }
    }
}
