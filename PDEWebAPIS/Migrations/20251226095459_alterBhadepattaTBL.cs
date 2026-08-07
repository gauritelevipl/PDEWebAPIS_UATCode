using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PDEWebAPIS.Migrations
{
    /// <inheritdoc />
    public partial class alterBhadepattaTBL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.RenameColumn(
            //    name: "isProbet",
            //    table: "mayatdtl",
            //    newName: "isprobet");

            //migrationBuilder.AddColumn<string>(
            //    name: "leasePeriod",
            //    table: "bhadepattaInfoDtl",
            //    type: "text",
            //    nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "leasePeriod",
            //    table: "bhadepattaInfoDtl");

            //migrationBuilder.RenameColumn(
            //    name: "isprobet",
            //    table: "mayatdtl",
            //    newName: "isProbet");
        }
    }
}
