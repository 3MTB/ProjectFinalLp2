﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectFinalLp2.Models;

#nullable disable

namespace ProjectFinalLp2.Migrations
{
    [DbContext(typeof(RentcargokudemonContext))]
    [Migration("20240218130409_SupportToEncryptation")]
    partial class SupportToEncryptation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProjectFinalLp2.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("nombre");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(300)
                        .IsUnicode(false)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("password");

                    b.HasKey("Id")
                        .HasName("PK_Admin");

                    b.ToTable("admin", (string)null);
                });

            modelBuilder.Entity("ProjectFinalLp2.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("apellido");

                    b.Property<int>("Edad")
                        .HasColumnType("int")
                        .HasColumnName("edad");

                    b.Property<int>("IdContacto")
                        .HasColumnType("int")
                        .HasColumnName("idContacto");

                    b.Property<int>("IdLicencia")
                        .HasColumnType("int")
                        .HasColumnName("idLicencia");

                    b.Property<byte[]>("Imagen")
                        .IsRequired()
                        .HasColumnType("image")
                        .HasColumnName("imagen");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(300)
                        .IsUnicode(false)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("password");

                    b.HasKey("Id")
                        .HasName("PK_client_1");

                    b.HasIndex("IdContacto");

                    b.HasIndex("IdLicencia");

                    b.ToTable("client", (string)null);
                });

            modelBuilder.Entity("ProjectFinalLp2.Models.Contacto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("ciudad");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(300)
                        .IsUnicode(false)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("direccion");

                    b.Property<string>("Email")
                        .HasMaxLength(300)
                        .IsUnicode(false)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("email");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasMaxLength(300)
                        .IsUnicode(false)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("pais");

                    b.Property<string>("Telefono")
                        .HasMaxLength(300)
                        .IsUnicode(false)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("telefono");

                    b.HasKey("Id");

                    b.ToTable("contacto", (string)null);
                });

            modelBuilder.Entity("ProjectFinalLp2.Models.Licencium", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("varchar(5)")
                        .HasColumnName("categoria");

                    b.Property<DateOnly>("Emision")
                        .HasColumnType("date")
                        .HasColumnName("emision");

                    b.Property<DateOnly>("FechaVencimiento")
                        .HasColumnType("date")
                        .HasColumnName("fechaVencimiento");

                    b.HasKey("Id");

                    b.ToTable("Licencia");
                });

            modelBuilder.Entity("ProjectFinalLp2.Models.Rentado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("FechaFinal")
                        .HasColumnType("datetime")
                        .HasColumnName("fechaFinal");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime")
                        .HasColumnName("fechaInicio");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("idCliente");

                    b.Property<int>("IdTrabajador")
                        .HasColumnType("int")
                        .HasColumnName("idTrabajador");

                    b.Property<int>("IdVehiculo")
                        .HasColumnType("int")
                        .HasColumnName("idVehiculo");

                    b.HasKey("Id");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdTrabajador");

                    b.HasIndex("IdVehiculo");

                    b.ToTable("Rentados");
                });

            modelBuilder.Entity("ProjectFinalLp2.Models.Trabajador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("cargo");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("password");

                    b.HasKey("Id");

                    b.ToTable("trabajador", (string)null);
                });

            modelBuilder.Entity("ProjectFinalLp2.Models.Vehiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Anio")
                        .HasColumnType("int")
                        .HasColumnName("anio");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("color");

                    b.Property<string>("Desription")
                        .IsRequired()
                        .HasMaxLength(300)
                        .IsUnicode(false)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("desription");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("varchar(12)")
                        .HasColumnName("estado");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<decimal>("PrecioRenta")
                        .HasColumnType("decimal(18, 2)")
                        .HasColumnName("precioRenta");

                    b.HasKey("Id");

                    b.ToTable("vehiculo", (string)null);
                });

            modelBuilder.Entity("ProjectFinalLp2.Models.Client", b =>
                {
                    b.HasOne("ProjectFinalLp2.Models.Contacto", "IdContactoNavigation")
                        .WithMany("Clients")
                        .HasForeignKey("IdContacto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_client_contacto1");

                    b.HasOne("ProjectFinalLp2.Models.Licencium", "IdLicenciaNavigation")
                        .WithMany("Clients")
                        .HasForeignKey("IdLicencia")
                        .IsRequired()
                        .HasConstraintName("FK_client_Licencia");

                    b.Navigation("IdContactoNavigation");

                    b.Navigation("IdLicenciaNavigation");
                });

            modelBuilder.Entity("ProjectFinalLp2.Models.Rentado", b =>
                {
                    b.HasOne("ProjectFinalLp2.Models.Client", "IdClienteNavigation")
                        .WithMany("Rentados")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Rentados_client");

                    b.HasOne("ProjectFinalLp2.Models.Trabajador", "IdTrabajadorNavigation")
                        .WithMany("Rentados")
                        .HasForeignKey("IdTrabajador")
                        .IsRequired()
                        .HasConstraintName("FK_Rentados_trabajador");

                    b.HasOne("ProjectFinalLp2.Models.Vehiculo", "IdVehiculoNavigation")
                        .WithMany("Rentados")
                        .HasForeignKey("IdVehiculo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Rentados_vehiculo");

                    b.Navigation("IdClienteNavigation");

                    b.Navigation("IdTrabajadorNavigation");

                    b.Navigation("IdVehiculoNavigation");
                });

            modelBuilder.Entity("ProjectFinalLp2.Models.Client", b =>
                {
                    b.Navigation("Rentados");
                });

            modelBuilder.Entity("ProjectFinalLp2.Models.Contacto", b =>
                {
                    b.Navigation("Clients");
                });

            modelBuilder.Entity("ProjectFinalLp2.Models.Licencium", b =>
                {
                    b.Navigation("Clients");
                });

            modelBuilder.Entity("ProjectFinalLp2.Models.Trabajador", b =>
                {
                    b.Navigation("Rentados");
                });

            modelBuilder.Entity("ProjectFinalLp2.Models.Vehiculo", b =>
                {
                    b.Navigation("Rentados");
                });
#pragma warning restore 612, 618
        }
    }
}
