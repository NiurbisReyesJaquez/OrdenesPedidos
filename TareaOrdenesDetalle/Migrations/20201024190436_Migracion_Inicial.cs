﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TareaOrdenesDetalle.Migrations
{
    public partial class Migracion_Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ordenes",
                columns: table => new
                {
                    OrdenId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(nullable: false),
                    SuplidorId = table.Column<int>(nullable: false),
                    Monto = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ordenes", x => x.OrdenId);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    ProductoId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(nullable: true),
                    Costo = table.Column<decimal>(nullable: false),
                    Inventario = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.ProductoId);
                });

            migrationBuilder.CreateTable(
                name: "Suplidores",
                columns: table => new
                {
                    SuplidorId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suplidores", x => x.SuplidorId);
                });

            migrationBuilder.CreateTable(
                name: "OrdenesDetalle",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrdenId = table.Column<int>(nullable: false),
                    Cantidad = table.Column<int>(nullable: false),
                    ProductoId = table.Column<int>(nullable: false),
                    Costo = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenesDetalle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdenesDetalle_Ordenes_OrdenId",
                        column: x => x.OrdenId,
                        principalTable: "Ordenes",
                        principalColumn: "OrdenId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "Costo", "Descripcion", "Inventario" },
                values: new object[] { 1, 300m, "Malta Morena", 40 });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "Costo", "Descripcion", "Inventario" },
                values: new object[] { 2, 500m, "Chocolate Hersheys", 15 });

            migrationBuilder.InsertData(
                table: "Suplidores",
                columns: new[] { "SuplidorId", "Nombre" },
                values: new object[] { 1, "Almacen Juan Maria" });

            migrationBuilder.InsertData(
                table: "Suplidores",
                columns: new[] { "SuplidorId", "Nombre" },
                values: new object[] { 2, "Surtidora La Economica" });

            migrationBuilder.CreateIndex(
                name: "IX_OrdenesDetalle_OrdenId",
                table: "OrdenesDetalle",
                column: "OrdenId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrdenesDetalle");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Suplidores");

            migrationBuilder.DropTable(
                name: "Ordenes");
        }
    }
}
