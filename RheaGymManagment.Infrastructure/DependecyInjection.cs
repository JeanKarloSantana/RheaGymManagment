
using GymManagement.Infrastructure.Admins.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RheaGymManagment.Application.Commons.interfaces;
using RheaGymManagment.Infrastructure.Common.Persistance;
using RheaGymManagment.Infrastructure.Gyms.Persistence;
using RheaGymManagment.Infrastructure.Subscriptions.Persistence;

namespace RheaGymManagment.Application
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddDbContext<GymManagementDbContext>(options => options.UseSqlite("Data Source = GymManagment.db"));
            services.AddScoped<IAdminsRepository, AdminsRepository>();
            services.AddScoped<IGymsRepository, GymsRepository>();
            services.AddScoped<IGymRepository, SubscriptionsRepository>();
            services.AddScoped<IUnitOfWork>(serviceProvider => serviceProvider.GetRequiredService<GymManagementDbContext>());
            return services;
        }
    }
}
