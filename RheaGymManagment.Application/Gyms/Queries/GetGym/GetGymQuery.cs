using ErrorOr;
using MediatR;
using RheaGymManagment.Domain.Gyms;

namespace RheaGymManagment.Application.Gyms.Queries.GetGym;

public record GetGymQuery(Guid SubscriptionId, Guid GymId) : IRequest<ErrorOr<Gym>>;