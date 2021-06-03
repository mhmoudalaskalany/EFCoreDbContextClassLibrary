using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class EfCoreDbContext : DbContext
    {
        public EfCoreDbContext(DbContextOptions<EfCoreDbContext> options) : base(options)
        {
            
        }
        
    }
}
