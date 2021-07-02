using Microsoft.EntityFrameworkCore.Migrations;

namespace InvoicesCreator.DAL.Migrations
{
    public partial class ChangingRelationBetweenInvoicesAndSeller : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Invoices_SellerID",
                table: "Invoices");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_SellerID",
                table: "Invoices",
                column: "SellerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Invoices_SellerID",
                table: "Invoices");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_SellerID",
                table: "Invoices",
                column: "SellerID",
                unique: true);
        }
    }
}
