using GarageSoft.Domain.Entities;
using GarageSoft.Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GarageSoft.Infrastructure;

public  static class InfraestructureServiceRegistration
{
    extension(IServiceCollection source)
    {
        public IServiceCollection AddInfrastructureServices(IConfiguration configuration)
        {
            source.AddDbContext<GarageSoftContext>(options =>
               options.UseSqlServer(configuration.GetConnectionString("GarageSoft")),
               ServiceLifetime.Scoped);

            
            return source;
        }
    }
}
