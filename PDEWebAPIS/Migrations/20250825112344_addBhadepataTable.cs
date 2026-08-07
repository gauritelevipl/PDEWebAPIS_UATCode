using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PDEWebAPIS.Migrations
{
    /// <inheritdoc />
    public partial class addBhadepataTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "bhadepattaInfoDtl",
            //    columns: table => new
            //    {
            //        Info_id = table.Column<int>(type: "integer", nullable: false)
            //            .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            //        userid = table.Column<int>(type: "integer", nullable: false),
            //        applicationid = table.Column<string>(type: "text", nullable: true),
            //        bhadepattaTenureYear = table.Column<string>(type: "text", nullable: true),
            //        bhadepattaTenureMonth = table.Column<string>(type: "text", nullable: true),
            //        bhadepattaFromDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
            //        bhadepattaToDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
            //        createdDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
            //        deletedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "'1900-01-01 00:00:00'"),
            //        isDeleted = table.Column<bool>(type: "boolean", nullable: true, defaultValue: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_bhadepattaInfoDtl", x => x.Info_id);
            //    });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "bhadepattaInfoDtl");
        }
    }
}
