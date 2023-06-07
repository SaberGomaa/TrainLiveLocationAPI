using Contracts;
using Repository;

namespace TraineAPI.Extentation
{
    public static class ServiceExtensions
    {

        //for repository manegar to add it in the main program
        public static void ConfigreRepositoryManegar(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryManegar, RepositoryManegar>();
        }

        //we have registered our RepositoryContext class at design time at RepositoryContextFactory This helps us find the RepositoryContext class in another project while executing migrations
        // this for RepositoryManager service registration, which happens at runtime
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSqlServer<RepositoryContext>((configuration.GetConnectionString("sqlConnection")));
        }
    }
}
