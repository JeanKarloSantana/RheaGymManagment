using RheaGymManagment.Domain.Admin.Events;
using RheaGymManagment.Domain.Common;
using RheaGymManagment.Domain.Subscriptions;
using Throw;
namespace RheaGymManagment.Domain.Admin;

public class Admin : Entity
{
    public Guid UserId { get; }
    public Guid? SubscriptionId { get; private set; } = null;

    public Admin(
        Guid userId,
        Guid? subscriptionId = null,
        Guid? id = null)
            : base(id ?? Guid.NewGuid())
    {
        UserId = userId;
        SubscriptionId = subscriptionId;
        Id = id ?? Guid.NewGuid();
    }

    private Admin() { }

    public void SetSubscription(Subscription subscription)
    {
        SubscriptionId.HasValue.Throw().IfTrue();

        SubscriptionId = subscription.Id;
    }

    public void DeleteSubscription(Guid subscriptionId)
    {
        SubscriptionId.ThrowIfNull().IfNotEquals(subscriptionId);

        SubscriptionId = null;

        _domainEvents.Add(new SubscriptionDeletedEvent(subscriptionId));
    }
}