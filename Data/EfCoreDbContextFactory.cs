using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Data
{
    public class EfCoreDbContextFactory : IDesignTimeDbContextFactory<EfCoreDbContext>
    {
        private IConfiguration Configuration => new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json").Build();

        public EfCoreDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<EfCoreDbContext>();
            builder.UseSqlServer(Configuration.GetConnectionString("sql"));
            return new EfCoreDbContext(builder.Options);
        }
    }
}
