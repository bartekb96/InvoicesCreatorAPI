using Microsoft.EntityFrameworkCore.Migrations;

namespace InvoicesCreator.DAL.Migrations
{
    public partial class ConnectedInvoiceId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ConnectedInvoiceId",
                table: "Invoices",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConnectedInvoiceId",
                table: "Invoices");
        }
    }
}
