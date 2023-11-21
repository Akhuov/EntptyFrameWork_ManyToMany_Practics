using Microsoft.EntityFrameworkCore;
using Practics_entityFr.Models;

namespace Practics_entityFr.DataBase
{
    public class UserDB: DbContext
    {
        private readonly string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=password;Database=LibDB";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString);
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<User> Users { get; set; }

        public DbSet<Book> Books{ get; set; }
    }
}
