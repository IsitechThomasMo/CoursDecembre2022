using Microsoft.EntityFrameworkCore;

namespace HeroAPI
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }    

    public DbSet<Food> Food { get; set; }
    public DbSet<Character> Character { get; set; }
    
    }
}
