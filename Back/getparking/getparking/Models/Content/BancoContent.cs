using System.Data.Entity;
using getparking.Models.Entity;
using GetParking.Models;
using MySql.Data.Entity;

namespace getparking.Models.Content
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class BancoContent : DbContext
    {
        public BancoContent() : base("BancoContent")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BancoContent, Configuration>());
        }

        public DbSet<Teste> Testes { get; set; }

        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Cidade> Cidades { get; set; }
        public virtual DbSet<Bairro> Bairros { get; set; }
        public virtual DbSet<Rua> Ruas { get; set; }
        public virtual DbSet<Quarteirao> Quarteiroes { get; set; }
        public virtual DbSet<Veiculo> Veiculos { get; set; }
        public virtual DbSet<Vaga> Vagas { get; set; }
        public virtual DbSet<Denuncia> Denuncias { get; set; }
        public virtual DbSet<FormaPagamento> FormasPagamento { get; set; }
        public virtual DbSet<Reserva> Reservas { get; set; }
        public virtual DbSet<Pagamento> Pagamentos { get; set; }
    }
}