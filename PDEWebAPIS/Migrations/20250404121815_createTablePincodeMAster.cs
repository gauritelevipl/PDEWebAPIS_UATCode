using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PDEWebAPIS.Migrations
{
    /// <inheritdoc />
    public partial class createTablePincodeMAster : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "inward_no_status_master",
            //    columns: table => new
            //    {
            //        inward_no_status_id = table.Column<int>(type: "integer", nullable: false)
            //            .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            //        applicationid = table.Column<string>(type: "text", nullable: true),
            //        mutation_type_code = table.Column<string>(type: "text", nullable: true),
            //        mutation_type_name = table.Column<string>(type: "text", nullable: true),
            //        inwardno = table.Column<string>(type: "text", nullable: true),
            //        srno = table.Column<int>(type: "integer", nullable: false),
            //        status = table.Column<string>(type: "text", nullable: true),
            //        status_date = table.Column<DateOnly>(type: "date", nullable: false),
            //        createddatetime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "current_timestamp")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_inward_no_status_master", x => x.inward_no_status_id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "pinCodeMaster",
            //    columns: table => new
            //    {
            //        pid = table.Column<int>(type: "integer", nullable: false)
            //            .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            //        Name = table.Column<string>(type: "text", nullable: false),
            //        Description = table.Column<string>(type: "text", nullable: false),
            //        BranchType = table.Column<string>(type: "text", nullable: false),
            //        DeliveryStatus = table.Column<string>(type: "text", nullable: false),
            //        Circle = table.Column<string>(type: "text", nullable: false),
            //        District = table.Column<string>(type: "text", nullable: false),
            //        Division = table.Column<string>(type: "text", nullable: false),
            //        Region = table.Column<string>(type: "text", nullable: false),
            //        Block = table.Column<string>(type: "text", nullable: false),
            //        State = table.Column<string>(type: "text", nullable: false),
            //        Country = table.Column<string>(type: "text", nullable: false),
            //        Pincode = table.Column<string>(type: "text", nullable: false),
            //        createdDateTime = table.Column<string>(type: "text", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_pinCodeMaster", x => x.pid);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_inward_no_status_master_srno_inwardno",
            //    table: "inward_no_status_master",
            //    columns: new[] { "srno", "inwardno" },
            //    unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "inward_no_status_master");

            //migrationBuilder.DropTable(
            //    name: "pinCodeMaster");
        }
    }
}
