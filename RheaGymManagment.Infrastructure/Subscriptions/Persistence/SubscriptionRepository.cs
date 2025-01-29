using Microsoft.EntityFrameworkCore;
using RheaGymManagment.Application.Commons.interfaces;
using RheaGymManagment.Domain.Subscriptions;
using RheaGymManagment.Infrastructure.Common.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RheaGymManagment.Infrastructure.Subscriptions.Persistence
{
    public class SubscriptionRepository : ISubscriptionRepository
    {
        private readonly GymManagmentDbContext _dbContext;

        public SubscriptionRepository(GymManagmentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddSubscriptionAsync(Subscription subscription)
        {
            await _dbContext.Subscriptions.AddAsync(subscription);
            await _dbContext.SaveChangesAsync();            
        }

        public async Task<Subscription?> GetByIdAsync(Guid subcriptionId)
        {
            return await _dbContext.Subscriptions.FindAsync(subcriptionId);
        }
    }
}
