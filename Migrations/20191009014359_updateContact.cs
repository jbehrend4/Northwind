using Microsoft.EntityFrameworkCore.Migrations;

namespace Northwind.Migrations
{
    public partial class updateContact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Contacts",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Contacts",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
