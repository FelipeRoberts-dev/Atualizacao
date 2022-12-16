using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VendasWeb.Migrations
{
    public partial class NovaMigracao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vendedor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataAniversario = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BaseSalario = table.Column<double>(type: "float", nullable: false),
                    DepartamentoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendedor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vendedor_Departament_DepartamentoId",
                        column: x => x.DepartamentoId,
                        principalTable: "Departament",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RecordeVendedors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quantia = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    VendedorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecordeVendedors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecordeVendedors_Vendedor_VendedorId",
                        column: x => x.VendedorId,
                        principalTable: "Vendedor",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_RecordeVendedors_VendedorId",
                table: "RecordeVendedors",
                column: "VendedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendedor_DepartamentoId",
                table: "Vendedor",
                column: "DepartamentoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecordeVendedors");

            migrationBuilder.DropTable(
                name: "Vendedor");
        }
    }
}
