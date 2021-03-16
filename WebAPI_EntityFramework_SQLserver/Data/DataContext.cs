using Microsoft.EntityFrameworkCore;
using Models;

namespace Data
{
    public class DataContext : DbContext
    {
        // public DataContext(DbContextOptions<DataContext> options) : base(options)
        // {}

        // public DataContext(DbContextOptions options) : base(options)
        // { }

        // public DataContext() : base()
        // { }

        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseMySql("Server=IP-or-DNS;Port=PORT-NUMBER;Database=DB-NAME;Uid=USER-NAME;Pwd=PASS-WORD;charset=utf8;");
            optionsBuilder.UseSqlServer(@"Server=IP-or-DNS\SQLEXPRESS;Database=DB-NAME;Trusted_Connection=True;");
        }
    }
}