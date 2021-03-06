// <auto-generated />
using System;
using ApiChurrasTrinca.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiChurrasTrinca.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApiChurrasTrinca.Data.Churrasco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ValorSugeridoPorParticipante")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ValorSugeridoPorParticipanteComBebida")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Churrascos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Data = new DateTime(2021, 4, 11, 9, 24, 10, 741, DateTimeKind.Local).AddTicks(8522),
                            Descricao = "Primeiro Churras",
                            Observacao = "Obs1",
                            ValorSugeridoPorParticipante = 30m,
                            ValorSugeridoPorParticipanteComBebida = 45m
                        },
                        new
                        {
                            Id = 2,
                            Data = new DateTime(2021, 4, 12, 9, 24, 10, 742, DateTimeKind.Local).AddTicks(9111),
                            Descricao = "Segundo Churras",
                            Observacao = "Obs2",
                            ValorSugeridoPorParticipante = 30m,
                            ValorSugeridoPorParticipanteComBebida = 45m
                        },
                        new
                        {
                            Id = 3,
                            Data = new DateTime(2021, 4, 13, 9, 24, 10, 742, DateTimeKind.Local).AddTicks(9189),
                            Descricao = "Terceiro Churras",
                            Observacao = "Obs3",
                            ValorSugeridoPorParticipante = 30m,
                            ValorSugeridoPorParticipanteComBebida = 45m
                        });
                });

            modelBuilder.Entity("ApiChurrasTrinca.Data.Participante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdChurrasco")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ValorDeContribuicao")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("IdChurrasco");

                    b.ToTable("Participantes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IdChurrasco = 1,
                            Nome = "A",
                            ValorDeContribuicao = 30m
                        },
                        new
                        {
                            Id = 2,
                            IdChurrasco = 1,
                            Nome = "B",
                            ValorDeContribuicao = 45m
                        },
                        new
                        {
                            Id = 3,
                            IdChurrasco = 1,
                            Nome = "C",
                            ValorDeContribuicao = 30m
                        },
                        new
                        {
                            Id = 4,
                            IdChurrasco = 2,
                            Nome = "A",
                            ValorDeContribuicao = 45m
                        },
                        new
                        {
                            Id = 5,
                            IdChurrasco = 2,
                            Nome = "B",
                            ValorDeContribuicao = 30m
                        },
                        new
                        {
                            Id = 6,
                            IdChurrasco = 3,
                            Nome = "C",
                            ValorDeContribuicao = 30m
                        });
                });

            modelBuilder.Entity("ApiChurrasTrinca.Data.Participante", b =>
                {
                    b.HasOne("ApiChurrasTrinca.Data.Churrasco", "Churrasco")
                        .WithMany("Participantes")
                        .HasForeignKey("IdChurrasco")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Churrasco");
                });

            modelBuilder.Entity("ApiChurrasTrinca.Data.Churrasco", b =>
                {
                    b.Navigation("Participantes");
                });
#pragma warning restore 612, 618
        }
    }
}
