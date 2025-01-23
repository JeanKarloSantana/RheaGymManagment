using Microsoft.AspNetCore.Mvc;
using RheaGymManagment.Application.Services;
using Titan.Contracts.Subscriptions;

namespace RheaGymManagment.Api.Controllers
{
    public class SubscriptionController : ControllerBase
    {
        private readonly ISubscriptionService _subscriptionsService;

        public SubscriptionController(ISubscriptionService subscriptionsService)
        {
            _subscriptionsService = subscriptionsService;
        }

        public IActionResult CreateSubscription(CreateSubscriptionRequest request)
        {
           var subscriptionId = _subscriptionsService.CreateSubscription(
                request.SubscriptionType.ToString(), 
                request.AdminId);

           var response = new SubscriptionResponse(
                subscriptionId,
                request.SubscriptionType);

            return Ok(response);
        }
    }
}
