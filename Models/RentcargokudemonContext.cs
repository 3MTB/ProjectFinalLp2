using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProjectFinalLp2.Models;

public partial class RentcargokudemonContext : DbContext
{
    public RentcargokudemonContext()
    {
    }

    public RentcargokudemonContext(DbContextOptions<RentcargokudemonContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Contacto> Contactos { get; set; }

    public virtual DbSet<Licencium> Licencia { get; set; }

    public virtual DbSet<Rentado> Rentados { get; set; }

    public virtual DbSet<Trabajador> Trabajadors { get; set; }

    public virtual DbSet<Vehiculo> Vehiculos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DRAKO\\SQLEXPRESS; Database=rentcargokudemon; Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Admin");

            entity.ToTable("admin");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Password)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("password");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_client_1");

            entity.ToTable("client");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.Edad).HasColumnName("edad");
            entity.Property(e => e.IdContacto).HasColumnName("idContacto");
            entity.Property(e => e.IdLicencia).HasColumnName("idLicencia");
            entity.Property(e => e.Imagen)
                .HasColumnType("image")
                .HasColumnName("imagen");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Password)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("password");

            entity.HasOne(d => d.IdContactoNavigation).WithMany(p => p.Clients)
                .HasForeignKey(d => d.IdContacto)
                .HasConstraintName("FK_client_contacto1");

            entity.HasOne(d => d.IdLicenciaNavigation).WithMany(p => p.Clients)
                .HasForeignKey(d => d.IdLicencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_client_Licencia");
        });

        modelBuilder.Entity<Contacto>(entity =>
        {
            entity.ToTable("contacto");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("ciudad");
            entity.Property(e => e.Direccion)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Email)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Pais)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("pais");
            entity.Property(e => e.Telefono)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("telefono");
        });

        modelBuilder.Entity<Licencium>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Categoria)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("categoria");
            entity.Property(e => e.Emision).HasColumnName("emision");
            entity.Property(e => e.FechaVencimiento).HasColumnName("fechaVencimiento");
        });

        modelBuilder.Entity<Rentado>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FechaFinal)
                .HasColumnType("datetime")
                .HasColumnName("fechaFinal");
            entity.Property(e => e.FechaInicio)
                .HasColumnType("datetime")
                .HasColumnName("fechaInicio");
            entity.Property(e => e.IdCliente).HasColumnName("idCliente");
            entity.Property(e => e.IdTrabajador).HasColumnName("idTrabajador");
            entity.Property(e => e.IdVehiculo).HasColumnName("idVehiculo");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Rentados)
                .HasForeignKey(d => d.IdCliente)
                .HasConstraintName("FK_Rentados_client");

            entity.HasOne(d => d.IdTrabajadorNavigation).WithMany(p => p.Rentados)
                .HasForeignKey(d => d.IdTrabajador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Rentados_trabajador");

            entity.HasOne(d => d.IdVehiculoNavigation).WithMany(p => p.Rentados)
                .HasForeignKey(d => d.IdVehiculo)
                .HasConstraintName("FK_Rentados_vehiculo");
        });

        modelBuilder.Entity<Trabajador>(entity =>
        {
            entity.ToTable("trabajador");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cargo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cargo");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("password");
        });

        modelBuilder.Entity<Vehiculo>(entity =>
        {
            entity.ToTable("vehiculo");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Anio).HasColumnName("anio");
            entity.Property(e => e.Color)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("color");
            entity.Property(e => e.Desription)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("desription");
            entity.Property(e => e.Estado)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.Marca)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Modelo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PrecioRenta)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("precioRenta");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
