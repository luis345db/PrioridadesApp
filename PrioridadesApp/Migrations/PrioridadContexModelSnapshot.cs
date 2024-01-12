﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PrioridadesApp.DAL;

#nullable disable

namespace PrioridadesApp.Migrations
{
    [DbContext(typeof(PrioridadContex))]
    partial class PrioridadContexModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("PrioridadesApp.Models.Prioridades", b =>
                {
                    b.Property<int>("PriodidadID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("DiasComprometidos")
                        .HasColumnType("INTEGER");

                    b.HasKey("PriodidadID");

                    b.ToTable("Prioridades");
                });
#pragma warning restore 612, 618
        }
    }
}
