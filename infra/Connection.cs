using Microsoft.EntityFrameworkCore;
using PrimeiraAPI.Model;

namespace PrimeiraAPI.infra
{
    public class Connection : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        private readonly IConfiguration _configuration;

        public Connection(IConfiguration configuration, DbContextOptions options) : base(options)
        {

            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

   

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = _configuration.GetConnectionString("SqlServer");

            if (string.IsNullOrEmpty(connectionString))
            {
                Console.WriteLine("A Connection String não está configurada ou está vazia.");
                throw new InvalidOperationException("Connection string for SQL Server is not configured.");
            }

            Console.WriteLine("Connection String: " + connectionString);
            try
            {
                optionsBuilder.UseSqlServer(connectionString);
                Console.WriteLine("Configuração de conexão realizada com sucesso.");
            }
            catch (Exception e)
            {

                Console.WriteLine("Erro ao configurar a conexão com o banco de dados: " + e.Message);
                Console.WriteLine("Stack Trace: " + e.StackTrace);
                throw;
            }
        }
    }

}
