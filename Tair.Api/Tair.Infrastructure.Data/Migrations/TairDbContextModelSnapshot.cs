﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tair.Data.Context;

namespace Tair.Infrastructure.Data.Migrations
{
    [DbContext(typeof(TairDbContext))]
    partial class TairDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Tair.Domain.Entities.Artigos", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EscritoPor")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("FotoCapa")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Html")
                        .IsRequired()
                        .HasMaxLength(8000)
                        .HasColumnType("varchar(8000)");

                    b.Property<string>("Resumo")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("varchar(2000)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("UrlArtigo")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Artigos");
                });

            modelBuilder.Entity("Tair.Domain.Entities.Reservas", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ChargeId")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ChargeStatus")
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("DataVoo")
                        .HasColumnType("datetime2");

                    b.Property<string>("ErrorMessage")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Identificador")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("TransactionId")
                        .HasColumnType("varchar(100)");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("VooId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("VooId");

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

                    b.Property<string>("UrlVoo")
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Voos");
                });

            modelBuilder.Entity("Tair.Domain.Entities.Reservas", b =>
                {
                    b.HasOne("Tair.Domain.Entities.Voos", "Voo")
                        .WithMany("Reservas")
                        .HasForeignKey("VooId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Voo");
                });

            modelBuilder.Entity("Tair.Domain.Entities.Voos", b =>
                {
                    b.Navigation("Reservas");
                });
#pragma warning restore 612, 618
        }
    }
}
