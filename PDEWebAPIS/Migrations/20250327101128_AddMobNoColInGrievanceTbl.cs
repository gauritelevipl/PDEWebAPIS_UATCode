using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PDEWebAPIS.Migrations
{
    /// <inheritdoc />
    public partial class AddMobNoColInGrievanceTbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AlterColumn<string>(
            //    name: "secondaryMoNo",
            //    table: "grievancetbl",
            //    type: "text",
            //    nullable: false,
            //    defaultValue: "NA",
            //    oldClrType: typeof(string),
            //    oldType: "text");

            //migrationBuilder.AddColumn<string>(
            //    name: "mobileno",
            //    table: "grievancetbl",
            //    type: "text",
            //    nullable: false,
            //    defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "mobileno",
            //    table: "grievancetbl");

            //migrationBuilder.AlterColumn<string>(
            //    name: "secondaryMoNo",
            //    table: "grievancetbl",
            //    type: "text",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "text",
            //    oldDefaultValue: "NA");
        }
    }
}
