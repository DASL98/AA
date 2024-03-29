﻿// <auto-generated />
using AA.Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AA.Migrations
{
    [DbContext(typeof(MascotaContext))]
    [Migration("20190612174555_DatosTIPOMASCOTA")]
    partial class DatosTIPOMASCOTA
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AA.Models.Mascota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CodigoMascota")
                        .IsRequired();

                    b.Property<int>("Edad");

                    b.Property<string>("Foto")
                        .IsRequired();

                    b.Property<string>("NombreMascota")
                        .IsRequired();

                    b.Property<int>("Peso");

                    b.Property<int>("TipoId");

                    b.HasKey("Id");

                    b.HasIndex("TipoId");

                    b.ToTable("Mascotas");
                });

            modelBuilder.Entity("AA.Models.TipoMascota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Tipos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Perro"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Gato"
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Tapir"
                        });
                });

            modelBuilder.Entity("AA.Models.Mascota", b =>
                {
                    b.HasOne("AA.Models.TipoMascota", "Tipo")
                        .WithMany("Mascotas")
                        .HasForeignKey("TipoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
