using Microsoft.EntityFrameworkCore.Migrations;

namespace agileworkspace.Migrations
{
    public partial class WithNullFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Seats_SeatId",
                table: "Employees");

            migrationBuilder.AlterColumn<long>(
                name: "SeatId",
                table: "Employees",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Seats_SeatId",
                table: "Employees",
                column: "SeatId",
                principalTable: "Seats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Seats_SeatId",
                table: "Employees");

            migrationBuilder.AlterColumn<long>(
                name: "SeatId",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Seats_SeatId",
                table: "Employees",
                column: "SeatId",
                principalTable: "Seats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
