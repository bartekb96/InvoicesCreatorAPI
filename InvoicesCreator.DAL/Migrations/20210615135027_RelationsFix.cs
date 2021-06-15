using Microsoft.EntityFrameworkCore.Migrations;

namespace InvoicesCreator.DAL.Migrations
{
    public partial class RelationsFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contractors_Invoices_InvoiceId",
                table: "Contractors");

            migrationBuilder.DropForeignKey(
                name: "FK_Sellers_Invoices_InvoiceId",
                table: "Sellers");

            migrationBuilder.DropIndex(
                name: "IX_Sellers_InvoiceId",
                table: "Sellers");

            migrationBuilder.DropIndex(
                name: "IX_Contractors_InvoiceId",
                table: "Contractors");

            migrationBuilder.DropColumn(
                name: "InvoiceId",
                table: "Sellers");

            migrationBuilder.DropColumn(
                name: "InvoiceId",
                table: "Contractors");

            migrationBuilder.AddColumn<int>(
                name: "ContractorID",
                table: "Invoices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SellerID",
                table: "Invoices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_ContractorID",
                table: "Invoices",
                column: "ContractorID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_SellerID",
                table: "Invoices",
                column: "SellerID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Contractors_ContractorID",
                table: "Invoices",
                column: "ContractorID",
                principalTable: "Contractors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Sellers_SellerID",
                table: "Invoices",
                column: "SellerID",
                principalTable: "Sellers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Contractors_ContractorID",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Sellers_SellerID",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_ContractorID",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_SellerID",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "ContractorID",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "SellerID",
                table: "Invoices");

            migrationBuilder.AddColumn<int>(
                name: "InvoiceId",
                table: "Sellers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InvoiceId",
                table: "Contractors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sellers_InvoiceId",
                table: "Sellers",
                column: "InvoiceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contractors_InvoiceId",
                table: "Contractors",
                column: "InvoiceId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Contractors_Invoices_InvoiceId",
                table: "Contractors",
                column: "InvoiceId",
                principalTable: "Invoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sellers_Invoices_InvoiceId",
                table: "Sellers",
                column: "InvoiceId",
                principalTable: "Invoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
