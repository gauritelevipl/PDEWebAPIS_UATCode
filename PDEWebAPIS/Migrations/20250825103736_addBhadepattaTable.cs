using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PDEWebAPIS.Migrations
{
    /// <inheritdoc />
    public partial class addBhadepattaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            //migrationBuilder.DropTable(
            //    name: "bhadepattaInfoDtl");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "bhadepattaInfoDtl",
            //    columns: table => new
            //    {
            //        Info_id = table.Column<int>(type: "integer", nullable: false)
            //            .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            //        userid = table.Column<int>(type: "integer", nullable: false),
            //        village_code = table.Column<string>(type: "text", nullable: true),
            //        ctsNo = table.Column<string>(type: "text", nullable: true),
            //        mutationSroNo = table.Column<string>(type: "text", nullable: true),
            //        ownerNo = table.Column<string>(type: "text", nullable: true),
            //        applicationid = table.Column<string>(type: "text", nullable: true),
            //        bhadepattaTenureYear = table.Column<string>(type: "text", nullable: true),
            //        bhadepattaTenureMonth = table.Column<string>(type: "text", nullable: true),
            //        bhadepattaFromDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
            //        bhadepattaToDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
            //        bhadepattaAmount = table.Column<string>(type: "text", nullable: true),
            //        createdDateTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true, defaultValueSql: "current_timestamp"),
            //        isDeleted = table.Column<bool>(type: "boolean", nullable: true, defaultValueSql: "false"),
            //        deletedDateTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true, defaultValueSql: "'1900-01-01 00:00:00 UTC'::timestamptz")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_bhadepattaInfoDtl", x => x.Info_id);
            //    });
        }
    }
}
