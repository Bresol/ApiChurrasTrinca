using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiChurrasTrinca.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Churrasco> Churrascos { get; set; }
        public DbSet<Participante> Participantes { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder
        //         .UseLazyLoadingProxies()
        //         .UseSqlServer("Data Source = MACORATTI; " +
        //              "Initial Catalog=CursoEFCOreModulo11DB;Integrated Security=True");
        //    optionsBuilder.UseLoggerFactory(new LoggerFactory().AddConsole((category, level) =>
        //         level == LogLevel.Information &&
        //            category == DbLoggerCategory.Database.Command.Name, true));
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Participante>()
            .HasOne(p => p.Churrasco)
            .WithMany(b => b.Participantes)
            .HasForeignKey(p => p.IdChurrasco);

            modelBuilder.Entity<Churrasco>()
                .HasData(
                new Churrasco { Id = 1, Descricao = "Primeiro Churras", Observacao = "Obs1", Data = DateTime.Now, ValorSugeridoPorParticipante = 30, ValorSugeridoPorParticipanteComBebida = 45 },
                new Churrasco { Id = 2, Descricao = "Segundo Churras", Observacao = "Obs2", Data = DateTime.Now.AddDays(1), ValorSugeridoPorParticipante = 30, ValorSugeridoPorParticipanteComBebida = 45 },
                new Churrasco { Id = 3, Descricao = "Terceiro Churras", Observacao = "Obs3", Data = DateTime.Now.AddDays(2), ValorSugeridoPorParticipante = 30, ValorSugeridoPorParticipanteComBebida = 45 }
                );

            modelBuilder.Entity<Participante>()
                .HasData(
                new Participante { Id = 1, Nome = "A", ValorDeContribuicao = 30, IdChurrasco = 1 },
                new Participante { Id = 2, Nome = "B", ValorDeContribuicao = 45, IdChurrasco = 1 },
                new Participante { Id = 3, Nome = "C", ValorDeContribuicao = 30, IdChurrasco = 1 },
                new Participante { Id = 4, Nome = "A", ValorDeContribuicao = 45, IdChurrasco = 2 },
                new Participante { Id = 5, Nome = "B", ValorDeContribuicao = 30, IdChurrasco = 2 },
                new Participante { Id = 6, Nome = "C", ValorDeContribuicao = 30, IdChurrasco = 3 }
                );
        }
    }
}
