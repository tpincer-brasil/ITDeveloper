﻿// <auto-generated />
using System;
using Cooperchip.ITDeveloper.Data.ORM;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cooperchip.ITDeveloper.Data.Migrations
{
    [DbContext(typeof(ITDeveloperDbContext))]
    [Migration("20190924222639_AddPaciente")]
    partial class AddPaciente
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Cooperchip.ITDeveloper.Domain.Entities.Mural", b =>
                {
                    b.Property<int>("MuralId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Autor");

                    b.Property<string>("Aviso");

                    b.Property<DateTime>("Data");

                    b.Property<string>("Email");

                    b.Property<string>("Titulo");

                    b.HasKey("MuralId");

                    b.ToTable("Mural");
                });

            modelBuilder.Entity("Cooperchip.ITDeveloper.Domain.Models.Paciente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo");

                    b.Property<string>("Cpf");

                    b.Property<DateTime>("DataInternacao");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.Property<string>("Rg");

                    b.Property<DateTime>("RgDataEmissao");

                    b.Property<string>("RgOrgao");

                    b.Property<int>("Sexo");

                    b.Property<int>("TipoPaciente");

                    b.HasKey("Id");

                    b.ToTable("Paciente");
                });
#pragma warning restore 612, 618
        }
    }
}
