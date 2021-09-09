﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAgroCoreBCC2021.Models;

namespace WebAgroCoreBCC2021.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAgroCoreBCC2021.Models.Dominio.Agricultor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("bairro")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("cpf")
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<string>("email")
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<int>("idade")
                        .HasColumnType("int");

                    b.Property<string>("municipio")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("proprietario")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.ToTable("Agricultores");
                });

            modelBuilder.Entity("WebAgroCoreBCC2021.Models.Dominio.Area", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("gps")
                        .HasColumnType("int");

                    b.Property<float>("hectares")
                        .HasColumnType("real");

                    b.Property<string>("municipio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("produtorid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("produtorid");

                    b.ToTable("Areas");
                });

            modelBuilder.Entity("WebAgroCoreBCC2021.Models.Dominio.Insumo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("quantidade")
                        .HasColumnType("real");

                    b.Property<float>("valor")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.ToTable("Insumos");
                });

            modelBuilder.Entity("WebAgroCoreBCC2021.Models.Dominio.InsumoArea", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("areaid")
                        .HasColumnType("int");

                    b.Property<DateTime>("data")
                        .HasColumnType("datetime2");

                    b.Property<int?>("insumoid")
                        .HasColumnType("int");

                    b.Property<float>("quantidade")
                        .HasColumnType("real");

                    b.Property<float>("valor")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.HasIndex("areaid");

                    b.HasIndex("insumoid");

                    b.ToTable("InsumosArea");
                });

            modelBuilder.Entity("WebAgroCoreBCC2021.Models.Dominio.Area", b =>
                {
                    b.HasOne("WebAgroCoreBCC2021.Models.Dominio.Agricultor", "produtor")
                        .WithMany("areas")
                        .HasForeignKey("produtorid");

                    b.Navigation("produtor");
                });

            modelBuilder.Entity("WebAgroCoreBCC2021.Models.Dominio.InsumoArea", b =>
                {
                    b.HasOne("WebAgroCoreBCC2021.Models.Dominio.Area", "area")
                        .WithMany()
                        .HasForeignKey("areaid");

                    b.HasOne("WebAgroCoreBCC2021.Models.Dominio.Insumo", "insumo")
                        .WithMany()
                        .HasForeignKey("insumoid");

                    b.Navigation("area");

                    b.Navigation("insumo");
                });

            modelBuilder.Entity("WebAgroCoreBCC2021.Models.Dominio.Agricultor", b =>
                {
                    b.Navigation("areas");
                });
#pragma warning restore 612, 618
        }
    }
}
