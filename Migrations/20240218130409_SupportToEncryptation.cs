using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectFinalLp2.Migrations
{
    /// <inheritdoc />
    public partial class SupportToEncryptation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "telefono",
                table: "contacto",
                type: "varchar(300)",
                unicode: false,
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "pais",
                table: "contacto",
                type: "varchar(300)",
                unicode: false,
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "contacto",
                type: "varchar(300)",
                unicode: false,
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "direccion",
                table: "contacto",
                type: "varchar(300)",
                unicode: false,
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(80)",
                oldUnicode: false,
                oldMaxLength: 80);

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "client",
                type: "varchar(300)",
                unicode: false,
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldUnicode: false,
                oldMaxLength: 15);

            migrationBuilder.AddColumn<int>(
                name: "idLicencia",
                table: "client",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "admin",
                type: "varchar(300)",
                unicode: false,
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldUnicode: false,
                oldMaxLength: 15);

            migrationBuilder.CreateTable(
                name: "Licencia",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    emision = table.Column<DateOnly>(type: "date", nullable: false),
                    categoria = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    fechaVencimiento = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Licencia", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_client_idLicencia",
                table: "client",
                column: "idLicencia");

            migrationBuilder.AddForeignKey(
                name: "FK_client_Licencia",
                table: "client",
                column: "idLicencia",
                principalTable: "Licencia",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_client_Licencia",
                table: "client");

            migrationBuilder.DropTable(
                name: "Licencia");

            migrationBuilder.DropIndex(
                name: "IX_client_idLicencia",
                table: "client");

            migrationBuilder.DropColumn(
                name: "idLicencia",
                table: "client");

            migrationBuilder.AlterColumn<string>(
                name: "telefono",
                table: "contacto",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(300)",
                oldUnicode: false,
                oldMaxLength: 300,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "pais",
                table: "contacto",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(300)",
                oldUnicode: false,
                oldMaxLength: 300);

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "contacto",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(300)",
                oldUnicode: false,
                oldMaxLength: 300,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "direccion",
                table: "contacto",
                type: "varchar(80)",
                unicode: false,
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(300)",
                oldUnicode: false,
                oldMaxLength: 300);

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "client",
                type: "varchar(15)",
                unicode: false,
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(300)",
                oldUnicode: false,
                oldMaxLength: 300);

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "admin",
                type: "varchar(15)",
                unicode: false,
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(300)",
                oldUnicode: false,
                oldMaxLength: 300);
        }
    }
}
