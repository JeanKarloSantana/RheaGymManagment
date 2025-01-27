using RheaGymManagment.Domain.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RheaGymManagment.Application.Commons.interfaces
{
    public interface ISubscriptionRepository
    {
       Task AddSubscriptionAsync(Subscription subscription);
       Task<Subscription?> GetByIdAsync(Guid subcriptionId);
    }
}
