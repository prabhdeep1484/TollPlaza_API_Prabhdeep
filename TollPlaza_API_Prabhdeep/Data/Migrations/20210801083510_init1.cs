using Microsoft.EntityFrameworkCore.Migrations;

namespace TollPlaza_API_Prabhdeep.Data.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_TollPrices_TollPriceID",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Vehicles_VehicleID",
                table: "Customers");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleID",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TollPriceID",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_TollPrices_TollPriceID",
                table: "Customers",
                column: "TollPriceID",
                principalTable: "TollPrices",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Vehicles_VehicleID",
                table: "Customers",
                column: "VehicleID",
                principalTable: "Vehicles",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_TollPrices_TollPriceID",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Vehicles_VehicleID",
                table: "Customers");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleID",
                table: "Customers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TollPriceID",
                table: "Customers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_TollPrices_TollPriceID",
                table: "Customers",
                column: "TollPriceID",
                principalTable: "TollPrices",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Vehicles_VehicleID",
                table: "Customers",
                column: "VehicleID",
                principalTable: "Vehicles",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
