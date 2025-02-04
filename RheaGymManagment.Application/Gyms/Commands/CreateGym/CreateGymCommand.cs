using ErrorOr;
using MediatR;
using RheaGymManagment.Domain.Gyms;

namespace RheaGymManagment.Application.Gyms.Commands.CreateGym;

public record CreateGymCommand(string Name, Guid SubscriptionId) : IRequest<ErrorOr<Gym>>;