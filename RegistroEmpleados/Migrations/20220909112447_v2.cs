using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RegistroEmpleados.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdCargo",
                table: "Empleado",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdSalario",
                table: "Empleado",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_CargoId",
                table: "Empleado",
                column: "CargoId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_SalarioId",
                table: "Empleado",
                column: "SalarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleado_Cargo_CargoId",
                table: "Empleado",
                column: "CargoId",
                principalTable: "Cargo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleado_Salario_SalarioId",
                table: "Empleado",
                column: "SalarioId",
                principalTable: "Salario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleado_Cargo_CargoId",
                table: "Empleado");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleado_Salario_SalarioId",
                table: "Empleado");

            migrationBuilder.DropIndex(
                name: "IX_Empleado_CargoId",
                table: "Empleado");

            migrationBuilder.DropIndex(
                name: "IX_Empleado_SalarioId",
                table: "Empleado");

            migrationBuilder.DropColumn(
                name: "IdCargo",
                table: "Empleado");

            migrationBuilder.DropColumn(
                name: "IdSalario",
                table: "Empleado");
        }
    }
}
