﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tair.Data.Context;

namespace Tair.Infrastructure.Data.Migrations
{
    [DbContext(typeof(TairDbContext))]
    [Migration("20240812131936_Inserindo_Reservas_e_relacionamento")]
    partial class Inserindo_Reservas_e_relacionamento
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Tair.Domain.Entities.Reservas", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ChargeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChargeStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataVoo")
                        .HasColumnType("datetime2");

                    b.Property<string>("TransactionId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("VooId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("VooId")
                        .IsUnique();

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("Tair.Domain.Entities.Voos", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CategoriaDeVoo")
                        .HasColumnType("int");

                    b.Property<string>("ImagemGrande")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ImagemMedia")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ImagemPequena")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("PrecoCartaoPessoa")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PrecoCartaoTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PrecoPixPessoa")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PrecoPixTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("QuantidadePax")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("varchar(100)");

                    b.Property<int>("TempoDeVooMinutos")
                        .HasColumnType("int");

                    b.Property<int>("TipoDeVoo")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Voos");
                });

            modelBuilder.Entity("Tair.Domain.Entities.Reservas", b =>
                {
                    b.HasOne("Tair.Domain.Entities.Voos", "Voo")
                        .WithOne()
                        .HasForeignKey("Tair.Domain.Entities.Reservas", "VooId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Voo");
                });
#pragma warning restore 612, 618
        }
    }
}
