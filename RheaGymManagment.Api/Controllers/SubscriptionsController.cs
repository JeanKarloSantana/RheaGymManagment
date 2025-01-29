using MediatR;
using Microsoft.AspNetCore.Mvc;
using RheaGymManagment.Application.Subscriptions.Commands;
using RheaGymManagment.Application.Subscriptions.Queries.GetSubscription;
using Titan.Contracts.Subscriptions;
namespace RheaGymManagment.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class SubscriptionController : ControllerBase
{ 
    private readonly ISender _mediator;

    public SubscriptionController(ISender mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> CreateSubscription([FromBody] CreateSubscriptionRequest request)
    {
        var command = new CreateSubscriptionCommand(
            request.SubscriptionType.ToString(),
            request.AdminId);

        var createSubscriptionResult = await _mediator.Send(command);

        return createSubscriptionResult.MatchFirst(
            subscription => Ok(new SubscriptionResponse(subscription.Id, request.SubscriptionType)),
            error => Problem());
    }

    [HttpGet("{subscriptionId:guid}")]
    public async Task<IActionResult> GetSubscription(Guid subscriptioId)
    {
        var query = new GetSubscriptionQuery(subscriptioId);

        var getSubscriptionResult = await _mediator.Send(query);

        return getSubscriptionResult.MatchFirst(
            SubscriptionController => Ok(new SubscriptionResponse(
                SubscriptionController.Id,
                SubscriptionType.Pro)),
            error => Problem());
    }
}
