using ErrorOr;
using MediatR;
using RheaGymManagment.Domain.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RheaGymManagment.Application.Subscriptions.Queries.GetSubscription
{
    public record class GetSubscriptionQuery(Guid SubscriptionId) : IRequest<ErrorOr<Subscription>>;
   
}
