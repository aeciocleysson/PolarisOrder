using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PolarisOrder.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class v102 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Exclusao",
                table: "TaxaServico",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Exclusao",
                table: "Mesa",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Exclusao",
                table: "CategoriaBebida",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Exclusao",
                table: "CategoriaAlimento",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Exclusao",
                table: "Cardapio",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Exclusao",
                table: "Bebida",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Exclusao",
                table: "Alimento",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Exclusao",
                table: "TaxaServico");

            migrationBuilder.DropColumn(
                name: "Exclusao",
                table: "Mesa");

            migrationBuilder.DropColumn(
                name: "Exclusao",
                table: "CategoriaBebida");

            migrationBuilder.DropColumn(
                name: "Exclusao",
                table: "CategoriaAlimento");

            migrationBuilder.DropColumn(
                name: "Exclusao",
                table: "Cardapio");

            migrationBuilder.DropColumn(
                name: "Exclusao",
                table: "Bebida");

            migrationBuilder.DropColumn(
                name: "Exclusao",
                table: "Alimento");
        }
    }
}
