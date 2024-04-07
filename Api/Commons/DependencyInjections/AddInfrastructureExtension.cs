using Api.Infrastructures.Commons.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Api.Commons.DependencyInjections;

public static class AddInfrastructureExtension
{
    public static void AddInfrastructure(this IServiceCollection services,IConfiguration configuration) {
        

        services.AddDbContext<TicketContext>(opt => {
            var connectionString = configuration.GetConnectionString("TicketDb");
            opt.UseSqlServer(connectionString);
        });

        
    }
}