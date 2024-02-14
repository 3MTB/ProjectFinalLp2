using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectFinalLp2.Migrations
{
	/// <inheritdoc />
	public partial class Initial : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "admin",
				columns: table => new
				{
					id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					nombre = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
					password = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Admin", x => x.id);
				});

			migrationBuilder.CreateTable(
				name: "contacto",
				columns: table => new
				{
					id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					pais = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
					ciudad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
					direccion = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: false),
					email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
					telefono = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_contacto", x => x.id);
				});

			migrationBuilder.CreateTable(
				name: "trabajador",
				columns: table => new
				{
					id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
					password = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
					cargo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_trabajador", x => x.id);
				});

			migrationBuilder.CreateTable(
				name: "vehiculo",
				columns: table => new
				{
					id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Marca = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
					Modelo = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
					anio = table.Column<int>(type: "int", nullable: false),
					color = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
					estado = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: false),
					precioRenta = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
					desription = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_vehiculo", x => x.id);
				});

			migrationBuilder.CreateTable(
				name: "client",
				columns: table => new
				{
					id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
					apellido = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
					edad = table.Column<int>(type: "int", nullable: false),
					password = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
					imagen = table.Column<byte[]>(type: "image", nullable: false),
					idContacto = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_client_1", x => x.id);
					table.ForeignKey(
						name: "FK_client_contacto1",
						column: x => x.idContacto,
						principalTable: "contacto",
						principalColumn: "id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "Rentados",
				columns: table => new
				{
					id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					idCliente = table.Column<int>(type: "int", nullable: false),
					idVehiculo = table.Column<int>(type: "int", nullable: false),
					fechaInicio = table.Column<DateTime>(type: "datetime", nullable: false),
					fechaFinal = table.Column<DateTime>(type: "datetime", nullable: false),
					idTrabajador = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Rentados", x => x.id);
					table.ForeignKey(
						name: "FK_Rentados_client",
						column: x => x.idCliente,
						principalTable: "client",
						principalColumn: "id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_Rentados_trabajador",
						column: x => x.idTrabajador,
						principalTable: "trabajador",
						principalColumn: "id");
					table.ForeignKey(
						name: "FK_Rentados_vehiculo",
						column: x => x.idVehiculo,
						principalTable: "vehiculo",
						principalColumn: "id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateIndex(
				name: "IX_client_idContacto",
				table: "client",
				column: "idContacto");

			migrationBuilder.CreateIndex(
				name: "IX_Rentados_idCliente",
				table: "Rentados",
				column: "idCliente");

			migrationBuilder.CreateIndex(
				name: "IX_Rentados_idTrabajador",
				table: "Rentados",
				column: "idTrabajador");

			migrationBuilder.CreateIndex(
				name: "IX_Rentados_idVehiculo",
				table: "Rentados",
				column: "idVehiculo");
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "admin");

			migrationBuilder.DropTable(
				name: "Rentados");

			migrationBuilder.DropTable(
				name: "client");

			migrationBuilder.DropTable(
				name: "trabajador");

			migrationBuilder.DropTable(
				name: "vehiculo");

			migrationBuilder.DropTable(
				name: "contacto");
		}
	}
}
