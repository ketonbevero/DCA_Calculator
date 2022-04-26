using Microsoft.EntityFrameworkCore.Migrations;

namespace DCA_Calculator.Data.Migrations
{
    public partial class portfolio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PortfolioUid",
                table: "Bags",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Portfolios",
                columns: table => new
                {
                    Uid = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Open = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portfolios", x => x.Uid);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bags_PortfolioUid",
                table: "Bags",
                column: "PortfolioUid");

            migrationBuilder.AddForeignKey(
                name: "FK_Bags_Portfolios_PortfolioUid",
                table: "Bags",
                column: "PortfolioUid",
                principalTable: "Portfolios",
                principalColumn: "Uid",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bags_Portfolios_PortfolioUid",
                table: "Bags");

            migrationBuilder.DropTable(
                name: "Portfolios");

            migrationBuilder.DropIndex(
                name: "IX_Bags_PortfolioUid",
                table: "Bags");

            migrationBuilder.DropColumn(
                name: "PortfolioUid",
                table: "Bags");
        }
    }
}
