using Api.Domain;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
