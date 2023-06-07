using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Repository;


//access the connection string from the appsettings
// because migration assembly is not in our main project, but in the Repository project
namespace Train_API.ContextFactory
{
    //we have registered our RepositoryContext class at design time at RepositoryContextFactory This helps us find the RepositoryContext class in another project while executing migrations
    public class RepositoryContextFactory : IDesignTimeDbContextFactory<RepositoryContext>
    {
        public RepositoryContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            var builder = new DbContextOptionsBuilder<RepositoryContext>()
                .UseSqlServer(configuration.GetConnectionString("sqlConnection"),
                 b => b.MigrationsAssembly("TraineAPI"));

            return new RepositoryContext(builder.Options);
        }
    }
}
