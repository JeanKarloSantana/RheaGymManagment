using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RheaGymManagment.Contracts.Subscriptions
{
    public record SubscriptionResponse(Guid Id, SubscriptionType SubscriptionType);
}
