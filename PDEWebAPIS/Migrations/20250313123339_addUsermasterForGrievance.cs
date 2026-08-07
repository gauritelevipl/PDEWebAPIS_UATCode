using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PDEWebAPIS.Migrations
{
    /// <inheritdoc />
    public partial class addUsermasterForGrievance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<int>(
            //    name: "AssignIssueToUserId",
            //    table: "grievancetbl",
            //    type: "integer",
            //    nullable: false,
            //    defaultValue: 0);

            //migrationBuilder.CreateTable(
            //    name: "GrievanceUserMaster",
            //    columns: table => new
            //    {
            //        guserid = table.Column<int>(type: "integer", nullable: false)
            //            .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            //        usertype = table.Column<string>(type: "text", nullable: false),
            //        fullname = table.Column<string>(type: "text", nullable: false),
            //        username = table.Column<string>(type: "text", nullable: false),
            //        division = table.Column<string>(type: "text", nullable: false),
            //        mobileno = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
            //        emailid = table.Column<string>(type: "text", nullable: false),
            //        password = table.Column<string>(type: "text", nullable: true),
            //        registerdatetime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
            //        webtoken = table.Column<string>(type: "text", nullable: false),
            //        moiletoken = table.Column<string>(type: "text", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_GrievanceUserMaster", x => x.guserid);
            //    });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "GrievanceUserMaster");

            //migrationBuilder.DropColumn(
            //    name: "AssignIssueToUserId",
            //    table: "grievancetbl");
        }
    }
}
