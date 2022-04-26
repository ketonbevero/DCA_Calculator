using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DCA_Calculator.Data.Migrations
{
    public partial class transactionsandchanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bags_Portfolios_PortfolioUid",
                table: "Bags");

            migrationBuilder.DropColumn(
                name: "CoinQuantity",
                table: "Bags");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Bags");

            migrationBuilder.DropColumn(
                name: "TotalCost",
                table: "Bags");

            migrationBuilder.RenameColumn(
                name: "Uid",
                table: "Portfolios",
                newName: "PortfolioId");

            migrationBuilder.RenameColumn(
                name: "PortfolioUid",
                table: "Bags",
                newName: "PortfolioId");

            migrationBuilder.RenameColumn(
                name: "Uid",
                table: "Bags",
                newName: "BagId");

            migrationBuilder.RenameIndex(
                name: "IX_Bags_PortfolioUid",
                table: "Bags",
                newName: "IX_Bags_PortfolioId");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Bags",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    TransactionId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CoinQuantity = table.Column<decimal>(type: "decimal(18,3)", nullable: false),
                    TotalCost = table.Column<decimal>(type: "decimal(18,3)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BagId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DCABagBagId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.TransactionId);
                    table.ForeignKey(
                        name: "FK_Transactions_Bags_DCABagBagId",
                        column: x => x.DCABagBagId,
                        principalTable: "Bags",
                        principalColumn: "BagId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_DCABagBagId",
                table: "Transactions",
                column: "DCABagBagId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bags_Portfolios_PortfolioId",
                table: "Bags",
                column: "PortfolioId",
                principalTable: "Portfolios",
                principalColumn: "PortfolioId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bags_Portfolios_PortfolioId",
                table: "Bags");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Bags");

            migrationBuilder.RenameColumn(
                name: "PortfolioId",
                table: "Portfolios",
                newName: "Uid");

            migrationBuilder.RenameColumn(
                name: "PortfolioId",
                table: "Bags",
                newName: "PortfolioUid");

            migrationBuilder.RenameColumn(
                name: "BagId",
                table: "Bags",
                newName: "Uid");

            migrationBuilder.RenameIndex(
                name: "IX_Bags_PortfolioId",
                table: "Bags",
                newName: "IX_Bags_PortfolioUid");

            migrationBuilder.AddColumn<decimal>(
                name: "CoinQuantity",
                table: "Bags",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Bags",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "TotalCost",
                table: "Bags",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddForeignKey(
                name: "FK_Bags_Portfolios_PortfolioUid",
                table: "Bags",
                column: "PortfolioUid",
                principalTable: "Portfolios",
                principalColumn: "Uid",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
