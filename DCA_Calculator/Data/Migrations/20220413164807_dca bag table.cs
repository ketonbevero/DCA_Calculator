using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DCA_Calculator.Data.Migrations
{
    public partial class dcabagtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bags",
                columns: table => new
                {
                    Uid = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CryptoCoin = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CoinQuantity = table.Column<decimal>(type: "decimal(18,3)", nullable: false),
                    TotalCost = table.Column<decimal>(type: "decimal(18,3)", nullable: false),
                    FIAT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bags", x => x.Uid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bags");
        }
    }
}
