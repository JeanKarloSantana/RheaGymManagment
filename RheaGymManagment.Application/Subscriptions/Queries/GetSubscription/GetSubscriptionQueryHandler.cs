using ErrorOr;
using RheaGymManagment.Application.Commons.interfaces;
using RheaGymManagment.Domain.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RheaGymManagment.Application.Subscriptions.Queries.GetSubscription
{
    public class GetSubscriptionQueryHandler
    {
        private readonly ISubscriptionRepository _subscriptionRepository;

        public GetSubscriptionQueryHandler(ISubscriptionRepository subscriptionRepository)
        {
            _subscriptionRepository = subscriptionRepository;
        }   

        public async Task<ErrorOr<Subscription>> Handle(GetSubscriptionQuery query, CancellationToken cancellationToken)
        {
            var subscription = await _subscriptionRepository.GetByIdAsync(query.SubscriptionId);

            return subscription is null
                ? Error.NotFound(description: "Subscription not found")
                : subscription;
        }
    }
}
