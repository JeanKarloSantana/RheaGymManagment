using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RheaGymManagment.Domain.Subscriptions
{
    public class Subscription
    {
        private readonly Guid _adminId;
        public Guid Id { get; private set; }
        public SubscriptionType SubscriptionType { get; private set; }

        public Subscription(SubscriptionType subscriptionType, Guid adminId, Guid? id = null) 
        { 
            SubscriptionType = subscriptionType;
            _adminId = adminId;
            Id = id ?? Guid.NewGuid();
        }

        private Subscription() 
        { 
            
        }
    }
}
