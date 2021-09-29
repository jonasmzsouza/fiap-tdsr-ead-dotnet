﻿// <auto-generated />
using System;
using Fiap.Aula03.Web.Exemplo01.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Fiap.Aula03.Web.Exemplo01.Migrations
{
    [DbContext(typeof(FiapFlixContext))]
    partial class FiapFlixContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Fiap.Aula03.Web.Exemplo01.Models.Filme", b =>
                {
                    b.Property<int>("FilmeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataLancamento")
                        .HasColumnType("datetime2")
                        .HasColumnName("Data_Lancamento");

                    b.Property<int>("Genero")
                        .HasColumnType("int")
                        .HasColumnName("Genero");

                    b.Property<bool>("MaiorIdade")
                        .HasColumnType("bit")
                        .HasColumnName("Maior_Idade");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Sinopse")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("FilmeId");

                    b.ToTable("Tbl_Filme");
                });
#pragma warning restore 612, 618
        }
    }
}
