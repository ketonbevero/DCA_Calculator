using Microsoft.EntityFrameworkCore.Migrations;

namespace DCA_Calculator.Data.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Bags_DCABagBagId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_DCABagBagId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "DCABagBagId",
                table: "Transactions");

            migrationBuilder.AlterColumn<string>(
                name: "BagId",
                table: "Transactions",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_BagId",
                table: "Transactions",
                column: "BagId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Bags_BagId",
                table: "Transactions",
                column: "BagId",
                principalTable: "Bags",
                principalColumn: "BagId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Bags_BagId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_BagId",
                table: "Transactions");

            migrationBuilder.AlterColumn<string>(
                name: "BagId",
                table: "Transactions",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "DCABagBagId",
                table: "Transactions",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_DCABagBagId",
                table: "Transactions",
                column: "DCABagBagId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Bags_DCABagBagId",
                table: "Transactions",
                column: "DCABagBagId",
                principalTable: "Bags",
                principalColumn: "BagId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
