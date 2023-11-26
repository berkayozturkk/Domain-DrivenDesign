using Domain_DrivenDesign.Domain.Abstraction;
using Domain_DrivenDesign.Domain.Categories;
using Domain_DrivenDesign.Domain.Orders;
using Domain_DrivenDesign.Domain.Products;
using Domain_DrivenDesign.Domain.Users;
using Domain_DrivenDesign.Infrastructure.Context;
using Domain_DrivenDesign.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Domain_DrivenDesign.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services)
    {

        services.AddScoped<ApplicationDbContext>();
        services.AddScoped<IUnitOfWork>(opt => opt.GetRequiredService<ApplicationDbContext>());

        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IOrderRepository, OrderRepository>();
        return services;
    }
}
