using Microsoft.EntityFrameworkCore;

namespace PersonalService.Data
{
    public class PersonalDataContext : DbContext
    {
        public PersonalDataContext(DbContextOptions<PersonalDataContext> options) : base(options) { }

        public DbSet<Personal> Personals { get; set; }
    }
}
