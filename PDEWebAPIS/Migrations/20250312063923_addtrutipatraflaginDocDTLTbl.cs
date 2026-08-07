using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PDEWebAPIS.Migrations
{
    /// <inheritdoc />
    public partial class addtrutipatraflaginDocDTLTbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<string>(
            //    name: "truti_patra_flag",
            //    table: "uploaded_documents_dtl",
            //    type: "text",
            //    nullable: true,
            //    defaultValue: "NA");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "truti_patra_flag",
            //    table: "uploaded_documents_dtl");
        }
    }
}
