using MediatR;
using RheaGymManagment.Application.Commons.interfaces;
using RheaGymManagment.Domain.Admin.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RheaGymManagment.Application.Gyms.Events
{
    public class SubscriptionDeletedEventHandler(IGymRepository gymsRepository,
        IUnitOfWork unitOfWork)
        : INotificationHandler<SubscriptionDeletedEvent>
    {

        private readonly IGymRepository _gymsRepository = gymsRepository;
        private readonly IUnitOfWork _unitOfWork = unitOfWork;

        public async Task Handle(SubscriptionDeletedEvent notification, CancellationToken cancellationToken)
        {
            var gyms = await _gymsRepository.ListBySubscriptionIdAsync();
            await _gymsRepository.RemoveSubscriptionAsync(gyms);
            await _unitOfWork.CommitChangesAsync();
        }
    }
}
