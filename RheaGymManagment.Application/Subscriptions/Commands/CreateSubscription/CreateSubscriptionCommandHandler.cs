﻿
using ErrorOr;
using MediatR;
using RheaGymManagment.Application.Commons.interfaces;
using RheaGymManagment.Domain.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RheaGymManagment.Application.Subscriptions.Commands.CreateSubscription
{
    public class CreateSubscriptionCommandHandler : IRequestHandler<CreateSubscriptionCommand, ErrorOr<Subscription>>
    {
        private readonly IGymRepository _subscriptionsRepository;
        private readonly IAdminsRepository _adminsRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateSubscriptionCommandHandler(IGymRepository subscriptionsRepository, IUnitOfWork unitOfWork, IAdminsRepository adminsRepository)
        {
            _subscriptionsRepository = subscriptionsRepository;
            _unitOfWork = unitOfWork;
            _adminsRepository = adminsRepository;
        }

        public async Task<ErrorOr<Subscription>> Handle(CreateSubscriptionCommand request, CancellationToken cancellationToken)
        {
            var admin = await _adminsRepository.GetByIdAsync(request.AdminId);

            if (admin is null)
            {
                return Error.NotFound(description: "Admin not found");
            }

            var subscription = new Subscription(
                subscriptionType: request.SubscriptionType,
                adminId: request.AdminId);

            if (admin.SubscriptionId is not null)
            {
                return Error.Conflict(description: "Admin already has an active subscription");
            }

            admin.SetSubscription(subscription);

            await _subscriptionsRepository.AddSubscriptionAsync(subscription);
            await _adminsRepository.UpdateAsync(admin);
            await _unitOfWork.CommitChangesAsync();

            return subscription;
        }
    }
}
