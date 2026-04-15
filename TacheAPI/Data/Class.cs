using Microsoft.EntityFrameworkCore;
using TacheAPI.Models;

namespace TacheAPI.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Tache> Taches { get; set; }
    }
}
