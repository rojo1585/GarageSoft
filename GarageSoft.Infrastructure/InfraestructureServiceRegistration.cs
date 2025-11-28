using GarageSoft.Application.Contracts.Persistence;
using GarageSoft.Domain.Entities;
using GarageSoft.Infrastructure.DbContexts;
using GarageSoft.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.ClientModel.Primitives;

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

            source.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            source.AddScoped<IClientRepository, ClientRepository>();
            return source;
        }
    }
}
