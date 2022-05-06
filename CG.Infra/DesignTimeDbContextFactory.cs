using CG.Infra.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace CG.Infra
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<CgDbContext>
    {
        public CgDbContext CreateDbContext(string[] args)
        {
            var environmentName = Environment.GetEnvironmentVariable("ASPNETCPRE_ENVIROMENT");
            var fileName = Directory.GetCurrentDirectory() + $"/../CG.Api/appsettings.json";

            var configuration = new ConfigurationBuilder()
                .AddJsonFile(fileName)
                .Build();

            var builder = new DbContextOptionsBuilder<CgDbContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseSqlServer(connectionString);

            return new CgDbContext(builder.Options);
        }
    }
}
