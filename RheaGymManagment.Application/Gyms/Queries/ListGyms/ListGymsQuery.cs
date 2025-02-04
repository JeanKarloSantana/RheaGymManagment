using ErrorOr;
using MediatR;
using RheaGymManagment.Domain.Gyms;

namespace RheaGymManagment.Application.Gyms.Queries.ListGyms;

public record ListGymsQuery(Guid SubscriptionId) : IRequest<ErrorOr<List<Gym>>>;