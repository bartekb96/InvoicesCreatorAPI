using Microsoft.EntityFrameworkCore.Migrations;

namespace InvoicesCreator.DAL.Migrations
{
    public partial class NullableSellersIdInUserModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Sellers_SellerID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_SellerID",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "SellerID",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Users_SellerID",
                table: "Users",
                column: "SellerID",
                unique: true,
                filter: "[SellerID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Sellers_SellerID",
                table: "Users",
                column: "SellerID",
                principalTable: "Sellers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Sellers_SellerID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_SellerID",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "SellerID",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_SellerID",
                table: "Users",
                column: "SellerID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Sellers_SellerID",
                table: "Users",
                column: "SellerID",
                principalTable: "Sellers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
