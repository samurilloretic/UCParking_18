﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UCP.App.Persistencia;

namespace UCP.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("UCP.App.Dominio.Parqueadero", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("horario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numeroPuestos")
                        .HasColumnType("int");

                    b.Property<int>("picoPlaca")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("parqueaderos");
                });

            modelBuilder.Entity("UCP.App.Dominio.Persona", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Parqueaderoid")
                        .HasColumnType("int");

                    b.Property<int?>("Vehiculo_1id")
                        .HasColumnType("int");

                    b.Property<int?>("Vehiculo_2id")
                        .HasColumnType("int");

                    b.Property<string>("apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("condicionEspecial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("correoElectronico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("identificacion")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Parqueaderoid");

                    b.HasIndex("Vehiculo_1id");

                    b.HasIndex("Vehiculo_2id");

                    b.ToTable("personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("UCP.App.Dominio.Puesto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("Parqueaderoid")
                        .HasColumnType("int");

                    b.Property<int>("estado")
                        .HasColumnType("int");

                    b.Property<int>("numero")
                        .HasColumnType("int");

                    b.Property<int>("tipoVehiculo")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Parqueaderoid");

                    b.ToTable("puestos");
                });

            modelBuilder.Entity("UCP.App.Dominio.Transaccion", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("Parqueaderoid")
                        .HasColumnType("int");

                    b.Property<DateTime>("horaIngreso")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("horaSalida")
                        .HasColumnType("datetime2");

                    b.Property<int?>("personaid")
                        .HasColumnType("int");

                    b.Property<int?>("vehiculoid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Parqueaderoid");

                    b.HasIndex("personaid");

                    b.HasIndex("vehiculoid");

                    b.ToTable("transacciones");
                });

            modelBuilder.Entity("UCP.App.Dominio.Vehiculo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("modelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("placa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tipoVehiculo")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("vehiculos");
                });

            modelBuilder.Entity("UCP.App.Dominio.Administrativo", b =>
                {
                    b.HasBaseType("UCP.App.Dominio.Persona");

                    b.Property<int>("oficina")
                        .HasColumnType("int");

                    b.Property<float>("tarifaAdministrativo")
                        .HasColumnType("real");

                    b.Property<string>("unidad")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Administrativo");
                });

            modelBuilder.Entity("UCP.App.Dominio.Estudiante", b =>
                {
                    b.HasBaseType("UCP.App.Dominio.Persona");

                    b.Property<string>("programa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("tarifaEstudiante")
                        .HasColumnType("real");

                    b.HasDiscriminator().HasValue("Estudiante");
                });

            modelBuilder.Entity("UCP.App.Dominio.Profesor", b =>
                {
                    b.HasBaseType("UCP.App.Dominio.Persona");

                    b.Property<int>("cubiculo")
                        .HasColumnType("int");

                    b.Property<string>("facultad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("tarifaProfesor")
                        .HasColumnType("real");

                    b.HasDiscriminator().HasValue("Profesor");
                });

            modelBuilder.Entity("UCP.App.Dominio.Visitante", b =>
                {
                    b.HasBaseType("UCP.App.Dominio.Persona");

                    b.Property<string>("actividad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("autoriza")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("tarifaVisitante")
                        .HasColumnType("real");

                    b.HasDiscriminator().HasValue("Visitante");
                });

            modelBuilder.Entity("UCP.App.Dominio.Persona", b =>
                {
                    b.HasOne("UCP.App.Dominio.Parqueadero", null)
                        .WithMany("personas")
                        .HasForeignKey("Parqueaderoid");

                    b.HasOne("UCP.App.Dominio.Vehiculo", "Vehiculo_1")
                        .WithMany()
                        .HasForeignKey("Vehiculo_1id");

                    b.HasOne("UCP.App.Dominio.Vehiculo", "Vehiculo_2")
                        .WithMany()
                        .HasForeignKey("Vehiculo_2id");

                    b.Navigation("Vehiculo_1");

                    b.Navigation("Vehiculo_2");
                });

            modelBuilder.Entity("UCP.App.Dominio.Puesto", b =>
                {
                    b.HasOne("UCP.App.Dominio.Parqueadero", null)
                        .WithMany("puestos")
                        .HasForeignKey("Parqueaderoid");
                });

            modelBuilder.Entity("UCP.App.Dominio.Transaccion", b =>
                {
                    b.HasOne("UCP.App.Dominio.Parqueadero", null)
                        .WithMany("Transacciones")
                        .HasForeignKey("Parqueaderoid");

                    b.HasOne("UCP.App.Dominio.Persona", "persona")
                        .WithMany()
                        .HasForeignKey("personaid");

                    b.HasOne("UCP.App.Dominio.Vehiculo", "vehiculo")
                        .WithMany()
                        .HasForeignKey("vehiculoid");

                    b.Navigation("persona");

                    b.Navigation("vehiculo");
                });

            modelBuilder.Entity("UCP.App.Dominio.Parqueadero", b =>
                {
                    b.Navigation("personas");

                    b.Navigation("puestos");

                    b.Navigation("Transacciones");
                });
#pragma warning restore 612, 618
        }
    }
}
