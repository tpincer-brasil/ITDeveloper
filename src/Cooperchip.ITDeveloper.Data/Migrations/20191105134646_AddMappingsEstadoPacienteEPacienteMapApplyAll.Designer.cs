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
    [Migration("20191105134646_AddMappingsEstadoPacienteEPacienteMapApplyAll")]
    partial class AddMappingsEstadoPacienteEPacienteMapApplyAll
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

                    b.Property<string>("Autor")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Aviso")
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("Data");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Titulo")
                        .HasColumnType("varchar(100)");

                    b.HasKey("MuralId");

                    b.ToTable("Mural");
                });

            modelBuilder.Entity("Cooperchip.ITDeveloper.Domain.Models.EstadoPaciente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnName("Descricao")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("EstadoPaciente");
                });

            modelBuilder.Entity("Cooperchip.ITDeveloper.Domain.Models.MovimentoPaciente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataMovimento");

                    b.Property<string>("Observacao")
                        .HasColumnType("varchar(100)");

                    b.Property<Guid>("PacienteId");

                    b.Property<int>("TipoEntradaPaciente");

                    b.Property<int>("TipoMovimentoPaciente");

                    b.Property<int>("TipoSaidaPaciente");

                    b.HasKey("Id");

                    b.HasIndex("PacienteId");

                    b.ToTable("MovimentoPaciente");
                });

            modelBuilder.Entity("Cooperchip.ITDeveloper.Domain.Models.Paciente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo");

                    b.Property<string>("Cpf")
                        .HasColumnName("Cpf")
                        .HasColumnType("varchar(100)")
                        .IsFixedLength(true)
                        .HasMaxLength(11);

                    b.Property<DateTime>("DataInternacao");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Email")
                        .HasColumnName("Email")
                        .HasColumnType("varchar(100)");

                    b.Property<Guid>("EstadoPacienteId");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("Nome")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Rg")
                        .HasColumnName("Rg")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(15);

                    b.Property<DateTime>("RgDataEmissao");

                    b.Property<string>("RgOrgao")
                        .HasColumnName("RgOrgao")
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Sexo");

                    b.Property<int>("TipoPaciente");

                    b.HasKey("Id");

                    b.HasIndex("EstadoPacienteId");

                    b.ToTable("Paciente");
                });

            modelBuilder.Entity("Cooperchip.ITDeveloper.Domain.Models.MovimentoPaciente", b =>
                {
                    b.HasOne("Cooperchip.ITDeveloper.Domain.Models.Paciente", "Paciente")
                        .WithMany()
                        .HasForeignKey("PacienteId");
                });

            modelBuilder.Entity("Cooperchip.ITDeveloper.Domain.Models.Paciente", b =>
                {
                    b.HasOne("Cooperchip.ITDeveloper.Domain.Models.EstadoPaciente", "EstadoPaciente")
                        .WithMany("Paciente")
                        .HasForeignKey("EstadoPacienteId");
                });
#pragma warning restore 612, 618
        }
    }
}