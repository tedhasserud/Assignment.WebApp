using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAuthKey.Migrations
{
    public partial class eanadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EAN",
                table: "Products",
                type: "varchar(13)",
                unicode: false,
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Products_EAN",
                table: "Products",
                column: "EAN",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_EAN",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "EAN",
                table: "Products");
        }
    }
}
