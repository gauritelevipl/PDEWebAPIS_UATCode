using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PDEWebAPIS.Migrations
{
    /// <inheritdoc />
    public partial class alterDeclarationEntryInfoTBL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "document_registration_date",
                table: "declaration_entry_info",
                type: "text",
                nullable: true,
                defaultValue: "NA");

            migrationBuilder.AddColumn<string>(
                name: "document_year",
                table: "declaration_entry_info",
                type: "text",
                nullable: true,
                defaultValue: "NA");

            migrationBuilder.AddColumn<string>(
                name: "is_there_a_development_agreement",
                table: "declaration_entry_info",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "occupancy_certificate_number",
                table: "declaration_entry_info",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "reg_document_no",
                table: "declaration_entry_info",
                type: "text",
                nullable: true,
                defaultValue: "NA");

            migrationBuilder.AddColumn<string>(
                name: "sub_registrar_office",
                table: "declaration_entry_info",
                type: "text",
                nullable: true,
                defaultValue: "NA");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "document_registration_date",
                table: "declaration_entry_info");

            migrationBuilder.DropColumn(
                name: "document_year",
                table: "declaration_entry_info");

            migrationBuilder.DropColumn(
                name: "is_there_a_development_agreement",
                table: "declaration_entry_info");

            migrationBuilder.DropColumn(
                name: "occupancy_certificate_number",
                table: "declaration_entry_info");

            migrationBuilder.DropColumn(
                name: "reg_document_no",
                table: "declaration_entry_info");

            migrationBuilder.DropColumn(
                name: "sub_registrar_office",
                table: "declaration_entry_info");
        }
    }
}
