using CrudLL.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudLL.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<TabelaBd> Cadastros { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
