using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace GarageSoft.Application;

public static class ApplicationServiceRegistration
{
    extension(IServiceCollection source)
    {
        public IServiceCollection AddApplicationServices()
        {

            source.AddAutoMapper(cfg => { cfg.AddMaps(AppDomain.CurrentDomain.GetAssemblies()); });
            source.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

            return source;
        }
    }
}
