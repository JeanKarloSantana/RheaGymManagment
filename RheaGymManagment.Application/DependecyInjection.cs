using Microsoft.Extensions.DependencyInjection;
using RheaGymManagment.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RheaGymManagment.Application
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<ISubscriptionService, SubscriptionService>();

            return services;
        }
    }
}
