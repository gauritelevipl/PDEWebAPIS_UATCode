using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PDEWebAPIS.Migrations
{
    /// <inheritdoc />
    public partial class addApplicationStatusHistoryTbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "application_status_history",
            //    columns: table => new
            //    {
            //        application_status_history_id = table.Column<int>(type: "integer", nullable: false)
            //            .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            //        applicationid = table.Column<string>(type: "text", nullable: true),
            //        application_status = table.Column<string>(type: "text", nullable: true),
            //        mutation_type_code = table.Column<string>(type: "text", nullable: true),
            //        mutation_type_name = table.Column<string>(type: "text", nullable: true),
            //        createddatetime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "current_timestamp")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_application_status_history", x => x.application_status_history_id);
            //    });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "application_status_history");
        }
    }
}
