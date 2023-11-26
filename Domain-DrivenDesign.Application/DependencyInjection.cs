using Domain_DrivenDesign.Domain.Abstraction;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Domain_DrivenDesign.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(
        this IServiceCollection services)
    {
        services.AddMediatR(cfr =>
        {
            cfr.RegisterServicesFromAssemblies(
                Assembly.GetExecutingAssembly(),
                typeof(Entity).Assembly);
        });

        return services;
    }
}
