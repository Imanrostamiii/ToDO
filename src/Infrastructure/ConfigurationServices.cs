using Infrastructure.persistence;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class ConfigurationServices
{
   public static IServiceCollection AddInfrastructure(this IServiceCollection service, IConfiguration configuration)
   {
      service.AddDbContext<ApplicationDbContext>(option =>
         option.UseSqlServer(configuration.GetConnectionString("ToDoList")));
      return service;
   }
}