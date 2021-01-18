using Domain;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class WinestoreContext : DbContext
    {
        public WinestoreContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Wine> Wines { get; set; }
    }
}