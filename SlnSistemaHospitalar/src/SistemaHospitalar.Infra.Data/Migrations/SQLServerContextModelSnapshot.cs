﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaHospitalar.Infra.Data.Context;

#nullable disable

namespace SistemaHospitalar.Infra.Data.Migrations
{
    [DbContext(typeof(SQLServerContext))]
    partial class SQLServerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SistemaHospitalar.Domain.Entities.Convenio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Convenios", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Clinipam"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Unimed"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "SC Saúde"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Amil"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Boa Saúde"
                        },
                        new
                        {
                            Id = 6,
                            Nome = "Bradesco Saúde"
                        },
                        new
                        {
                            Id = 7,
                            Nome = "HapVida"
                        });
                });

            modelBuilder.Entity("SistemaHospitalar.Domain.Entities.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PessoaId")
                        .HasColumnType("int");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.ToTable("Enderecos", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bairro = "Nossa Senhora Aparecida",
                            Cep = "01001-000",
                            Cidade = "São Paulo",
                            Numero = "18",
                            PessoaId = 1,
                            Rua = "Rua Fulaninho de Assis",
                            UF = "SP"
                        },
                        new
                        {
                            Id = 2,
                            Bairro = "Fortaleza",
                            Cep = "89055-440",
                            Cidade = "Santa Catarina",
                            Numero = "5",
                            PessoaId = 2,
                            Rua = "Rua Fulaninho Monteiro",
                            UF = "SC"
                        },
                        new
                        {
                            Id = 3,
                            Bairro = "Nossa Senhora Aparecida",
                            Cep = "01001-000",
                            Cidade = "São Paulo",
                            Numero = "18",
                            PessoaId = 3,
                            Rua = "Rua Fulaninho de Assis",
                            UF = "SP"
                        },
                        new
                        {
                            Id = 4,
                            Bairro = "Itoupava",
                            Cep = "89741-123",
                            Cidade = "Belo Horizonte",
                            Numero = "4562",
                            PessoaId = 4,
                            Rua = "Rua Fulaninho de Souza",
                            UF = "Minas Gerais"
                        });
                });

            modelBuilder.Entity("SistemaHospitalar.Domain.Entities.EspecialidadeMedica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EspecialidadesMedicas", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Especialista em Cardiologia"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Especialista em Dermatologia"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Especialista em Endoscopia"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Especialista em Ginecologia e Obstetrícia"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Especialista em Nutrologia"
                        },
                        new
                        {
                            Id = 6,
                            Nome = "Especialista em Oftalmologia"
                        },
                        new
                        {
                            Id = 7,
                            Nome = "Especialista em Oncologia Clínica"
                        },
                        new
                        {
                            Id = 8,
                            Nome = "Especialista em Ortopedia e Traumatologia"
                        },
                        new
                        {
                            Id = 9,
                            Nome = "Especialista em Otorrinolaringologia"
                        },
                        new
                        {
                            Id = 10,
                            Nome = "Especialista em Pediatria"
                        },
                        new
                        {
                            Id = 11,
                            Nome = "Especialista em Pneumologia"
                        },
                        new
                        {
                            Id = 12,
                            Nome = "Especialista em Psiquiatria"
                        },
                        new
                        {
                            Id = 13,
                            Nome = "Especialista em Radioterapia"
                        },
                        new
                        {
                            Id = 14,
                            Nome = "Especialista em Reumatologia"
                        },
                        new
                        {
                            Id = 15,
                            Nome = "Especialista em Urologia"
                        });
                });

            modelBuilder.Entity("SistemaHospitalar.Domain.Entities.Medico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CRM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EspecialidadeId")
                        .HasColumnType("int");

                    b.Property<int>("PessoaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EspecialidadeId");

                    b.HasIndex("PessoaId");

                    b.ToTable("Medicos", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CRM = "6546hk55w",
                            EspecialidadeId = 10,
                            PessoaId = 2
                        });
                });

            modelBuilder.Entity("SistemaHospitalar.Domain.Entities.Paciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ConvenioId")
                        .HasColumnType("int");

                    b.Property<int>("PessoaId")
                        .HasColumnType("int");

                    b.Property<int>("Situacao")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ConvenioId");

                    b.HasIndex("PessoaId");

                    b.ToTable("Pacientes", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConvenioId = 1,
                            PessoaId = 1,
                            Situacao = 2
                        });
                });

            modelBuilder.Entity("SistemaHospitalar.Domain.Entities.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naturalidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Perfil")
                        .HasColumnType("int");

                    b.Property<string>("Rg")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sexo")
                        .HasColumnType("int");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pessoas", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cpf = "156.789.754-85",
                            CreatedOn = new DateTime(2023, 6, 18, 21, 29, 51, 11, DateTimeKind.Local).AddTicks(1272),
                            DataNascimento = new DateTime(2023, 6, 18, 21, 29, 51, 11, DateTimeKind.Local).AddTicks(1264),
                            Email = "ana@gmail.com",
                            Naturalidade = "Blumenau/SC",
                            Nome = "Ana",
                            Perfil = 2,
                            Rg = "7.654.852",
                            Senha = "123",
                            Sexo = 0,
                            Sobrenome = "da Silva",
                            Telefone = "(47)3339-4832"
                        },
                        new
                        {
                            Id = 2,
                            Cpf = "456.799.466-65",
                            CreatedOn = new DateTime(2023, 6, 18, 21, 29, 51, 11, DateTimeKind.Local).AddTicks(1274),
                            DataNascimento = new DateTime(2023, 6, 18, 21, 29, 51, 11, DateTimeKind.Local).AddTicks(1273),
                            Email = "carlos@gmail.com",
                            Naturalidade = "Criciúma/SC",
                            Nome = "Carlos",
                            Perfil = 1,
                            Rg = "7.654.852",
                            Senha = "123",
                            Sexo = 1,
                            Sobrenome = "da Silva",
                            Telefone = "(47)3339-1235"
                        },
                        new
                        {
                            Id = 3,
                            Cpf = "787.464.796-56",
                            CreatedOn = new DateTime(2023, 6, 18, 21, 29, 51, 11, DateTimeKind.Local).AddTicks(1275),
                            DataNascimento = new DateTime(2023, 6, 18, 21, 29, 51, 11, DateTimeKind.Local).AddTicks(1275),
                            Email = "maria@gmail.com",
                            Naturalidade = "Joinville/SC",
                            Nome = "Maria Clara",
                            Perfil = 3,
                            Rg = "7.654.852",
                            Senha = "123",
                            Sexo = 0,
                            Sobrenome = "da Silva",
                            Telefone = "(47)3339-8923"
                        },
                        new
                        {
                            Id = 4,
                            Cpf = "899.799.465-78",
                            CreatedOn = new DateTime(2023, 6, 18, 21, 29, 51, 11, DateTimeKind.Local).AddTicks(1277),
                            DataNascimento = new DateTime(2023, 6, 18, 21, 29, 51, 11, DateTimeKind.Local).AddTicks(1276),
                            Email = "joao@gmail.com",
                            Naturalidade = "Blumenau/SC",
                            Nome = "Jupiter",
                            Perfil = 0,
                            Rg = "7.654.852",
                            Senha = "123",
                            Sexo = 2,
                            Sobrenome = "da Silva",
                            Telefone = "(47)3339-8965"
                        });
                });

            modelBuilder.Entity("SistemaHospitalar.Domain.Entities.Prontuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Conduta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExameFisico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HipoteseDiagnostica")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HistoricoFamiliar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MedicoId")
                        .HasColumnType("int");

                    b.Property<int>("PacienteId")
                        .HasColumnType("int");

                    b.Property<string>("Prescricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QueixaPrincipal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MedicoId");

                    b.HasIndex("PacienteId");

                    b.ToTable("Prontuarios", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Conduta = "Solicito EDA, PHmetria e exames laboratoriais ",
                            CreatedOn = new DateTime(2023, 6, 18, 21, 29, 51, 11, DateTimeKind.Local).AddTicks(1400),
                            Descricao = "Aproximadamente há 20 dias, evoluiu uma dor forte na barriga que piora com café e bebidas ácidas",
                            ExameFisico = "BNF sem SA, MVUA sem alterações, dor a palpação de região epigástrica",
                            HipoteseDiagnostica = "K29 - Gastrite e duodenite",
                            HistoricoFamiliar = "Ninguém na família com sistomas parecidos",
                            MedicoId = 1,
                            PacienteId = 1,
                            Prescricao = "Annita de 12/12hs por 3 dias",
                            QueixaPrincipal = "Dor na barriga"
                        },
                        new
                        {
                            Id = 2,
                            Conduta = "Solicito EDA, PHmetria e exames laboratoriais ",
                            CreatedOn = new DateTime(2023, 6, 18, 21, 29, 51, 11, DateTimeKind.Local).AddTicks(1402),
                            Descricao = "Aproximadamente há 20 dias, evoluiu uma dor forte na cabeça",
                            ExameFisico = "BNF sem SA, MVUA sem alterações, dor a palpação de região epigástrica",
                            HipoteseDiagnostica = "Dor de cabeça normal",
                            HistoricoFamiliar = "Ninguém na família com sistomas parecidos",
                            MedicoId = 1,
                            PacienteId = 1,
                            Prescricao = "Dipirona de 12/12hs por 3 dias",
                            QueixaPrincipal = "Dor de cabeça"
                        });
                });

            modelBuilder.Entity("SistemaHospitalar.Domain.Entities.Recepcionista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bloco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PessoaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.ToTable("Recepcionistas", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bloco = "02-D",
                            PessoaId = 3
                        });
                });

            modelBuilder.Entity("SistemaHospitalar.Domain.Entities.Endereco", b =>
                {
                    b.HasOne("SistemaHospitalar.Domain.Entities.Pessoa", "Pessoa")
                        .WithMany("Enderecos")
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("SistemaHospitalar.Domain.Entities.Medico", b =>
                {
                    b.HasOne("SistemaHospitalar.Domain.Entities.EspecialidadeMedica", "Especialidade")
                        .WithMany()
                        .HasForeignKey("EspecialidadeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("SistemaHospitalar.Domain.Entities.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Especialidade");

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("SistemaHospitalar.Domain.Entities.Paciente", b =>
                {
                    b.HasOne("SistemaHospitalar.Domain.Entities.Convenio", "Convenio")
                        .WithMany()
                        .HasForeignKey("ConvenioId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("SistemaHospitalar.Domain.Entities.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Convenio");

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("SistemaHospitalar.Domain.Entities.Prontuario", b =>
                {
                    b.HasOne("SistemaHospitalar.Domain.Entities.Medico", "Medico")
                        .WithMany()
                        .HasForeignKey("MedicoId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("SistemaHospitalar.Domain.Entities.Paciente", "Paciente")
                        .WithMany()
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Medico");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("SistemaHospitalar.Domain.Entities.Recepcionista", b =>
                {
                    b.HasOne("SistemaHospitalar.Domain.Entities.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("SistemaHospitalar.Domain.Entities.Pessoa", b =>
                {
                    b.Navigation("Enderecos");
                });
#pragma warning restore 612, 618
        }
    }
}
