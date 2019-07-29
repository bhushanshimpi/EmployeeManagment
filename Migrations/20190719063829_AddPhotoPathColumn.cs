using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagment.Migrations
{
    public partial class AddPhotoPathColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhotoPat",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SomeProparty",
                table: "Employees",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoPat",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "SomeProparty",
                table: "Employees");
        }
    }
}
