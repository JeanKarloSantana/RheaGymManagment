using MediatR;
using Microsoft.AspNetCore.Mvc;
using RheaGymManagment.Application.Commands.CreateSubscription;
using Titan.Contracts.Subscriptions;

namespace RheaGymManagment.Api.Controllers
{
    public class SubscriptionController : ControllerBase
    { 
        private readonly ISender _mediator;

        public SubscriptionController(ISender mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> CreateSubscription(CreateSubscriptionRequest request)
        {
            var command = new CreateSubscriptionCommand(
                request.SubscriptionType.ToString(), 
                request.AdminId);

            var createSubscriptionResult = await _mediator.Send(command);

            if(createSubscriptionResult.IsError)
            {
                return Problem();
            }

           var response = new SubscriptionResponse(
                createSubscriptionResult.Value,
                request.SubscriptionType);

            return Ok(response);
        }
    }
}
