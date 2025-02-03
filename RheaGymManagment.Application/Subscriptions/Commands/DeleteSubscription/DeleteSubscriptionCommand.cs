using ErrorOr;
using MediatR;

namespace RheaGymManagment.Application.Subscriptions.Commands.DeleteSubscription;

public record DeleteSubscriptionCommand(Guid SubscriptionId) : IRequest<ErrorOr<Deleted>>;