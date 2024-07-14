using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskOneMVC.Migrations
{
    /// <inheritdoc />
    public partial class FixForeignKeyNaming : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeID",
                table: "Tasks");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeID",
                table: "Tasks",
                type: "int",
                nullable: true);
        }
    }
}
