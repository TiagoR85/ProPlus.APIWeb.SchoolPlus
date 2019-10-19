using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProPlus.ApiWeb.SchoolPlus.Dominio.Models;
using System.IO;

namespace ProPlus.APIWeb.SchoolPlus.DbContext
{
    public class SchoolPlusDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public SchoolPlusDbContext() { }
        public SchoolPlusDbContext(DbContextOptions<SchoolPlusDbContext> opts) : base(opts) { }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cla> Clas { get; set; }
        public DbSet<DadosEscolares> DadosEscolares { get; set; }
        public DbSet<DadosGamefication> DadosGamefications { get; set; }
        public DbSet<DadosVisual> DadosVisuals { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Equipe> Equipes { get; set; }
        public DbSet<Municipio> Municipios { get; set; }
        public DbSet<Pontuacao> Pontuacoes { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
        public DbSet<Instituicao> Instituicoes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var builder = new ConfigurationBuilder()
                                    .SetBasePath(Directory.GetCurrentDirectory())
                                    .AddJsonFile("appsettings.json");
                var configuration = builder.Build();
                optionsBuilder.UseSqlServer(configuration["ConnectionStrings:SchoolPlusDbContext"]);
            }
            //base.OnConfiguring(optionsBuilder);
        }
    }
}
