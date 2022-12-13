using Microsoft.EntityFrameworkCore;
using PersonalService.Model;

namespace PersonalService.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Personal> Personals { get; set; }
    }
}
