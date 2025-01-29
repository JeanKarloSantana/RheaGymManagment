
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RheaGymManagment.Application.Commons.interfaces;
using RheaGymManagment.Infrastructure.Common.Persistance;
using RheaGymManagment.Infrastructure.Subscriptions.Persistence;

namespace RheaGymManagment.Application
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddDbContext<GymManagmentDbContext>(options => options.UseSqlite("Data Source = GymManagment.db"));
            services.AddScoped<ISubscriptionRepository, SubscriptionRepository>();
            services.AddScoped<IUnitOfWork>(serviceProvider => serviceProvider.GetRequiredService<GymManagmentDbContext>());
            return services;
        }
    }
}
