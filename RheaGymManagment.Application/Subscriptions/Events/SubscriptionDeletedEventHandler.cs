using MediatR;
using RheaGymManagment.Application.Commons.interfaces;
using RheaGymManagment.Domain.Admin.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RheaGymManagment.Application.Subscriptions.Events
{
    public class SubscriptionDeletedEventHandler(IGymRepository subscriptionRepository, 
        IUnitOfWork unitOfWork) 
        : INotificationHandler<SubscriptionDeletedEvent>
    {

        private readonly IGymRepository _subscriptionsRepository = subscriptionRepository;
        private readonly IUnitOfWork _unitOfWork = unitOfWork;
        
        public async Task Handle(SubscriptionDeletedEvent notification, CancellationToken cancellationToken)
        {
            var subscription = await _subscriptionsRepository.GetByIdAsync(notification.SubscriptionId)
                ?? throw new InvalidOperationException();

            await _subscriptionsRepository.RemoveSubscriptionAsync(subscription);
            await _unitOfWork.CommitChangesAsync();
        }
    }
}
