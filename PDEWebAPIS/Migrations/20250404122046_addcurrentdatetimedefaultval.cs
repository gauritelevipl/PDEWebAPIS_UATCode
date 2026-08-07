using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PDEWebAPIS.Migrations
{
    /// <inheritdoc />
    public partial class addcurrentdatetimedefaultval : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //    migrationBuilder.AlterColumn<string>(
            //        name: "createdDateTime",
            //        table: "pinCodeMaster",
            //        type: "text",
            //        nullable: false,
            //        defaultValueSql: "current_timestamp",
            //        oldClrType: typeof(string),
            //        oldType: "text");
        }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AlterColumn<string>(
            //    name: "createdDateTime",
            //    table: "pinCodeMaster",
            //    type: "text",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "text",
            //    oldDefaultValueSql: "current_timestamp");
        }
    }
}
