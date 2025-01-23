using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RheaGymManagment.Application.Services
{
    public interface ISubscriptionService
    {
        Guid CreateSubscription(string subscriptionType, Guid adminId);
    }
}
