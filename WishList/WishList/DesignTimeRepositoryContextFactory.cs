using DBRepository.Factories;
using DBRepository;
using Microsoft.EntityFrameworkCore.Design;

namespace WishList
{
    public class DesignTimeRepositoryContextFactory :
    IDesignTimeDbContextFactory<RepositoryContext>
    {
        public RepositoryContext CreateDbContext(string[] args)
        {
            var builder = new ConfigurationBuilder()
                      .SetBasePath(Directory.GetCurrentDirectory())
                  .AddJsonFile("appsettings.json");

            var config = builder.Build();
            var connectionString = config.GetConnectionString("DefaultConnection");
            var repositoryFactory = new RepositoryContextFactory();

            return repositoryFactory.CreateDbContext(connectionString);
        }
    }
}
