namespace Api.Commons.DependencyInjections;

public static class AddApplicationExtension
{
    public static void AddApplicationService(this IServiceCollection services) {

        services.AddMediatR(opt => {
            opt.RegisterServicesFromAssemblyContaining(typeof(AddApplicationExtension));
        });
    }
}