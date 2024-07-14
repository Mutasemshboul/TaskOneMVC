using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskOneMVC.Migrations
{
    /// <inheritdoc />
    public partial class FixForeignKeyNaming2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Employees_EmployeeId",
                table: "Tasks");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Tasks",
                newName: "EmployeeID");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_EmployeeId",
                table: "Tasks",
                newName: "IX_Tasks_EmployeeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Employees_EmployeeID",
                table: "Tasks",
                column: "EmployeeID",
                principalTable: "Employees",
                principalColumn: "EmployeesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Employees_EmployeeID",
                table: "Tasks");

            migrationBuilder.RenameColumn(
                name: "EmployeeID",
                table: "Tasks",
                newName: "EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_EmployeeID",
                table: "Tasks",
                newName: "IX_Tasks_EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Employees_EmployeeId",
                table: "Tasks",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeesId");
        }
    }
}
