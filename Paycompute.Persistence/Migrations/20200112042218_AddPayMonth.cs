using Microsoft.EntityFrameworkCore.Migrations;

namespace Paycompute.Persistence.Migrations
{
    public partial class AddPayMonth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PayMonth",
                table: "PaymentRecords",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PayMonth",
                table: "PaymentRecords");
        }
    }
}
