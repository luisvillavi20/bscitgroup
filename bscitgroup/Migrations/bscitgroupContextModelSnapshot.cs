﻿// <auto-generated />
using bscitgroup.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace bscitgroup.Migrations
{
    [DbContext(typeof(bscitgroupContext))]
    partial class bscitgroupContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("bscitgroup.Models.Categorias", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<int?>("PersonaDNI");

                    b.HasKey("ID");

                    b.HasIndex("PersonaDNI");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("bscitgroup.Models.Persona", b =>
                {
                    b.Property<int>("DNI")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellido")
                        .IsRequired();

                    b.Property<string>("Celular")
                        .IsRequired();

                    b.Property<string>("Ciudad")
                        .IsRequired();

                    b.Property<string>("Correo")
                        .IsRequired();

                    b.Property<string>("Institucion")
                        .IsRequired();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<string>("Pais")
                        .IsRequired();

                    b.Property<string>("Profesion")
                        .IsRequired();

                    b.Property<string>("Telefono");

                    b.HasKey("DNI");

                    b.ToTable("Persona");
                });

            modelBuilder.Entity("bscitgroup.Models.Categorias", b =>
                {
                    b.HasOne("bscitgroup.Models.Persona")
                        .WithMany("Intereses")
                        .HasForeignKey("PersonaDNI");
                });
#pragma warning restore 612, 618
        }
    }
}
